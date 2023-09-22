using ClassLibrary.DataAccess.TransactionDataAccess;
using ClassLibrary.Models.Transaction.DTOs;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.TransactionChildForms.ChildForms;

public partial class MngViewTransactionsForm : Form
{
    private readonly TransactionDataAccess _transactionDataAccess;
    private readonly string _username;

    public MngViewTransactionsForm(string username)
    {
        InitializeComponent();
        Helper.DGVDoubleBuffered(ViewTransactionsDGV, true);
        _transactionDataAccess = new TransactionDataAccess();
        _username = username;
    }

    //Events

    private void SearchComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {

        string? searchMethod = SearchComboBox.SelectedItem.ToString();

        if (string.IsNullOrEmpty(searchMethod))
            throw new Exception("Invalid search method");

        switch (searchMethod)
        {
            case "All":
            case "Purchase":
            case "Rent":
                SearchText.Visible = false;
                break;

            case "Id":
                SearchText.Visible = true;
                SearchText.PlaceHolder = "Transaction Id";
                break;

            case "Client Phone Nb":
                SearchText.Visible = true;
                SearchText.PlaceHolder = "Client Phone Number";
                break;
            default:
                throw new Exception("Invalid search method");
        }
    }

    private void ViewTransactionsForm_Load(object sender, EventArgs e)
    {
        SearchComboBox.SelectedIndex = 0;
        GetTransactionsButton_Click(GetTransactionsButton, e);
    }

    private async void GetTransactionsButton_Click(object sender, EventArgs e)
    {
        LoadingBar.Visible = true;
        LoadingLabel.Visible = true;

        try
        {
            string? searchMethod = SearchComboBox.SelectedItem.ToString();

            List<TransactionDTO> TransactionsList = new();

            switch (searchMethod)
            {
                case "All":

                    IEnumerable<TransactionDTO> transactions = await _transactionDataAccess.GetTransactions();
                    TransactionsList.AddRange(transactions);

                    break;

                case "Id":

                    string IdText = SearchText.Texts;

                    if (string.IsNullOrEmpty(IdText))
                        throw new Exception("Transaction Id is required");

                    bool parsed = int.TryParse(IdText, out int id);
                    if (!parsed)
                        throw new Exception("Transaction id should be numeric");

                    TransactionDTO transaction = await _transactionDataAccess.GetTransactionById(id);
                    TransactionsList.Add(transaction);

                    break;

                case "Purchase":

                    IEnumerable<TransactionDTO> purchaseTransactions = await _transactionDataAccess.GetPurchaseTransactions();
                    TransactionsList.AddRange(purchaseTransactions);

                    break;

                case "Rent":

                    IEnumerable<TransactionDTO> rentTransactions = await _transactionDataAccess.GetRentTransactions();
                    TransactionsList.AddRange(rentTransactions);

                    break;

                case "Client Phone Nb":

                    string phoneNumber = SearchText.Texts;

                    if (string.IsNullOrEmpty(phoneNumber))
                        throw new Exception("client phone number is required");

                    if (!int.TryParse(phoneNumber, out int phoneNb))
                        throw new Exception("Client phone number should be numeric");

                    IEnumerable<TransactionDTO> transactionsByPhoneNb = await _transactionDataAccess.GetTransactionsByPhoneNumber(phoneNumber);
                    TransactionsList.AddRange(transactionsByPhoneNb);

                    break;

                default:

                    throw new Exception("please specify a way of searching");
            }

            ViewTransactionsDGV.DataSource = TransactionsList;
            ViewTransactionsDGV.Enabled = true;

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

        }
        catch (Exception ex)
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

    private void ViewTransactionsForm_Resize(object sender, EventArgs e)
    {
        
        if (this.Size.Width >= 1792)
            ViewTransactionsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        else
            ViewTransactionsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private async void ViewTransactionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
        try
        {
            //column index of deleteButton is 1 
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show
                    (
                        "Are you sure you want to remove this Transaction",
                        caption: "Confimation Message",
                        MessageBoxButtons.YesNo,
                        icon: MessageBoxIcon.Question
                    );
                if (dialogResult == DialogResult.No)
                    return;
            
                int row = e.RowIndex;
                TransactionDTO transaction = (TransactionDTO)ViewTransactionsDGV.Rows[row].DataBoundItem;
                int id = transaction.Transaction_Id;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeDeleted = await _transactionDataAccess.DeleteTransaction(id);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                    employeeDeleted,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
                GetTransactionsButton_Click(GetTransactionsButton, e);

            }
            //index of editButton is 0
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                int row = e.RowIndex;
                TransactionDTO transaction = (TransactionDTO)ViewTransactionsDGV.Rows[row].DataBoundItem;
                int transactionId = transaction.Transaction_Id;

                EditTransactionsForm editTransactionsForm = new(_username, transactionId);
                editTransactionsForm.ShowDialog();

            }
        }
        catch (Exception ex)
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
}
