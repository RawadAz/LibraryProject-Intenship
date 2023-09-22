namespace LibraryUI.MainUIForms.ClientChildForms
{
    partial class ClientMainChildForm
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
            this.RemoveClientButton = new FontAwesome.Sharp.IconButton();
            this.EditClientButton = new FontAwesome.Sharp.IconButton();
            this.AddClientButton = new FontAwesome.Sharp.IconButton();
            this.ViewClientButton = new FontAwesome.Sharp.IconButton();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.SubMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Controls.Add(this.RemoveClientButton);
            this.SubMenuPanel.Controls.Add(this.EditClientButton);
            this.SubMenuPanel.Controls.Add(this.AddClientButton);
            this.SubMenuPanel.Controls.Add(this.ViewClientButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(977, 60);
            this.SubMenuPanel.TabIndex = 2;
            // 
            // RemoveClientButton
            // 
            this.RemoveClientButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RemoveClientButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveClientButton.FlatAppearance.BorderSize = 0;
            this.RemoveClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveClientButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RemoveClientButton.ForeColor = System.Drawing.Color.Teal;
            this.RemoveClientButton.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.RemoveClientButton.IconColor = System.Drawing.Color.Teal;
            this.RemoveClientButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemoveClientButton.IconSize = 44;
            this.RemoveClientButton.Location = new System.Drawing.Point(519, 0);
            this.RemoveClientButton.Name = "RemoveClientButton";
            this.RemoveClientButton.Size = new System.Drawing.Size(173, 60);
            this.RemoveClientButton.TabIndex = 4;
            this.RemoveClientButton.Text = "Remove";
            this.RemoveClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveClientButton.UseVisualStyleBackColor = false;
            this.RemoveClientButton.Click += new System.EventHandler(this.RemoveClientButton_Click);
            // 
            // EditClientButton
            // 
            this.EditClientButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EditClientButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditClientButton.FlatAppearance.BorderSize = 0;
            this.EditClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditClientButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EditClientButton.ForeColor = System.Drawing.Color.Teal;
            this.EditClientButton.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.EditClientButton.IconColor = System.Drawing.Color.Teal;
            this.EditClientButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditClientButton.IconSize = 44;
            this.EditClientButton.Location = new System.Drawing.Point(346, 0);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(173, 60);
            this.EditClientButton.TabIndex = 3;
            this.EditClientButton.Text = "Edit";
            this.EditClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditClientButton.UseVisualStyleBackColor = false;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddClientButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddClientButton.FlatAppearance.BorderSize = 0;
            this.AddClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddClientButton.ForeColor = System.Drawing.Color.Teal;
            this.AddClientButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddClientButton.IconColor = System.Drawing.Color.Teal;
            this.AddClientButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddClientButton.IconSize = 44;
            this.AddClientButton.Location = new System.Drawing.Point(173, 0);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(173, 60);
            this.AddClientButton.TabIndex = 2;
            this.AddClientButton.Text = "Add";
            this.AddClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // ViewClientButton
            // 
            this.ViewClientButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewClientButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewClientButton.FlatAppearance.BorderSize = 0;
            this.ViewClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewClientButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewClientButton.ForeColor = System.Drawing.Color.Teal;
            this.ViewClientButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ViewClientButton.IconColor = System.Drawing.Color.Teal;
            this.ViewClientButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewClientButton.IconSize = 44;
            this.ViewClientButton.Location = new System.Drawing.Point(0, 0);
            this.ViewClientButton.Name = "ViewClientButton";
            this.ViewClientButton.Size = new System.Drawing.Size(173, 60);
            this.ViewClientButton.TabIndex = 1;
            this.ViewClientButton.Text = "View";
            this.ViewClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewClientButton.UseVisualStyleBackColor = false;
            this.ViewClientButton.Click += new System.EventHandler(this.ViewClientButton_Click);
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(977, 5);
            this.SplitterPanel.TabIndex = 4;
            // 
            // FormPanel
            // 
            this.FormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(977, 450);
            this.FormPanel.TabIndex = 5;
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
            this.LogoutButton.Location = new System.Drawing.Point(804, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ClientMainChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 515);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "ClientMainChildForm";
            this.Text = "ClientMainChildForm";
            this.Load += new System.EventHandler(this.ClientMainChildForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton AddClientButton;
        private FontAwesome.Sharp.IconButton ViewClientButton;
        private Panel SplitterPanel;
        private Panel FormPanel;
        private FontAwesome.Sharp.IconButton RemoveClientButton;
        private FontAwesome.Sharp.IconButton EditClientButton;
        private FontAwesome.Sharp.IconButton LogoutButton;
    }
}