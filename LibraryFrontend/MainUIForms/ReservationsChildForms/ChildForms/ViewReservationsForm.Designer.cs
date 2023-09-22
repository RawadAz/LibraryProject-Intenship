namespace LibraryUI.MainUIForms.ReservationsChildForms.ChildForms
{
    partial class ViewReservationsForm
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
            this.ViewReservationsTableLayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.GetReservationsButton = new System.Windows.Forms.Button();
            this.ViewReservationsTitleLabel = new System.Windows.Forms.Label();
            this.ViewReservationsDGV = new System.Windows.Forms.DataGridView();
            this.reservationDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventOrPhoneNumberComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.EventOrPhoneNumberLabel = new System.Windows.Forms.Label();
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbOfTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.ViewReservationsTableLayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReservationsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewReservationsTableLayoutpanel
            // 
            this.ViewReservationsTableLayoutpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewReservationsTableLayoutpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewReservationsTableLayoutpanel.ColumnCount = 5;
            this.ViewReservationsTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ViewReservationsTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.70454F));
            this.ViewReservationsTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.06818F));
            this.ViewReservationsTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ViewReservationsTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.SearchComboBox, 3, 1);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.GetReservationsButton, 3, 2);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.ViewReservationsTitleLabel, 0, 0);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.ViewReservationsDGV, 0, 3);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.EventOrPhoneNumberComboBox, 2, 1);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.BranchNameComboBox, 2, 2);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.LoadingLabel, 1, 4);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.EventOrPhoneNumberLabel, 1, 1);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.BranchNameLabel, 1, 2);
            this.ViewReservationsTableLayoutpanel.Controls.Add(this.LoadingBar, 0, 4);
            this.ViewReservationsTableLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewReservationsTableLayoutpanel.ForeColor = System.Drawing.Color.Transparent;
            this.ViewReservationsTableLayoutpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ViewReservationsTableLayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.ViewReservationsTableLayoutpanel.Name = "ViewReservationsTableLayoutpanel";
            this.ViewReservationsTableLayoutpanel.RowCount = 5;
            this.ViewReservationsTableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.00023F));
            this.ViewReservationsTableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00016F));
            this.ViewReservationsTableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00016F));
            this.ViewReservationsTableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0009F));
            this.ViewReservationsTableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.998553F));
            this.ViewReservationsTableLayoutpanel.Size = new System.Drawing.Size(1011, 636);
            this.ViewReservationsTableLayoutpanel.TabIndex = 15;
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
            "Event",
            "Client Phone Nb"});
            this.SearchComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SearchComboBox.Location = new System.Drawing.Point(695, 105);
            this.SearchComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.SearchComboBox.Size = new System.Drawing.Size(200, 42);
            this.SearchComboBox.TabIndex = 1;
            this.SearchComboBox.Texts = "";
            this.SearchComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SearchComboBox_OnSelectedIndexChanged);
            // 
            // GetReservationsButton
            // 
            this.GetReservationsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetReservationsButton.BackColor = System.Drawing.Color.Teal;
            this.GetReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetReservationsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetReservationsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GetReservationsButton.Location = new System.Drawing.Point(695, 168);
            this.GetReservationsButton.Name = "GetReservationsButton";
            this.GetReservationsButton.Size = new System.Drawing.Size(200, 42);
            this.GetReservationsButton.TabIndex = 5;
            this.GetReservationsButton.Text = "View Reservations";
            this.GetReservationsButton.UseVisualStyleBackColor = false;
            this.GetReservationsButton.Click += new System.EventHandler(this.GetReservationsButton_Click);
            // 
            // ViewReservationsTitleLabel
            // 
            this.ViewReservationsTableLayoutpanel.SetColumnSpan(this.ViewReservationsTitleLabel, 3);
            this.ViewReservationsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ViewReservationsTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ViewReservationsTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ViewReservationsTitleLabel.Name = "ViewReservationsTitleLabel";
            this.ViewReservationsTitleLabel.Size = new System.Drawing.Size(390, 95);
            this.ViewReservationsTitleLabel.TabIndex = 56;
            this.ViewReservationsTitleLabel.Text = "Current Reservations";
            this.ViewReservationsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewReservationsDGV
            // 
            this.ViewReservationsDGV.AutoGenerateColumns = false;
            this.ViewReservationsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewReservationsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewReservationsDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ViewReservationsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewReservationsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewReservationsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewReservationsDGV.ColumnHeadersHeight = 40;
            this.ViewReservationsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIdDataGridViewTextBoxColumn,
            this.eventDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientPhoneNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.nbOfTicketsDataGridViewTextBoxColumn,
            this.totalFeeDataGridViewTextBoxColumn,
            this.EditButton,
            this.DeleteButton});
            this.ViewReservationsTableLayoutpanel.SetColumnSpan(this.ViewReservationsDGV, 5);
            this.ViewReservationsDGV.DataSource = this.reservationDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewReservationsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewReservationsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewReservationsDGV.EnableHeadersVisualStyles = false;
            this.ViewReservationsDGV.GridColor = System.Drawing.Color.Teal;
            this.ViewReservationsDGV.Location = new System.Drawing.Point(3, 224);
            this.ViewReservationsDGV.Name = "ViewReservationsDGV";
            this.ViewReservationsDGV.ReadOnly = true;
            this.ViewReservationsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewReservationsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewReservationsDGV.RowHeadersWidth = 51;
            this.ViewReservationsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ViewReservationsDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewReservationsDGV.RowTemplate.Height = 30;
            this.ViewReservationsDGV.RowTemplate.ReadOnly = true;
            this.ViewReservationsDGV.Size = new System.Drawing.Size(1005, 362);
            this.ViewReservationsDGV.TabIndex = 57;
            this.ViewReservationsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewReservationsDGV_CellContentClick);
            this.ViewReservationsDGV.Resize += new System.EventHandler(this.ViewReservationsDGV_Resize);
            // 
            // reservationDTOBindingSource
            // 
            this.reservationDTOBindingSource.DataSource = typeof(ClassLibrary.Models.Reservation.DTO.ReservationDTO);
            // 
            // EventOrPhoneNumberComboBox
            // 
            this.EventOrPhoneNumberComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EventOrPhoneNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EventOrPhoneNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EventOrPhoneNumberComboBox.BackColor = System.Drawing.Color.Teal;
            this.EventOrPhoneNumberComboBox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EventOrPhoneNumberComboBox.BorderSize = 1;
            this.EventOrPhoneNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventOrPhoneNumberComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventOrPhoneNumberComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EventOrPhoneNumberComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.EventOrPhoneNumberComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.EventOrPhoneNumberComboBox.ListForeColor = System.Drawing.Color.Black;
            this.EventOrPhoneNumberComboBox.Location = new System.Drawing.Point(424, 105);
            this.EventOrPhoneNumberComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.EventOrPhoneNumberComboBox.Name = "EventOrPhoneNumberComboBox";
            this.EventOrPhoneNumberComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.EventOrPhoneNumberComboBox.Size = new System.Drawing.Size(200, 42);
            this.EventOrPhoneNumberComboBox.TabIndex = 58;
            this.EventOrPhoneNumberComboBox.Texts = "";
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BranchNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BranchNameComboBox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.BorderSize = 1;
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(424, 168);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 42);
            this.BranchNameComboBox.TabIndex = 59;
            this.BranchNameComboBox.Texts = "";
            this.BranchNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BranchNameComboBox_OnSelectedIndexChanged);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(53, 599);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(365, 37);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading Transactions, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // EventOrPhoneNumberLabel
            // 
            this.EventOrPhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EventOrPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventOrPhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.EventOrPhoneNumberLabel.Location = new System.Drawing.Point(261, 114);
            this.EventOrPhoneNumberLabel.Name = "EventOrPhoneNumberLabel";
            this.EventOrPhoneNumberLabel.Size = new System.Drawing.Size(157, 25);
            this.EventOrPhoneNumberLabel.TabIndex = 60;
            this.EventOrPhoneNumberLabel.Text = "Event Name :";
            this.EventOrPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(261, 177);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(157, 25);
            this.BranchNameLabel.TabIndex = 61;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.LoadingBar.Location = new System.Drawing.Point(13, 599);
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
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "Event_Id";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "Event Id";
            this.eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventDataGridViewTextBoxColumn
            // 
            this.eventDataGridViewTextBoxColumn.DataPropertyName = "Event";
            this.eventDataGridViewTextBoxColumn.HeaderText = "Event";
            this.eventDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventDataGridViewTextBoxColumn.Name = "eventDataGridViewTextBoxColumn";
            this.eventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_Phone_Number";
            this.clientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Client Phone#";
            this.clientPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Name = "clientPhoneNumberDataGridViewTextBoxColumn";
            this.clientPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Width = 163;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee($)";
            this.feeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            this.feeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbOfTicketsDataGridViewTextBoxColumn
            // 
            this.nbOfTicketsDataGridViewTextBoxColumn.DataPropertyName = "Nb_Of_Tickets";
            this.nbOfTicketsDataGridViewTextBoxColumn.HeaderText = "Tickets#";
            this.nbOfTicketsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbOfTicketsDataGridViewTextBoxColumn.Name = "nbOfTicketsDataGridViewTextBoxColumn";
            this.nbOfTicketsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalFeeDataGridViewTextBoxColumn
            // 
            this.totalFeeDataGridViewTextBoxColumn.DataPropertyName = "Total_Fee";
            this.totalFeeDataGridViewTextBoxColumn.HeaderText = "Total($)";
            this.totalFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalFeeDataGridViewTextBoxColumn.Name = "totalFeeDataGridViewTextBoxColumn";
            this.totalFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditButton.Description = "Edit";
            this.EditButton.HeaderText = "";
            this.EditButton.Image = global::LibraryUI.Properties.Resources.pencil;
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Width = 27;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteButton.Description = "Delete";
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Image = global::LibraryUI.Properties.Resources.delete;
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Width = 27;
            // 
            // ViewReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1011, 636);
            this.Controls.Add(this.ViewReservationsTableLayoutpanel);
            this.Name = "ViewReservationsForm";
            this.Text = "ViewReservationsForm";
            this.Load += new System.EventHandler(this.ViewReservationsForm_Load);
            this.ViewReservationsTableLayoutpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewReservationsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ViewReservationsTableLayoutpanel;
        private AdditionalControls.CustomComboBox.CustomComboBox SearchComboBox;
        private Button GetReservationsButton;
        private Label LoadingLabel;
        private Label ViewReservationsTitleLabel;
        private DataGridView ViewReservationsDGV;
        private AdditionalControls.CustomComboBox.CustomComboBox EventOrPhoneNumberComboBox;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private Label EventOrPhoneNumberLabel;
        private Label BranchNameLabel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
        private BindingSource reservationDTOBindingSource;
        private DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nbOfTicketsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalFeeDataGridViewTextBoxColumn;
        private DataGridViewImageColumn EditButton;
        private DataGridViewImageColumn DeleteButton;
    }
}