namespace LibraryUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginBtn = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetBtn = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.UsernameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.PasswordText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PasswordToggleImage = new System.Windows.Forms.PictureBox();
            this.loginProgressBar = new CircularProgressBar.CircularProgressBar();
            this.loggingInLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordToggleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBtn.BackColor = System.Drawing.Color.Teal;
            this.LoginBtn.BorderRadius = 50;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Location = new System.Drawing.Point(140, 485);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(212, 62);
            this.LoginBtn.TabIndex = 20;
            this.LoginBtn.Text = "login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetBtn.BackColor = System.Drawing.Color.LightGray;
            this.ResetBtn.BorderRadius = 50;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.ForeColor = System.Drawing.Color.Teal;
            this.ResetBtn.Location = new System.Drawing.Point(140, 553);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(212, 62);
            this.ResetBtn.TabIndex = 30;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // UsernameText
            // 
            this.UsernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UsernameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameText.BorderColor = System.Drawing.Color.Teal;
            this.UsernameText.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.UsernameText.BorderSize = 2;
            this.UsernameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameText.Location = new System.Drawing.Point(90, 325);
            this.UsernameText.MultiLine = false;
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Padding = new System.Windows.Forms.Padding(7);
            this.UsernameText.PasswordChar = false;
            this.UsernameText.PlaceHolder = "Username:";
            this.UsernameText.Size = new System.Drawing.Size(314, 43);
            this.UsernameText.TabIndex = 1;
            this.UsernameText.Texts = "rawad123";
            this.UsernameText.Underlined = true;
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordText.BorderColor = System.Drawing.Color.Teal;
            this.PasswordText.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.PasswordText.BorderSize = 2;
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordText.Location = new System.Drawing.Point(88, 399);
            this.PasswordText.MultiLine = false;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordText.PasswordChar = true;
            this.PasswordText.PlaceHolder = "Password:";
            this.PasswordText.Size = new System.Drawing.Size(314, 43);
            this.PasswordText.TabIndex = 10;
            this.PasswordText.Texts = "1234";
            this.PasswordText.Underlined = true;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.Controls.Add(this.iconPictureBox1);
            this.loginPanel.Controls.Add(this.PasswordToggleImage);
            this.loginPanel.Controls.Add(this.loginProgressBar);
            this.loginPanel.Controls.Add(this.PasswordText);
            this.loginPanel.Controls.Add(this.loggingInLabel);
            this.loginPanel.Controls.Add(this.ResetBtn);
            this.loginPanel.Controls.Add(this.LoginBtn);
            this.loginPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginPanel.Location = new System.Drawing.Point(2, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(494, 724);
            this.loginPanel.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 170;
            this.iconPictureBox1.Location = new System.Drawing.Point(162, 147);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(170, 170);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // PasswordToggleImage
            // 
            this.PasswordToggleImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordToggleImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordToggleImage.Image = global::LibraryUI.Properties.Resources.hide_password;
            this.PasswordToggleImage.InitialImage = null;
            this.PasswordToggleImage.Location = new System.Drawing.Point(368, 409);
            this.PasswordToggleImage.Name = "PasswordToggleImage";
            this.PasswordToggleImage.Size = new System.Drawing.Size(30, 20);
            this.PasswordToggleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordToggleImage.TabIndex = 9;
            this.PasswordToggleImage.TabStop = false;
            this.PasswordToggleImage.Click += new System.EventHandler(this.PasswordToggleImage_Click);
            // 
            // loginProgressBar
            // 
            this.loginProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loginProgressBar.AnimationSpeed = 500;
            this.loginProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.loginProgressBar.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginProgressBar.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.loginProgressBar.InnerMargin = 2;
            this.loginProgressBar.InnerWidth = -1;
            this.loginProgressBar.Location = new System.Drawing.Point(90, 632);
            this.loginProgressBar.MarqueeAnimationSpeed = 2000;
            this.loginProgressBar.Name = "loginProgressBar";
            this.loginProgressBar.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.loginProgressBar.OuterMargin = -25;
            this.loginProgressBar.OuterWidth = 26;
            this.loginProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.loginProgressBar.ProgressWidth = 5;
            this.loginProgressBar.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginProgressBar.Size = new System.Drawing.Size(40, 40);
            this.loginProgressBar.StartAngle = 270;
            this.loginProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loginProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loginProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loginProgressBar.SubscriptText = ".23";
            this.loginProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loginProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loginProgressBar.SuperscriptText = "°C";
            this.loginProgressBar.TabIndex = 2;
            this.loginProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loginProgressBar.Value = 68;
            this.loginProgressBar.Visible = false;
            // 
            // loggingInLabel
            // 
            this.loggingInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loggingInLabel.AutoSize = true;
            this.loggingInLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loggingInLabel.Location = new System.Drawing.Point(142, 647);
            this.loggingInLabel.Name = "loggingInLabel";
            this.loggingInLabel.Size = new System.Drawing.Size(205, 25);
            this.loggingInLabel.TabIndex = 1;
            this.loggingInLabel.Text = "Logging in, please wait...";
            this.loggingInLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 728);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.loginPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 700);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Login Page";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordToggleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdditionalControls.Buttons.RoundedButton LoginBtn;
        private AdditionalControls.Buttons.RoundedButton ResetBtn;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox UsernameText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox PasswordText;
        private Panel loginPanel;
        private Label loggingInLabel;
        private CircularProgressBar.CircularProgressBar loginProgressBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private PictureBox PasswordToggleImage;
    }
}