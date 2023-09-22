namespace LibraryUI.MainUIForms.SettingsChildForm.ChildForms
{
    partial class ChangePasswordForm
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
            this.ChangePasswordTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.NewPasswordText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.ConfirmPasswordText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.ChangePasswordButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.UsernameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.ChangePasswordTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePasswordTableLayout
            // 
            this.ChangePasswordTableLayout.ColumnCount = 5;
            this.ChangePasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ChangePasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.13699F));
            this.ChangePasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75538F));
            this.ChangePasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ChangePasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ChangePasswordTableLayout.Controls.Add(this.LoadingBar, 0, 6);
            this.ChangePasswordTableLayout.Controls.Add(this.UsernameLabel, 1, 1);
            this.ChangePasswordTableLayout.Controls.Add(this.oldPasswordLabel, 1, 2);
            this.ChangePasswordTableLayout.Controls.Add(this.newPasswordLabel, 1, 3);
            this.ChangePasswordTableLayout.Controls.Add(this.OldPasswordText, 2, 2);
            this.ChangePasswordTableLayout.Controls.Add(this.NewPasswordText, 2, 3);
            this.ChangePasswordTableLayout.Controls.Add(this.ConfirmPasswordText, 2, 4);
            this.ChangePasswordTableLayout.Controls.Add(this.ChangePasswordButton, 3, 5);
            this.ChangePasswordTableLayout.Controls.Add(this.ResetButton, 4, 6);
            this.ChangePasswordTableLayout.Controls.Add(this.LoadingLabel, 1, 6);
            this.ChangePasswordTableLayout.Controls.Add(this.ChangePasswordLabel, 0, 0);
            this.ChangePasswordTableLayout.Controls.Add(this.ConfirmPasswordLabel, 1, 4);
            this.ChangePasswordTableLayout.Controls.Add(this.UsernameText, 2, 1);
            this.ChangePasswordTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangePasswordTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ChangePasswordTableLayout.Name = "ChangePasswordTableLayout";
            this.ChangePasswordTableLayout.RowCount = 7;
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ChangePasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.ChangePasswordTableLayout.Size = new System.Drawing.Size(1022, 597);
            this.ChangePasswordTableLayout.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.Teal;
            this.UsernameLabel.Location = new System.Drawing.Point(136, 142);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(220, 31);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username :\r\n";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oldPasswordLabel.ForeColor = System.Drawing.Color.Teal;
            this.oldPasswordLabel.Location = new System.Drawing.Point(136, 219);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(220, 31);
            this.oldPasswordLabel.TabIndex = 0;
            this.oldPasswordLabel.Text = "Old Password :\r\n";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPasswordLabel.ForeColor = System.Drawing.Color.Teal;
            this.newPasswordLabel.Location = new System.Drawing.Point(136, 296);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(220, 31);
            this.newPasswordLabel.TabIndex = 0;
            this.newPasswordLabel.Text = "New Password :\r\n";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OldPasswordText
            // 
            this.OldPasswordText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OldPasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OldPasswordText.BorderColor = System.Drawing.Color.Teal;
            this.OldPasswordText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.OldPasswordText.BorderSize = 2;
            this.ChangePasswordTableLayout.SetColumnSpan(this.OldPasswordText, 2);
            this.OldPasswordText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OldPasswordText.ForeColor = System.Drawing.Color.Black;
            this.OldPasswordText.Location = new System.Drawing.Point(362, 212);
            this.OldPasswordText.MultiLine = false;
            this.OldPasswordText.Name = "OldPasswordText";
            this.OldPasswordText.Padding = new System.Windows.Forms.Padding(7);
            this.OldPasswordText.PasswordChar = true;
            this.OldPasswordText.PlaceHolder = "Old Password";
            this.OldPasswordText.Size = new System.Drawing.Size(320, 45);
            this.OldPasswordText.TabIndex = 6;
            this.OldPasswordText.Texts = "";
            this.OldPasswordText.Underlined = true;
            // 
            // NewPasswordText
            // 
            this.NewPasswordText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewPasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewPasswordText.BorderColor = System.Drawing.Color.Teal;
            this.NewPasswordText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.NewPasswordText.BorderSize = 2;
            this.ChangePasswordTableLayout.SetColumnSpan(this.NewPasswordText, 2);
            this.NewPasswordText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordText.ForeColor = System.Drawing.Color.Black;
            this.NewPasswordText.Location = new System.Drawing.Point(362, 289);
            this.NewPasswordText.MultiLine = false;
            this.NewPasswordText.Name = "NewPasswordText";
            this.NewPasswordText.Padding = new System.Windows.Forms.Padding(7);
            this.NewPasswordText.PasswordChar = true;
            this.NewPasswordText.PlaceHolder = "New Password";
            this.NewPasswordText.Size = new System.Drawing.Size(320, 45);
            this.NewPasswordText.TabIndex = 7;
            this.NewPasswordText.Texts = "";
            this.NewPasswordText.Underlined = true;
            // 
            // ConfirmPasswordText
            // 
            this.ConfirmPasswordText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConfirmPasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConfirmPasswordText.BorderColor = System.Drawing.Color.Teal;
            this.ConfirmPasswordText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.ConfirmPasswordText.BorderSize = 2;
            this.ChangePasswordTableLayout.SetColumnSpan(this.ConfirmPasswordText, 2);
            this.ConfirmPasswordText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordText.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPasswordText.Location = new System.Drawing.Point(362, 366);
            this.ConfirmPasswordText.MultiLine = false;
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.Padding = new System.Windows.Forms.Padding(7);
            this.ConfirmPasswordText.PasswordChar = true;
            this.ConfirmPasswordText.PlaceHolder = "Confirm Password";
            this.ConfirmPasswordText.Size = new System.Drawing.Size(320, 45);
            this.ConfirmPasswordText.TabIndex = 8;
            this.ConfirmPasswordText.Texts = "";
            this.ConfirmPasswordText.Underlined = true;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangePasswordButton.BackColor = System.Drawing.Color.Teal;
            this.ChangePasswordButton.BorderRadius = 40;
            this.ChangePasswordTableLayout.SetColumnSpan(this.ChangePasswordButton, 2);
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePasswordButton.Location = new System.Drawing.Point(707, 453);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(220, 60);
            this.ChangePasswordButton.TabIndex = 9;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightGray;
            this.ResetButton.BorderRadius = 40;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(819, 519);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(108, 55);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset\r\n";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(54, 560);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(279, 37);
            this.LoadingLabel.TabIndex = 75;
            this.LoadingLabel.Text = "Changing password, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadingLabel.Visible = false;
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordTableLayout.SetColumnSpan(this.ChangePasswordLabel, 3);
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.Teal;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(3, 0);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(416, 119);
            this.ChangePasswordLabel.TabIndex = 0;
            this.ChangePasswordLabel.Text = "Change Password:";
            this.ChangePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.Teal;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(136, 373);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(220, 31);
            this.ConfirmPasswordLabel.TabIndex = 76;
            this.ConfirmPasswordLabel.Text = "Confirm Password :\r\n";
            this.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameText
            // 
            this.UsernameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UsernameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.UsernameText.BorderSize = 0;
            this.ChangePasswordTableLayout.SetColumnSpan(this.UsernameText, 2);
            this.UsernameText.Enabled = false;
            this.UsernameText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UsernameText.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameText.Location = new System.Drawing.Point(362, 135);
            this.UsernameText.MultiLine = false;
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Padding = new System.Windows.Forms.Padding(7);
            this.UsernameText.PasswordChar = false;
            this.UsernameText.PlaceHolder = "Username";
            this.UsernameText.Size = new System.Drawing.Size(451, 45);
            this.UsernameText.TabIndex = 0;
            this.UsernameText.Texts = "";
            this.UsernameText.Underlined = true;
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
            this.LoadingBar.Location = new System.Drawing.Point(14, 560);
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
            this.LoadingBar.TabIndex = 77;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1022, 597);
            this.Controls.Add(this.ChangePasswordTableLayout);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ChangePasswordTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ChangePasswordTableLayout;
        private Label ChangePasswordLabel;
        private Label UsernameLabel;
        private Label oldPasswordLabel;
        private Label newPasswordLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox UsernameText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox OldPasswordText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox NewPasswordText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox ConfirmPasswordText;
        private AdditionalControls.Buttons.RoundedButton ChangePasswordButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private Label LoadingLabel;
        private Label ConfirmPasswordLabel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}