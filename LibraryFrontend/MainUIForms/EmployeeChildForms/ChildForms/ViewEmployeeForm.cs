using ClassLibrary.Models.Employee;
using LibraryUI.LayoutHelper;
using ClassLibrary.DataAccess.EmployeeDataAccess;
using ClassLibrary.Models.Employee.DTO_s;

namespace LibraryUI.MainUIForms.EmployeeChildForms.ChildForms;

public partial class ViewEmployeeForm : Form
{
    private readonly EmployeeDataAccess _employeeDataAccess;

    public ViewEmployeeForm()
    {
        InitializeComponent();
        Helper.DGVDoubleBuffered(ViewEmployeesDGV, true);
        _employeeDataAccess = new EmployeeDataAccess();       
    }

    //Events

    private async void GetEmployeesButton_Click(object sender, EventArgs e)
    {

        //loading visuals
        LoadingBar.Visible = true;
        LoadingLabel.Visible = true;

        try
        {
            string? searchMethod = searchComboBox.SelectedItem.ToString();

            if (searchMethod != null)
            {
                if (searchMethod.Equals("All"))
                {
                    IEnumerable<EmployeeDTO> employees = await _employeeDataAccess.GetEmployees();

                    BindingSource source = new()
                    {
                        DataSource = employees
                    };

                    ViewEmployeesDGV.AutoGenerateColumns = true;
                    ViewEmployeesDGV.DataSource = source;

                }
                else if (searchMethod.Equals("Id"))
                {

                    string? id = IdOrFirstNameText.Texts;

                    EmployeeDTO employee = await _employeeDataAccess.GetEmployeeById(id);

                    BindingSource source = new()
                    {
                        DataSource = employee
                    };

                    ViewEmployeesDGV.AutoGenerateColumns = true;
                    ViewEmployeesDGV.DataSource = source;
                }

                else if (searchMethod.Equals("Name"))
                {

                    string FirstName = IdOrFirstNameText.Texts;
                    string LastName = LastNameText.Texts;

                    IEnumerable<EmployeeDTO> employees = await _employeeDataAccess.GetEmployeeByName(FirstName, LastName);

                    BindingSource source = new()
                    {
                        DataSource = employees
                    };

                    ViewEmployeesDGV.AutoGenerateColumns = true;
                    ViewEmployeesDGV.DataSource = source;
                }

                IdOrFirstNameText.Texts = string.Empty;
                LastNameText.Texts = string.Empty;

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;
            }
            else
                throw new Exception("please specify a way of searching");
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

    private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (searchComboBox.SelectedItem.Equals("Id"))
        {
            IdOrFirstNameText.PlaceHolder = "Id:";
            IdOrFirstNameText.Texts = string.Empty;
            IdOrFirstNameText.Visible = true;
            LastNameText.Texts = string.Empty;
            LastNameText.Visible = false;
            return;
        }

        if (searchComboBox.SelectedItem.Equals("Name"))
        {
            IdOrFirstNameText.PlaceHolder = "First Name:";
            IdOrFirstNameText.Texts = string.Empty;
            IdOrFirstNameText.Visible = true;
            LastNameText.Texts = string.Empty;
            LastNameText.Visible = true;
            return;
        }

        IdOrFirstNameText.Visible = false;
        LastNameText.Visible = false;
        IdOrFirstNameText.Texts = string.Empty;
        LastNameText.Texts = string.Empty;
        return;
    }

    private void ViewEmployeeForm_Load(object sender, EventArgs e)
    {
        searchComboBox.SelectedIndex = 0;
        GetEmployeesButton_Click(GetEmployeesButton, e);
    }

    private void ViewSalesButton_Click(object sender, EventArgs e)
    {
        BestSales sales = new();
        sales.ShowDialog();
    }

    private void ViewEmployeeForm_ResizeEnd(object sender, EventArgs e)
    {
        if (this.Size.Width >= 1525)
            ViewEmployeesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        else
            ViewEmployeesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

    }
}