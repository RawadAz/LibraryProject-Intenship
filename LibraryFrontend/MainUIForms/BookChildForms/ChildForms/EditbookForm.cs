using ClassLibrary.DataAccess.BookDataAccess;
using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.Models.Book;
using ClassLibrary.Models.IdAndNameDTO;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class EditbookForm : Form
{
    private readonly Dispatcher _dispatcher;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly BookDataAccess _bookDataAccess;
    private Book tempBook = new();
    public EditbookForm()
    {
        InitializeComponent();
        _branchDataAccess = new BranchDataAccess();
        _bookDataAccess = new BookDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private async void EditbookForm_Load(object sender, EventArgs e)
    {
        await FillBranchNameComboBox();
    }

    private async void BranchIdComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {

        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

        await FillBookNameComboBox(branchId);
    }

    private async void BookNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int bookId = Helper.GetIdFromComboBox(BookNameComboBox);
        if (bookId >= 0)
            await FillBookInfo(bookId);
    }

    private void EditBookRB_CheckedChanged(object sender, EventArgs e)
    {
        if (EditBookRB.Checked)
        {
            AuthorNameText.Enabled = true;
            CategoryText.Enabled = true;
            PurchasePriceNumeric.Enabled = true;
            RentPriceNumeric.Enabled = true;
            BookCopiesNumeric.Enabled = true;
            DescriptionText.Enabled = true;
            ResetButton.Enabled = true;
            UpdateOrDeleteBookButton.Text = "Update Book";
            UpdateOrDeleteBookButton.BackColor = System.Drawing.Color.Teal;
            LoadingLabel.Text = "Updating book, please wait..";
        }
        else
        {
            AuthorNameText.Enabled = false;
            CategoryText.Enabled = false;
            PurchasePriceNumeric.Enabled = false;
            RentPriceNumeric.Enabled = false;
            BookCopiesNumeric.Enabled = false;
            DescriptionText.Enabled = false;
            ResetButton.Enabled = false;
            UpdateOrDeleteBookButton.Text = "Remove Book";
            UpdateOrDeleteBookButton.BackColor = System.Drawing.Color.Crimson;
            LoadingLabel.Text = "Removing book, please wait..";
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        AuthorNameText.Texts = tempBook.Author;
        CategoryText.Texts = tempBook.Category;
        BookCopiesNumeric.Value = tempBook.In_Stock;
        PurchasePriceNumeric.Value = (decimal)tempBook.Purchase_Price;
        RentPriceNumeric.Value = (decimal)tempBook.Rent_Price;
        DescriptionText.Texts = tempBook.Description;
    }

    private async void UpdateOrDeleteBookButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (EditBookRB.Checked)
            {

                Book book = BookValidatedInfo();

                if (book.Equals(tempBook))
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string bookUpdated = await _bookDataAccess.UpdateBook(book);

                tempBook = book;

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                bookUpdated,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
            }
            else
            {
                int bookId = Helper.GetIdFromComboBox(BookNameComboBox);

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string bookDeleted = await _bookDataAccess.DeleteBook(bookId);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                bookDeleted,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );

                await FillBranchNameComboBox();

            }
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

    //Functions

    private Book BookValidatedInfo()
    {
        int bookId = Helper.GetIdFromComboBox(BookNameComboBox);

        string bookName = Helper.GetNameFromComboBox(BookNameComboBox);
        if (bookName.Contains('\''))
            bookName = Helper.EscapeSingleQuote(bookName);

        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

        string authorName = AuthorNameText.Texts;
        if (string.IsNullOrEmpty(authorName))
            throw new Exception("Author name is required");
        if (authorName.Contains('\''))
            authorName = Helper.EscapeSingleQuote(authorName);

        string category = CategoryText.Texts;
        if (string.IsNullOrEmpty(category))
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
            Id = bookId,
            Name = bookName,
            Author = authorName,
            Category = category,
            Purchase_Price = purchasePrice,
            Rent_Price = rentPrice,
            Branch_Id = branchId,
            In_Stock = bookCopies,
            Description = description
        };
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

    private async Task FillBookInfo(int bookId)
    {
        try
        {
            Book book = await _bookDataAccess.GetBookById(bookId);

            AuthorNameText.Texts = book.Author;
            CategoryText.Texts = book.Category;
            PurchasePriceNumeric.Value = (decimal)book.Purchase_Price;
            RentPriceNumeric.Value = (decimal)book.Rent_Price;
            BookCopiesNumeric.Value = (decimal)book.In_Stock;
            DescriptionText.Texts = book.Description;

            tempBook = book;
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
