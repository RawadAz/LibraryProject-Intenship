using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.EmployeeDataAccess;
using ClassLibrary.Models.Branch;
using ClassLibrary.Models.Branch.DTO;
using ClassLibrary.Models.IdAndNameDTO;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms;

public partial class EditBranchForm : Form
{
    private readonly EmployeeDataAccess _employeeDataAccess;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly Dispatcher _dispatcher;
    private readonly int _branchId;
    private readonly Form _Form;
    private BranchUpdateDTO tempBranch = new();

    public EditBranchForm(int branchId, Form form)
    {
        InitializeComponent();
        CenterToParent();

        _employeeDataAccess = new EmployeeDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
        _branchId = branchId;
        _Form = form;
    }

    //Events

    private void EditBranchRB_CheckedChanged(object sender, EventArgs e)
    {
        if(EditBranchRB.Checked)
        {
            LocationText.Enabled = true;
            ManagerIdComboBox.Enabled = true;
            ManagerStartDatePicker.Enabled = true;
            EditBranchButton.BackColor = Color.Teal;
            EditBranchButton.Text = "Update Branch";
            ResetButton.Enabled = true;
        }
        else
        {
            LocationText.Enabled = false;
            ManagerIdComboBox.Enabled = false;
            ManagerStartDatePicker.Enabled = false;
            EditBranchButton.BackColor = Color.Crimson;
            EditBranchButton.Text = "Remove Branch";
            ResetButton.Enabled = false;
        }
    }

    private async void EditBranchForm_Load(object sender, EventArgs e)
    {
        await FillManagerIDComboBox();
        await FillBranchNameComboBox();
        Selectbranch();
    }

    private async void BranchNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);
        if (branchId >= 0)
            await FillBranchInfo(branchId);
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        LocationText.Texts = tempBranch.Location;
        if (tempBranch.CurrentManagerId != null)
            ManagerIdComboBox.SelectedItem = tempBranch.CurrentManagerId;
        if (tempBranch.ManagerStartDate != null)
            ManagerStartDatePicker.Value = DateTime.Parse(tempBranch.ManagerStartDate);
    }

    private async void EditBranchButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (EditBranchRB.Checked)
            {

                BranchUpdateDTO branch = BranchValidatedInfo();

                if (branch.Equals(tempBranch))
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string branchUpdated = await _branchDataAccess.UpdateBranch(branch);

                tempBranch = branch;

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                branchUpdated,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete the selected branch",
                    caption: "Confimation Message",
                    MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.No)
                    return;

                int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string branchDeleted = await _branchDataAccess.DeleteBranch(branchId);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                branchDeleted,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );

                await FillBranchNameComboBox();

            }
        }
        catch (Exception ex)
        {

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
        }
    }

    private async void EditBranchForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        //Refresh ViewBranchForm

        ViewBranchForm form = (ViewBranchForm)_Form;

        await form.FillBranchNameComboBox();
    }

    //Functions

    private void Selectbranch()
    {
        var BranchNamePair = Helper.SelectPairById(BranchNameComboBox, _branchId);
        if (BranchNamePair != null)
            BranchNameComboBox.SelectedIndex = BranchNameComboBox.Items.IndexOf(BranchNamePair);
        else
            BranchNameComboBox.SelectedIndex = 0;
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

    private async Task FillManagerIDComboBox()
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

    private async Task FillBranchInfo(int branchId)
    {
        try
        {
            Branch branch = await _branchDataAccess.GetBranchById(branchId);

            LocationText.Texts = branch.Location;
            if(branch.Manager_Id != null)
                ManagerIdComboBox.SelectedItem = branch.Manager_Id;
            if(branch.Manager_Start_Date != null)
                ManagerStartDatePicker.Value = DateTime.Parse(branch.Manager_Start_Date);

            FillTempBranch(branch);

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

    private void FillTempBranch(Branch branch)
    {
        tempBranch.Id = branch.Id;
        tempBranch.Name = branch.Name;
        tempBranch.Location = branch.Location;
        tempBranch.CurrentManagerId = branch.Manager_Id;
        tempBranch.NewManagerId = branch.Manager_Id;
        tempBranch.ManagerStartDate = branch.Manager_Start_Date;
    }

    private BranchUpdateDTO BranchValidatedInfo()
    {
        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);
        string branchName = Helper.GetNameFromComboBox(BranchNameComboBox);
        
        string location = LocationText.Texts;
        if (string.IsNullOrEmpty(location))
            throw new Exception("Branch location is required");
        if(location.Contains('\''))
            location = Helper.EscapeSingleQuote(location);

        bool idParsed = int.TryParse(ManagerIdComboBox.SelectedItem.ToString(), out int managerId);
        if (!idParsed)
            throw new Exception("Please select a valid manager id");

        string managerStartDate = ManagerStartDatePicker.Value.ToString("yyyy-MM-dd");
        if (string.IsNullOrEmpty(managerStartDate))
            throw new Exception("please select a valid manager start date");

        return new BranchUpdateDTO()
        {
            Id = branchId,
            Name = branchName,
            Location = location,
            CurrentManagerId = tempBranch.CurrentManagerId,
            NewManagerId = managerId,
            ManagerStartDate = managerStartDate
        };

    }  
}
