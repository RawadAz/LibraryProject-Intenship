using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.BookChildForms.ChildForms;

namespace LibraryUI.MainUIForms.BookChildForms;

public partial class MngBookMainChildForm : Form
{
    private readonly string _Username;

    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    public MngBookMainChildForm(string username)
    {
        InitializeComponent();
        _Username = username;
    }

    //Events

    private void HomeButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new HomeForm(_Username), CurrentChildForm, FormPanel);
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new BookSearchForm(_Username), CurrentChildForm, FormPanel);
    }

    private void ReturnDatesbutton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ReturnDatesForm(), CurrentChildForm, FormPanel);
    }

    private void AddBookButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new AddBookForm(), CurrentChildForm, FormPanel);
    }

    private void EditBookButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new EditbookForm(), CurrentChildForm, FormPanel);
    }

    private void BookMainChildForm_Load(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(HomeButton, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new HomeForm(_Username), CurrentChildForm, FormPanel);
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }

}
