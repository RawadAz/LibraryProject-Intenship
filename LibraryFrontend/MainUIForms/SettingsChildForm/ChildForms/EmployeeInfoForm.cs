using ClassLibrary.DataAccess.EmployeeDataAccess;
using ClassLibrary.Models.Employee;
using ClassLibrary.Models.Employee.DTO_s;

namespace LibraryUI.MainUIForms.SettingsChildForm.ChildForms;

public partial class EmployeeInfoForm : Form
{

    private readonly string _username;
    private readonly EmployeeDataAccess _employeeDataAccess;

    public EmployeeInfoForm(string username)
    {
        InitializeComponent();

        _username = username;
        _employeeDataAccess = new EmployeeDataAccess();
    }

    private async void EmployeeInfoForm_Load(object sender, EventArgs e)
    {

        try
        {

            EmployeeDTO? employee = await _employeeDataAccess.GetEmployeeByUsername(_username);

            if (employee != null)
            {
                IdText.Text = employee.Id.ToString();
                FirstNameText.Text = employee.First_Name;
                LastnameText.Text = employee.Last_Name;
                BirthDateText.Text = employee.Dob;
                GenderText.Text = employee.Gender;
                PhoneNumberText.Text = employee.Phone_Number;
                PositionText.Text = employee.Position;
                SalaryText.Text = employee.Salary.ToString() + "$";
                BranchIdText.Text = employee.Branch_Id.ToString();
                SupervisorIdText.Text = employee.Supervisor_Id.ToString();

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
    }
        
}
