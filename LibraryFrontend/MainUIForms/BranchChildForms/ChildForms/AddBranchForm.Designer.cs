namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms
{
    partial class AddBranchForm
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
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.BranchNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.ManagerIdLabel = new System.Windows.Forms.Label();
            this.ManagerIdComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.ManagerStartDateLabel = new System.Windows.Forms.Label();
            this.ManagerStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.AddBranchButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.AddBookTitleLabel = new System.Windows.Forms.Label();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.FormTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTablePanel
            // 
            this.FormTablePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTablePanel.ColumnCount = 6;
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.051814F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.12435F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.64544F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.598726F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.95754F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.281552F));
            this.FormTablePanel.Controls.Add(this.LoadingBar, 0, 6);
            this.FormTablePanel.Controls.Add(this.BranchNameLabel, 1, 1);
            this.FormTablePanel.Controls.Add(this.BranchNameText, 2, 1);
            this.FormTablePanel.Controls.Add(this.LocationLabel, 1, 2);
            this.FormTablePanel.Controls.Add(this.LocationText, 2, 2);
            this.FormTablePanel.Controls.Add(this.ManagerIdLabel, 1, 3);
            this.FormTablePanel.Controls.Add(this.ManagerIdComboBox, 2, 3);
            this.FormTablePanel.Controls.Add(this.ManagerStartDateLabel, 1, 4);
            this.FormTablePanel.Controls.Add(this.ManagerStartDatePicker, 2, 4);
            this.FormTablePanel.Controls.Add(this.LoadingLabel, 1, 6);
            this.FormTablePanel.Controls.Add(this.AddBranchButton, 4, 4);
            this.FormTablePanel.Controls.Add(this.ResetButton, 4, 5);
            this.FormTablePanel.Controls.Add(this.AddBookTitleLabel, 0, 0);
            this.FormTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTablePanel.Location = new System.Drawing.Point(0, 0);
            this.FormTablePanel.Name = "FormTablePanel";
            this.FormTablePanel.RowCount = 7;
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.80804F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.81901F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.FormTablePanel.Size = new System.Drawing.Size(942, 547);
            this.FormTablePanel.TabIndex = 1;
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(124, 123);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(223, 25);
            this.BranchNameLabel.TabIndex = 56;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BranchNameText
            // 
            this.BranchNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BranchNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameText.BorderColor = System.Drawing.Color.Teal;
            this.BranchNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.BranchNameText.BorderSize = 2;
            this.BranchNameText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchNameText.ForeColor = System.Drawing.Color.Black;
            this.BranchNameText.Location = new System.Drawing.Point(353, 116);
            this.BranchNameText.MultiLine = false;
            this.BranchNameText.Name = "BranchNameText";
            this.BranchNameText.Padding = new System.Windows.Forms.Padding(7);
            this.BranchNameText.PasswordChar = false;
            this.BranchNameText.PlaceHolder = "Branch Name";
            this.BranchNameText.Size = new System.Drawing.Size(188, 40);
            this.BranchNameText.TabIndex = 64;
            this.BranchNameText.Texts = "";
            this.BranchNameText.Underlined = true;
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationLabel.ForeColor = System.Drawing.Color.Teal;
            this.LocationLabel.Location = new System.Drawing.Point(124, 201);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(223, 25);
            this.LocationLabel.TabIndex = 77;
            this.LocationLabel.Text = "Location :";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocationText
            // 
            this.LocationText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LocationText.BorderColor = System.Drawing.Color.Teal;
            this.LocationText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.LocationText.BorderSize = 2;
            this.FormTablePanel.SetColumnSpan(this.LocationText, 2);
            this.LocationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationText.ForeColor = System.Drawing.Color.Black;
            this.LocationText.Location = new System.Drawing.Point(353, 176);
            this.LocationText.MultiLine = true;
            this.LocationText.Name = "LocationText";
            this.LocationText.Padding = new System.Windows.Forms.Padding(7);
            this.LocationText.PasswordChar = false;
            this.LocationText.PlaceHolder = "Location";
            this.LocationText.Size = new System.Drawing.Size(326, 75);
            this.LocationText.TabIndex = 78;
            this.LocationText.Texts = "";
            this.LocationText.Underlined = false;
            // 
            // ManagerIdLabel
            // 
            this.ManagerIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManagerIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManagerIdLabel.ForeColor = System.Drawing.Color.Teal;
            this.ManagerIdLabel.Location = new System.Drawing.Point(124, 287);
            this.ManagerIdLabel.Name = "ManagerIdLabel";
            this.ManagerIdLabel.Size = new System.Drawing.Size(223, 25);
            this.ManagerIdLabel.TabIndex = 79;
            this.ManagerIdLabel.Text = "Manager Id :";
            this.ManagerIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManagerIdComboBox
            // 
            this.ManagerIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManagerIdComboBox.BackColor = System.Drawing.Color.Teal;
            this.ManagerIdComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ManagerIdComboBox.BorderSize = 4;
            this.ManagerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManagerIdComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ManagerIdComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ManagerIdComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.ManagerIdComboBox.ListForeColor = System.Drawing.Color.Black;
            this.ManagerIdComboBox.Location = new System.Drawing.Point(353, 281);
            this.ManagerIdComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ManagerIdComboBox.Name = "ManagerIdComboBox";
            this.ManagerIdComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.ManagerIdComboBox.Size = new System.Drawing.Size(200, 38);
            this.ManagerIdComboBox.TabIndex = 80;
            this.ManagerIdComboBox.Texts = "";
            // 
            // ManagerStartDateLabel
            // 
            this.ManagerStartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManagerStartDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManagerStartDateLabel.ForeColor = System.Drawing.Color.Teal;
            this.ManagerStartDateLabel.Location = new System.Drawing.Point(124, 370);
            this.ManagerStartDateLabel.Name = "ManagerStartDateLabel";
            this.ManagerStartDateLabel.Size = new System.Drawing.Size(223, 25);
            this.ManagerStartDateLabel.TabIndex = 81;
            this.ManagerStartDateLabel.Text = "Manager Start Date :";
            this.ManagerStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManagerStartDatePicker
            // 
            this.ManagerStartDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManagerStartDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagerStartDatePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.ManagerStartDatePicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.ManagerStartDatePicker.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.ManagerStartDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ManagerStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ManagerStartDatePicker.Location = new System.Drawing.Point(353, 369);
            this.ManagerStartDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.ManagerStartDatePicker.Name = "ManagerStartDatePicker";
            this.ManagerStartDatePicker.Size = new System.Drawing.Size(194, 27);
            this.ManagerStartDatePicker.TabIndex = 82;
            this.ManagerStartDatePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormTablePanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(50, 510);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(383, 37);
            this.LoadingLabel.TabIndex = 76;
            this.LoadingLabel.Text = "Adding new branch, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // AddBranchButton
            // 
            this.AddBranchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBranchButton.BackColor = System.Drawing.Color.Teal;
            this.AddBranchButton.BorderRadius = 35;
            this.AddBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBranchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBranchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddBranchButton.Location = new System.Drawing.Point(694, 359);
            this.AddBranchButton.Name = "AddBranchButton";
            this.AddBranchButton.Size = new System.Drawing.Size(173, 58);
            this.AddBranchButton.TabIndex = 84;
            this.AddBranchButton.Text = "Add Branch";
            this.AddBranchButton.UseVisualStyleBackColor = false;
            this.AddBranchButton.Click += new System.EventHandler(this.AddBranchButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightGray;
            this.ResetButton.BorderRadius = 35;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(747, 423);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(120, 56);
            this.ResetButton.TabIndex = 85;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddBookTitleLabel
            // 
            this.FormTablePanel.SetColumnSpan(this.AddBookTitleLabel, 3);
            this.AddBookTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddBookTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.AddBookTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.AddBookTitleLabel.Name = "AddBookTitleLabel";
            this.AddBookTitleLabel.Size = new System.Drawing.Size(435, 99);
            this.AddBookTitleLabel.TabIndex = 55;
            this.AddBookTitleLabel.Text = "Adding a New Branch?";
            this.AddBookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LoadingBar.Location = new System.Drawing.Point(10, 510);
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
            this.LoadingBar.TabIndex = 86;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // AddBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 547);
            this.Controls.Add(this.FormTablePanel);
            this.MinimumSize = new System.Drawing.Size(700, 430);
            this.Name = "AddBranchForm";
            this.Text = "AddBranchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBranchForm_FormClosed);
            this.Load += new System.EventHandler(this.AddBranchForm_Load);
            this.FormTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTablePanel;
        private Label BranchNameLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox BranchNameText;
        private Label AddBookTitleLabel;
        private Label LoadingLabel;
        private Label LocationLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox LocationText;
        private Label ManagerIdLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox ManagerIdComboBox;
        private Label ManagerStartDateLabel;
        private DateTimePicker ManagerStartDatePicker;
        private AdditionalControls.Buttons.RoundedButton AddBranchButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}