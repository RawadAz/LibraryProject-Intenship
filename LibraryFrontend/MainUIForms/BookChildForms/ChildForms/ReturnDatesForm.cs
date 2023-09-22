using ClassLibrary.Models.IdAndNameDTO;
using ClassLibrary.Models.Transaction.DTOs;
using System.Windows.Threading;
using LibraryUI.LayoutHelper;
using ClassLibrary.DataAccess.BookDataAccess;
using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.TransactionDataAccess;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class ReturnDatesForm : Form
{
    private readonly TransactionDataAccess _transactionDataAccess;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly BookDataAccess _bookDataAccess;
    private readonly Dispatcher _dispatcher;

    public ReturnDatesForm()
    {
        InitializeComponent();
        _transactionDataAccess = new TransactionDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _bookDataAccess = new BookDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private async void SearchButton_Click(object sender, EventArgs e)
    {
        LoadingBar.Visible = true;
        LoadingLabel.Visible = true;

        try
        {

            ReturnDatesDTV.DataSource = null; 

            string bookName = Helper.GetNameFromComboBox(BookNameComboBox);
            if (bookName.Contains('\''))
                bookName = Helper.EscapeSingleQuote(bookName);

            string branchName = Helper.GetNameFromComboBox(BranchNameComboBox);

            IEnumerable<ReturnDateDTO> returnDates = await _transactionDataAccess.GetReturnDates(bookName, branchName);

            BindingSource source = new()
            {
                DataSource = returnDates
            };

            ReturnDatesDTV.AutoGenerateColumns = true;
            ReturnDatesDTV.DataSource = source;

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

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

    private async void ReturnDatesForm_Load(object sender, EventArgs e)
    {
        await FillBranchNameComboBox();
    }

    private async void BranchNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

        await FillBookNamecomboBox(branchId);
    }

    //Functions

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

    private async Task FillBookNamecomboBox(int branchId)
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

}
