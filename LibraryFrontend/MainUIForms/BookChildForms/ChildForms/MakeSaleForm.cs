using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.DataAccess.TransactionDataAccess;
using ClassLibrary.Models.SaleInfo;
using ClassLibrary.Models.Transaction.DTOs;
using LibraryUI.AdditionalControls.UnderlinedTextbox;
using LibraryUI.MainUIForms.ClientChildForms.ChildForms;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class MakeSaleForm : Form
{
    private readonly SaleInfoModel _saleInfo;
    private readonly string _username;
    private readonly TransactionDataAccess _transactionDataAccess;
    private readonly ClientDataAccess _clientDataAccess;
    private readonly Form _form;
    private bool SaleMade = false;

    public MakeSaleForm(string username, SaleInfoModel saleInfo, Form Form)
    {
        
        InitializeComponent();
        CenterToScreen();
        _username = username;
        _saleInfo = saleInfo;
        _transactionDataAccess = new TransactionDataAccess();
        _clientDataAccess = new ClientDataAccess();
        _form = Form;
    }

    //Events

    private async void MakeSaleForm_Load(object sender, EventArgs e)
    {
        UsernameText.Texts = _username;
        BookNameText.Texts = _saleInfo.Book_Name;
        BranchNameText.Texts = _saleInfo.Branch_Name;
        SaleTypeComboBox.SelectedItem = _saleInfo.Sale_Type;
        CopiesNumeric.Maximum = _saleInfo.Available_Copies;
        UpdateTotalPrice();
        await FillClientPhoneNumberComboBox();
    }

    private void SaleTypeComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (SaleTypeComboBox.SelectedItem.ToString() == "Purchase")
        {
            DurationLabel.Visible = false;
            DurationNumeric.Visible = false;
            LatePenaltyLabel.Visible = false;
            LatePenaltyNumeric.Visible = false;
        }
        else
        {
            DurationLabel.Visible = true;
            DurationNumeric.Visible = true;
            LatePenaltyLabel.Visible = true;
            LatePenaltyNumeric.Visible = true;
        }
        UpdateTotalPrice();
    }

    private void CopiesNumeric_ValueChanged(object sender, EventArgs e)
    {
        UpdateTotalPrice();           
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        CopiesNumeric.Value = 1;
        DurationNumeric.Value = 1;
        LatePenaltyNumeric.Value = 10;
        UpdateTotalPrice();
    }

    private async void MakeSaleButton_Click(object sender, EventArgs e)
    {
        try
        {

            bool copiesParsed = int.TryParse(CopiesNumeric.Value.ToString(), out int copies);
            if (!copiesParsed)
                throw new Exception("Copies should be a number");

            bool durationParsed = int.TryParse(DurationNumeric.Value.ToString(), out int duration);
            if (!durationParsed)
                throw new Exception("Duration should be a number");

            bool LatePenaltyParsed = int.TryParse(LatePenaltyNumeric.Value.ToString(), out int latePenalty);
            if (!LatePenaltyParsed)
                throw new Exception("Late penalty should be a number");

            string? transactionType = SaleTypeComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(transactionType))
                throw new Exception("Sale type should be specified");

            string? clientPhoneNumber = ClientPhoneNbComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(clientPhoneNumber))
                throw new Exception("Client phone number is required");

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            EditTransactionDTO transactionDTO = new()
            {
                Book_Name = BookNameText.Texts,
                Branch_Name = BranchNameText.Texts,
                Client_Phone_Number = clientPhoneNumber,
                Employee_Username = _username,
                Type = transactionType,
                Copies = copies,
                Return_Date_Months = duration,
                Late_Penalty_Percentage = latePenalty
            };
           

            string transactionAdded = await _transactionDataAccess.AddTransaction(transactionDTO);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            DialogResult dialogResult = MessageBox.Show(
                                            transactionAdded,
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.None
                                            );
            SaleMade = true;

        }
        catch (Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
            );
        }
    }

    private async void MakeSaleForm_FormClosed(object sender, FormClosedEventArgs e)
    {

        if (SaleMade)
        {
            try
            {
                HomeForm form = (HomeForm)_form;
                await form.FillTopSellingPanel();
                await form.AddCategories();
            }
            catch (InvalidCastException)
            {
                BookSearchForm form = (BookSearchForm)_form;
                Control[] searchText = form.Controls.Find("SearchText", true);
                Control[] searchResultLabel = form.Controls.Find("SearchResultLabel", true);
                if (searchText[0] is UnderlinedTextbox SearchText)
                {
                    if (string.IsNullOrEmpty(SearchText.Texts) || searchResultLabel[0].Text.Equals("Available Books"))
                        await form.ShowTrendingBooks();
                    else
                        await form.FillSearchPanel();
                }
            }
        }
        
    }

    private void AddNewClientLabelButton_Click(object sender, EventArgs e)
    {
        AddClientForm addClient = new();
        addClient.ShowDialog();
    }

    //Functions

    private void UpdateTotalPrice()
    {
        if (SaleTypeComboBox.SelectedItem.ToString() == "Purchase")
        {
            TotalPriceText.Texts = (int.Parse(CopiesNumeric.Value.ToString()) * _saleInfo.Purchase_Price) + "$";
        }
        else
        {
            TotalPriceText.Texts = (int.Parse(CopiesNumeric.Value.ToString()) * _saleInfo.Rent_Price) + "$";
        }
    }

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

}
