namespace LibraryUI.MainUIForms.EmployeeChildForms.ChildForms;

partial class ViewEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewEmployeeLayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.IdOrFirstNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LastNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.searchComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.GetEmployeesButton = new System.Windows.Forms.Button();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.ViewSalesButton = new System.Windows.Forms.Button();
            this.ViewEmployeesDGV = new System.Windows.Forms.DataGridView();
            this.employeeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewEmployeeLayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewEmployeesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewEmployeeLayoutpanel
            // 
            this.ViewEmployeeLayoutpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewEmployeeLayoutpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewEmployeeLayoutpanel.ColumnCount = 5;
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.004076F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.98417F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.15628F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.91395F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingBar, 0, 4);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.IdOrFirstNameText, 1, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LastNameText, 1, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.searchComboBox, 2, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.GetEmployeesButton, 2, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingLabel, 1, 4);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewEmployeeTitleLabel, 0, 0);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewSalesButton, 3, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewEmployeesDGV, 0, 3);
            this.ViewEmployeeLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEmployeeLayoutpanel.ForeColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeeLayoutpanel.Name = "ViewEmployeeLayoutpanel";
            this.ViewEmployeeLayoutpanel.RowCount = 5;
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.1677F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.40373F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95652F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.32919F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.987577F));
            this.ViewEmployeeLayoutpanel.Size = new System.Drawing.Size(1041, 644);
            this.ViewEmployeeLayoutpanel.TabIndex = 12;
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
            this.LoadingBar.Location = new System.Drawing.Point(13, 607);
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
            this.LoadingBar.TabIndex = 73;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // IdOrFirstNameText
            // 
            this.IdOrFirstNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdOrFirstNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IdOrFirstNameText.BorderColor = System.Drawing.Color.Teal;
            this.IdOrFirstNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.IdOrFirstNameText.BorderSize = 2;
            this.IdOrFirstNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdOrFirstNameText.ForeColor = System.Drawing.Color.Black;
            this.IdOrFirstNameText.Location = new System.Drawing.Point(406, 120);
            this.IdOrFirstNameText.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.IdOrFirstNameText.MultiLine = false;
            this.IdOrFirstNameText.Name = "IdOrFirstNameText";
            this.IdOrFirstNameText.Padding = new System.Windows.Forms.Padding(7);
            this.IdOrFirstNameText.PasswordChar = false;
            this.IdOrFirstNameText.PlaceHolder = "Id:";
            this.IdOrFirstNameText.Size = new System.Drawing.Size(200, 43);
            this.IdOrFirstNameText.TabIndex = 10;
            this.IdOrFirstNameText.Texts = "";
            this.IdOrFirstNameText.Underlined = true;
            this.IdOrFirstNameText.Visible = false;
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameText.BorderColor = System.Drawing.Color.Teal;
            this.LastNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.LastNameText.BorderSize = 2;
            this.LastNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameText.ForeColor = System.Drawing.Color.Black;
            this.LastNameText.Location = new System.Drawing.Point(406, 187);
            this.LastNameText.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.LastNameText.MultiLine = false;
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Padding = new System.Windows.Forms.Padding(7);
            this.LastNameText.PasswordChar = false;
            this.LastNameText.PlaceHolder = "last name:";
            this.LastNameText.Size = new System.Drawing.Size(200, 43);
            this.LastNameText.TabIndex = 15;
            this.LastNameText.Texts = "";
            this.LastNameText.Underlined = true;
            this.LastNameText.Visible = false;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchComboBox.BackColor = System.Drawing.Color.Teal;
            this.searchComboBox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.searchComboBox.BorderSize = 1;
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.searchComboBox.Items.AddRange(new object[] {
            "All",
            "Id",
            "Name"});
            this.searchComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.searchComboBox.ListForeColor = System.Drawing.Color.Black;
            this.searchComboBox.Location = new System.Drawing.Point(619, 131);
            this.searchComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.searchComboBox.Size = new System.Drawing.Size(200, 38);
            this.searchComboBox.TabIndex = 1;
            this.searchComboBox.Texts = "All";
            this.searchComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // GetEmployeesButton
            // 
            this.GetEmployeesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GetEmployeesButton.BackColor = System.Drawing.Color.Teal;
            this.GetEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetEmployeesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetEmployeesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GetEmployeesButton.Location = new System.Drawing.Point(619, 203);
            this.GetEmployeesButton.Name = "GetEmployeesButton";
            this.GetEmployeesButton.Size = new System.Drawing.Size(200, 38);
            this.GetEmployeesButton.TabIndex = 5;
            this.GetEmployeesButton.Text = "Get Employees";
            this.GetEmployeesButton.UseVisualStyleBackColor = false;
            this.GetEmployeesButton.Click += new System.EventHandler(this.GetEmployeesButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(53, 607);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(279, 37);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading employees, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadingLabel.Visible = false;
            // 
            // ViewEmployeeTitleLabel
            // 
            this.ViewEmployeeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewEmployeeTitleLabel, 2);
            this.ViewEmployeeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ViewEmployeeTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ViewEmployeeTitleLabel.Name = "ViewEmployeeTitleLabel";
            this.ViewEmployeeTitleLabel.Size = new System.Drawing.Size(405, 115);
            this.ViewEmployeeTitleLabel.TabIndex = 56;
            this.ViewEmployeeTitleLabel.Text = "View Employees";
            this.ViewEmployeeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSalesButton
            // 
            this.ViewSalesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ViewSalesButton.BackColor = System.Drawing.Color.Teal;
            this.ViewSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSalesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewSalesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewSalesButton.Location = new System.Drawing.Point(843, 203);
            this.ViewSalesButton.Name = "ViewSalesButton";
            this.ViewSalesButton.Size = new System.Drawing.Size(165, 38);
            this.ViewSalesButton.TabIndex = 57;
            this.ViewSalesButton.Text = "View Sales";
            this.ViewSalesButton.UseVisualStyleBackColor = false;
            this.ViewSalesButton.Click += new System.EventHandler(this.ViewSalesButton_Click);
            // 
            // ViewEmployeesDGV
            // 
            this.ViewEmployeesDGV.AllowUserToDeleteRows = false;
            this.ViewEmployeesDGV.AutoGenerateColumns = false;
            this.ViewEmployeesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewEmployeesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewEmployeesDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ViewEmployeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewEmployeesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewEmployeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewEmployeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewEmployeesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.supervisorIdDataGridViewTextBoxColumn});
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewEmployeesDGV, 5);
            this.ViewEmployeesDGV.DataSource = this.employeeDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewEmployeesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewEmployeesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEmployeesDGV.EnableHeadersVisualStyles = false;
            this.ViewEmployeesDGV.GridColor = System.Drawing.Color.Teal;
            this.ViewEmployeesDGV.Location = new System.Drawing.Point(3, 264);
            this.ViewEmployeesDGV.Name = "ViewEmployeesDGV";
            this.ViewEmployeesDGV.ReadOnly = true;
            this.ViewEmployeesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewEmployeesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewEmployeesDGV.RowHeadersWidth = 51;
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ViewEmployeesDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewEmployeesDGV.RowTemplate.Height = 30;
            this.ViewEmployeesDGV.RowTemplate.ReadOnly = true;
            this.ViewEmployeesDGV.Size = new System.Drawing.Size(1035, 331);
            this.ViewEmployeesDGV.TabIndex = 0;
            // 
            // employeeDTOBindingSource
            // 
            this.employeeDTOBindingSource.DataSource = typeof(ClassLibrary.Models.Employee.DTO_s.EmployeeDTO);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 64;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 141;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 138;
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "Branch_Id";
            this.branchIdDataGridViewTextBoxColumn.HeaderText = "Branch Id";
            this.branchIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIdDataGridViewTextBoxColumn.Width = 128;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 83;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 109;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 177;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 115;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supervisorIdDataGridViewTextBoxColumn
            // 
            this.supervisorIdDataGridViewTextBoxColumn.DataPropertyName = "Supervisor_Id";
            this.supervisorIdDataGridViewTextBoxColumn.HeaderText = "Supervisor Id";
            this.supervisorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supervisorIdDataGridViewTextBoxColumn.Name = "supervisorIdDataGridViewTextBoxColumn";
            this.supervisorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.supervisorIdDataGridViewTextBoxColumn.Width = 160;
            // 
            // ViewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 644);
            this.Controls.Add(this.ViewEmployeeLayoutpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewEmployeeForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ViewEmployeeForm_Load);
            this.ResizeEnd += new System.EventHandler(this.ViewEmployeeForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.ViewEmployeeForm_ResizeEnd);
            this.ViewEmployeeLayoutpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewEmployeesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel ViewEmployeeLayoutpanel;
    private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox LastNameText;
    private DataGridView ViewEmployeesDGV;
    private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox IdOrFirstNameText;
    private Label LoadingLabel;
    private AdditionalControls.CustomComboBox.CustomComboBox searchComboBox;
    private Button GetEmployeesButton;
    private Label ViewEmployeeTitleLabel;
    private Button ViewSalesButton;
    private CircularProgressBar.CircularProgressBar LoadingBar;
    private BindingSource employeeDTOBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn supervisorIdDataGridViewTextBoxColumn;
}