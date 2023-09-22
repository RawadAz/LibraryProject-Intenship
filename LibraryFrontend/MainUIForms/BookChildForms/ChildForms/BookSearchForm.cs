using ClassLibrary.DataAccess.BookDataAccess;
using ClassLibrary.Models.Book.DTO_s;
using LibraryUI.AdditionalControls.BookInfoHolder;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class BookSearchForm : Form
{
    private readonly string _username;
    private readonly BookDataAccess _bookDataAccess;
    private readonly Dispatcher _dispatcher;

    public BookSearchForm(string username)
    {
        InitializeComponent();
        _username = username;
        _bookDataAccess = new BookDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
        Helper.FLPDoubleBuffered(SearchResultFlowPanel, true);
    }

    //Events

    private async void BookSearchForm_Load(object sender, EventArgs e)
    {
        SearchMethodComboBox.SelectedIndex = 0;
        await ShowTrendingBooks();
    }

    private void SearchMethodComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {

        if (SearchMethodComboBox.SelectedItem.Equals("Name")) 
            SearchText.PlaceHolder = "Book Name";  
        else if(SearchMethodComboBox.SelectedItem.Equals("Author"))
            SearchText.PlaceHolder = "Author Name";
        else
            SearchText.PlaceHolder = "Category";
    }

    private async void SearchButton_Click(object sender, EventArgs e)
    {

        SearchResultFlowPanel.Controls.Clear();
        
        try
        {
            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            await FillSearchPanel();

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

            await ShowTrendingBooks();

        }
    }

    private static void VerifyInputs(string? searchMethod, string searchText)
    {

        if (string.IsNullOrEmpty(searchMethod))
            throw new Exception("Invalid search method, please select one from the provided list");

        if (string.IsNullOrEmpty(searchText))
        {
            throw searchMethod switch
            {
                "Name" => new Exception("Book name is required"),
                "Author" => new Exception("Author name is required"),
                "Category" => new Exception("Category is required"),
                _ => new Exception("Invalid search method, please select one from the provided list"),
            };
        }
    }

    //Functions

    public async Task ShowTrendingBooks()
    {
        try
        {
            SearchResultFlowPanel.Controls.Clear();

            IEnumerable<BookDTO>? books = await _bookDataAccess.GetAllBooks();

            if (books != null && books.Any())
            {
                await Task.Run(() =>
                {
                    var bookHolders = new List<BookHolder>();

                    foreach (var book in books)
                    {

                        BookHolder bookHolder = new(_username)
                        {
                            BookId = book.Id,
                            BookNameText = book.Name,
                            AuthorNameText = book.Author,
                            CategoryText = book.Category,
                            PurchasePriceText = book.Purchase_Price + "$",
                            RentPriceText = book.Rent_Price + "$",
                            AvailableCopiesText = book.In_Stock.ToString(),
                            BranchNameText = book.Branch_Name.ToString(),
                            ReturnButtonVisible = false
                        };

                        bookHolders.Add(bookHolder);

                    }
                    _dispatcher.Invoke(() =>
                    {
                        foreach (var bookHolder in bookHolders)
                        {
                            SearchResultFlowPanel.Controls.Add(bookHolder);
                            SearchResultLabel.Text = "Available Books";
                        }
                    });
                });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
            ex.Message,
            "Error occured",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
            );
        }
    }

    public async Task FillSearchPanel()
    {
        SearchResultFlowPanel.Controls.Clear();

        IEnumerable<BookDTO>? books = await SearchBooks();

        if (books != null && books.Any())
        {
            await Task.Run(() =>
            {
                var bookHolders = new List<BookHolder>();

                foreach (var book in books)
                {

                    BookHolder bookHolder = new(_username)
                    {
                        BookId = book.Id,
                        BookNameText = book.Name,
                        AuthorNameText = book.Author,
                        CategoryText = book.Category,
                        PurchasePriceText = book.Purchase_Price + "$",
                        RentPriceText = book.Rent_Price + "$",
                        AvailableCopiesText = book.In_Stock.ToString(),
                        BranchNameText = book.Branch_Name.ToString(),
                        ReturnButtonVisible = false
                    };

                    bookHolders.Add(bookHolder);

                }
                _dispatcher.Invoke(() =>
                {
                    foreach (var bookHolder in bookHolders)
                    {
                        SearchResultFlowPanel.Controls.Add(bookHolder);
                        SearchResultLabel.Text = "Search Result";
                    }
                });
            });
        }
    }

    private async Task<IEnumerable<BookDTO>?> SearchBooks()
    {
        string? searchMethod = SearchMethodComboBox.SelectedItem.ToString();
        string searchText = SearchText.Texts;
        
        VerifyInputs(searchMethod, searchText);
        if (searchText.Contains('\''))
            searchText = Helper.EscapeSingleQuote(searchText);

        return await _bookDataAccess.SearchBooks(searchMethod, searchText);            
    }
}
