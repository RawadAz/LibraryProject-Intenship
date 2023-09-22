using ClassLibrary.DataAccess.DashboardDataAccess;
using ClassLibrary.Models.Dashboard;
using ClassLibrary.Models.IdAndNameDTO;
using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryUI.MainUIForms.DashBoardForm;

public partial class DashboardForm : Form
{
    private readonly DashboardDataAccess _dashboardDataAccess;

    private IconButton? CurrentButton;
    private Button? CurrentDateButton;

    public DashboardForm()
    {
        InitializeComponent();
        this.DoubleBuffered = true;

        _dashboardDataAccess = new DashboardDataAccess();
    }

    //Events

    private void DashBoardForm_Load(object sender, EventArgs e)
    {
        MonthButton_Click(MonthButton, e);
    }

    private async void AllTimeButton_Click(object sender, EventArgs e)
    {
        
        string startDate = "2000-01-01";
        await FillDashBoard(startDate);
        CurrentDateButton = ActiveButton(sender, CurrentDateButton);
    }

    private async void MonthButton_Click(object sender, EventArgs e)
    {
        string startDate = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
        await FillDashBoard(startDate);
        CurrentDateButton = ActiveButton(sender, CurrentDateButton);
    }

    private async void WeekButton_Click(object sender, EventArgs e)
    {
        string startDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
        await FillDashBoard(startDate);
        CurrentDateButton = ActiveButton(sender, CurrentDateButton);
    }

    private async void TodayButton_Click(object sender, EventArgs e)
    {
        string startDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd hh:mm:ss tt");
        await FillDayDashBoard(startDate);
        CurrentDateButton = ActiveButton(sender, CurrentDateButton);
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }

    //Functions

    private async Task FillDashBoard(string startDate)
    {
        LoadingBar.Visible = true;
        LoadingLabel.Visible = true;
        
        try
        {
            await GetDashboardInfo(startDate);
            await GetTopEmployeesInfo();
            await GetSalesChartInfo(startDate);
            await GetTopBooksChartInfo(startDate);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

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

    private async Task FillDayDashBoard(string startDate)
    {
        LoadingBar.Visible = true;
        LoadingLabel.Visible = true;
        try
        {
            await GetDashboardInfo(startDate);
            await GetTopEmployeesInfo();
            await GetSalesChartDailyInfo(startDate);
            await GetTopBooksChartInfo(startDate);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

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

    private async Task GetTopEmployeesInfo()
    {   
        IEnumerable<NameAndIdDTO> NamesAndIds = await _dashboardDataAccess.GetTopThreeEmployees();
        FillTopEmployeesInfo(NamesAndIds);
    }

    public async Task GetDashboardInfo(string startDate)
    {    
        DashboardSalesInfo dashboardSalesInfo = await _dashboardDataAccess.GetSalesInfo(startDate);   
        FillSalesInfoTop(dashboardSalesInfo);
    }

    private async Task GetSalesChartDailyInfo(string startDate)
    { 
        IEnumerable<SalesChartDailyDTO> salesInfo = await _dashboardDataAccess.GetSalesChartDailyInfo(startDate);   
        FillSalesChart(salesInfo);
    }

    private async Task GetSalesChartInfo(string startDate)
    {  
        IEnumerable<SalesChartDTO> salesInfo = await _dashboardDataAccess.GetSalesChartInfo(startDate); 
        FillSalesChart(salesInfo);
    }

    private async Task GetTopBooksChartInfo(string startDate)
    {   
        IEnumerable<TopBookChartInfo> TopBooks = await _dashboardDataAccess.GetTopBooksChartInfo(startDate); 
        FillTopBooksChart(TopBooks);
    }

    private void FillTopBooksChart(IEnumerable<TopBookChartInfo> topBooks)
    {
        if (topBooks.Any())
        {
            BooksPieChart.DataSource = topBooks.ToList();
            BooksPieChart.Series[0].Label = string.Empty;
            BooksPieChart.Series[0].IsValueShownAsLabel = true;
            BooksPieChart.Series[0].XValueMember = "Name";
            BooksPieChart.Series[0].YValueMembers = "Sold_Books";
            BooksPieChart.DataBind();
        }
        else
        {
            List<int> emptyChart = new() { 360 };
            
            BooksPieChart.DataSource = emptyChart;
            BooksPieChart.Series[0].IsValueShownAsLabel = false;
            BooksPieChart.Series[0].Label = "None";
            BooksPieChart.Series[0].XValueMember = "None";
            BooksPieChart.Series[0].YValueMembers = "emptyChart";
            BooksPieChart.DataBind();
        }
    }

    private void FillSalesChart(IEnumerable<object> salesInfo)
    {
        if (salesInfo.Any())
        {
            SalesBarGraph.DataSource = salesInfo;
            SalesBarGraph.Series[0].XValueMember = "Date";
            SalesBarGraph.Series[0].YValueMembers = "Revenue";
            SalesBarGraph.DataBind();
        }
        else
        {
            List<int> emptyChart = new() { 0 };
            SalesBarGraph.DataSource = emptyChart;
            SalesBarGraph.Series[0].XValueMember = "emptyChart";
            SalesBarGraph.Series[0].YValueMembers = "emptyChart";
            SalesBarGraph.DataBind();
        }
    }

    private void FillTopEmployeesInfo(IEnumerable<NameAndIdDTO> namesAndIds)
    {
        if (namesAndIds == null)
            throw new Exception("Top Employees Not Found");
        
        int employeeCount = namesAndIds.Count();

        if (employeeCount <= 0)
        {
            FirstEmployeeIdTitleLabel.Visible = false;
            SecondEmployeeIdTitleLabel.Visible = false;
            ThirdEmployeeIdTitleLabel.Visible = false;

            return;
        }

        if (employeeCount == 1)
        {
            FirstEmployeeIdLabel.Text = namesAndIds.ElementAt(0).Id.ToString();
            FirstEmployeeNameLabel.Text = namesAndIds.ElementAt(0).Name.ToUpper();
            SecondEmployeeIdTitleLabel.Visible = false;
            ThirdEmployeeIdTitleLabel.Visible = false;

            return;
        }

        if (employeeCount == 2)
        {
            FirstEmployeeIdLabel.Text = namesAndIds.ElementAt(0).Id.ToString();
            FirstEmployeeNameLabel.Text = namesAndIds.ElementAt(0).Name.ToUpper();

            SecondEmployeeIdLabel.Text = namesAndIds.ElementAt(1).Id.ToString();
            SecondEmployeeNameLabel.Text = namesAndIds.ElementAt(1).Name.ToUpper();

            ThirdEmployeeIdTitleLabel.Visible = false;

            return;
        }

        if (employeeCount == 3)
        {

            FirstEmployeeIdLabel.Text = namesAndIds.ElementAt(0).Id.ToString();
            FirstEmployeeNameLabel.Text = namesAndIds.ElementAt(0).Name.ToUpper();

            SecondEmployeeIdLabel.Text = namesAndIds.ElementAt(1).Id.ToString();
            SecondEmployeeNameLabel.Text = namesAndIds.ElementAt(1).Name.ToUpper();

            ThirdEmployeeIdLabel.Text = namesAndIds.ElementAt(2).Id.ToString();
            ThirdEmployeeNameLabel.Text = namesAndIds.ElementAt(2).Name.ToUpper();

        }
    }

    private void FillSalesInfoTop(DashboardSalesInfo salesInfo)
    {
        TotalRevenueLabel.Text = $"{salesInfo.Total_Revenue} $";
        TotalSalesLabel.Text = salesInfo.Total_sales.ToString();
        BooksSoldLabel.Text = salesInfo.Books_Sold.ToString();
        BooksRentedLabel.Text = salesInfo.Books_Rented.ToString();
        RentedNowLabel.Text = salesInfo.Rented_Now.ToString();
    }


    //change Date button appearance on click
    public static Button? ActiveButton(object senderButton, Button? CurrentDateButton)
    {
        if (senderButton != null)
        {
            DisableButton(CurrentDateButton);
            //Change active button style

            CurrentDateButton = (Button)senderButton;
            CurrentDateButton.BackColor = Color.DeepSkyBlue;
 
        }
        return CurrentDateButton;
    }

    //resets Date button appearance
    public static Button? DisableButton(Button? CurrentDateButton)
    {
        if (CurrentDateButton != null)
        {
            CurrentDateButton.BackColor = Color.LightSkyBlue;
        }
        return CurrentDateButton;
    }

    private void SecondEmployeeIdTitleLabel_Click(object sender, EventArgs e)
    {

    }
}