namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms
{
    partial class EditBranchForm
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
            this.ManagerStartDateLabel = new System.Windows.Forms.Label();
            this.EditDeletePanel = new System.Windows.Forms.Panel();
            this.DeletebranchRB = new System.Windows.Forms.RadioButton();
            this.EditBranchRB = new System.Windows.Forms.RadioButton();
            this.EditBranchButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ManagerIdComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.ManagerIdLabel = new System.Windows.Forms.Label();
            this.ManagerStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EditBranchTitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.LocationText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.FormTablePanel.SuspendLayout();
            this.EditDeletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTablePanel
            // 
            this.FormTablePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTablePanel.ColumnCount = 6;
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.76619F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.07193F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18282F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.6644F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.23597F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.004648F));
            this.FormTablePanel.Controls.Add(this.LoadingBar, 0, 7);
            this.FormTablePanel.Controls.Add(this.ManagerStartDateLabel, 1, 4);
            this.FormTablePanel.Controls.Add(this.EditDeletePanel, 3, 0);
            this.FormTablePanel.Controls.Add(this.EditBranchButton, 4, 5);
            this.FormTablePanel.Controls.Add(this.ResetButton, 4, 6);
            this.FormTablePanel.Controls.Add(this.BranchNameComboBox, 2, 1);
            this.FormTablePanel.Controls.Add(this.BranchNameLabel, 1, 1);
            this.FormTablePanel.Controls.Add(this.LocationLabel, 1, 2);
            this.FormTablePanel.Controls.Add(this.ManagerIdComboBox, 2, 3);
            this.FormTablePanel.Controls.Add(this.ManagerIdLabel, 1, 3);
            this.FormTablePanel.Controls.Add(this.ManagerStartDatePicker, 2, 4);
            this.FormTablePanel.Controls.Add(this.EditBranchTitleLabel, 0, 0);
            this.FormTablePanel.Controls.Add(this.LoadingLabel, 1, 7);
            this.FormTablePanel.Controls.Add(this.LocationText, 2, 2);
            this.FormTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTablePanel.Location = new System.Drawing.Point(0, 0);
            this.FormTablePanel.Name = "FormTablePanel";
            this.FormTablePanel.RowCount = 8;
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.43753F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.73787F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.16279F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76285F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.425209F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.760684F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.905983F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.760684F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.Size = new System.Drawing.Size(1001, 618);
            this.FormTablePanel.TabIndex = 2;
            // 
            // ManagerStartDateLabel
            // 
            this.ManagerStartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManagerStartDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManagerStartDateLabel.ForeColor = System.Drawing.Color.Teal;
            this.ManagerStartDateLabel.Location = new System.Drawing.Point(125, 417);
            this.ManagerStartDateLabel.Name = "ManagerStartDateLabel";
            this.ManagerStartDateLabel.Size = new System.Drawing.Size(200, 25);
            this.ManagerStartDateLabel.TabIndex = 62;
            this.ManagerStartDateLabel.Text = "Manager Start Date :";
            this.ManagerStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditDeletePanel
            // 
            this.FormTablePanel.SetColumnSpan(this.EditDeletePanel, 2);
            this.EditDeletePanel.Controls.Add(this.DeletebranchRB);
            this.EditDeletePanel.Controls.Add(this.EditBranchRB);
            this.EditDeletePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditDeletePanel.Location = new System.Drawing.Point(503, 3);
            this.EditDeletePanel.Name = "EditDeletePanel";
            this.EditDeletePanel.Size = new System.Drawing.Size(433, 114);
            this.EditDeletePanel.TabIndex = 80;
            // 
            // DeletebranchRB
            // 
            this.DeletebranchRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletebranchRB.AutoSize = true;
            this.DeletebranchRB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletebranchRB.ForeColor = System.Drawing.Color.Teal;
            this.DeletebranchRB.Location = new System.Drawing.Point(248, 82);
            this.DeletebranchRB.Name = "DeletebranchRB";
            this.DeletebranchRB.Size = new System.Drawing.Size(175, 29);
            this.DeletebranchRB.TabIndex = 1;
            this.DeletebranchRB.Text = "Remove a Branch";
            this.DeletebranchRB.UseVisualStyleBackColor = true;
            // 
            // EditBranchRB
            // 
            this.EditBranchRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBranchRB.AutoSize = true;
            this.EditBranchRB.Checked = true;
            this.EditBranchRB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBranchRB.ForeColor = System.Drawing.Color.Teal;
            this.EditBranchRB.Location = new System.Drawing.Point(30, 82);
            this.EditBranchRB.Name = "EditBranchRB";
            this.EditBranchRB.Size = new System.Drawing.Size(169, 29);
            this.EditBranchRB.TabIndex = 0;
            this.EditBranchRB.TabStop = true;
            this.EditBranchRB.Text = "Update a Branch";
            this.EditBranchRB.UseVisualStyleBackColor = true;
            this.EditBranchRB.CheckedChanged += new System.EventHandler(this.EditBranchRB_CheckedChanged);
            // 
            // EditBranchButton
            // 
            this.EditBranchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBranchButton.BackColor = System.Drawing.Color.Teal;
            this.EditBranchButton.BorderRadius = 25;
            this.EditBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBranchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBranchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditBranchButton.Location = new System.Drawing.Point(748, 459);
            this.EditBranchButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditBranchButton.Name = "EditBranchButton";
            this.EditBranchButton.Size = new System.Drawing.Size(191, 54);
            this.EditBranchButton.TabIndex = 87;
            this.EditBranchButton.Text = "Update Branch";
            this.EditBranchButton.UseVisualStyleBackColor = false;
            this.EditBranchButton.Click += new System.EventHandler(this.EditBranchButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ResetButton.BorderRadius = 25;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(833, 513);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 47);
            this.ResetButton.TabIndex = 88;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BranchNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BranchNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.BorderSize = 4;
            this.FormTablePanel.SetColumnSpan(this.BranchNameComboBox, 2);
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(331, 152);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 38);
            this.BranchNameComboBox.TabIndex = 84;
            this.BranchNameComboBox.Texts = "";
            this.BranchNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BranchNameComboBox_OnSelectedIndexChanged);
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(125, 159);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(200, 25);
            this.BranchNameLabel.TabIndex = 89;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationLabel.ForeColor = System.Drawing.Color.Teal;
            this.LocationLabel.Location = new System.Drawing.Point(125, 223);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(200, 45);
            this.LocationLabel.TabIndex = 91;
            this.LocationLabel.Text = "Location :";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManagerIdComboBox
            // 
            this.ManagerIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManagerIdComboBox.BackColor = System.Drawing.Color.Teal;
            this.ManagerIdComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ManagerIdComboBox.BorderSize = 4;
            this.FormTablePanel.SetColumnSpan(this.ManagerIdComboBox, 2);
            this.ManagerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManagerIdComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ManagerIdComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ManagerIdComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.ManagerIdComboBox.ListForeColor = System.Drawing.Color.Black;
            this.ManagerIdComboBox.Location = new System.Drawing.Point(331, 333);
            this.ManagerIdComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ManagerIdComboBox.Name = "ManagerIdComboBox";
            this.ManagerIdComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.ManagerIdComboBox.Size = new System.Drawing.Size(200, 38);
            this.ManagerIdComboBox.TabIndex = 92;
            this.ManagerIdComboBox.Texts = "";
            // 
            // ManagerIdLabel
            // 
            this.ManagerIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManagerIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManagerIdLabel.ForeColor = System.Drawing.Color.Teal;
            this.ManagerIdLabel.Location = new System.Drawing.Point(125, 340);
            this.ManagerIdLabel.Name = "ManagerIdLabel";
            this.ManagerIdLabel.Size = new System.Drawing.Size(200, 25);
            this.ManagerIdLabel.TabIndex = 93;
            this.ManagerIdLabel.Text = "Manager Id :";
            this.ManagerIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManagerStartDatePicker
            // 
            this.ManagerStartDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManagerStartDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagerStartDatePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.ManagerStartDatePicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.ManagerStartDatePicker.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTablePanel.SetColumnSpan(this.ManagerStartDatePicker, 2);
            this.ManagerStartDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ManagerStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ManagerStartDatePicker.Location = new System.Drawing.Point(331, 416);
            this.ManagerStartDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.ManagerStartDatePicker.Name = "ManagerStartDatePicker";
            this.ManagerStartDatePicker.Size = new System.Drawing.Size(194, 27);
            this.ManagerStartDatePicker.TabIndex = 94;
            this.ManagerStartDatePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // EditBranchTitleLabel
            // 
            this.FormTablePanel.SetColumnSpan(this.EditBranchTitleLabel, 3);
            this.EditBranchTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.EditBranchTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.EditBranchTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.EditBranchTitleLabel.Name = "EditBranchTitleLabel";
            this.EditBranchTitleLabel.Size = new System.Drawing.Size(378, 91);
            this.EditBranchTitleLabel.TabIndex = 55;
            this.EditBranchTitleLabel.Text = "Edit Branch";
            this.EditBranchTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormTablePanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(50, 581);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(268, 37);
            this.LoadingLabel.TabIndex = 76;
            this.LoadingLabel.Text = "Updating Branch, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // LocationText
            // 
            this.LocationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LocationText.BorderColor = System.Drawing.Color.Teal;
            this.LocationText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.LocationText.BorderSize = 2;
            this.FormTablePanel.SetColumnSpan(this.LocationText, 2);
            this.LocationText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationText.ForeColor = System.Drawing.Color.Black;
            this.LocationText.Location = new System.Drawing.Point(331, 226);
            this.LocationText.MultiLine = true;
            this.LocationText.Name = "LocationText";
            this.LocationText.Padding = new System.Windows.Forms.Padding(7);
            this.LocationText.PasswordChar = false;
            this.LocationText.PlaceHolder = "Location";
            this.LocationText.Size = new System.Drawing.Size(393, 75);
            this.LocationText.TabIndex = 95;
            this.LocationText.Texts = "";
            this.LocationText.Underlined = false;
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
            this.LoadingBar.Location = new System.Drawing.Point(10, 581);
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
            this.LoadingBar.TabIndex = 96;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // EditBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 618);
            this.Controls.Add(this.FormTablePanel);
            this.MinimumSize = new System.Drawing.Size(914, 550);
            this.Name = "EditBranchForm";
            this.Text = "EditBranchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditBranchForm_FormClosed);
            this.Load += new System.EventHandler(this.EditBranchForm_Load);
            this.FormTablePanel.ResumeLayout(false);
            this.EditDeletePanel.ResumeLayout(false);
            this.EditDeletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTablePanel;
        private Label EditBranchTitleLabel;
        private Label LoadingLabel;
        private Panel EditDeletePanel;
        private RadioButton DeletebranchRB;
        private RadioButton EditBranchRB;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private AdditionalControls.Buttons.RoundedButton EditBranchButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private Label BranchNameLabel;
        private Label LocationLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox ManagerIdComboBox;
        private Label ManagerIdLabel;
        private Label ManagerStartDateLabel;
        private DateTimePicker ManagerStartDatePicker;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox LocationText;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}