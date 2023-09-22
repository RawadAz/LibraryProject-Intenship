using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.Models.Book.DTO_s;
using LibraryUI.AdditionalControls.BookInfoHolder;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms;

public partial class RentedBooksForm : Form
{
    private readonly string _username;
    private readonly int _clientId;
    private readonly ClientDataAccess _clientDataAccess;
    private readonly ViewClientForm _form;
    private readonly Dispatcher _dispatcher;

    public RentedBooksForm(string username,int ClientId, ViewClientForm form)
    {
        InitializeComponent();
        CenterToScreen();

        _clientId = ClientId;
        _username = username;
        _form = form;
        _clientDataAccess = new ClientDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
        Helper.FLPDoubleBuffered(RentedBooksFlowLayoutPanel, true);
    }

    //Events
    private async void RentedBooksForm_Load(object sender, EventArgs e)
    {
        await FillRentedBooksPanel();
    }

    private void RentedBooksForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        ViewClientForm form = _form;
        form.ViewClientForm_Load(form, EventArgs.Empty);
    }

    //Functions

    public async Task FillRentedBooksPanel()
    {
        try
        {
            IEnumerable<RentedBookDTO>? rentedBooks = await _clientDataAccess.GetRentedBooks(_clientId);

            if (rentedBooks == null || !rentedBooks.Any())
            {
                NoRentedBooksLabel.Visible = true;
                RentedBookTableLayoutPanel.SetRow(NoRentedBooksLabel, 0);
                RentedBookTableLayoutPanel.SetRow(RentedBooksFlowLayoutPanel, 1);
                RentedBooksFlowLayoutPanel.Visible = false;
                return;
            }

            RentedBookTableLayoutPanel.SetRow(NoRentedBooksLabel, 2);
            RentedBookTableLayoutPanel.SetRow(RentedBooksFlowLayoutPanel, 1);
            RentedBooksFlowLayoutPanel.Visible = true;

            RentedBooksFlowLayoutPanel.Controls.Clear();

            await Task.Run(() =>
            {
                var bookHolders = new List<BookHolder>();

                foreach (var book in rentedBooks)
                {

                    BookHolder bookHolder = new(_username)
                    {

                        BookId = book.Id,
                        Transaction_Id = book.Transaction_Id,
                        BookNameText = book.Name,
                        AuthorNameText = book.Author,
                        CategoryText = book.Category,
                        PurchasePriceText = book.Purchase_Price + "$",
                        RentPriceText = book.Rent_Price + "$",
                        AvailableCopiesText = book.In_Stock.ToString(),
                        BranchNameText = book.Branch_Name.ToString(),
                        PurchaseButtonVisible = false,
                        RentButtonVisible = false,
                        CopiesText = "Rented Copies:"
                        };

                    bookHolders.Add(bookHolder);

                }
                _dispatcher.Invoke(() =>
                {
                    foreach (var bookHolder in bookHolders)
                    {
                        RentedBooksFlowLayoutPanel.Controls.Add(bookHolder);
                    }
                });
            });
        }
        catch(Exception ex)
        {
            MessageBox.Show(
                    ex.Message,
                    "Error occured",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
        }
    }

}

