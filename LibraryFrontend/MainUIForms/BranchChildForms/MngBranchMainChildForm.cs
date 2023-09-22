using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.BranchChildForms.ChildForms;

namespace LibraryUI.MainUIForms.BranchChildForms;

public partial class MngBranchMainChildForm : Form
{
    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    public MngBranchMainChildForm()
    {
        InitializeComponent();
    }

    //Events

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }

    private void ViewTransactionsButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ViewBranchForm(), CurrentChildForm, FormPanel);
    }

    private void BranchMainChildForm_Load(object sender, EventArgs e)
    {
        ViewTransactionsButton_Click(ViewTransactionsButton, e);
    }
}
