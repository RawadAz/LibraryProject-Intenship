using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.SettingsChildForm.ChildForms;

namespace LibraryUI.MainUIForms.SettingsChildForm;

public partial class SettingsMainForm : Form
{

    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    private readonly string _username;

    public SettingsMainForm(string username)
    {
        InitializeComponent();
        _username = username;
    }

    //Events

    private void ViewInfoButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new EmployeeInfoForm(_username), CurrentChildForm, FormPanel);
    }

    private void ChangePasswordButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ChangePasswordForm(_username), CurrentChildForm, FormPanel);
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }

    private void SettingsMainForm_Load(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(ViewInfoButton, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new EmployeeInfoForm(_username), CurrentChildForm, FormPanel);
    }
}
