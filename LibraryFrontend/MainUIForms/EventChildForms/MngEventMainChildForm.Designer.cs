namespace LibraryUI.MainUIForms.EventChildForms
{
    partial class MngEventMainChildForm
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
            this.EditEventButton = new FontAwesome.Sharp.IconButton();
            this.AddEventButton = new FontAwesome.Sharp.IconButton();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.ViewEventsButton = new FontAwesome.Sharp.IconButton();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SubMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.AutoScroll = true;
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.EditEventButton);
            this.SubMenuPanel.Controls.Add(this.AddEventButton);
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Controls.Add(this.ViewEventsButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(943, 60);
            this.SubMenuPanel.TabIndex = 3;
            // 
            // EditEventButton
            // 
            this.EditEventButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EditEventButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditEventButton.FlatAppearance.BorderSize = 0;
            this.EditEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEventButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EditEventButton.ForeColor = System.Drawing.Color.Teal;
            this.EditEventButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.EditEventButton.IconColor = System.Drawing.Color.Teal;
            this.EditEventButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditEventButton.IconSize = 44;
            this.EditEventButton.Location = new System.Drawing.Point(414, 0);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(207, 60);
            this.EditEventButton.TabIndex = 5;
            this.EditEventButton.Text = "Edit";
            this.EditEventButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditEventButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditEventButton.UseVisualStyleBackColor = false;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // AddEventButton
            // 
            this.AddEventButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddEventButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddEventButton.FlatAppearance.BorderSize = 0;
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddEventButton.ForeColor = System.Drawing.Color.Teal;
            this.AddEventButton.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.AddEventButton.IconColor = System.Drawing.Color.Teal;
            this.AddEventButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddEventButton.IconSize = 44;
            this.AddEventButton.Location = new System.Drawing.Point(207, 0);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(207, 60);
            this.AddEventButton.TabIndex = 4;
            this.AddEventButton.Text = "Add";
            this.AddEventButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEventButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEventButton.UseVisualStyleBackColor = false;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
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
            this.LogoutButton.Location = new System.Drawing.Point(770, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ViewEventsButton
            // 
            this.ViewEventsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewEventsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewEventsButton.FlatAppearance.BorderSize = 0;
            this.ViewEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEventsButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEventsButton.ForeColor = System.Drawing.Color.Teal;
            this.ViewEventsButton.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.ViewEventsButton.IconColor = System.Drawing.Color.Teal;
            this.ViewEventsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewEventsButton.IconSize = 44;
            this.ViewEventsButton.Location = new System.Drawing.Point(0, 0);
            this.ViewEventsButton.Name = "ViewEventsButton";
            this.ViewEventsButton.Size = new System.Drawing.Size(207, 60);
            this.ViewEventsButton.TabIndex = 1;
            this.ViewEventsButton.Text = "View";
            this.ViewEventsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewEventsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewEventsButton.UseVisualStyleBackColor = false;
            this.ViewEventsButton.Click += new System.EventHandler(this.ViewEventsButton_Click);
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(943, 5);
            this.SplitterPanel.TabIndex = 5;
            // 
            // FormPanel
            // 
            this.FormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(943, 499);
            this.FormPanel.TabIndex = 6;
            // 
            // EventMainChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 564);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "EventMainChildForm";
            this.Text = "EventMainChildForm";
            this.Load += new System.EventHandler(this.EventMainChildForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private FontAwesome.Sharp.IconButton ViewEventsButton;
        private Panel SplitterPanel;
        private Panel FormPanel;
        private FontAwesome.Sharp.IconButton AddEventButton;
        private FontAwesome.Sharp.IconButton EditEventButton;
    }
}