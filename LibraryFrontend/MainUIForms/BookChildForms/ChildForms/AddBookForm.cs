using ClassLibrary.Models.Book;
using ClassLibrary.Models.IdAndNameDTO;
using ClassLibrary.DataAccess.BookDataAccess;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;
using ClassLibrary.DataAccess.BranchDataAccess;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class AddBookForm : Form
{
    private readonly BranchDataAccess _branchDataAccess;
    private readonly BookDataAccess _bookDataAccess;
    private readonly Dispatcher _dispatcher;

    public AddBookForm()
    {
        InitializeComponent();
        _bookDataAccess = new BookDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private async void AddBookButton_Click(object sender, EventArgs e)
    {
        try
        {
            Book book = VerifyBookInputs();

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string bookAdded = await _bookDataAccess.AddBook(book);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            bookAdded,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
            );

        }
        catch(Exception ex) 
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

    private void ResetButton_Click(object sender, EventArgs e)
    {
        BookNameText.Texts = string.Empty;
        AuthorNameText.Texts = string.Empty;
        CategoryText.Texts = string.Empty;
        PurchasePriceNumeric.Value = 0;
        RentPriceNumeric.Value = 0;
        BookCopiesNumeric.Value = 1;
        BranchNameComboBox.SelectedIndex = 0;
        DescriptionText.Texts = string.Empty;
    }

    private async void AddBookForm_Load(object sender, EventArgs e)
    {
        await FillBranchNameComboBox();
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

    private Book VerifyBookInputs()
    {
        string bookName = BookNameText.Texts;
        if (string.IsNullOrEmpty(bookName))
            throw new Exception("Book name is required");
        if (bookName.Contains('\''))
            bookName = Helper.EscapeSingleQuote(bookName);

        string authorName = AuthorNameText.Texts;
        if (string.IsNullOrEmpty(authorName))
            throw new Exception("Author name is required");
        if (authorName.Contains('\''))
            authorName = Helper.EscapeSingleQuote(authorName);

        string category = CategoryText.Texts;
        if(string.IsNullOrEmpty(category))
            throw new Exception("Book category is required");
        if (category.Contains('\''))
            category = Helper.EscapeSingleQuote(category);

        bool purchasePriceParsed = double.TryParse(PurchasePriceNumeric.Value.ToString(), out double purchasePrice);
        if (!purchasePriceParsed)
            throw new Exception("Purchase price should be a numeric");

        bool rentPriceParsed = double.TryParse(RentPriceNumeric.Value.ToString(), out double rentPrice);
        if (!rentPriceParsed)
            throw new Exception("Rent price should be a numeric");

        bool bookCopiesParsed = int.TryParse(BookCopiesNumeric.Value.ToString(), out int bookCopies);
        if (!bookCopiesParsed)
            throw new Exception("book copies should be a numeric");

        string description = DescriptionText.Texts;
        if (string.IsNullOrEmpty(description))
            throw new Exception("book description is required");
        if (description.Contains('\''))
            description = Helper.EscapeSingleQuote(description);

        return new Book
        {
            Name = bookName,
            Author = authorName,
            Category = category,
            Purchase_Price = purchasePrice,
            Rent_Price = rentPrice,
            Branch_Id = Helper.GetIdFromComboBox(BranchNameComboBox),
            In_Stock = bookCopies,
            Description = description
        };
    }
}
