namespace LibraryUI.MainUIForms.EmployeeChildForms
{
    partial class EmployeeMainChildForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveEmployeebutton = new FontAwesome.Sharp.IconButton();
            this.UpdateEmployeeButton = new FontAwesome.Sharp.IconButton();
            this.AddEmployeeButton = new FontAwesome.Sharp.IconButton();
            this.ViewEmployeesButton = new FontAwesome.Sharp.IconButton();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.RemoveEmployeebutton);
            this.panel1.Controls.Add(this.UpdateEmployeeButton);
            this.panel1.Controls.Add(this.AddEmployeeButton);
            this.panel1.Controls.Add(this.ViewEmployeesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 60);
            this.panel1.TabIndex = 3;
            // 
            // RemoveEmployeebutton
            // 
            this.RemoveEmployeebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RemoveEmployeebutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveEmployeebutton.FlatAppearance.BorderSize = 0;
            this.RemoveEmployeebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEmployeebutton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RemoveEmployeebutton.ForeColor = System.Drawing.Color.Teal;
            this.RemoveEmployeebutton.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.RemoveEmployeebutton.IconColor = System.Drawing.Color.Teal;
            this.RemoveEmployeebutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemoveEmployeebutton.IconSize = 44;
            this.RemoveEmployeebutton.Location = new System.Drawing.Point(519, 0);
            this.RemoveEmployeebutton.Name = "RemoveEmployeebutton";
            this.RemoveEmployeebutton.Size = new System.Drawing.Size(173, 60);
            this.RemoveEmployeebutton.TabIndex = 12;
            this.RemoveEmployeebutton.Text = "Remove";
            this.RemoveEmployeebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveEmployeebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveEmployeebutton.UseVisualStyleBackColor = false;
            this.RemoveEmployeebutton.Click += new System.EventHandler(this.RemoveEmployeebutton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateEmployeeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdateEmployeeButton.FlatAppearance.BorderSize = 0;
            this.UpdateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployeeButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UpdateEmployeeButton.ForeColor = System.Drawing.Color.Teal;
            this.UpdateEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.UpdateEmployeeButton.IconColor = System.Drawing.Color.Teal;
            this.UpdateEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateEmployeeButton.IconSize = 44;
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(346, 0);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(173, 60);
            this.UpdateEmployeeButton.TabIndex = 11;
            this.UpdateEmployeeButton.Text = "Update";
            this.UpdateEmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateEmployeeButton.UseVisualStyleBackColor = false;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddEmployeeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.Teal;
            this.AddEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddEmployeeButton.IconColor = System.Drawing.Color.Teal;
            this.AddEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddEmployeeButton.IconSize = 44;
            this.AddEmployeeButton.Location = new System.Drawing.Point(173, 0);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(173, 60);
            this.AddEmployeeButton.TabIndex = 8;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // ViewEmployeesButton
            // 
            this.ViewEmployeesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewEmployeesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewEmployeesButton.FlatAppearance.BorderSize = 0;
            this.ViewEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEmployeesButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeesButton.ForeColor = System.Drawing.Color.Teal;
            this.ViewEmployeesButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ViewEmployeesButton.IconColor = System.Drawing.Color.Teal;
            this.ViewEmployeesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewEmployeesButton.IconSize = 44;
            this.ViewEmployeesButton.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeesButton.Name = "ViewEmployeesButton";
            this.ViewEmployeesButton.Size = new System.Drawing.Size(173, 60);
            this.ViewEmployeesButton.TabIndex = 1;
            this.ViewEmployeesButton.Text = "View";
            this.ViewEmployeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewEmployeesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewEmployeesButton.UseVisualStyleBackColor = false;
            this.ViewEmployeesButton.Click += new System.EventHandler(this.ViewEmployeesButton_Click);
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(951, 5);
            this.SplitterPanel.TabIndex = 5;
            // 
            // FormPanel
            // 
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(951, 636);
            this.FormPanel.TabIndex = 6;
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
            this.LogoutButton.Location = new System.Drawing.Point(778, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 13;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmployeeMainChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(951, 701);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeMainChildForm";
            this.Text = "MainEmployeeChildForm";
            this.Load += new System.EventHandler(this.EmployeeMainChildForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ViewEmployeesButton;
        private Panel SplitterPanel;
        private Panel FormPanel;
        private FontAwesome.Sharp.IconButton RemoveEmployeebutton;
        private FontAwesome.Sharp.IconButton UpdateEmployeeButton;
        private FontAwesome.Sharp.IconButton AddEmployeeButton;
        private FontAwesome.Sharp.IconButton LogoutButton;
    }
}