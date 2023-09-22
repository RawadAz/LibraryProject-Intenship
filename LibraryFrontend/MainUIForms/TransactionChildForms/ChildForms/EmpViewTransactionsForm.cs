using ClassLibrary.DataAccess.TransactionDataAccess;
using ClassLibrary.Models.Transaction.DTOs;
using LibraryUI.LayoutHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.MainUIForms.TransactionChildForms.ChildForms
{
    public partial class EmpViewTransactionsForm : Form
    {
        private readonly TransactionDataAccess _transactionDataAccess;

        public EmpViewTransactionsForm()
        {
            InitializeComponent();
            Helper.DGVDoubleBuffered(ViewTransactionsDGV, true);

            _transactionDataAccess = new TransactionDataAccess();
        }

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

    }
}
