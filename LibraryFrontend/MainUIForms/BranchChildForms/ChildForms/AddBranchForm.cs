using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.EmployeeDataAccess;
using ClassLibrary.Models.Branch;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms;

public partial class AddBranchForm : Form
{
    private readonly EmployeeDataAccess _employeeDataAccess;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly Form _form;

    public AddBranchForm(Form form)
    {
        InitializeComponent();
        CenterToScreen();
        _employeeDataAccess = new EmployeeDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _form = form;
    }

    //Events

    private async void AddBranchForm_Load(object sender, EventArgs e)
    {
        ManagerStartDatePicker.Value = DateTime.Now;
        await FillManagerIdComboBox();
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        BranchNameText.Texts = string.Empty;
        LocationText.Texts = string.Empty;
        ManagerIdComboBox.SelectedIndex = 0;
        ManagerStartDatePicker.Value = DateTime.Now;
    }

    private async void AddBranchButton_Click(object sender, EventArgs e)
    {
        try
        {
            Branch branch = BranchInputsVerified();

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string branchAdded = await _branchDataAccess.AddBranch(branch);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            branchAdded,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
            );

            await FillManagerIdComboBox();
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

    private async void AddBranchForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        //Refresh ViewBranchForm

        ViewBranchForm form = (ViewBranchForm)_form;

        await form.FillBranchNameComboBox();
    }

    //Functions

    private async Task FillManagerIdComboBox()
    {
        try
        {
            IEnumerable<int> ids = await _employeeDataAccess.GetEmployeeIds();

            ManagerIdComboBox.DataSource = ids;
            ManagerIdComboBox.DisplayMember = ids.First().ToString();

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

    private Branch BranchInputsVerified()
    {
        string branchName = BranchNameText.Texts;
        if (string.IsNullOrEmpty(branchName))
            throw new Exception("Branch name is required");
        if (branchName.Contains('\''))
            branchName = Helper.EscapeSingleQuote(branchName);

        string location = LocationText.Texts;
        if (string.IsNullOrEmpty(location))
            throw new Exception("Branch location is required");
        if (location.Contains('\''))
            location = Helper.EscapeSingleQuote(location);

        bool idParsed = int.TryParse(ManagerIdComboBox.SelectedItem.ToString(), out int id);
        if (!idParsed)
            throw new Exception("Invalid Manager Id");

        string managerStartDate = ManagerStartDatePicker.Value.ToString();
        if (string.IsNullOrEmpty(managerStartDate))
            throw new Exception("Start date is required");

        return new Branch()
        {
            Id = 0,
            Name = branchName,
            Location = location,
            Manager_Id = id,
            Manager_Start_Date = managerStartDate
        };
    }

    
}
