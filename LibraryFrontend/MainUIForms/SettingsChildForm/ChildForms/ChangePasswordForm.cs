using ClassLibrary.DataAccess.EmployeeDataAccess;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.SettingsChildForm.ChildForms;

public partial class ChangePasswordForm : Form
{
    private readonly string _username;
    private readonly EmployeeDataAccess _employeeDataAccess;
    public ChangePasswordForm(string Username)
    {
        InitializeComponent();
        _username = Username;
        _employeeDataAccess = new EmployeeDataAccess();
    }

    //Events

    private void ResetButton_Click(object sender, EventArgs e)
    {
        OldPasswordText.Texts = string.Empty;
        NewPasswordText.Texts = string.Empty;
        ConfirmPasswordText.Texts = string.Empty;

    }

    private async void ChangePasswordButton_Click(object sender, EventArgs e)
    {

        string username = _username;
        string oldPassword = OldPasswordText.Texts;
        if (oldPassword.Contains('\''))
            oldPassword = Helper.EscapeSingleQuote(oldPassword);

        string newPassword = NewPasswordText.Texts;
        if (newPassword.Contains('\''))
            newPassword = Helper.EscapeSingleQuote(newPassword);

        string confirmPassword = ConfirmPasswordText.Texts;
        if (confirmPassword.Contains('\''))
            confirmPassword = Helper.EscapeSingleQuote(confirmPassword);

        try
        {

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeAdded = await _employeeDataAccess.UpdatePassword(username, oldPassword, newPassword, confirmPassword);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                "Password changed successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );

        }
        catch (Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                ex.Message,
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
    }

    private void ChangePasswordForm_Load(object sender, EventArgs e)
    {
        UsernameText.Texts = _username;
    }
}
