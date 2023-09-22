using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.TransactionChildForms.ChildForms;

namespace LibraryUI.MainUIForms.TransactionChildForms;

public partial class MngTransactionMainChildForm : Form
{
    private readonly string _Username;
    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    public MngTransactionMainChildForm(string username)
    {
        InitializeComponent();
        _Username = username;
    }

    //Events

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);        
    }

    private void ViewTransactionsButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new MngViewTransactionsForm(_Username),CurrentChildForm, FormPanel);
    }

    private void TransactionMainChildForm_Load(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(ViewTransactionsButton, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new MngViewTransactionsForm(_Username), CurrentChildForm, FormPanel);
    }
}
