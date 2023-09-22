using ClassLibrary.Models.Employee;
using ClassLibrary.Models.IdAndNameDTO;
using System.Windows.Threading;
using LibraryUI.LayoutHelper;
using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.EmployeeDataAccess;
using LibraryUI.AdditionalControls.UnderlinedTextbox;

namespace LibraryUI.MainUIForms.EmployeeChildForms.ChildForms;

public partial class AddEmployeeForm : Form
{

    private readonly EmployeeDataAccess _employeeDataAccess; 
    private readonly BranchDataAccess _branchDataAccess;
    private readonly Dispatcher _dispatcher;

    public AddEmployeeForm()
    {
        InitializeComponent();
        _employeeDataAccess = new EmployeeDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private void ResetButton_Click(object sender, EventArgs e)
    {
        ResetAllInputs();
    }

    private async void AddEmployeeButton_Click(object sender, EventArgs e)
    {

        try
        {
            Employee employee = EmployeeInputsVerified();

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string employeeAdded = await _employeeDataAccess.AddEmployee(employee);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                employeeAdded,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );

            await FillSuperVisorIdComboBox();
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

    private async void AddEmployeeForm_Load(object sender, EventArgs e)
    {
        //set date
        DoBPicker.Value = DateTime.Now;
        await FillSuperVisorIdComboBox();
        await FillBranchNameComboBox();
    }

    //Functions

    private void ResetAllInputs()
    {
        FirstNameText.Texts = string.Empty;
        LastNameText.Texts= string.Empty;
        DoBPicker.Value = DateTime.Now;
        MGenderRB.Checked = true;
        PhoneNumberText.Texts = string.Empty;
        UsernameText.Texts = string.Empty;
        PasswordText.Texts = string.Empty;
        ConfirmPasswordText.Texts = string.Empty;
        PositionText.Texts = string.Empty;
        SalaryText.Texts = string.Empty;
        BranchNameComboBox.SelectedIndex = 0;
        SupervisorIdComboBox.SelectedIndex = 0;

        
    }

    private Employee EmployeeInputsVerified()
    {
        string? firstName = FirstNameText.Texts;
        string? lastName = LastNameText.Texts;
        string? phoneNumber = PhoneNumberText.Texts;
        string? username = UsernameText.Texts;
        string? password = PasswordText.Texts;
        string? confrimPassword = ConfirmPasswordText.Texts;
        string? position = PositionText.Texts;

        if (string.IsNullOrEmpty(firstName))            
            throw new Exception("First name is required!");
        if(firstName.Contains('\''))
            firstName = Helper.EscapeSingleQuote(firstName);

        if (string.IsNullOrEmpty(lastName))
            throw new Exception("Last name is required");
        if (lastName.Contains('\''))
            lastName = Helper.EscapeSingleQuote(lastName);

        if (DoBPicker.Value > DateTime.Now)   
            throw new Exception("Invalid birth date");

        if (string.IsNullOrEmpty(phoneNumber))
            throw new Exception("Phone number is required");
        if (phoneNumber.Contains('\''))
            phoneNumber = Helper.EscapeSingleQuote(phoneNumber);

        if (string.IsNullOrEmpty(username))
            throw new Exception("Username is required");
        if (username.Contains('\''))
            username = Helper.EscapeSingleQuote(username);

        if (string.IsNullOrEmpty(password))
            throw new Exception("Password is required");
        if (password.Contains('\''))
            password = Helper.EscapeSingleQuote(password);

        if (string.IsNullOrEmpty(confrimPassword))
            throw new Exception("Password Confirmation is required");
        if (confrimPassword.Contains('\''))
            confrimPassword = Helper.EscapeSingleQuote(confrimPassword);

        if (!PasswordText.Texts.Equals(ConfirmPasswordText.Texts))

            throw new Exception("Passwords do not match");

        if (string.IsNullOrEmpty(position))
            throw new Exception("Position is required");
        if (position.Contains('\''))
            position = Helper.EscapeSingleQuote(position);

        if (string.IsNullOrEmpty(SalaryText.Texts))
            throw new Exception("salary is required");

        string Dob = DoBPicker.Value.ToString("yyyy-MM-dd");

        string Gender = "male";
        if (FGenderRB.Checked)
            Gender = "female";

        bool SalaryParsed = float.TryParse(SalaryText.Texts, out float Salary);
        if (!SalaryParsed)
            throw new Exception("salary must be numeric (dont include currency)");


        bool SuperVisorIdParsed = int.TryParse(SupervisorIdComboBox.SelectedItem.ToString(), out int SupervisorId);
        if (!SuperVisorIdParsed)
            throw new Exception("Supervisor Id must be a number");

        return new Employee()
        {
            Id = 0,
            First_Name = firstName,
            Last_Name = lastName,
            Branch_Id = Helper.GetIdFromComboBox(BranchNameComboBox),
            Dob = Dob,
            Gender = Gender,
            Phone_Number = phoneNumber,
            Username = username,
            Password = password,
            Position = position,
            Salary = Salary,
            Supervisor_Id = SupervisorId
        };
    }

    private async Task FillSuperVisorIdComboBox()
    {
        //fill Supervisor Id comboBox
        try
        {
            IEnumerable<int> ids = await _employeeDataAccess.GetSupervisorIds();

            SupervisorIdComboBox.DataSource = ids;
            SupervisorIdComboBox.DisplayMember = ids.First().ToString();

        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
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
}
