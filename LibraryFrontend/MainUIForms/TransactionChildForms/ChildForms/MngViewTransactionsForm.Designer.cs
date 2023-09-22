namespace LibraryUI.MainUIForms.TransactionChildForms.ChildForms
{
    partial class MngViewTransactionsForm
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
            this.ViewTransactionsDGV = new System.Windows.Forms.DataGridView();
            this.ViewTransactionsTitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.GetTransactionsButton = new System.Windows.Forms.Button();
            this.SearchComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.SearchText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.ViewEmployeeLayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.transactionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latePenaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTransactionsDGV)).BeginInit();
            this.ViewEmployeeLayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewTransactionsDGV
            // 
            this.ViewTransactionsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewTransactionsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewTransactionsDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ViewTransactionsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewTransactionsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewTransactionsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewTransactionsDGV.ColumnHeadersHeight = 40;
            this.ViewTransactionsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.clientPhoneNumberDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.copiesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.latePenaltyDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewTransactionsDGV, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewTransactionsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewTransactionsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTransactionsDGV.EnableHeadersVisualStyles = false;
            this.ViewTransactionsDGV.GridColor = System.Drawing.Color.Teal;
            this.ViewTransactionsDGV.Location = new System.Drawing.Point(3, 234);
            this.ViewTransactionsDGV.Name = "ViewTransactionsDGV";
            this.ViewTransactionsDGV.ReadOnly = true;
            this.ViewTransactionsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewTransactionsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewTransactionsDGV.RowHeadersWidth = 51;
            this.ViewTransactionsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ViewTransactionsDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewTransactionsDGV.RowTemplate.Height = 30;
            this.ViewTransactionsDGV.RowTemplate.ReadOnly = true;
            this.ViewTransactionsDGV.Size = new System.Drawing.Size(1259, 376);
            this.ViewTransactionsDGV.TabIndex = 57;
            this.ViewTransactionsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewTransactionsDGV_CellContentClick);
            this.ViewTransactionsDGV.Resize += new System.EventHandler(this.ViewTransactionsForm_Resize);
            // 
            // ViewTransactionsTitleLabel
            // 
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewTransactionsTitleLabel, 2);
            this.ViewTransactionsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ViewTransactionsTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ViewTransactionsTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ViewTransactionsTitleLabel.Name = "ViewTransactionsTitleLabel";
            this.ViewTransactionsTitleLabel.Size = new System.Drawing.Size(390, 99);
            this.ViewTransactionsTitleLabel.TabIndex = 56;
            this.ViewTransactionsTitleLabel.Text = "Transactions";
            this.ViewTransactionsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(66, 623);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(493, 37);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading Transactions, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // GetTransactionsButton
            // 
            this.GetTransactionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetTransactionsButton.BackColor = System.Drawing.Color.Teal;
            this.GetTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetTransactionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetTransactionsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GetTransactionsButton.Location = new System.Drawing.Point(886, 177);
            this.GetTransactionsButton.Name = "GetTransactionsButton";
            this.GetTransactionsButton.Size = new System.Drawing.Size(200, 42);
            this.GetTransactionsButton.TabIndex = 5;
            this.GetTransactionsButton.Text = "View Transactions";
            this.GetTransactionsButton.UseVisualStyleBackColor = false;
            this.GetTransactionsButton.Click += new System.EventHandler(this.GetTransactionsButton_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchComboBox.BackColor = System.Drawing.Color.Teal;
            this.SearchComboBox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.BorderSize = 1;
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.Items.AddRange(new object[] {
            "All",
            "Id",
            "Purchase",
            "Rent",
            "Client Phone Nb"});
            this.SearchComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SearchComboBox.Location = new System.Drawing.Point(886, 111);
            this.SearchComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.SearchComboBox.Size = new System.Drawing.Size(200, 42);
            this.SearchComboBox.TabIndex = 1;
            this.SearchComboBox.Texts = "All";
            this.SearchComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SearchComboBox_OnSelectedIndexChanged);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchText.BorderColor = System.Drawing.Color.Teal;
            this.SearchText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.SearchText.BorderSize = 2;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchText.ForeColor = System.Drawing.Color.Black;
            this.SearchText.Location = new System.Drawing.Point(585, 110);
            this.SearchText.MultiLine = false;
            this.SearchText.Name = "SearchText";
            this.SearchText.Padding = new System.Windows.Forms.Padding(7);
            this.SearchText.PasswordChar = false;
            this.SearchText.PlaceHolder = "";
            this.SearchText.Size = new System.Drawing.Size(221, 43);
            this.SearchText.TabIndex = 10;
            this.SearchText.Texts = "";
            this.SearchText.Underlined = true;
            this.SearchText.Visible = false;
            // 
            // ViewEmployeeLayoutpanel
            // 
            this.ViewEmployeeLayoutpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewEmployeeLayoutpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewEmployeeLayoutpanel.ColumnCount = 4;
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.ViewEmployeeLayoutpanel.Controls.Add(this.SearchText, 1, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.SearchComboBox, 2, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.GetTransactionsButton, 2, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingLabel, 1, 4);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewTransactionsTitleLabel, 0, 0);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewTransactionsDGV, 0, 3);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingBar, 0, 4);
            this.ViewEmployeeLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEmployeeLayoutpanel.ForeColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ViewEmployeeLayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeeLayoutpanel.Name = "ViewEmployeeLayoutpanel";
            this.ViewEmployeeLayoutpanel.RowCount = 5;
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.00023F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00016F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00016F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0009F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.998553F));
            this.ViewEmployeeLayoutpanel.Size = new System.Drawing.Size(1265, 660);
            this.ViewEmployeeLayoutpanel.TabIndex = 14;
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
            this.LoadingBar.Location = new System.Drawing.Point(26, 623);
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
            // transactionDTOBindingSource
            // 
            this.transactionDTOBindingSource.DataSource = typeof(ClassLibrary.Models.Transaction.DTOs.TransactionDTO);
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "Transaction_Id";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.transactionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 86;
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "Branch_Id";
            this.branchIdDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIdDataGridViewTextBoxColumn.Width = 102;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Width = 93;
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_Phone_Number";
            this.clientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Client Phone#";
            this.clientPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Name = "clientPhoneNumberDataGridViewTextBoxColumn";
            this.clientPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Width = 163;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Width = 149;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "Transaction_Date";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionDateDataGridViewTextBoxColumn.Width = 84;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 83;
            // 
            // copiesDataGridViewTextBoxColumn
            // 
            this.copiesDataGridViewTextBoxColumn.DataPropertyName = "Copies";
            this.copiesDataGridViewTextBoxColumn.HeaderText = "Copies";
            this.copiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.copiesDataGridViewTextBoxColumn.Name = "copiesDataGridViewTextBoxColumn";
            this.copiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price($)";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 108;
            // 
            // latePenaltyDataGridViewTextBoxColumn
            // 
            this.latePenaltyDataGridViewTextBoxColumn.DataPropertyName = "Late_Penalty";
            this.latePenaltyDataGridViewTextBoxColumn.HeaderText = "Penalty($)";
            this.latePenaltyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latePenaltyDataGridViewTextBoxColumn.Name = "latePenaltyDataGridViewTextBoxColumn";
            this.latePenaltyDataGridViewTextBoxColumn.ReadOnly = true;
            this.latePenaltyDataGridViewTextBoxColumn.Width = 129;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total ($)";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 112;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnDateDataGridViewTextBoxColumn.Width = 146;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 95;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::LibraryUI.Properties.Resources.pencil;
            this.Edit.MinimumWidth = 10;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 27;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::LibraryUI.Properties.Resources.delete;
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 27;
            // 
            // MngViewTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 660);
            this.Controls.Add(this.ViewEmployeeLayoutpanel);
            this.Name = "MngViewTransactionsForm";
            this.Text = "ViewTransactionsForm";
            this.Load += new System.EventHandler(this.ViewTransactionsForm_Load);
            this.Resize += new System.EventHandler(this.ViewTransactionsForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ViewTransactionsDGV)).EndInit();
            this.ViewEmployeeLayoutpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView ViewTransactionsDGV;
        private TableLayoutPanel ViewEmployeeLayoutpanel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox SearchText;
        private AdditionalControls.CustomComboBox.CustomComboBox SearchComboBox;
        private Button GetTransactionsButton;
        private Label LoadingLabel;
        private Label ViewTransactionsTitleLabel;
        private BindingSource transactionDTOBindingSource;
        private CircularProgressBar.CircularProgressBar LoadingBar;
        private DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copiesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn latePenaltyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}