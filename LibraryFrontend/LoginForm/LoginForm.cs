using ClassLibrary.DataAccess.EmployeeDataAccess;
using ClassLibrary.Models.Employee.DTO_s.LoginInfo;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms;
using LibraryUI.MainUIFroms;
using LibraryUI.Properties;

namespace LibraryUI;

public partial class LoginForm : Form
{
    private readonly EmployeeDataAccess _EmployeeDataAccess;

    public LoginForm()
    {
        InitializeComponent();
        CenterToScreen();
        _EmployeeDataAccess = new EmployeeDataAccess();
    }

    private async void LoginBtn_Click(object sender, EventArgs e)
    {
        try
        {
            //logging in visuals
            loggingInLabel.Visible = true;
            loginProgressBar.Visible = true;
            LoginBtn.Cursor = Cursors.WaitCursor;

            string username = UsernameText.Texts;
            if(username.Contains('\''))
                username = Helper.EscapeSingleQuote(username);

            string password = PasswordText.Texts;
            if (password.Contains('\''))
                password = Helper.EscapeSingleQuote(password);

            LoginInfoResponseDTO? login = await _EmployeeDataAccess.GetLoginInfo(username, password);

            if (login != null)
            {

                string fullName = $"{login.First_Name} {login.Last_Name}";

                if (login.Position == "manager")
                {
                    this.Hide();

                    ManagerUI managerUI = new(this, username);
                    managerUI.Show();
                }
                else
                {
                    this.Hide();

                    EmployeeUI employeeUI = new(this, username);
                    employeeUI.Show();
                }

                //clear texts if login successful
                UsernameText.Texts = string.Empty;
                PasswordText.Texts = string.Empty;

                //hide login visuals
                loggingInLabel.Visible = false;
                loginProgressBar.Visible = false;

                LoginBtn.Cursor = Cursors.Default;
            }
        }
        catch (Exception ex)
        {
            loggingInLabel.Visible = false;
            loginProgressBar.Visible = false;

            LoginBtn.Cursor = Cursors.Default;

            MessageBox.Show(
                ex.Message,
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
    }

    private void ResetBtn_Click(object sender, EventArgs e)
    {
        UsernameText.Texts = string.Empty;
        PasswordText.Texts = string.Empty;
    }

    private void PasswordToggleImage_Click(object sender, EventArgs e)
    {
        if (PasswordText.PasswordChar)
        {
            PasswordText.PasswordChar = false;
            PasswordToggleImage.Image = Resources.show_password;
        }
        else
        {
            PasswordText.PasswordChar = true;
            PasswordToggleImage.Image = Resources.hide_password;
        }
    }
}