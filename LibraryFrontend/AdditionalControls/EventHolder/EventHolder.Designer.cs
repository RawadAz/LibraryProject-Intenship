namespace LibraryUI.AdditionalControls.EventHolder
{
    partial class EventHolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HolderPanel = new System.Windows.Forms.Panel();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.FeeText = new System.Windows.Forms.Label();
            this.ReserveSeatbutton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.ReccurenceTitleLabel = new System.Windows.Forms.Label();
            this.ReccurenceTextLabel = new System.Windows.Forms.Label();
            this.AvaialableSeatsTitleLabel = new System.Windows.Forms.Label();
            this.AvailableSeatsTextLabel = new System.Windows.Forms.Label();
            this.BranchNameTitleLabel = new System.Windows.Forms.Label();
            this.branchNameTextLabel = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.HolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HolderPanel
            // 
            this.HolderPanel.AutoScroll = true;
            this.HolderPanel.AutoSize = true;
            this.HolderPanel.BackColor = System.Drawing.Color.Teal;
            this.HolderPanel.Controls.Add(this.FeeLabel);
            this.HolderPanel.Controls.Add(this.FeeText);
            this.HolderPanel.Controls.Add(this.ReserveSeatbutton);
            this.HolderPanel.Controls.Add(this.DescriptionText);
            this.HolderPanel.Controls.Add(this.ReccurenceTitleLabel);
            this.HolderPanel.Controls.Add(this.ReccurenceTextLabel);
            this.HolderPanel.Controls.Add(this.AvaialableSeatsTitleLabel);
            this.HolderPanel.Controls.Add(this.AvailableSeatsTextLabel);
            this.HolderPanel.Controls.Add(this.BranchNameTitleLabel);
            this.HolderPanel.Controls.Add(this.branchNameTextLabel);
            this.HolderPanel.Controls.Add(this.EventDateLabel);
            this.HolderPanel.Controls.Add(this.EventNameLabel);
            this.HolderPanel.Controls.Add(this.iconPictureBox);
            this.HolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HolderPanel.Location = new System.Drawing.Point(0, 0);
            this.HolderPanel.Name = "HolderPanel";
            this.HolderPanel.Size = new System.Drawing.Size(905, 227);
            this.HolderPanel.TabIndex = 0;
            // 
            // FeeLabel
            // 
            this.FeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FeeLabel.Location = new System.Drawing.Point(563, 128);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(102, 28);
            this.FeeLabel.TabIndex = 14;
            this.FeeLabel.Text = "Fee/Seat: ";
            // 
            // FeeText
            // 
            this.FeeText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FeeText.AutoSize = true;
            this.FeeText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeeText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FeeText.Location = new System.Drawing.Point(671, 128);
            this.FeeText.Name = "FeeText";
            this.FeeText.Size = new System.Drawing.Size(34, 28);
            this.FeeText.TabIndex = 13;
            this.FeeText.Text = "0$";
            // 
            // ReserveSeatbutton
            // 
            this.ReserveSeatbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReserveSeatbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ReserveSeatbutton.BorderRadius = 25;
            this.ReserveSeatbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveSeatbutton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReserveSeatbutton.ForeColor = System.Drawing.Color.Teal;
            this.ReserveSeatbutton.Location = new System.Drawing.Point(699, 172);
            this.ReserveSeatbutton.Name = "ReserveSeatbutton";
            this.ReserveSeatbutton.Size = new System.Drawing.Size(180, 46);
            this.ReserveSeatbutton.TabIndex = 12;
            this.ReserveSeatbutton.Text = "Reserve a Seat";
            this.ReserveSeatbutton.UseVisualStyleBackColor = false;
            this.ReserveSeatbutton.Click += new System.EventHandler(this.ReserveSeatbutton_Click);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriptionText.BackColor = System.Drawing.Color.Teal;
            this.DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DescriptionText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionText.Location = new System.Drawing.Point(126, 125);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionText.Size = new System.Drawing.Size(405, 93);
            this.DescriptionText.TabIndex = 11;
            this.DescriptionText.Text = "Description";
            // 
            // ReccurenceTitleLabel
            // 
            this.ReccurenceTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReccurenceTitleLabel.AutoSize = true;
            this.ReccurenceTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReccurenceTitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReccurenceTitleLabel.Location = new System.Drawing.Point(563, 88);
            this.ReccurenceTitleLabel.Name = "ReccurenceTitleLabel";
            this.ReccurenceTitleLabel.Size = new System.Drawing.Size(72, 28);
            this.ReccurenceTitleLabel.TabIndex = 10;
            this.ReccurenceTitleLabel.Text = "Held : ";
            // 
            // ReccurenceTextLabel
            // 
            this.ReccurenceTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReccurenceTextLabel.AutoSize = true;
            this.ReccurenceTextLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReccurenceTextLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReccurenceTextLabel.Location = new System.Drawing.Point(642, 88);
            this.ReccurenceTextLabel.Name = "ReccurenceTextLabel";
            this.ReccurenceTextLabel.Size = new System.Drawing.Size(110, 28);
            this.ReccurenceTextLabel.TabIndex = 9;
            this.ReccurenceTextLabel.Text = "reccurence";
            // 
            // AvaialableSeatsTitleLabel
            // 
            this.AvaialableSeatsTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvaialableSeatsTitleLabel.AutoSize = true;
            this.AvaialableSeatsTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvaialableSeatsTitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AvaialableSeatsTitleLabel.Location = new System.Drawing.Point(563, 48);
            this.AvaialableSeatsTitleLabel.Name = "AvaialableSeatsTitleLabel";
            this.AvaialableSeatsTitleLabel.Size = new System.Drawing.Size(112, 28);
            this.AvaialableSeatsTitleLabel.TabIndex = 8;
            this.AvaialableSeatsTitleLabel.Text = "Seats Left :";
            // 
            // AvailableSeatsTextLabel
            // 
            this.AvailableSeatsTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvailableSeatsTextLabel.AutoSize = true;
            this.AvailableSeatsTextLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvailableSeatsTextLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AvailableSeatsTextLabel.Location = new System.Drawing.Point(681, 48);
            this.AvailableSeatsTextLabel.Name = "AvailableSeatsTextLabel";
            this.AvailableSeatsTextLabel.Size = new System.Drawing.Size(60, 28);
            this.AvailableSeatsTextLabel.TabIndex = 7;
            this.AvailableSeatsTextLabel.Text = "Seats";
            // 
            // BranchNameTitleLabel
            // 
            this.BranchNameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BranchNameTitleLabel.AutoSize = true;
            this.BranchNameTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameTitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameTitleLabel.Location = new System.Drawing.Point(563, 8);
            this.BranchNameTitleLabel.Name = "BranchNameTitleLabel";
            this.BranchNameTitleLabel.Size = new System.Drawing.Size(85, 28);
            this.BranchNameTitleLabel.TabIndex = 6;
            this.BranchNameTitleLabel.Text = "Branch :";
            // 
            // branchNameTextLabel
            // 
            this.branchNameTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.branchNameTextLabel.AutoSize = true;
            this.branchNameTextLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchNameTextLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.branchNameTextLabel.Location = new System.Drawing.Point(654, 8);
            this.branchNameTextLabel.Name = "branchNameTextLabel";
            this.branchNameTextLabel.Size = new System.Drawing.Size(134, 28);
            this.branchNameTextLabel.TabIndex = 5;
            this.branchNameTextLabel.Text = "Branch Name";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EventDateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EventDateLabel.Location = new System.Drawing.Point(158, 62);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(115, 28);
            this.EventDateLabel.TabIndex = 4;
            this.EventDateLabel.Text = "Event Date";
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameLabel.Location = new System.Drawing.Point(126, 20);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(176, 38);
            this.EventNameLabel.TabIndex = 3;
            this.EventNameLabel.Text = "Event Name";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconPictureBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox.IconSize = 70;
            this.iconPictureBox.Location = new System.Drawing.Point(35, 20);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(70, 70);
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            // 
            // EventHolder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.HolderPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(824, 227);
            this.Name = "EventHolder";
            this.Size = new System.Drawing.Size(905, 227);
            this.HolderPanel.ResumeLayout(false);
            this.HolderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel HolderPanel;
        private Label EventNameLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox;
        private Buttons.RoundedButton ReserveSeatbutton;
        private TextBox DescriptionText;
        private Label ReccurenceTitleLabel;
        private Label ReccurenceTextLabel;
        private Label AvaialableSeatsTitleLabel;
        private Label AvailableSeatsTextLabel;
        private Label BranchNameTitleLabel;
        private Label branchNameTextLabel;
        private Label EventDateLabel;
        private Label FeeLabel;
        private Label FeeText;
    }
}
