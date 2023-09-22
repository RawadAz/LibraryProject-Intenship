using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.Models.Branch.DTO;

namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms
{
    public partial class BranchLocationsForm : Form
    {
        private readonly BranchDataAccess _branchDataAccess;
        private readonly Form _form;

        public BranchLocationsForm(Form form)
        {
            InitializeComponent();
            CenterToScreen();

            _branchDataAccess = new BranchDataAccess();
            _form = form;
        }

        private async Task FillBranchLocationDGV()
        {
            try
            {
                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                IEnumerable<BranchLocationDTO> branchLocations = await _branchDataAccess.GetBranchLocations();

                ViewBranchDGV.DataSource = branchLocations;
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

        private void BranchLocationDGV_Resize(object sender, EventArgs e)
        {
            if (ViewBranchDGV.Size.Width >= 800)
                ViewBranchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            else
                ViewBranchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private async void BranchLocationForm_Load(object sender , EventArgs e) 
        {
            await FillBranchLocationDGV();
        }

        private void BranchLocationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeUI employeeUI = (EmployeeUI)_form ;

            employeeUI.DisableButton();
            Control[] control = employeeUI.Controls.Find("LeftBorderButton", true);
            Panel LeftBorderButton = (Panel)control[0];
            LeftBorderButton.Visible = false;
        }
    }
}
