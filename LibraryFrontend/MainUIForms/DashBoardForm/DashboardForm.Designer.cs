namespace LibraryUI.MainUIForms.DashBoardForm
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.DashBoardTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.TopEmployeesLabel = new System.Windows.Forms.Label();
            this.TotalSalesPanel = new System.Windows.Forms.Panel();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.TotalSalesTitleLabel = new System.Windows.Forms.Label();
            this.WeekButton = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.DashboardTitleLabel = new System.Windows.Forms.Label();
            this.AllTimeButton = new System.Windows.Forms.Button();
            this.MonthButton = new System.Windows.Forms.Button();
            this.TotalRevenuePanel = new System.Windows.Forms.Panel();
            this.TotalRevenueLabel = new System.Windows.Forms.Label();
            this.TotalRevenueTitleLabel = new System.Windows.Forms.Label();
            this.BooksSoldPanel = new System.Windows.Forms.Panel();
            this.BooksSoldLabel = new System.Windows.Forms.Label();
            this.BooksSoldTitleLabel = new System.Windows.Forms.Label();
            this.BooksRentedPanel = new System.Windows.Forms.Panel();
            this.BooksRentedLabel = new System.Windows.Forms.Label();
            this.BooksRentedTitleLabel = new System.Windows.Forms.Label();
            this.SalesBarGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BooksPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RentedNowPanel = new System.Windows.Forms.Panel();
            this.RentedNowLabel = new System.Windows.Forms.Label();
            this.RentedNowTitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.CountersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.FirstEmployeePanel = new System.Windows.Forms.Panel();
            this.FirstEmployeeNameLabel = new System.Windows.Forms.Label();
            this.FirstEmployeeIdLabel = new System.Windows.Forms.Label();
            this.FirstEmployeeIdTitleLabel = new System.Windows.Forms.Label();
            this.FirstEmployeeRankingLabel = new System.Windows.Forms.Label();
            this.SecondEmployePanel = new System.Windows.Forms.Panel();
            this.SecondEmployeeNameLabel = new System.Windows.Forms.Label();
            this.SecondEmployeeIdLabel = new System.Windows.Forms.Label();
            this.SecondEmployeeIdTitleLabel = new System.Windows.Forms.Label();
            this.SecondEmployeeRankingLabel = new System.Windows.Forms.Label();
            this.ThridEmployeePanel = new System.Windows.Forms.Panel();
            this.ThirdEmployeeNameLabel = new System.Windows.Forms.Label();
            this.ThirdEmployeeIdLabel = new System.Windows.Forms.Label();
            this.ThirdEmployeeIdTitleLabel = new System.Windows.Forms.Label();
            this.ThirdEmployeeRankingLabel = new System.Windows.Forms.Label();
            this.SubMenuPanel.SuspendLayout();
            this.DashBoardTableLayoutPanel.SuspendLayout();
            this.TotalSalesPanel.SuspendLayout();
            this.TotalRevenuePanel.SuspendLayout();
            this.BooksSoldPanel.SuspendLayout();
            this.BooksRentedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBarGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPieChart)).BeginInit();
            this.RentedNowPanel.SuspendLayout();
            this.CountersFlowLayout.SuspendLayout();
            this.FirstEmployeePanel.SuspendLayout();
            this.SecondEmployePanel.SuspendLayout();
            this.ThridEmployeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(1144, 5);
            this.SplitterPanel.TabIndex = 6;
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(1144, 60);
            this.SubMenuPanel.TabIndex = 5;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.Teal;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.LogoutButton.IconColor = System.Drawing.Color.Teal;
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 44;
            this.LogoutButton.Location = new System.Drawing.Point(971, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DashBoardTableLayoutPanel
            // 
            this.DashBoardTableLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DashBoardTableLayoutPanel.ColumnCount = 7;
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.DashBoardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.DashBoardTableLayoutPanel.Controls.Add(this.LoadingBar, 0, 7);
            this.DashBoardTableLayoutPanel.Controls.Add(this.TopEmployeesLabel, 1, 5);
            this.DashBoardTableLayoutPanel.Controls.Add(this.TotalSalesPanel, 3, 1);
            this.DashBoardTableLayoutPanel.Controls.Add(this.WeekButton, 4, 0);
            this.DashBoardTableLayoutPanel.Controls.Add(this.TodayButton, 3, 0);
            this.DashBoardTableLayoutPanel.Controls.Add(this.DashboardTitleLabel, 0, 0);
            this.DashBoardTableLayoutPanel.Controls.Add(this.AllTimeButton, 6, 0);
            this.DashBoardTableLayoutPanel.Controls.Add(this.MonthButton, 5, 0);
            this.DashBoardTableLayoutPanel.Controls.Add(this.TotalRevenuePanel, 0, 1);
            this.DashBoardTableLayoutPanel.Controls.Add(this.BooksSoldPanel, 4, 1);
            this.DashBoardTableLayoutPanel.Controls.Add(this.BooksRentedPanel, 5, 1);
            this.DashBoardTableLayoutPanel.Controls.Add(this.SalesBarGraph, 0, 2);
            this.DashBoardTableLayoutPanel.Controls.Add(this.BooksPieChart, 5, 2);
            this.DashBoardTableLayoutPanel.Controls.Add(this.RentedNowPanel, 6, 1);
            this.DashBoardTableLayoutPanel.Controls.Add(this.LoadingLabel, 1, 7);
            this.DashBoardTableLayoutPanel.Controls.Add(this.CountersFlowLayout, 1, 6);
            this.DashBoardTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardTableLayoutPanel.Location = new System.Drawing.Point(0, 65);
            this.DashBoardTableLayoutPanel.Name = "DashBoardTableLayoutPanel";
            this.DashBoardTableLayoutPanel.RowCount = 8;
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.20729F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49826F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.84669F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.462403F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26132F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.574913F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.86063F));
            this.DashBoardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.665505F));
            this.DashBoardTableLayoutPanel.Size = new System.Drawing.Size(1144, 574);
            this.DashBoardTableLayoutPanel.TabIndex = 7;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.LoadingBar.AnimationSpeed = 500;
            this.LoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingBar.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadingBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.InnerMargin = 2;
            this.LoadingBar.InnerWidth = -1;
            this.LoadingBar.Location = new System.Drawing.Point(23, 537);
            this.LoadingBar.MarqueeAnimationSpeed = 2000;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.OuterMargin = -25;
            this.LoadingBar.OuterWidth = 26;
            this.LoadingBar.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.LoadingBar.ProgressWidth = 22;
            this.LoadingBar.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadingBar.Size = new System.Drawing.Size(34, 34);
            this.LoadingBar.StartAngle = 270;
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LoadingBar.SubscriptText = ".23";
            this.LoadingBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LoadingBar.SuperscriptText = "°C";
            this.LoadingBar.TabIndex = 80;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // TopEmployeesLabel
            // 
            this.TopEmployeesLabel.AutoSize = true;
            this.TopEmployeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopEmployeesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopEmployeesLabel.Location = new System.Drawing.Point(63, 385);
            this.TopEmployeesLabel.Name = "TopEmployeesLabel";
            this.TopEmployeesLabel.Size = new System.Drawing.Size(153, 28);
            this.TopEmployeesLabel.TabIndex = 2;
            this.TopEmployeesLabel.Text = "Top Employees";
            // 
            // TotalSalesPanel
            // 
            this.TotalSalesPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TotalSalesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSalesPanel.Controls.Add(this.TotalSalesLabel);
            this.TotalSalesPanel.Controls.Add(this.TotalSalesTitleLabel);
            this.TotalSalesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalSalesPanel.Location = new System.Drawing.Point(423, 66);
            this.TotalSalesPanel.Name = "TotalSalesPanel";
            this.TotalSalesPanel.Size = new System.Drawing.Size(174, 59);
            this.TotalSalesPanel.TabIndex = 64;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalSalesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalSalesLabel.Location = new System.Drawing.Point(0, 23);
            this.TotalSalesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(172, 26);
            this.TotalSalesLabel.TabIndex = 1;
            this.TotalSalesLabel.Text = "10000";
            this.TotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSalesTitleLabel
            // 
            this.TotalSalesTitleLabel.AutoSize = true;
            this.TotalSalesTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalSalesTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalSalesTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalSalesTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TotalSalesTitleLabel.Name = "TotalSalesTitleLabel";
            this.TotalSalesTitleLabel.Size = new System.Drawing.Size(89, 23);
            this.TotalSalesTitleLabel.TabIndex = 0;
            this.TotalSalesTitleLabel.Text = "Total Sales";
            // 
            // WeekButton
            // 
            this.WeekButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekButton.AutoSize = true;
            this.WeekButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.WeekButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.WeekButton.FlatAppearance.BorderSize = 2;
            this.WeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeekButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeekButton.ForeColor = System.Drawing.Color.Teal;
            this.WeekButton.Location = new System.Drawing.Point(600, 26);
            this.WeekButton.Margin = new System.Windows.Forms.Padding(0);
            this.WeekButton.Name = "WeekButton";
            this.WeekButton.Size = new System.Drawing.Size(180, 37);
            this.WeekButton.TabIndex = 59;
            this.WeekButton.Text = "This Week";
            this.WeekButton.UseVisualStyleBackColor = false;
            this.WeekButton.Click += new System.EventHandler(this.WeekButton_Click);
            // 
            // TodayButton
            // 
            this.TodayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayButton.AutoSize = true;
            this.TodayButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TodayButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.TodayButton.FlatAppearance.BorderSize = 2;
            this.TodayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TodayButton.ForeColor = System.Drawing.Color.Teal;
            this.TodayButton.Location = new System.Drawing.Point(422, 26);
            this.TodayButton.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(178, 37);
            this.TodayButton.TabIndex = 58;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = false;
            this.TodayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // DashboardTitleLabel
            // 
            this.DashboardTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DashBoardTableLayoutPanel.SetColumnSpan(this.DashboardTitleLabel, 3);
            this.DashboardTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.DashboardTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.DashboardTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.DashboardTitleLabel.Name = "DashboardTitleLabel";
            this.DashboardTitleLabel.Size = new System.Drawing.Size(395, 63);
            this.DashboardTitleLabel.TabIndex = 56;
            this.DashboardTitleLabel.Text = "Dashboard";
            this.DashboardTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllTimeButton
            // 
            this.AllTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTimeButton.AutoSize = true;
            this.AllTimeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AllTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.AllTimeButton.FlatAppearance.BorderSize = 2;
            this.AllTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllTimeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllTimeButton.ForeColor = System.Drawing.Color.Teal;
            this.AllTimeButton.Location = new System.Drawing.Point(960, 26);
            this.AllTimeButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTimeButton.Name = "AllTimeButton";
            this.AllTimeButton.Size = new System.Drawing.Size(182, 37);
            this.AllTimeButton.TabIndex = 57;
            this.AllTimeButton.Text = "All Time";
            this.AllTimeButton.UseVisualStyleBackColor = false;
            this.AllTimeButton.Click += new System.EventHandler(this.AllTimeButton_Click);
            // 
            // MonthButton
            // 
            this.MonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthButton.AutoSize = true;
            this.MonthButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MonthButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.MonthButton.FlatAppearance.BorderSize = 2;
            this.MonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonthButton.ForeColor = System.Drawing.Color.Teal;
            this.MonthButton.Location = new System.Drawing.Point(780, 26);
            this.MonthButton.Margin = new System.Windows.Forms.Padding(0);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(180, 37);
            this.MonthButton.TabIndex = 60;
            this.MonthButton.Text = "This Month";
            this.MonthButton.UseVisualStyleBackColor = false;
            this.MonthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // TotalRevenuePanel
            // 
            this.TotalRevenuePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TotalRevenuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DashBoardTableLayoutPanel.SetColumnSpan(this.TotalRevenuePanel, 3);
            this.TotalRevenuePanel.Controls.Add(this.TotalRevenueLabel);
            this.TotalRevenuePanel.Controls.Add(this.TotalRevenueTitleLabel);
            this.TotalRevenuePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalRevenuePanel.Location = new System.Drawing.Point(3, 66);
            this.TotalRevenuePanel.Name = "TotalRevenuePanel";
            this.TotalRevenuePanel.Size = new System.Drawing.Size(414, 59);
            this.TotalRevenuePanel.TabIndex = 65;
            // 
            // TotalRevenueLabel
            // 
            this.TotalRevenueLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalRevenueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalRevenueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalRevenueLabel.Location = new System.Drawing.Point(0, 20);
            this.TotalRevenueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TotalRevenueLabel.Name = "TotalRevenueLabel";
            this.TotalRevenueLabel.Size = new System.Drawing.Size(412, 26);
            this.TotalRevenueLabel.TabIndex = 1;
            this.TotalRevenueLabel.Text = "10000";
            this.TotalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TotalRevenueTitleLabel
            // 
            this.TotalRevenueTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalRevenueTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalRevenueTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalRevenueTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TotalRevenueTitleLabel.Name = "TotalRevenueTitleLabel";
            this.TotalRevenueTitleLabel.Size = new System.Drawing.Size(412, 20);
            this.TotalRevenueTitleLabel.TabIndex = 0;
            this.TotalRevenueTitleLabel.Text = "Total Revenue";
            // 
            // BooksSoldPanel
            // 
            this.BooksSoldPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BooksSoldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BooksSoldPanel.Controls.Add(this.BooksSoldLabel);
            this.BooksSoldPanel.Controls.Add(this.BooksSoldTitleLabel);
            this.BooksSoldPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BooksSoldPanel.Location = new System.Drawing.Point(603, 66);
            this.BooksSoldPanel.Name = "BooksSoldPanel";
            this.BooksSoldPanel.Size = new System.Drawing.Size(174, 59);
            this.BooksSoldPanel.TabIndex = 69;
            // 
            // BooksSoldLabel
            // 
            this.BooksSoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.BooksSoldLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksSoldLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BooksSoldLabel.Location = new System.Drawing.Point(0, 23);
            this.BooksSoldLabel.Margin = new System.Windows.Forms.Padding(3);
            this.BooksSoldLabel.Name = "BooksSoldLabel";
            this.BooksSoldLabel.Size = new System.Drawing.Size(172, 26);
            this.BooksSoldLabel.TabIndex = 1;
            this.BooksSoldLabel.Text = "10000";
            this.BooksSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BooksSoldTitleLabel
            // 
            this.BooksSoldTitleLabel.AutoSize = true;
            this.BooksSoldTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.BooksSoldTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksSoldTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BooksSoldTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.BooksSoldTitleLabel.Name = "BooksSoldTitleLabel";
            this.BooksSoldTitleLabel.Size = new System.Drawing.Size(86, 23);
            this.BooksSoldTitleLabel.TabIndex = 0;
            this.BooksSoldTitleLabel.Text = "Book Sold";
            // 
            // BooksRentedPanel
            // 
            this.BooksRentedPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BooksRentedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BooksRentedPanel.Controls.Add(this.BooksRentedLabel);
            this.BooksRentedPanel.Controls.Add(this.BooksRentedTitleLabel);
            this.BooksRentedPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BooksRentedPanel.Location = new System.Drawing.Point(783, 66);
            this.BooksRentedPanel.Name = "BooksRentedPanel";
            this.BooksRentedPanel.Size = new System.Drawing.Size(174, 59);
            this.BooksRentedPanel.TabIndex = 70;
            // 
            // BooksRentedLabel
            // 
            this.BooksRentedLabel.BackColor = System.Drawing.Color.Transparent;
            this.BooksRentedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksRentedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BooksRentedLabel.Location = new System.Drawing.Point(0, 23);
            this.BooksRentedLabel.Margin = new System.Windows.Forms.Padding(3);
            this.BooksRentedLabel.Name = "BooksRentedLabel";
            this.BooksRentedLabel.Size = new System.Drawing.Size(172, 26);
            this.BooksRentedLabel.TabIndex = 1;
            this.BooksRentedLabel.Text = "10000";
            this.BooksRentedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BooksRentedTitleLabel
            // 
            this.BooksRentedTitleLabel.AutoSize = true;
            this.BooksRentedTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.BooksRentedTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksRentedTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BooksRentedTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.BooksRentedTitleLabel.Name = "BooksRentedTitleLabel";
            this.BooksRentedTitleLabel.Size = new System.Drawing.Size(103, 23);
            this.BooksRentedTitleLabel.TabIndex = 0;
            this.BooksRentedTitleLabel.Text = "Book rented";
            // 
            // SalesBarGraph
            // 
            lineAnnotation1.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            lineAnnotation1.LineWidth = 0;
            lineAnnotation1.Name = "LineAnnotation1";
            this.SalesBarGraph.Annotations.Add(lineAnnotation1);
            this.SalesBarGraph.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SalesBarGraph.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.SalesBarGraph.ChartAreas.Add(chartArea1);
            this.DashBoardTableLayoutPanel.SetColumnSpan(this.SalesBarGraph, 5);
            this.SalesBarGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.Name = " ";
            this.SalesBarGraph.Legends.Add(legend1);
            this.SalesBarGraph.Location = new System.Drawing.Point(3, 131);
            this.SalesBarGraph.Name = "SalesBarGraph";
            this.SalesBarGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.SalesBarGraph.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Teal};
            this.DashBoardTableLayoutPanel.SetRowSpan(this.SalesBarGraph, 3);
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Teal;
            series1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            series1.IsValueShownAsLabel = true;
            series1.Legend = " ";
            series1.LegendText = "Revenue/Day";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.SalesBarGraph.Series.Add(series1);
            this.SalesBarGraph.Size = new System.Drawing.Size(774, 251);
            this.SalesBarGraph.TabIndex = 71;
            this.SalesBarGraph.Text = "Revenue Chart";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Revenue ($)";
            this.SalesBarGraph.Titles.Add(title1);
            // 
            // BooksPieChart
            // 
            this.BooksPieChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BooksPieChart.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.BooksPieChart.ChartAreas.Add(chartArea2);
            this.DashBoardTableLayoutPanel.SetColumnSpan(this.BooksPieChart, 2);
            this.BooksPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.WhiteSmoke;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend2.TitleFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BooksPieChart.Legends.Add(legend2);
            this.BooksPieChart.Location = new System.Drawing.Point(783, 131);
            this.BooksPieChart.Name = "BooksPieChart";
            this.BooksPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.DashBoardTableLayoutPanel.SetRowSpan(this.BooksPieChart, 6);
            series2.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            series2.BorderColor = System.Drawing.Color.WhiteSmoke;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.BooksPieChart.Series.Add(series2);
            this.BooksPieChart.Size = new System.Drawing.Size(358, 440);
            this.BooksPieChart.TabIndex = 72;
            this.BooksPieChart.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top 5 Books";
            this.BooksPieChart.Titles.Add(title2);
            // 
            // RentedNowPanel
            // 
            this.RentedNowPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RentedNowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RentedNowPanel.Controls.Add(this.RentedNowLabel);
            this.RentedNowPanel.Controls.Add(this.RentedNowTitleLabel);
            this.RentedNowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RentedNowPanel.Location = new System.Drawing.Point(963, 66);
            this.RentedNowPanel.Name = "RentedNowPanel";
            this.RentedNowPanel.Size = new System.Drawing.Size(178, 59);
            this.RentedNowPanel.TabIndex = 73;
            // 
            // RentedNowLabel
            // 
            this.RentedNowLabel.BackColor = System.Drawing.Color.Transparent;
            this.RentedNowLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentedNowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentedNowLabel.Location = new System.Drawing.Point(0, 23);
            this.RentedNowLabel.Margin = new System.Windows.Forms.Padding(3);
            this.RentedNowLabel.Name = "RentedNowLabel";
            this.RentedNowLabel.Size = new System.Drawing.Size(176, 26);
            this.RentedNowLabel.TabIndex = 1;
            this.RentedNowLabel.Text = "10000";
            this.RentedNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RentedNowTitleLabel
            // 
            this.RentedNowTitleLabel.AutoSize = true;
            this.RentedNowTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.RentedNowTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentedNowTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentedNowTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.RentedNowTitleLabel.Name = "RentedNowTitleLabel";
            this.RentedNowTitleLabel.Size = new System.Drawing.Size(104, 23);
            this.RentedNowTitleLabel.TabIndex = 0;
            this.RentedNowTitleLabel.Text = "Rented Now";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardTableLayoutPanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(63, 541);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(348, 33);
            this.LoadingLabel.TabIndex = 78;
            this.LoadingLabel.Text = "Loading info, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // CountersFlowLayout
            // 
            this.CountersFlowLayout.AutoScroll = true;
            this.DashBoardTableLayoutPanel.SetColumnSpan(this.CountersFlowLayout, 4);
            this.CountersFlowLayout.Controls.Add(this.FirstEmployeePanel);
            this.CountersFlowLayout.Controls.Add(this.SecondEmployePanel);
            this.CountersFlowLayout.Controls.Add(this.ThridEmployeePanel);
            this.CountersFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountersFlowLayout.Location = new System.Drawing.Point(63, 419);
            this.CountersFlowLayout.Name = "CountersFlowLayout";
            this.CountersFlowLayout.Size = new System.Drawing.Size(714, 106);
            this.CountersFlowLayout.TabIndex = 79;
            // 
            // FirstEmployeePanel
            // 
            this.FirstEmployeePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstEmployeePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FirstEmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstEmployeePanel.Controls.Add(this.FirstEmployeeNameLabel);
            this.FirstEmployeePanel.Controls.Add(this.FirstEmployeeIdLabel);
            this.FirstEmployeePanel.Controls.Add(this.FirstEmployeeIdTitleLabel);
            this.FirstEmployeePanel.Controls.Add(this.FirstEmployeeRankingLabel);
            this.FirstEmployeePanel.Location = new System.Drawing.Point(3, 3);
            this.FirstEmployeePanel.Name = "FirstEmployeePanel";
            this.FirstEmployeePanel.Size = new System.Drawing.Size(200, 86);
            this.FirstEmployeePanel.TabIndex = 63;
            // 
            // FirstEmployeeNameLabel
            // 
            this.FirstEmployeeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstEmployeeNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstEmployeeNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstEmployeeNameLabel.Location = new System.Drawing.Point(0, 28);
            this.FirstEmployeeNameLabel.Name = "FirstEmployeeNameLabel";
            this.FirstEmployeeNameLabel.Size = new System.Drawing.Size(198, 35);
            this.FirstEmployeeNameLabel.TabIndex = 8;
            this.FirstEmployeeNameLabel.Text = "None";
            this.FirstEmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstEmployeeIdLabel
            // 
            this.FirstEmployeeIdLabel.AutoSize = true;
            this.FirstEmployeeIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstEmployeeIdLabel.Location = new System.Drawing.Point(72, 61);
            this.FirstEmployeeIdLabel.Name = "FirstEmployeeIdLabel";
            this.FirstEmployeeIdLabel.Size = new System.Drawing.Size(0, 23);
            this.FirstEmployeeIdLabel.TabIndex = 6;
            // 
            // FirstEmployeeIdTitleLabel
            // 
            this.FirstEmployeeIdTitleLabel.AutoSize = true;
            this.FirstEmployeeIdTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstEmployeeIdTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstEmployeeIdTitleLabel.Location = new System.Drawing.Point(30, 61);
            this.FirstEmployeeIdTitleLabel.Name = "FirstEmployeeIdTitleLabel";
            this.FirstEmployeeIdTitleLabel.Size = new System.Drawing.Size(36, 23);
            this.FirstEmployeeIdTitleLabel.TabIndex = 5;
            this.FirstEmployeeIdTitleLabel.Text = "ID :";
            // 
            // FirstEmployeeRankingLabel
            // 
            this.FirstEmployeeRankingLabel.AutoSize = true;
            this.FirstEmployeeRankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstEmployeeRankingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstEmployeeRankingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FirstEmployeeRankingLabel.ForeColor = System.Drawing.Color.Teal;
            this.FirstEmployeeRankingLabel.Location = new System.Drawing.Point(0, 0);
            this.FirstEmployeeRankingLabel.Name = "FirstEmployeeRankingLabel";
            this.FirstEmployeeRankingLabel.Size = new System.Drawing.Size(35, 28);
            this.FirstEmployeeRankingLabel.TabIndex = 0;
            this.FirstEmployeeRankingLabel.Text = "1st";
            // 
            // SecondEmployePanel
            // 
            this.SecondEmployePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SecondEmployePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondEmployePanel.Controls.Add(this.SecondEmployeeNameLabel);
            this.SecondEmployePanel.Controls.Add(this.SecondEmployeeIdLabel);
            this.SecondEmployePanel.Controls.Add(this.SecondEmployeeIdTitleLabel);
            this.SecondEmployePanel.Controls.Add(this.SecondEmployeeRankingLabel);
            this.SecondEmployePanel.Location = new System.Drawing.Point(209, 3);
            this.SecondEmployePanel.Name = "SecondEmployePanel";
            this.SecondEmployePanel.Size = new System.Drawing.Size(200, 86);
            this.SecondEmployePanel.TabIndex = 61;
            // 
            // SecondEmployeeNameLabel
            // 
            this.SecondEmployeeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondEmployeeNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondEmployeeNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondEmployeeNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SecondEmployeeNameLabel.Location = new System.Drawing.Point(0, 28);
            this.SecondEmployeeNameLabel.Name = "SecondEmployeeNameLabel";
            this.SecondEmployeeNameLabel.Size = new System.Drawing.Size(198, 35);
            this.SecondEmployeeNameLabel.TabIndex = 9;
            this.SecondEmployeeNameLabel.Text = "None";
            this.SecondEmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondEmployeeIdLabel
            // 
            this.SecondEmployeeIdLabel.AutoSize = true;
            this.SecondEmployeeIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondEmployeeIdLabel.Location = new System.Drawing.Point(72, 61);
            this.SecondEmployeeIdLabel.Name = "SecondEmployeeIdLabel";
            this.SecondEmployeeIdLabel.Size = new System.Drawing.Size(0, 23);
            this.SecondEmployeeIdLabel.TabIndex = 4;
            // 
            // SecondEmployeeIdTitleLabel
            // 
            this.SecondEmployeeIdTitleLabel.AutoSize = true;
            this.SecondEmployeeIdTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondEmployeeIdTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondEmployeeIdTitleLabel.Location = new System.Drawing.Point(30, 61);
            this.SecondEmployeeIdTitleLabel.Name = "SecondEmployeeIdTitleLabel";
            this.SecondEmployeeIdTitleLabel.Size = new System.Drawing.Size(36, 23);
            this.SecondEmployeeIdTitleLabel.TabIndex = 3;
            this.SecondEmployeeIdTitleLabel.Text = "ID :";
            this.SecondEmployeeIdTitleLabel.Click += new System.EventHandler(this.SecondEmployeeIdTitleLabel_Click);
            // 
            // SecondEmployeeRankingLabel
            // 
            this.SecondEmployeeRankingLabel.AutoSize = true;
            this.SecondEmployeeRankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondEmployeeRankingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondEmployeeRankingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SecondEmployeeRankingLabel.ForeColor = System.Drawing.Color.Teal;
            this.SecondEmployeeRankingLabel.Location = new System.Drawing.Point(0, 0);
            this.SecondEmployeeRankingLabel.Name = "SecondEmployeeRankingLabel";
            this.SecondEmployeeRankingLabel.Size = new System.Drawing.Size(45, 28);
            this.SecondEmployeeRankingLabel.TabIndex = 0;
            this.SecondEmployeeRankingLabel.Text = "2nd";
            // 
            // ThridEmployeePanel
            // 
            this.ThridEmployeePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ThridEmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThridEmployeePanel.Controls.Add(this.ThirdEmployeeNameLabel);
            this.ThridEmployeePanel.Controls.Add(this.ThirdEmployeeIdLabel);
            this.ThridEmployeePanel.Controls.Add(this.ThirdEmployeeIdTitleLabel);
            this.ThridEmployeePanel.Controls.Add(this.ThirdEmployeeRankingLabel);
            this.ThridEmployeePanel.Location = new System.Drawing.Point(415, 3);
            this.ThridEmployeePanel.Name = "ThridEmployeePanel";
            this.ThridEmployeePanel.Size = new System.Drawing.Size(200, 86);
            this.ThridEmployeePanel.TabIndex = 64;
            // 
            // ThirdEmployeeNameLabel
            // 
            this.ThirdEmployeeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdEmployeeNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThirdEmployeeNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdEmployeeNameLabel.Location = new System.Drawing.Point(0, 28);
            this.ThirdEmployeeNameLabel.Name = "ThirdEmployeeNameLabel";
            this.ThirdEmployeeNameLabel.Size = new System.Drawing.Size(198, 35);
            this.ThirdEmployeeNameLabel.TabIndex = 10;
            this.ThirdEmployeeNameLabel.Text = "None";
            this.ThirdEmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThirdEmployeeIdLabel
            // 
            this.ThirdEmployeeIdLabel.AutoSize = true;
            this.ThirdEmployeeIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdEmployeeIdLabel.Location = new System.Drawing.Point(72, 61);
            this.ThirdEmployeeIdLabel.Name = "ThirdEmployeeIdLabel";
            this.ThirdEmployeeIdLabel.Size = new System.Drawing.Size(0, 23);
            this.ThirdEmployeeIdLabel.TabIndex = 4;
            // 
            // ThirdEmployeeIdTitleLabel
            // 
            this.ThirdEmployeeIdTitleLabel.AutoSize = true;
            this.ThirdEmployeeIdTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdEmployeeIdTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThirdEmployeeIdTitleLabel.Location = new System.Drawing.Point(30, 61);
            this.ThirdEmployeeIdTitleLabel.Name = "ThirdEmployeeIdTitleLabel";
            this.ThirdEmployeeIdTitleLabel.Size = new System.Drawing.Size(36, 23);
            this.ThirdEmployeeIdTitleLabel.TabIndex = 3;
            this.ThirdEmployeeIdTitleLabel.Text = "ID :";
            // 
            // ThirdEmployeeRankingLabel
            // 
            this.ThirdEmployeeRankingLabel.AutoSize = true;
            this.ThirdEmployeeRankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThirdEmployeeRankingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThirdEmployeeRankingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ThirdEmployeeRankingLabel.ForeColor = System.Drawing.Color.Teal;
            this.ThirdEmployeeRankingLabel.Location = new System.Drawing.Point(0, 0);
            this.ThirdEmployeeRankingLabel.Name = "ThirdEmployeeRankingLabel";
            this.ThirdEmployeeRankingLabel.Size = new System.Drawing.Size(41, 28);
            this.ThirdEmployeeRankingLabel.TabIndex = 0;
            this.ThirdEmployeeRankingLabel.Text = "3rd";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 639);
            this.Controls.Add(this.DashBoardTableLayoutPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "DashboardForm";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.DashBoardTableLayoutPanel.ResumeLayout(false);
            this.DashBoardTableLayoutPanel.PerformLayout();
            this.TotalSalesPanel.ResumeLayout(false);
            this.TotalSalesPanel.PerformLayout();
            this.TotalRevenuePanel.ResumeLayout(false);
            this.BooksSoldPanel.ResumeLayout(false);
            this.BooksSoldPanel.PerformLayout();
            this.BooksRentedPanel.ResumeLayout(false);
            this.BooksRentedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBarGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPieChart)).EndInit();
            this.RentedNowPanel.ResumeLayout(false);
            this.RentedNowPanel.PerformLayout();
            this.CountersFlowLayout.ResumeLayout(false);
            this.FirstEmployeePanel.ResumeLayout(false);
            this.FirstEmployeePanel.PerformLayout();
            this.SecondEmployePanel.ResumeLayout(false);
            this.SecondEmployePanel.PerformLayout();
            this.ThridEmployeePanel.ResumeLayout(false);
            this.ThridEmployeePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SplitterPanel;
        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private TableLayoutPanel DashBoardTableLayoutPanel;
        private Label TopEmployeesLabel;
        private Panel TotalSalesPanel;
        private Label TotalSalesLabel;
        private Label TotalSalesTitleLabel;
        private Button WeekButton;
        private Button TodayButton;
        private Label DashboardTitleLabel;
        private Button AllTimeButton;
        private Button MonthButton;
        private Panel TotalRevenuePanel;
        private Label TotalRevenueLabel;
        private Label TotalRevenueTitleLabel;
        private Panel BooksSoldPanel;
        private Label BooksSoldLabel;
        private Label BooksSoldTitleLabel;
        private Panel BooksRentedPanel;
        private Label BooksRentedLabel;
        private Label BooksRentedTitleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesBarGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart BooksPieChart;
        private Panel RentedNowPanel;
        private Label RentedNowLabel;
        private Label RentedNowTitleLabel;
        private Label LoadingLabel;
        private FlowLayoutPanel CountersFlowLayout;
        private Panel FirstEmployeePanel;
        private Label FirstEmployeeNameLabel;
        private Label FirstEmployeeIdLabel;
        private Label FirstEmployeeIdTitleLabel;
        private Label FirstEmployeeRankingLabel;
        private Panel SecondEmployePanel;
        private Label SecondEmployeeNameLabel;
        private Label SecondEmployeeIdLabel;
        private Label SecondEmployeeIdTitleLabel;
        private Label SecondEmployeeRankingLabel;
        private Panel ThridEmployeePanel;
        private Label ThirdEmployeeNameLabel;
        private Label ThirdEmployeeIdLabel;
        private Label ThirdEmployeeIdTitleLabel;
        private Label ThirdEmployeeRankingLabel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}