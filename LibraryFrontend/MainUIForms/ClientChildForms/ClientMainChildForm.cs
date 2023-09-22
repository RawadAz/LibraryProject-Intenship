using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.ClientChildForms.ChildForms;

namespace LibraryUI.MainUIForms.ClientChildForms;

public partial class ClientMainChildForm : Form
{
    private readonly string _username;
    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    public ClientMainChildForm(string username)
    {
        InitializeComponent();
        _username = username;
    }

    //Events

    private void ViewClientButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm =  Helper.OpenChildForm(new ViewClientForm(_username), CurrentChildForm, FormPanel);
    }

    private void AddClientButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new AddClientForm(), CurrentChildForm, FormPanel);
    }

    private void EditClientButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new EditClientForm(), CurrentChildForm, FormPanel);
    }

    private void RemoveClientButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new RemoveClientForm(), CurrentChildForm, FormPanel);
    }

    private void ClientMainChildForm_Load(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(ViewClientButton, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ViewClientForm(_username), CurrentChildForm, FormPanel);
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }
}
