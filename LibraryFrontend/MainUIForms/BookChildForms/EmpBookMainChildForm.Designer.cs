namespace LibraryUI.MainUIForms.BookChildForms
{
    partial class EmpBookMainChildForm
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
            this.ReturnDatesbutton = new FontAwesome.Sharp.IconButton();
            this.SearchButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.SubMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1009, 611);
            this.FormPanel.TabIndex = 11;
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(1009, 5);
            this.SplitterPanel.TabIndex = 10;
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.AutoScroll = true;
            this.SubMenuPanel.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Controls.Add(this.ReturnDatesbutton);
            this.SubMenuPanel.Controls.Add(this.SearchButton);
            this.SubMenuPanel.Controls.Add(this.HomeButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(1009, 60);
            this.SubMenuPanel.TabIndex = 9;
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
            this.LogoutButton.Location = new System.Drawing.Point(836, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 14;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ReturnDatesbutton
            // 
            this.ReturnDatesbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ReturnDatesbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReturnDatesbutton.FlatAppearance.BorderSize = 0;
            this.ReturnDatesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnDatesbutton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ReturnDatesbutton.ForeColor = System.Drawing.Color.Teal;
            this.ReturnDatesbutton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.ReturnDatesbutton.IconColor = System.Drawing.Color.Teal;
            this.ReturnDatesbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReturnDatesbutton.IconSize = 44;
            this.ReturnDatesbutton.Location = new System.Drawing.Point(265, 0);
            this.ReturnDatesbutton.Name = "ReturnDatesbutton";
            this.ReturnDatesbutton.Size = new System.Drawing.Size(185, 60);
            this.ReturnDatesbutton.TabIndex = 4;
            this.ReturnDatesbutton.Text = "Return Dates";
            this.ReturnDatesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnDatesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnDatesbutton.UseVisualStyleBackColor = false;
            this.ReturnDatesbutton.Click += new System.EventHandler(this.ReturnDatesbutton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.Teal;
            this.SearchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchButton.IconColor = System.Drawing.Color.Teal;
            this.SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchButton.IconSize = 44;
            this.SearchButton.Location = new System.Drawing.Point(133, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(132, 60);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.Teal;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.HomeButton.IconColor = System.Drawing.Color.Teal;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.IconSize = 44;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(133, 60);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // EmpBookMainChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1009, 676);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "EmpBookMainChildForm";
            this.Load += new System.EventHandler(this.BookMainChildForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FormPanel;
        private Panel SplitterPanel;
        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private FontAwesome.Sharp.IconButton ReturnDatesbutton;
        private FontAwesome.Sharp.IconButton SearchButton;
        private FontAwesome.Sharp.IconButton HomeButton;
    }
}