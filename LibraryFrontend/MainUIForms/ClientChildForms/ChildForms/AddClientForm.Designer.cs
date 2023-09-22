﻿namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms
{
    partial class AddClientForm
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
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.ViewClientTitleLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.PhoneNumberText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.19753F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.LoadingBar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ViewClientTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LastNameLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LastNameText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberText, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddEmployeeButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.LoadingLabel, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.81319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.89011F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 525);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.LoadingBar.Location = new System.Drawing.Point(22, 488);
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
            this.LoadingBar.TabIndex = 75;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // ViewClientTitleLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ViewClientTitleLabel, 3);
            this.ViewClientTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ViewClientTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ViewClientTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ViewClientTitleLabel.Name = "ViewClientTitleLabel";
            this.ViewClientTitleLabel.Size = new System.Drawing.Size(444, 103);
            this.ViewClientTitleLabel.TabIndex = 57;
            this.ViewClientTitleLabel.Text = "Adding a New Client?";
            this.ViewClientTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.FirstNameLabel.Location = new System.Drawing.Point(124, 121);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(210, 40);
            this.FirstNameLabel.TabIndex = 58;
            this.FirstNameLabel.Text = "First Name:";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstNameLabel.UseMnemonic = false;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameText.BorderColor = System.Drawing.Color.Teal;
            this.FirstNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.FirstNameText.BorderSize = 2;
            this.FirstNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameText.ForeColor = System.Drawing.Color.Black;
            this.FirstNameText.Location = new System.Drawing.Point(340, 120);
            this.FirstNameText.MultiLine = false;
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Padding = new System.Windows.Forms.Padding(7);
            this.FirstNameText.PasswordChar = false;
            this.FirstNameText.PlaceHolder = "First name";
            this.FirstNameText.Size = new System.Drawing.Size(199, 43);
            this.FirstNameText.TabIndex = 59;
            this.FirstNameText.Texts = "";
            this.FirstNameText.Underlined = true;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.LastNameLabel.Location = new System.Drawing.Point(124, 198);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(210, 40);
            this.LastNameLabel.TabIndex = 60;
            this.LastNameLabel.Text = "Last Name:";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LastNameLabel.UseMnemonic = false;
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameText.BorderColor = System.Drawing.Color.Teal;
            this.LastNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.LastNameText.BorderSize = 2;
            this.LastNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameText.ForeColor = System.Drawing.Color.Black;
            this.LastNameText.Location = new System.Drawing.Point(340, 197);
            this.LastNameText.MultiLine = false;
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Padding = new System.Windows.Forms.Padding(7);
            this.LastNameText.PasswordChar = false;
            this.LastNameText.PlaceHolder = "Last Name";
            this.LastNameText.Size = new System.Drawing.Size(199, 43);
            this.LastNameText.TabIndex = 61;
            this.LastNameText.Texts = "";
            this.LastNameText.Underlined = true;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumberText.BorderColor = System.Drawing.Color.Teal;
            this.PhoneNumberText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.PhoneNumberText.BorderSize = 2;
            this.PhoneNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberText.ForeColor = System.Drawing.Color.Black;
            this.PhoneNumberText.Location = new System.Drawing.Point(340, 274);
            this.PhoneNumberText.MultiLine = false;
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Padding = new System.Windows.Forms.Padding(7);
            this.PhoneNumberText.PasswordChar = false;
            this.PhoneNumberText.PlaceHolder = "Phone Number";
            this.PhoneNumberText.Size = new System.Drawing.Size(199, 43);
            this.PhoneNumberText.TabIndex = 62;
            this.PhoneNumberText.Texts = "";
            this.PhoneNumberText.Underlined = true;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(124, 275);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(210, 40);
            this.PhoneNumberLabel.TabIndex = 63;
            this.PhoneNumberLabel.Text = "Phone Number:";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneNumberLabel.UseMnemonic = false;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeeButton.BackColor = System.Drawing.Color.Teal;
            this.AddEmployeeButton.BorderRadius = 35;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddEmployeeButton.Location = new System.Drawing.Point(629, 347);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(174, 58);
            this.AddEmployeeButton.TabIndex = 66;
            this.AddEmployeeButton.Text = "Add Client";
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightGray;
            this.ResetButton.BorderRadius = 35;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(674, 408);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(132, 51);
            this.ResetButton.TabIndex = 71;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(62, 488);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(285, 37);
            this.LoadingLabel.TabIndex = 74;
            this.LoadingLabel.Text = "Adding client, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(734, 411);
            this.Name = "AddClientForm";
            this.Text = "Add Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddClientForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ViewClientTitleLabel;
        private Label FirstNameLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox FirstNameText;
        private Label LastNameLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox LastNameText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox PhoneNumberText;
        private Label PhoneNumberLabel;
        private AdditionalControls.Buttons.RoundedButton AddEmployeeButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private Label LoadingLabel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}