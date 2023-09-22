using ClassLibrary.Models.IdAndNameDTO;
using System.Windows.Threading;
using LibraryUI.LayoutHelper;
using ClassLibrary.Models.Branch;
using ClassLibrary.DataAccess.BranchDataAccess;

namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms;

public partial class ViewBranchForm : Form
{
    private readonly BranchDataAccess _branchDataAccess;
    private readonly Dispatcher _dispatcher;

    public ViewBranchForm()
    {
        InitializeComponent();
        _branchDataAccess = new BranchDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events
    private void ViewBranchDGV_Resize(object sender, EventArgs e)
    {
        if(ViewBranchDGV.Size.Width >= 1024)
            ViewBranchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        else
            ViewBranchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
    }

    private async void ViewBranchForm_Load(object sender, EventArgs e)
    {
        await FillBranchNameComboBox();
    }

    private async void BranchNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        await FillBranchDGV();
    }

    private void AddNewBranchLabelButton_Click(object sender, EventArgs e)
    {
        AddBranchForm addBranchForm = new(this.FindForm());
        addBranchForm.ShowDialog();
    }

    private void ViewBranchDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 5 && e.RowIndex >= 0)
        {

            int row = e.RowIndex;
            Branch branch = (Branch)ViewBranchDGV.Rows[row].DataBoundItem;
            int branchId = branch.Id;

            EditBranchForm editBranchForm = new(branchId, this.FindForm());
            editBranchForm.ShowDialog();

        }
    }

    //Functions

    public async Task FillBranchNameComboBox()
    {
        try
        {
            IEnumerable<NameAndIdDTO> namesAndIds = await _branchDataAccess.GetBranchIdsAndNames();

            Dictionary<string, int> namesAndIdsDict = new();

            await Task.Run(() =>
            {
                Dictionary<string, int> temp = new();

                KeyValuePair<string, int> keyValue = new(key: "All", value: 0);
                temp.Add(keyValue.Key, keyValue.Value);

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

    private async Task FillBranchDGV()
    {
        try
        {
            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

            List<Branch> branchList = new();

            if (branchId == 0) //All branches
            {
                IEnumerable<Branch>? branches = await _branchDataAccess.GetAllBranches();

                if (branches != null && branches.Any())
                {
                    branchList = branches.ToList();
                }
                else
                    throw new Exception("No branches found");
            }
            else
            {
                Branch branch = await _branchDataAccess.GetBranchById(branchId);
                branchList.Add(branch);
            }

            ViewBranchDGV.DataSource = branchList;
            ViewBranchDGV.Enabled = true;

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

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
}
