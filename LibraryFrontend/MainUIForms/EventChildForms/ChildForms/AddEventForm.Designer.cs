namespace LibraryUI.MainUIForms.EventChildForms.ChildForms
{
    partial class AddEventForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddEventTitleLabel = new System.Windows.Forms.Label();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.ReccurenceLabel = new System.Windows.Forms.Label();
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.EventNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.EventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.AvailableSeatsLabel = new System.Windows.Forms.Label();
            this.AvailableSeatsNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddEventButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ReccurenceComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.FeeNumeric = new System.Windows.Forms.NumericUpDown();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableSeatsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.993291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.15739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.79463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.01152F));
            this.tableLayoutPanel1.Controls.Add(this.LoadingBar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.AddEventTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EventNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EventDateLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoadingLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.BranchNameLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReccurenceLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BranchNameComboBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.EventNameText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.EventDatePicker, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionText, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.AvailableSeatsLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AvailableSeatsNumeric, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddEventButton, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.ReccurenceComboBox, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.FeeLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.FeeNumeric, 5, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.011665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.37589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.574468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.446808F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddEventTitleLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.AddEventTitleLabel, 3);
            this.AddEventTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddEventTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.AddEventTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.AddEventTitleLabel.Name = "AddEventTitleLabel";
            this.AddEventTitleLabel.Size = new System.Drawing.Size(509, 99);
            this.AddEventTitleLabel.TabIndex = 56;
            this.AddEventTitleLabel.Text = "Adding a New Event?";
            this.AddEventTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EventNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.EventNameLabel.Location = new System.Drawing.Point(97, 138);
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
            this.EventDateLabel.Location = new System.Drawing.Point(97, 216);
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
            this.tableLayoutPanel1.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(54, 531);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(361, 33);
            this.LoadingLabel.TabIndex = 77;
            this.LoadingLabel.Text = "Adding new event, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.BranchNameLabel, 2);
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(541, 138);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(153, 25);
            this.BranchNameLabel.TabIndex = 78;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReccurenceLabel
            // 
            this.ReccurenceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ReccurenceLabel, 2);
            this.ReccurenceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReccurenceLabel.ForeColor = System.Drawing.Color.Teal;
            this.ReccurenceLabel.Location = new System.Drawing.Point(541, 216);
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
            this.tableLayoutPanel1.SetColumnSpan(this.BranchNameComboBox, 2);
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(724, 132);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 38);
            this.BranchNameComboBox.TabIndex = 81;
            this.BranchNameComboBox.Texts = "";
            // 
            // EventNameText
            // 
            this.EventNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameText.BorderColor = System.Drawing.Color.Teal;
            this.EventNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.EventNameText.BorderSize = 2;
            this.EventNameText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventNameText.ForeColor = System.Drawing.Color.Black;
            this.EventNameText.Location = new System.Drawing.Point(286, 131);
            this.EventNameText.MultiLine = false;
            this.EventNameText.Name = "EventNameText";
            this.EventNameText.Padding = new System.Windows.Forms.Padding(7);
            this.EventNameText.PasswordChar = false;
            this.EventNameText.PlaceHolder = "Event Name";
            this.EventNameText.Size = new System.Drawing.Size(200, 40);
            this.EventNameText.TabIndex = 82;
            this.EventNameText.Texts = "";
            this.EventNameText.Underlined = true;
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
            this.EventDatePicker.Location = new System.Drawing.Point(286, 215);
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
            this.DescriptionLabel.Location = new System.Drawing.Point(97, 368);
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
            this.tableLayoutPanel1.SetColumnSpan(this.DescriptionText, 2);
            this.DescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionText.ForeColor = System.Drawing.Color.Black;
            this.DescriptionText.Location = new System.Drawing.Point(263, 374);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(6);
            this.DescriptionText.MultiLine = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionText.PasswordChar = false;
            this.DescriptionText.PlaceHolder = "Description";
            this.DescriptionText.Size = new System.Drawing.Size(368, 85);
            this.DescriptionText.TabIndex = 84;
            this.DescriptionText.Texts = "";
            this.DescriptionText.Underlined = false;
            // 
            // AvailableSeatsLabel
            // 
            this.AvailableSeatsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvailableSeatsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvailableSeatsLabel.ForeColor = System.Drawing.Color.Teal;
            this.AvailableSeatsLabel.Location = new System.Drawing.Point(97, 294);
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
            this.AvailableSeatsNumeric.Location = new System.Drawing.Point(286, 290);
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
            // AddEventButton
            // 
            this.AddEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEventButton.BackColor = System.Drawing.Color.Teal;
            this.AddEventButton.BorderRadius = 25;
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEventButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddEventButton.Location = new System.Drawing.Point(721, 410);
            this.AddEventButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(173, 55);
            this.AddEventButton.TabIndex = 88;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = false;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ResetButton.BorderRadius = 25;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(784, 465);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 50);
            this.ResetButton.TabIndex = 89;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ReccurenceComboBox
            // 
            this.ReccurenceComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReccurenceComboBox.BackColor = System.Drawing.Color.Teal;
            this.ReccurenceComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ReccurenceComboBox.BorderSize = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.ReccurenceComboBox, 2);
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
            this.ReccurenceComboBox.Location = new System.Drawing.Point(724, 210);
            this.ReccurenceComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ReccurenceComboBox.Name = "ReccurenceComboBox";
            this.ReccurenceComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.ReccurenceComboBox.Size = new System.Drawing.Size(200, 38);
            this.ReccurenceComboBox.TabIndex = 90;
            this.ReccurenceComboBox.Texts = "";
            // 
            // FeeLabel
            // 
            this.FeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.FeeLabel, 2);
            this.FeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeeLabel.ForeColor = System.Drawing.Color.Teal;
            this.FeeLabel.Location = new System.Drawing.Point(541, 294);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(153, 25);
            this.FeeLabel.TabIndex = 91;
            this.FeeLabel.Text = "Fee :";
            this.FeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FeeNumeric
            // 
            this.FeeNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FeeNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.FeeNumeric, 2);
            this.FeeNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeNumeric.ForeColor = System.Drawing.Color.Teal;
            this.FeeNumeric.Location = new System.Drawing.Point(724, 290);
            this.FeeNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.FeeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FeeNumeric.Name = "FeeNumeric";
            this.FeeNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FeeNumeric.Size = new System.Drawing.Size(200, 34);
            this.FeeNumeric.TabIndex = 92;
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
            this.LoadingBar.Location = new System.Drawing.Point(14, 527);
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
            this.LoadingBar.TabIndex = 93;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableSeatsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label AddEventTitleLabel;
        private Label EventNameLabel;
        private Label EventDateLabel;
        private Label DescriptionLabel;
        private Label LoadingLabel;
        private Label BranchNameLabel;
        private Label ReccurenceLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox EventNameText;
        private DateTimePicker EventDatePicker;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox DescriptionText;
        private Label AvailableSeatsLabel;
        private NumericUpDown AvailableSeatsNumeric;
        private AdditionalControls.Buttons.RoundedButton AddEventButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private AdditionalControls.CustomComboBox.CustomComboBox ReccurenceComboBox;
        private Label FeeLabel;
        private NumericUpDown FeeNumeric;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}