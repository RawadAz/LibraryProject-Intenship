namespace LibraryUI.MainUIForms.SettingsChildForm
{
    partial class SettingsMainForm
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
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.ChangePasswordButton = new FontAwesome.Sharp.IconButton();
            this.ViewInfoButton = new FontAwesome.Sharp.IconButton();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SubMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Controls.Add(this.ChangePasswordButton);
            this.SubMenuPanel.Controls.Add(this.ViewInfoButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(964, 60);
            this.SubMenuPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.Teal;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.LogoutButton.IconColor = System.Drawing.Color.Teal;
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 44;
            this.LogoutButton.Location = new System.Drawing.Point(791, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.Teal;
            this.ChangePasswordButton.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.ChangePasswordButton.IconColor = System.Drawing.Color.Teal;
            this.ChangePasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChangePasswordButton.IconSize = 44;
            this.ChangePasswordButton.Location = new System.Drawing.Point(173, 0);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(236, 60);
            this.ChangePasswordButton.TabIndex = 2;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ViewInfoButton
            // 
            this.ViewInfoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewInfoButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewInfoButton.FlatAppearance.BorderSize = 0;
            this.ViewInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewInfoButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewInfoButton.ForeColor = System.Drawing.Color.Teal;
            this.ViewInfoButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ViewInfoButton.IconColor = System.Drawing.Color.Teal;
            this.ViewInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewInfoButton.IconSize = 44;
            this.ViewInfoButton.Location = new System.Drawing.Point(0, 0);
            this.ViewInfoButton.Name = "ViewInfoButton";
            this.ViewInfoButton.Size = new System.Drawing.Size(173, 60);
            this.ViewInfoButton.TabIndex = 1;
            this.ViewInfoButton.Text = "My Info";
            this.ViewInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewInfoButton.UseVisualStyleBackColor = false;
            this.ViewInfoButton.Click += new System.EventHandler(this.ViewInfoButton_Click);
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(964, 5);
            this.SplitterPanel.TabIndex = 3;
            // 
            // FormPanel
            // 
            this.FormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(964, 453);
            this.FormPanel.TabIndex = 4;
            // 
            // SettingsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 518);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "SettingsMainForm";
            this.Text = "SettingsMainForm";
            this.Load += new System.EventHandler(this.SettingsMainForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private FontAwesome.Sharp.IconButton ChangePasswordButton;
        private FontAwesome.Sharp.IconButton ViewInfoButton;
        private Panel SplitterPanel;
        private Panel FormPanel;
    }
}