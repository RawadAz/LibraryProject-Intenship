using ClassLibrary.DataAccess.BookDataAccess;
using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.DataAccess.TransactionDataAccess;
using ClassLibrary.Models.IdAndNameDTO;
using ClassLibrary.Models.Transaction.DTOs;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.ClientChildForms.ChildForms;
using System.Globalization;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.TransactionChildForms.ChildForms;

public partial class EditTransactionsForm : Form
{
    private readonly TransactionDataAccess _transactionDataAccess;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly BookDataAccess _bookDataAccess;
    private readonly ClientDataAccess _clientDataAccess;
    private readonly Dispatcher _dispatcher;
    private readonly string _username;
    private readonly int _id;
    private EditTransactionDTO tempTransaction = new();

    public EditTransactionsForm(string username, int id)
    {
        InitializeComponent();
        CenterToScreen();

        _transactionDataAccess = new TransactionDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _bookDataAccess = new BookDataAccess();
        _clientDataAccess = new ClientDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
        _username = username;
        _id = id;
    }

    //Events

    private async void EditTransactionsForm_Load(object sender, EventArgs e)
    {
        TransactionIdText.Text = _id.ToString();
        TypeComboBox.SelectedIndex = 0;
        await FillBranchNameComboBox();
        await FillClientPhoneNumberComboBox();
        await FillTransactionInformation();
    }

    private async void BranchNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

        await FillBookNameComboBox(branchId);
    }

    private void TypeComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (TypeComboBox.SelectedItem.Equals("rent"))
        {
            DurationNumeric.Visible = true;
            DurationLabel.Visible = true;
            LatePenaltyLabel.Visible = true;
            LatePenaltyNumeric.Visible = true;
        }
        else
        {
            DurationNumeric.Visible = false;
            DurationLabel.Visible = false;
            LatePenaltyLabel.Visible = false;
            LatePenaltyNumeric.Visible = false;
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        var branchNamePair = Helper.SelectPairByName(BranchNameComboBox, tempTransaction.Branch_Name);
        if (branchNamePair != null)
            BranchNameComboBox.SelectedIndex = BranchNameComboBox.Items.IndexOf(branchNamePair);

        var booknamePair = Helper.SelectPairByName(BookNameComboBox, tempTransaction.Book_Name);
        if (booknamePair != null)
            BookNameComboBox.SelectedIndex = BookNameComboBox.Items.IndexOf(booknamePair);
        
        TypeComboBox.SelectedIndex = TypeComboBox.Items.IndexOf(tempTransaction.Type);

        ClientPhoneNbComboBox.SelectedIndex = ClientPhoneNbComboBox.Items.IndexOf(tempTransaction.Client_Phone_Number);

        CopiesNumeric.Value = tempTransaction.Copies;

        if(tempTransaction.Return_Date_Months != null)
            DurationNumeric.Value = (decimal) tempTransaction.Return_Date_Months;

        if (tempTransaction.Late_Penalty_Percentage != null)
            LatePenaltyNumeric.Value = (decimal) tempTransaction.Late_Penalty_Percentage;

    }

    private async void UpdateButton_Click(object sender, EventArgs e)
    {
        try
        {
            EditTransactionDTO editTransaction = VerifyTransactionInfo();

            if (editTransaction.Equals(tempTransaction))
                return;

            LoadingLabel.Text = "Updating transaction, please wait..";
            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string transactionUpdated = await _transactionDataAccess.UpdateTransaction(_id, editTransaction);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            tempTransaction = editTransaction;

            MessageBox.Show(
            transactionUpdated,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
            );

        }
        catch (Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
        }
    }

    private void AddNewClientLabelButton_Click(object sender, EventArgs e)
    {
        AddClientForm addClient = new();
        addClient.ShowDialog();
    }

    //functions

    private async Task FillClientPhoneNumberComboBox()
    {
        try
        {
            IEnumerable<string> phoneNumbers = await _clientDataAccess.GetClientPhoneNumbers();
            ClientPhoneNbComboBox.DataSource = phoneNumbers;

        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
    }

    private async Task FillBranchNameComboBox()
    {
        try
        {
            IEnumerable<NameAndIdDTO> namesAndIds = await _branchDataAccess.GetBranchIdsAndNames();

            Dictionary<string, int> namesAndIdsDict = new();

            await Task.Run(() =>
            {
                Dictionary<string, int> temp = new();

                foreach (var nameAndId in namesAndIds)
                {
                    temp.Add(key: nameAndId.Name, value: nameAndId.Id);
                }
                _dispatcher.Invoke(() =>
                {
                    namesAndIdsDict.Clear();
                    namesAndIdsDict = temp;
                });
            });

            if (namesAndIdsDict.Count > 0)
            {

                BranchNameComboBox.DataSource = new BindingSource(namesAndIdsDict, null);
                BranchNameComboBox.DisplayMember = "Key";
                BranchNameComboBox.ValueMember = "Value";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
    }

    private async Task FillTransactionInformation()
    {
        try
        {
            LoadingBar.Visible = true;
            LoadingLabel.Text = "Getting transaction info, please wait..";
            LoadingLabel.Visible = true;

            TransactionDTO transaction = await _transactionDataAccess.GetTransactionById(_id);

            await FillTransactionInfo(transaction);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            tempTransaction = VerifyTransactionInfo();

        }
        catch(Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                ex.Message,
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
    }

    private EditTransactionDTO VerifyTransactionInfo()
    {
        string? type = TypeComboBox.SelectedItem.ToString();
        if (string.IsNullOrEmpty(type))
            throw new Exception("Invalid transaction type");
        if (CopiesNumeric.Value <= 0)
            throw new Exception("At least one book copy is needed");
        string? phoneNumber = ClientPhoneNbComboBox.SelectedItem.ToString();
        if (!ClientPhoneNbComboBox.Items.Contains(ClientPhoneNbComboBox.SelectedItem) || string.IsNullOrEmpty(phoneNumber))
            throw new Exception("Client does not exist, please add a new one or pick a valid phone number");
        if (DurationNumeric.Value <= 0)
            throw new Exception("Durations should be between 1 and 6 months");
        if (LatePenaltyNumeric.Value <= 0)
            throw new Exception("Penalty percentage should be between 1 and 100");

        EditTransactionDTO temp = new()
        {
            Book_Name = Helper.GetNameFromComboBox(BookNameComboBox),
            Branch_Name = Helper.GetNameFromComboBox(BranchNameComboBox),
            Employee_Username = _username,
            Client_Phone_Number = phoneNumber,
            Type = type,
            Copies = (int)CopiesNumeric.Value,
            Return_Date_Months = (int)DurationNumeric.Value,
            Late_Penalty_Percentage = (double)LatePenaltyNumeric.Value
        };

        return temp;               
    }

    private async Task FillBookNameComboBox(int branchId)
    {
        try
        {

            IEnumerable<NameAndIdDTO> namesAndIds = await _bookDataAccess.GetBookNameAndId(branchId);

            Dictionary<string, int> namesAndIdsDict = new();

            await Task.Run(() =>
            {
                Dictionary<string, int> temp = new();

                foreach (var nameAndId in namesAndIds)
                {
                    temp.Add(key: nameAndId.Name, value: nameAndId.Id);
                }
                _dispatcher.Invoke(() =>
                {
                    namesAndIdsDict.Clear();
                    namesAndIdsDict = temp;
                });
            });

            if (namesAndIdsDict.Count > 0)
            {

                BookNameComboBox.DataSource = new BindingSource(namesAndIdsDict, null);
                BookNameComboBox.DisplayMember = "Key";
                BookNameComboBox.ValueMember = "Value";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
    }

    private async Task FillTransactionInfo(TransactionDTO transaction)
    {
        var branchNamePair = Helper.SelectPairById(BranchNameComboBox, transaction.Branch_Id);
        BranchNameComboBox.SelectedIndex = BranchNameComboBox.Items.IndexOf(branchNamePair);

        await FillBookNameComboBox(transaction.Branch_Id);

        var BookNamePair = Helper.SelectPairByName(BookNameComboBox, transaction.Book_Name);
        BookNameComboBox.SelectedIndex = BookNameComboBox.Items.IndexOf(BookNamePair);

        TypeComboBox.SelectedIndex = TypeComboBox.Items.IndexOf(transaction.Type);

        TypeComboBox_OnSelectedIndexChanged(TypeComboBox, EventArgs.Empty);

        ClientPhoneNbComboBox.SelectedIndex = ClientPhoneNbComboBox.Items.IndexOf(transaction.Client_Phone_Number);

        CopiesNumeric.Value = transaction.Copies;

        if (string.IsNullOrEmpty(transaction.Return_Date))
        {
            DurationNumeric.Value = 1;
        }
        else
        {
            bool parsed = DateTime.TryParseExact(transaction.Transaction_Date, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime transactionDate);
            if (!parsed)
                throw new Exception("Unable to get transaction date, please refresh");
            DateOnly returnDate = DateOnly.Parse(transaction.Return_Date);
            int months = returnDate.Month - transactionDate.Month;

            DurationNumeric.Value = months;
        }
        if (transaction.Late_Penalty != null)
        {
            var penalty = (int)((transaction.Late_Penalty * 100) * 100 / ((transaction.Price * 100) * transaction.Copies));
            LatePenaltyNumeric.Value = penalty;
        }
        else
            LatePenaltyNumeric.Value = 10;
    }
}
