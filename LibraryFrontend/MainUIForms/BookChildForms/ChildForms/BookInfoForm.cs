using ClassLibrary.DataAccess.BookDataAccess;
using ClassLibrary.Models.Book;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms;

public partial class BookInfoForm : Form
{
    private readonly int _id = 0;
    private readonly BookDataAccess _bookDataAccess;

    public BookInfoForm(int id)
    {
        InitializeComponent();
        CenterToScreen();
        Helper.DGVDoubleBuffered(BookInfoDGV, true);
        _id = id;
        _bookDataAccess = new BookDataAccess();
    }

    //Events

    private async void BookInfoForm_Load(object sender, EventArgs e)
    {
        try
        {
            if (_id <= 0)
                throw new Exception("invalid book id");

            Book? book = await _bookDataAccess.GetBookById(_id);

            if (book == null)
                throw new Exception("Book info not available");

            BindingSource source = new()
            {
                DataSource = book
            };

            BookInfoDGV.AutoGenerateColumns = true;
            BookInfoDGV.DataSource = source;

        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
            this.Close();
        }
    }

    private void BookInfoForm_Resize(object sender, EventArgs e)
    {
        if (this.Size.Width >= 1104)
            BookInfoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        else
            BookInfoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }
}
