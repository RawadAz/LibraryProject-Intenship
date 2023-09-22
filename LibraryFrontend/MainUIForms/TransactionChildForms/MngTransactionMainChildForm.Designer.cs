namespace LibraryUI.MainUIForms.TransactionChildForms
{
    partial class MngTransactionMainChildForm
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
            this.ViewTransactionsButton = new FontAwesome.Sharp.IconButton();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SubMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubMenuPanel.Controls.Add(this.LogoutButton);
            this.SubMenuPanel.Controls.Add(this.ViewTransactionsButton);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(1073, 60);
            this.SubMenuPanel.TabIndex = 2;
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
            this.LogoutButton.Location = new System.Drawing.Point(900, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(173, 60);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ViewTransactionsButton
            // 
            this.ViewTransactionsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewTransactionsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewTransactionsButton.FlatAppearance.BorderSize = 0;
            this.ViewTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTransactionsButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewTransactionsButton.ForeColor = System.Drawing.Color.Teal;
            this.ViewTransactionsButton.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.ViewTransactionsButton.IconColor = System.Drawing.Color.Teal;
            this.ViewTransactionsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewTransactionsButton.IconSize = 44;
            this.ViewTransactionsButton.Location = new System.Drawing.Point(0, 0);
            this.ViewTransactionsButton.Name = "ViewTransactionsButton";
            this.ViewTransactionsButton.Size = new System.Drawing.Size(207, 60);
            this.ViewTransactionsButton.TabIndex = 1;
            this.ViewTransactionsButton.Text = "View";
            this.ViewTransactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewTransactionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewTransactionsButton.UseVisualStyleBackColor = false;
            this.ViewTransactionsButton.Click += new System.EventHandler(this.ViewTransactionsButton_Click);
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackColor = System.Drawing.Color.Teal;
            this.SplitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel.Location = new System.Drawing.Point(0, 60);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(1073, 5);
            this.SplitterPanel.TabIndex = 4;
            // 
            // FormPanel
            // 
            this.FormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 65);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1073, 531);
            this.FormPanel.TabIndex = 5;
            // 
            // TransactionMainChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 596);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.SubMenuPanel);
            this.Name = "TransactionMainChildForm";
            this.Text = "TransactionMainChildForm";
            this.Load += new System.EventHandler(this.TransactionMainChildForm_Load);
            this.SubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SubMenuPanel;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private FontAwesome.Sharp.IconButton ViewTransactionsButton;
        private Panel SplitterPanel;
        private Panel FormPanel;
    }
}