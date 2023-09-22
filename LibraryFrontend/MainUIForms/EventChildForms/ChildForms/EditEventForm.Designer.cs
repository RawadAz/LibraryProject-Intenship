namespace LibraryUI.MainUIForms.EventChildForms.ChildForms
{
    partial class EditEventForm
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
            this.FormTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.RentPriceLabel = new System.Windows.Forms.Label();
            this.RentPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.EditEventTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EditEventTitleLabel = new System.Windows.Forms.Label();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.ReccurenceLabel = new System.Windows.Forms.Label();
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.EventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.AvailableSeatsLabel = new System.Windows.Forms.Label();
            this.AvailableSeatsNumeric = new System.Windows.Forms.NumericUpDown();
            this.EditEventButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ReccurenceComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.EventNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteEventRB = new System.Windows.Forms.RadioButton();
            this.EditEventRB = new System.Windows.Forms.RadioButton();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.FeeNumeric = new System.Windows.Forms.NumericUpDown();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.FormTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentPriceNumeric)).BeginInit();
            this.EditEventTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableSeatsNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTablePanel
            // 
            this.FormTablePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTablePanel.ColumnCount = 5;
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.19959F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.03259F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.9776F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.87008F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.299212F));
            this.FormTablePanel.Controls.Add(this.RentPriceLabel, 2, 3);
            this.FormTablePanel.Location = new System.Drawing.Point(0, 0);
            this.FormTablePanel.Name = "FormTablePanel";
            this.FormTablePanel.RowCount = 4;
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.Size = new System.Drawing.Size(200, 100);
            this.FormTablePanel.TabIndex = 0;
            // 
            // RentPriceLabel
            // 
            this.RentPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RentPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentPriceLabel.ForeColor = System.Drawing.Color.Teal;
            this.RentPriceLabel.Location = new System.Drawing.Point(94, 67);
            this.RentPriceLabel.Name = "RentPriceLabel";
            this.RentPriceLabel.Size = new System.Drawing.Size(35, 25);
            this.RentPriceLabel.TabIndex = 61;
            this.RentPriceLabel.Text = "Rent price :";
            this.RentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RentPriceNumeric
            // 
            this.RentPriceNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentPriceNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RentPriceNumeric.DecimalPlaces = 2;
            this.RentPriceNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentPriceNumeric.ForeColor = System.Drawing.Color.Teal;
            this.RentPriceNumeric.Location = new System.Drawing.Point(135, 33);
            this.RentPriceNumeric.Name = "RentPriceNumeric";
            this.RentPriceNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RentPriceNumeric.Size = new System.Drawing.Size(47, 34);
            this.RentPriceNumeric.TabIndex = 69;
            this.RentPriceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditEventTableLayout
            // 
            this.EditEventTableLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditEventTableLayout.ColumnCount = 7;
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.993291F));
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97316F));
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96646F));
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80422F));
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.15739F));
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88112F));
            this.EditEventTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.88811F));
            this.EditEventTableLayout.Controls.Add(this.LoadingBar, 0, 7);
            this.EditEventTableLayout.Controls.Add(this.EditEventTitleLabel, 0, 0);
            this.EditEventTableLayout.Controls.Add(this.EventNameLabel, 1, 1);
            this.EditEventTableLayout.Controls.Add(this.EventDateLabel, 1, 2);
            this.EditEventTableLayout.Controls.Add(this.LoadingLabel, 1, 7);
            this.EditEventTableLayout.Controls.Add(this.BranchNameLabel, 3, 1);
            this.EditEventTableLayout.Controls.Add(this.ReccurenceLabel, 3, 2);
            this.EditEventTableLayout.Controls.Add(this.BranchNameComboBox, 5, 1);
            this.EditEventTableLayout.Controls.Add(this.EventDatePicker, 2, 2);
            this.EditEventTableLayout.Controls.Add(this.DescriptionLabel, 1, 5);
            this.EditEventTableLayout.Controls.Add(this.DescriptionText, 2, 5);
            this.EditEventTableLayout.Controls.Add(this.AvailableSeatsLabel, 1, 3);
            this.EditEventTableLayout.Controls.Add(this.AvailableSeatsNumeric, 2, 3);
            this.EditEventTableLayout.Controls.Add(this.EditEventButton, 5, 5);
            this.EditEventTableLayout.Controls.Add(this.ResetButton, 5, 6);
            this.EditEventTableLayout.Controls.Add(this.ReccurenceComboBox, 5, 2);
            this.EditEventTableLayout.Controls.Add(this.EventNameComboBox, 2, 1);
            this.EditEventTableLayout.Controls.Add(this.panel1, 3, 0);
            this.EditEventTableLayout.Controls.Add(this.FeeLabel, 3, 3);
            this.EditEventTableLayout.Controls.Add(this.FeeNumeric, 5, 3);
            this.EditEventTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditEventTableLayout.Location = new System.Drawing.Point(0, 0);
            this.EditEventTableLayout.Name = "EditEventTableLayout";
            this.EditEventTableLayout.RowCount = 8;
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05833F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04083F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04083F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04083F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.011665F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.19858F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510638F));
            this.EditEventTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.023331F));
            this.EditEventTableLayout.Size = new System.Drawing.Size(1001, 641);
            this.EditEventTableLayout.TabIndex = 1;
            // 
            // EditEventTitleLabel
            // 
            this.EditEventTableLayout.SetColumnSpan(this.EditEventTitleLabel, 3);
            this.EditEventTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.EditEventTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.EditEventTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.EditEventTitleLabel.Name = "EditEventTitleLabel";
            this.EditEventTitleLabel.Size = new System.Drawing.Size(489, 99);
            this.EditEventTitleLabel.TabIndex = 56;
            this.EditEventTitleLabel.Text = "Edit An Event";
            this.EditEventTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EventNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.EventNameLabel.Location = new System.Drawing.Point(87, 160);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(157, 25);
            this.EventNameLabel.TabIndex = 57;
            this.EventNameLabel.Text = "Event Name :";
            this.EventNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EventDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventDateLabel.ForeColor = System.Drawing.Color.Teal;
            this.EventDateLabel.Location = new System.Drawing.Point(87, 250);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(157, 25);
            this.EventDateLabel.TabIndex = 59;
            this.EventDateLabel.Text = "Date :";
            this.EventDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditEventTableLayout.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(52, 608);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(331, 33);
            this.LoadingLabel.TabIndex = 77;
            this.LoadingLabel.Text = "Updating event, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditEventTableLayout.SetColumnSpan(this.BranchNameLabel, 2);
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(517, 160);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(153, 25);
            this.BranchNameLabel.TabIndex = 78;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReccurenceLabel
            // 
            this.ReccurenceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditEventTableLayout.SetColumnSpan(this.ReccurenceLabel, 2);
            this.ReccurenceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReccurenceLabel.ForeColor = System.Drawing.Color.Teal;
            this.ReccurenceLabel.Location = new System.Drawing.Point(517, 250);
            this.ReccurenceLabel.Name = "ReccurenceLabel";
            this.ReccurenceLabel.Size = new System.Drawing.Size(153, 25);
            this.ReccurenceLabel.TabIndex = 80;
            this.ReccurenceLabel.Text = "Reccurence :";
            this.ReccurenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BranchNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BranchNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.BorderSize = 4;
            this.EditEventTableLayout.SetColumnSpan(this.BranchNameComboBox, 2);
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(696, 154);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 38);
            this.BranchNameComboBox.TabIndex = 81;
            this.BranchNameComboBox.Texts = "";
            // 
            // EventDatePicker
            // 
            this.EventDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDatePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.EventDatePicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.EventDatePicker.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.EventDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.EventDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventDatePicker.Location = new System.Drawing.Point(271, 249);
            this.EventDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.EventDatePicker.Name = "EventDatePicker";
            this.EventDatePicker.Size = new System.Drawing.Size(200, 27);
            this.EventDatePicker.TabIndex = 83;
            this.EventDatePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Teal;
            this.DescriptionLabel.Location = new System.Drawing.Point(87, 423);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(157, 73);
            this.DescriptionLabel.TabIndex = 60;
            this.DescriptionLabel.Text = "Description :";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionText.BorderColor = System.Drawing.Color.Teal;
            this.DescriptionText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.DescriptionText.BorderSize = 2;
            this.EditEventTableLayout.SetColumnSpan(this.DescriptionText, 2);
            this.DescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionText.ForeColor = System.Drawing.Color.Black;
            this.DescriptionText.Location = new System.Drawing.Point(253, 429);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(6);
            this.DescriptionText.MultiLine = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionText.PasswordChar = false;
            this.DescriptionText.PlaceHolder = "Description";
            this.DescriptionText.Size = new System.Drawing.Size(353, 98);
            this.DescriptionText.TabIndex = 84;
            this.DescriptionText.Texts = "";
            this.DescriptionText.Underlined = false;
            // 
            // AvailableSeatsLabel
            // 
            this.AvailableSeatsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvailableSeatsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvailableSeatsLabel.ForeColor = System.Drawing.Color.Teal;
            this.AvailableSeatsLabel.Location = new System.Drawing.Point(87, 340);
            this.AvailableSeatsLabel.Name = "AvailableSeatsLabel";
            this.AvailableSeatsLabel.Size = new System.Drawing.Size(157, 25);
            this.AvailableSeatsLabel.TabIndex = 85;
            this.AvailableSeatsLabel.Text = "Available Seats :";
            this.AvailableSeatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AvailableSeatsNumeric
            // 
            this.AvailableSeatsNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvailableSeatsNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvailableSeatsNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailableSeatsNumeric.ForeColor = System.Drawing.Color.Teal;
            this.AvailableSeatsNumeric.Location = new System.Drawing.Point(271, 336);
            this.AvailableSeatsNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AvailableSeatsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AvailableSeatsNumeric.Name = "AvailableSeatsNumeric";
            this.AvailableSeatsNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AvailableSeatsNumeric.Size = new System.Drawing.Size(200, 34);
            this.AvailableSeatsNumeric.TabIndex = 87;
            this.AvailableSeatsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AvailableSeatsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EditEventButton
            // 
            this.EditEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditEventButton.BackColor = System.Drawing.Color.Teal;
            this.EditEventButton.BorderRadius = 25;
            this.EditEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEventButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditEventButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditEventButton.Location = new System.Drawing.Point(696, 478);
            this.EditEventButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(184, 55);
            this.EditEventButton.TabIndex = 88;
            this.EditEventButton.Text = "Update Event";
            this.EditEventButton.UseVisualStyleBackColor = false;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ResetButton.BorderRadius = 25;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(770, 533);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 50);
            this.ResetButton.TabIndex = 89;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // ReccurenceComboBox
            // 
            this.ReccurenceComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReccurenceComboBox.BackColor = System.Drawing.Color.Teal;
            this.ReccurenceComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ReccurenceComboBox.BorderSize = 4;
            this.EditEventTableLayout.SetColumnSpan(this.ReccurenceComboBox, 2);
            this.ReccurenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReccurenceComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReccurenceComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ReccurenceComboBox.Items.AddRange(new object[] {
            "none",
            "daily",
            "weekly",
            "monthly",
            "every 2 months",
            "every 3 months",
            "every 6 months",
            "yearly"});
            this.ReccurenceComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.ReccurenceComboBox.ListForeColor = System.Drawing.Color.Black;
            this.ReccurenceComboBox.Location = new System.Drawing.Point(696, 244);
            this.ReccurenceComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ReccurenceComboBox.Name = "ReccurenceComboBox";
            this.ReccurenceComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReccurenceComboBox.Size = new System.Drawing.Size(200, 38);
            this.ReccurenceComboBox.TabIndex = 90;
            this.ReccurenceComboBox.Texts = "";
            // 
            // EventNameComboBox
            // 
            this.EventNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.EventNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.EventNameComboBox.BorderSize = 4;
            this.EventNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.EventNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.EventNameComboBox.Location = new System.Drawing.Point(271, 154);
            this.EventNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.EventNameComboBox.Name = "EventNameComboBox";
            this.EventNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.EventNameComboBox.Size = new System.Drawing.Size(200, 38);
            this.EventNameComboBox.TabIndex = 91;
            this.EventNameComboBox.Texts = "";
            this.EventNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.EventNameComboBox_OnSelectedIndexChanged);
            // 
            // panel1
            // 
            this.EditEventTableLayout.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.DeleteEventRB);
            this.panel1.Controls.Add(this.EditEventRB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(498, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 122);
            this.panel1.TabIndex = 92;
            // 
            // DeleteEventRB
            // 
            this.DeleteEventRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteEventRB.AutoSize = true;
            this.DeleteEventRB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteEventRB.ForeColor = System.Drawing.Color.Teal;
            this.DeleteEventRB.Location = new System.Drawing.Point(198, 90);
            this.DeleteEventRB.Name = "DeleteEventRB";
            this.DeleteEventRB.Size = new System.Drawing.Size(151, 29);
            this.DeleteEventRB.TabIndex = 3;
            this.DeleteEventRB.Text = "Remove Event";
            this.DeleteEventRB.UseVisualStyleBackColor = true;
            // 
            // EditEventRB
            // 
            this.EditEventRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditEventRB.AutoSize = true;
            this.EditEventRB.Checked = true;
            this.EditEventRB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditEventRB.ForeColor = System.Drawing.Color.Teal;
            this.EditEventRB.Location = new System.Drawing.Point(27, 90);
            this.EditEventRB.Name = "EditEventRB";
            this.EditEventRB.Size = new System.Drawing.Size(145, 29);
            this.EditEventRB.TabIndex = 2;
            this.EditEventRB.TabStop = true;
            this.EditEventRB.Text = "Update Event";
            this.EditEventRB.UseVisualStyleBackColor = true;
            this.EditEventRB.CheckedChanged += new System.EventHandler(this.EditEventRB_CheckedChanged);
            // 
            // FeeLabel
            // 
            this.FeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditEventTableLayout.SetColumnSpan(this.FeeLabel, 2);
            this.FeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeeLabel.ForeColor = System.Drawing.Color.Teal;
            this.FeeLabel.Location = new System.Drawing.Point(517, 340);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(153, 25);
            this.FeeLabel.TabIndex = 93;
            this.FeeLabel.Text = "Reccurence :";
            this.FeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FeeNumeric
            // 
            this.FeeNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FeeNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditEventTableLayout.SetColumnSpan(this.FeeNumeric, 2);
            this.FeeNumeric.DecimalPlaces = 2;
            this.FeeNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeNumeric.ForeColor = System.Drawing.Color.Teal;
            this.FeeNumeric.Location = new System.Drawing.Point(696, 336);
            this.FeeNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.FeeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.FeeNumeric.Name = "FeeNumeric";
            this.FeeNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FeeNumeric.Size = new System.Drawing.Size(200, 34);
            this.FeeNumeric.TabIndex = 94;
            this.FeeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FeeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.LoadingBar.Location = new System.Drawing.Point(12, 604);
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
            this.LoadingBar.TabIndex = 95;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 641);
            this.Controls.Add(this.EditEventTableLayout);
            this.Name = "EditEventForm";
            this.Text = "EditEvents";
            this.Load += new System.EventHandler(this.EditEvents_Load);
            this.FormTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentPriceNumeric)).EndInit();
            this.EditEventTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableSeatsNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTablePanel;
        private Label RentPriceLabel;
        private NumericUpDown RentPriceNumeric;
        private TableLayoutPanel EditEventTableLayout;
        private Label EditEventTitleLabel;
        private Label EventNameLabel;
        private Label EventDateLabel;
        private Label LoadingLabel;
        private Label BranchNameLabel;
        private Label ReccurenceLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private DateTimePicker EventDatePicker;
        private Label DescriptionLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox DescriptionText;
        private Label AvailableSeatsLabel;
        private NumericUpDown AvailableSeatsNumeric;
        private AdditionalControls.Buttons.RoundedButton EditEventButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private AdditionalControls.CustomComboBox.CustomComboBox ReccurenceComboBox;
        private AdditionalControls.CustomComboBox.CustomComboBox EventNameComboBox;
        private Panel panel1;
        private RadioButton DeleteEventRB;
        private RadioButton EditEventRB;
        private Label FeeLabel;
        private NumericUpDown FeeNumeric;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}