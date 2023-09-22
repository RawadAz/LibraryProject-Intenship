namespace LibraryUI.MainUIForms.ReservationsChildForms
{
    partial class ReservationsMainChildForm
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
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.ViewReservationsButton = new FontAwesome.Sharp.IconButton();
            this.SubMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(988, 560);
            this.FormPanel.TabIndex = 9;
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(988, 5);
            this.SplitterPanel.TabIndex = 8;
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Controls.Add(this.ViewReservationsButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(988, 60);
            this.SubMenuPanel.TabIndex = 7;
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
            this.LogoutButton.Location = new System.Drawing.Point(815, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ViewReservationsButton
            // 
            this.ViewReservationsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewReservationsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewReservationsButton.FlatAppearance.BorderSize = 0;
            this.ViewReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewReservationsButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewReservationsButton.ForeColor = System.Drawing.Color.Teal;
            this.ViewReservationsButton.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ViewReservationsButton.IconColor = System.Drawing.Color.Teal;
            this.ViewReservationsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewReservationsButton.IconSize = 44;
            this.ViewReservationsButton.Location = new System.Drawing.Point(0, 0);
            this.ViewReservationsButton.Name = "ViewReservationsButton";
            this.ViewReservationsButton.Size = new System.Drawing.Size(207, 60);
            this.ViewReservationsButton.TabIndex = 1;
            this.ViewReservationsButton.Text = "View";
            this.ViewReservationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewReservationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewReservationsButton.UseVisualStyleBackColor = false;
            this.ViewReservationsButton.Click += new System.EventHandler(this.ViewReservationsButton_Click);
            // 
            // ReservationsMainChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 625);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "ReservationsMainChildForm";
            this.Text = "ReservationsMainChildForm";
            this.Load += new System.EventHandler(this.ReservationsMainChildForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FormPanel;
        private Panel SplitterPanel;
        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private FontAwesome.Sharp.IconButton ViewReservationsButton;
    }
}