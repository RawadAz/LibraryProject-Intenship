using ClassLibrary.DataAccess.EmployeeDataAccess;
using FontAwesome.Sharp;

namespace LibraryUI.MainUIForms.EmployeeChildForms.ChildForms;

public partial class RemoveEmployeeForm : Form
{
    private readonly EmployeeDataAccess _employeeDataAccess;
    private readonly List<int> _idsToBeDeleted = new();
    
    private bool IsInitializing = true; //prevents adding an id to above list on load

    public RemoveEmployeeForm()
    {
        InitializeComponent();
        _employeeDataAccess = new EmployeeDataAccess();
    }

    //Events

    private void RemoveSingleRB_CheckedChanged(object sender, EventArgs e)
    {
        if(RemoveSingleRB.Checked)
        {
            SingleEmployeeIdComboBox.Enabled = true;
            MultipleEmployeeIdComboBox.Enabled = false;
            ResetButton.Enabled = false;
            _idsToBeDeleted.Clear();
            ToBeRemovedFLP.Controls.Clear();
            RemoveButton.Text = "Remove Employee";
            LoadingLabel.Text = "Removing employee, please wait...";
        }
        else
        {
            SingleEmployeeIdComboBox.Enabled = false;
            MultipleEmployeeIdComboBox.Enabled = true;
            ResetButton.Enabled = true;
            RemoveButton.Text = "Remove Employees";
            LoadingLabel.Text = "Removing employees, please wait...";

        }
    }

    private async void RemoveButton_Click(object sender, EventArgs e)
    {

        try
        {
            if (RemoveSingleRB.Checked)
            {
                bool parsed = int.TryParse(SingleEmployeeIdComboBox.SelectedItem.ToString(), out int id);

                if (!parsed)
                    throw new Exception("Id should be a number");

                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete the selected employee",
                    caption: "Confimation Message",
                    MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.No)
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeDeleted = await _employeeDataAccess.DeleteEmployee(id);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                    employeeDeleted,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
            }
            else
            {
                if (!_idsToBeDeleted.Any())
                    throw new Exception("Please select at least one employee to be deleted");

                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete the selected employee(s)",
                    caption: "Confimation Message",
                    MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.No)
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeDeleted = await _employeeDataAccess.DeleteMultipleEmployees(_idsToBeDeleted);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                    employeeDeleted,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );

                ToBeRemovedFLP.Controls.Clear();

            }

            IsInitializing = true;
            await FillSingleEmployeeIdComboBox();
            await FillMultipleEmployeeIdComboBox();
            ToBeRemovedFLP.Controls.Clear();

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

            ToBeRemovedFLP.Controls.Clear();
        }
    }

    private async void RemoveEmployeeForm_Load(object sender, EventArgs e)
    {
        await FillSingleEmployeeIdComboBox();
        await FillMultipleEmployeeIdComboBox();
    }

    private void Remove_Id_From_List(IconButton sender, EventArgs e)
    {
        _idsToBeDeleted.RemoveAt(_idsToBeDeleted.IndexOf(int.Parse(sender.Text)));
        sender.Dispose();
    }

    private void MultipleEmployeeIdComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if(!IsInitializing)
        {
            string? id = MultipleEmployeeIdComboBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(id))
            {
                if (!_idsToBeDeleted.Contains(int.Parse(id)))
                {
                    AddIdToFLP(id);
                    _idsToBeDeleted.Add(int.Parse(id));
                }
            }
        }
    }

    //Functions

    private void AddIdToFLP(string id)
    {
        IconButton button = new()
        {
            Size = new Size(120, 40),
            BackColor = Color.LightSkyBlue,
            FlatStyle = FlatStyle.Flat,
            Text = $"{id}",
            IconChar = IconChar.Remove,
            IconColor = Color.Teal,
            ForeColor = Color.Teal,
            TextImageRelation = TextImageRelation.TextBeforeImage,
            TextAlign = ContentAlignment.MiddleLeft,
            ImageAlign = ContentAlignment.MiddleCenter,
            IconSize = 34,
            Font = new Font("Segoe UI",12)
        };

        button.Click += new EventHandler((sender, e) => Remove_Id_From_List(button, EventArgs.Empty));

        ToBeRemovedFLP.Controls.Add(button);
    }

    private async Task<IEnumerable<int>> GetEmployeeIds()
    {
        return await _employeeDataAccess.GetEmployeeIds();
    }

    private async Task FillSingleEmployeeIdComboBox()
    {
        try
        {
            IEnumerable<int> ids = await GetEmployeeIds();

            SingleEmployeeIdComboBox.DataSource = ids;
            SingleEmployeeIdComboBox.DisplayMember = ids.First().ToString();
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

    private async Task FillMultipleEmployeeIdComboBox()
    {
        
        try
        {
            IEnumerable<int> ids = await GetEmployeeIds();

            MultipleEmployeeIdComboBox.DataSource = ids;
            MultipleEmployeeIdComboBox.DisplayMember = ids.First().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
        IsInitializing = false;
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        _idsToBeDeleted.Clear();
        ToBeRemovedFLP.Controls.Clear();
    }

}
