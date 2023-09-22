namespace LibraryUI.MainUIForms
{
    partial class EmployeeUI
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsMenuButton = new FontAwesome.Sharp.IconButton();
            this.ClientsMenuButton = new FontAwesome.Sharp.IconButton();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.EventsMenuButton = new FontAwesome.Sharp.IconButton();
            this.ReservationsMenuButton = new FontAwesome.Sharp.IconButton();
            this.BranchMenuButton = new FontAwesome.Sharp.IconButton();
            this.BookMenuButton = new FontAwesome.Sharp.IconButton();
            this.TransactionsMenuButton = new FontAwesome.Sharp.IconButton();
            this.TaskBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.Exitbutton = new FontAwesome.Sharp.IconButton();
            this.MainPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.TaskBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.FormPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Controls.Add(this.TaskBarPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1304, 864);
            this.MainPanel.TabIndex = 1;
            // 
            // FormPanel
            // 
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(220, 32);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1084, 832);
            this.FormPanel.TabIndex = 52;
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPanel.BackColor = System.Drawing.Color.Teal;
            this.MenuPanel.Controls.Add(this.SettingsMenuButton);
            this.MenuPanel.Controls.Add(this.ClientsMenuButton);
            this.MenuPanel.Controls.Add(this.LogoImage);
            this.MenuPanel.Controls.Add(this.EventsMenuButton);
            this.MenuPanel.Controls.Add(this.ReservationsMenuButton);
            this.MenuPanel.Controls.Add(this.BranchMenuButton);
            this.MenuPanel.Controls.Add(this.BookMenuButton);
            this.MenuPanel.Controls.Add(this.TransactionsMenuButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 32);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(220, 832);
            this.MenuPanel.TabIndex = 50;
            // 
            // SettingsMenuButton
            // 
            this.SettingsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SettingsMenuButton.BackColor = System.Drawing.Color.Teal;
            this.SettingsMenuButton.FlatAppearance.BorderSize = 0;
            this.SettingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SettingsMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsMenuButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.SettingsMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsMenuButton.Location = new System.Drawing.Point(0, 638);
            this.SettingsMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsMenuButton.Name = "SettingsMenuButton";
            this.SettingsMenuButton.Size = new System.Drawing.Size(220, 80);
            this.SettingsMenuButton.TabIndex = 41;
            this.SettingsMenuButton.Text = "&Settings";
            this.SettingsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsMenuButton.UseVisualStyleBackColor = false;
            this.SettingsMenuButton.Click += new System.EventHandler(this.SettingsMenuButton_Click);
            // 
            // ClientsMenuButton
            // 
            this.ClientsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClientsMenuButton.BackColor = System.Drawing.Color.Teal;
            this.ClientsMenuButton.FlatAppearance.BorderSize = 0;
            this.ClientsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ClientsMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientsMenuButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ClientsMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ClientsMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientsMenuButton.Location = new System.Drawing.Point(0, 469);
            this.ClientsMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.ClientsMenuButton.Name = "ClientsMenuButton";
            this.ClientsMenuButton.Size = new System.Drawing.Size(220, 80);
            this.ClientsMenuButton.TabIndex = 30;
            this.ClientsMenuButton.Text = " &Clients";
            this.ClientsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientsMenuButton.UseVisualStyleBackColor = false;
            this.ClientsMenuButton.Click += new System.EventHandler(this.ClientsMenuButton_Click);
            // 
            // LogoImage
            // 
            this.LogoImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoImage.BackgroundImage = global::LibraryUI.Properties.Resources.Library_Logo1;
            this.LogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoImage.Location = new System.Drawing.Point(47, 6);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(120, 120);
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // EventsMenuButton
            // 
            this.EventsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EventsMenuButton.BackColor = System.Drawing.Color.Teal;
            this.EventsMenuButton.FlatAppearance.BorderSize = 0;
            this.EventsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EventsMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EventsMenuButton.IconChar = FontAwesome.Sharp.IconChar.GroupArrowsRotate;
            this.EventsMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.EventsMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EventsMenuButton.Location = new System.Drawing.Point(0, 229);
            this.EventsMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.EventsMenuButton.Name = "EventsMenuButton";
            this.EventsMenuButton.Size = new System.Drawing.Size(220, 80);
            this.EventsMenuButton.TabIndex = 15;
            this.EventsMenuButton.Text = " E&vents";
            this.EventsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EventsMenuButton.UseVisualStyleBackColor = false;
            this.EventsMenuButton.Click += new System.EventHandler(this.EventsMenuButton_Click);
            // 
            // ReservationsMenuButton
            // 
            this.ReservationsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReservationsMenuButton.BackColor = System.Drawing.Color.Teal;
            this.ReservationsMenuButton.FlatAppearance.BorderSize = 0;
            this.ReservationsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationsMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ReservationsMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationsMenuButton.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.ReservationsMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ReservationsMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReservationsMenuButton.Location = new System.Drawing.Point(0, 389);
            this.ReservationsMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReservationsMenuButton.Name = "ReservationsMenuButton";
            this.ReservationsMenuButton.Rotation = -10D;
            this.ReservationsMenuButton.Size = new System.Drawing.Size(220, 80);
            this.ReservationsMenuButton.TabIndex = 25;
            this.ReservationsMenuButton.Text = " &Reservations";
            this.ReservationsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservationsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservationsMenuButton.UseVisualStyleBackColor = false;
            this.ReservationsMenuButton.Click += new System.EventHandler(this.ReservationsMenuButton_Click);
            // 
            // BranchMenuButton
            // 
            this.BranchMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BranchMenuButton.BackColor = System.Drawing.Color.Teal;
            this.BranchMenuButton.FlatAppearance.BorderSize = 0;
            this.BranchMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BranchMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BranchMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchMenuButton.IconChar = FontAwesome.Sharp.IconChar.City;
            this.BranchMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BranchMenuButton.Location = new System.Drawing.Point(0, 558);
            this.BranchMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.BranchMenuButton.Name = "BranchMenuButton";
            this.BranchMenuButton.Size = new System.Drawing.Size(220, 80);
            this.BranchMenuButton.TabIndex = 40;
            this.BranchMenuButton.Text = " Bra&nch";
            this.BranchMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BranchMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BranchMenuButton.UseVisualStyleBackColor = false;
            this.BranchMenuButton.Click += new System.EventHandler(this.BranchMenuButton_Click);
            // 
            // BookMenuButton
            // 
            this.BookMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BookMenuButton.BackColor = System.Drawing.Color.Teal;
            this.BookMenuButton.FlatAppearance.BorderSize = 0;
            this.BookMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BookMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BookMenuButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BookMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BookMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BookMenuButton.Location = new System.Drawing.Point(0, 149);
            this.BookMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.BookMenuButton.Name = "BookMenuButton";
            this.BookMenuButton.Rotation = -15D;
            this.BookMenuButton.Size = new System.Drawing.Size(220, 80);
            this.BookMenuButton.TabIndex = 10;
            this.BookMenuButton.TabStop = false;
            this.BookMenuButton.Text = " &Books";
            this.BookMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BookMenuButton.UseVisualStyleBackColor = false;
            this.BookMenuButton.Click += new System.EventHandler(this.BookMenuButton_Click);
            // 
            // TransactionsMenuButton
            // 
            this.TransactionsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TransactionsMenuButton.BackColor = System.Drawing.Color.Teal;
            this.TransactionsMenuButton.FlatAppearance.BorderSize = 0;
            this.TransactionsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TransactionsMenuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionsMenuButton.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.TransactionsMenuButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionsMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TransactionsMenuButton.Location = new System.Drawing.Point(0, 309);
            this.TransactionsMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.TransactionsMenuButton.Name = "TransactionsMenuButton";
            this.TransactionsMenuButton.Size = new System.Drawing.Size(220, 80);
            this.TransactionsMenuButton.TabIndex = 20;
            this.TransactionsMenuButton.Text = " &Transactions";
            this.TransactionsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TransactionsMenuButton.UseVisualStyleBackColor = false;
            this.TransactionsMenuButton.Click += new System.EventHandler(this.TransactionsMenuButton_Click);
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.BackColor = System.Drawing.Color.Teal;
            this.TaskBarPanel.Controls.Add(this.MinimizeButton);
            this.TaskBarPanel.Controls.Add(this.MaximizeButton);
            this.TaskBarPanel.Controls.Add(this.Exitbutton);
            this.TaskBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskBarPanel.Name = "TaskBarPanel";
            this.TaskBarPanel.Size = new System.Drawing.Size(1304, 32);
            this.TaskBarPanel.TabIndex = 48;
            this.TaskBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskBarPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Teal;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 27;
            this.MinimizeButton.Location = new System.Drawing.Point(1190, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 32);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackColor = System.Drawing.Color.Teal;
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 27;
            this.MaximizeButton.Location = new System.Drawing.Point(1228, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(38, 32);
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Teal;
            this.Exitbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Exitbutton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Exitbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exitbutton.IconSize = 27;
            this.Exitbutton.Location = new System.Drawing.Point(1266, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(38, 32);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            this.Exitbutton.MouseEnter += new System.EventHandler(this.Exitbutton_MouseEnter);
            this.Exitbutton.MouseLeave += new System.EventHandler(this.Exitbutton_MouseLeave);
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 864);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(1200, 670);
            this.Name = "EmployeeUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseApp);
            this.Load += new System.EventHandler(this.EmployeeUI_Load);
            this.MainPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.TaskBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel FormPanel;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton SettingsMenuButton;
        private FontAwesome.Sharp.IconButton ClientsMenuButton;
        private PictureBox LogoImage;
        private FontAwesome.Sharp.IconButton EventsMenuButton;
        private FontAwesome.Sharp.IconButton ReservationsMenuButton;
        private FontAwesome.Sharp.IconButton BranchMenuButton;
        private FontAwesome.Sharp.IconButton BookMenuButton;
        private FontAwesome.Sharp.IconButton TransactionsMenuButton;
        private Panel TaskBarPanel;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton Exitbutton;
    }
}