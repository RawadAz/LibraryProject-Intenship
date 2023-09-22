using ClassLibrary.DataAccess.BookDataAccess;
using ClassLibrary.Models.Book.DTO_s;
using LibraryUI.AdditionalControls.BookInfoHolder;
using LibraryUI.AdditionalControls.CategoryHolder;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class HomeForm : Form
{
    private readonly Dispatcher _dispatcher;
    private readonly string _username;
    private readonly BookDataAccess _bookDataAccess;

    public HomeForm(string username)
    {
        InitializeComponent();
        this.DoubleBuffered = true;
        
        _username = username;
        _bookDataAccess = new BookDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
        Helper.FLPDoubleBuffered(TopSellingFlowLayoutPanel, true);
    }

    //Events

    public async void HomeForm_Load(object sender, EventArgs e)
    {
        await AddCategories();
        await FillTopSellingPanel();
    }

    //Functions

    public async Task FillTopSellingPanel()
    {
        try
        {
            TopSellingFlowLayoutPanel.Controls.Clear();

            IEnumerable<TopSellingBook>? topSellingBooks = await _bookDataAccess.GetTopSellingBooks();

            if (topSellingBooks != null && topSellingBooks.Any())
            {
                await Task.Run(() =>
                {
                    var bookHolders = new List<BookHolder>();

                    foreach (var book in topSellingBooks)
                    {

                        BookHolder bookHolder = new(_username)
                        {
                            BookId = book.ID,
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
                            TopSellingFlowLayoutPanel.Controls.Add(bookHolder);

                        }
                    });
                });
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(
                       ex.Message,
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.None
                       );
        }
    }

    public async Task AddCategories()
    {
        try
        {
            CategoriesPanel.Controls.Clear();

            IEnumerable<string>? bookCategories = await _bookDataAccess.GetBookCategories();

            if (bookCategories != null && bookCategories.Any())
            {
                var categoryHolders = new List<CategoryHolder>();

                foreach (var category in bookCategories)
                {
                    IEnumerable<BookDTO>? books = await _bookDataAccess.GetBooksByCategory(category);

                    if (books != null && books.Any())
                    {

                        CategoryHolder categoryHolder = new()
                        {
                            TitleText = category
                        };

                        var bookHolders = new List<BookHolder>();

                        await Task.Run(() =>
                        {
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
                                    categoryHolder.CategoryFlowLayoutPanel.Controls.Add(bookHolder);
                                }
                            });
                        });

                        categoryHolders.Add(categoryHolder);
                    }
                }

                foreach (var categoryHolder in categoryHolders)
                {
                    CategoriesPanel.Controls.Add(categoryHolder);
                    categoryHolder.Dock = DockStyle.Bottom;

                }
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

