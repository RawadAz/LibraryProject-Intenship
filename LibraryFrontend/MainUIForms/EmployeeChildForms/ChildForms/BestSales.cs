using ClassLibrary.DataAccess.TransactionDataAccess;
using ClassLibrary.Models.Employee.DTO_s;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.EmployeeChildForms.ChildForms;

public partial class BestSales : Form
{

    private readonly TransactionDataAccess _transactionDataAccess;

    public BestSales()
    {
        InitializeComponent();
        CenterToScreen();
        Helper.DGVDoubleBuffered(EmployeeSalesDGV, true);
        _transactionDataAccess = new TransactionDataAccess();
    }

    //Events

    private async void BestSales_Load(object sender, EventArgs e)
    {
        try
        {
            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            IEnumerable<EmployeeSalesDTO> sales = await _transactionDataAccess.GetAllEmployeeSales();

            EmployeeSalesDGV.AutoGenerateColumns = true;
            EmployeeSalesDGV.DataSource = sales;

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

        }
        catch(Exception ex) 
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            ex.Message,
            "Error occured",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
            );

            this.Close();
        }
    }
    
    private void BestSales_Resize(object sender, EventArgs e)
    {
        if (this.Size.Width >= 644)
            EmployeeSalesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        else
            EmployeeSalesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }
}
