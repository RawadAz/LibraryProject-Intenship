namespace LibraryUI.MainUIForms.ReservationsChildForms.ChildForms
{
    partial class EditReservationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.EditReservationTitleLabel = new System.Windows.Forms.Label();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.EventNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.BranchNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.TicketsLabel = new System.Windows.Forms.Label();
            this.TicketsNumeric = new System.Windows.Forms.NumericUpDown();
            this.UpdateReservationButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.FeeText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalFeeText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.34188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.34043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.19149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.23404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.LoadingBar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.EditReservationTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FeeLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EventNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoadingLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.EventNameText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BranchNameText, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TicketsLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TicketsNumeric, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.UpdateReservationButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.FeeText, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.TotalFeeText, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 635);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.LoadingBar.AnimationSpeed = 500;
            this.LoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingBar.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadingBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.InnerMargin = 2;
            this.LoadingBar.InnerWidth = -1;
            this.LoadingBar.Location = new System.Drawing.Point(14, 598);
            this.LoadingBar.MarqueeAnimationSpeed = 2000;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.OuterMargin = -25;
            this.LoadingBar.OuterWidth = 26;
            this.LoadingBar.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.LoadingBar.ProgressWidth = 22;
            this.LoadingBar.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadingBar.Size = new System.Drawing.Size(34, 34);
            this.LoadingBar.StartAngle = 270;
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LoadingBar.SubscriptText = ".23";
            this.LoadingBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LoadingBar.SuperscriptText = "°C";
            this.LoadingBar.TabIndex = 93;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // EditReservationTitleLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.EditReservationTitleLabel, 3);
            this.EditReservationTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.EditReservationTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.EditReservationTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.EditReservationTitleLabel.Name = "EditReservationTitleLabel";
            this.EditReservationTitleLabel.Size = new System.Drawing.Size(407, 127);
            this.EditReservationTitleLabel.TabIndex = 58;
            this.EditReservationTitleLabel.Text = "Edit a Reservation";
            this.EditReservationTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FeeLabel
            // 
            this.FeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeeLabel.ForeColor = System.Drawing.Color.Teal;
            this.FeeLabel.Location = new System.Drawing.Point(117, 344);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(189, 40);
            this.FeeLabel.TabIndex = 61;
            this.FeeLabel.Text = "Fee/ticket ($) :";
            this.FeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FeeLabel.UseMnemonic = false;
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EventNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.EventNameLabel.Location = new System.Drawing.Point(117, 154);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(189, 40);
            this.EventNameLabel.TabIndex = 66;
            this.EventNameLabel.Text = "Event name :";
            this.EventNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventNameLabel.UseMnemonic = false;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(54, 598);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(378, 37);
            this.LoadingLabel.TabIndex = 82;
            this.LoadingLabel.Text = "Updating Reservation Info, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightGray;
            this.ResetButton.BorderRadius = 30;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(811, 510);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(144, 60);
            this.ResetButton.TabIndex = 78;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // EventNameText
            // 
            this.EventNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EventNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.EventNameText.BorderSize = 0;
            this.EventNameText.Enabled = false;
            this.EventNameText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EventNameText.ForeColor = System.Drawing.Color.DimGray;
            this.EventNameText.Location = new System.Drawing.Point(312, 152);
            this.EventNameText.MultiLine = false;
            this.EventNameText.Name = "EventNameText";
            this.EventNameText.Padding = new System.Windows.Forms.Padding(7);
            this.EventNameText.PasswordChar = false;
            this.EventNameText.PlaceHolder = "name";
            this.EventNameText.Size = new System.Drawing.Size(240, 45);
            this.EventNameText.TabIndex = 83;
            this.EventNameText.Texts = "";
            this.EventNameText.Underlined = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(577, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 84;
            this.label1.Text = "Branch name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // BranchNameText
            // 
            this.BranchNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BranchNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.BranchNameText.BorderSize = 0;
            this.BranchNameText.Enabled = false;
            this.BranchNameText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BranchNameText.ForeColor = System.Drawing.Color.DimGray;
            this.BranchNameText.Location = new System.Drawing.Point(748, 152);
            this.BranchNameText.MultiLine = false;
            this.BranchNameText.Name = "BranchNameText";
            this.BranchNameText.Padding = new System.Windows.Forms.Padding(7);
            this.BranchNameText.PasswordChar = false;
            this.BranchNameText.PlaceHolder = "name";
            this.BranchNameText.Size = new System.Drawing.Size(193, 45);
            this.BranchNameText.TabIndex = 85;
            this.BranchNameText.Texts = "";
            this.BranchNameText.Underlined = true;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(117, 249);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(189, 40);
            this.PhoneNumberLabel.TabIndex = 64;
            this.PhoneNumberLabel.Text = "Client Phone Nb :";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneNumberLabel.UseMnemonic = false;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumberText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumberText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.PhoneNumberText.BorderSize = 0;
            this.PhoneNumberText.Enabled = false;
            this.PhoneNumberText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberText.ForeColor = System.Drawing.Color.DimGray;
            this.PhoneNumberText.Location = new System.Drawing.Point(312, 247);
            this.PhoneNumberText.MultiLine = false;
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Padding = new System.Windows.Forms.Padding(7);
            this.PhoneNumberText.PasswordChar = false;
            this.PhoneNumberText.PlaceHolder = "phone number";
            this.PhoneNumberText.Size = new System.Drawing.Size(240, 45);
            this.PhoneNumberText.TabIndex = 86;
            this.PhoneNumberText.Texts = "";
            this.PhoneNumberText.Underlined = true;
            // 
            // TicketsLabel
            // 
            this.TicketsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TicketsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicketsLabel.ForeColor = System.Drawing.Color.Teal;
            this.TicketsLabel.Location = new System.Drawing.Point(117, 439);
            this.TicketsLabel.Name = "TicketsLabel";
            this.TicketsLabel.Size = new System.Drawing.Size(189, 40);
            this.TicketsLabel.TabIndex = 87;
            this.TicketsLabel.Text = "Tickets:";
            this.TicketsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TicketsLabel.UseMnemonic = false;
            // 
            // TicketsNumeric
            // 
            this.TicketsNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TicketsNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TicketsNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketsNumeric.ForeColor = System.Drawing.Color.Teal;
            this.TicketsNumeric.Location = new System.Drawing.Point(346, 442);
            this.TicketsNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TicketsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketsNumeric.Name = "TicketsNumeric";
            this.TicketsNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TicketsNumeric.Size = new System.Drawing.Size(188, 34);
            this.TicketsNumeric.TabIndex = 89;
            this.TicketsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TicketsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketsNumeric.ValueChanged += new System.EventHandler(this.TicketsNumeric_ValueChanged);
            // 
            // UpdateReservationButton
            // 
            this.UpdateReservationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateReservationButton.BackColor = System.Drawing.Color.Teal;
            this.UpdateReservationButton.BorderRadius = 30;
            this.UpdateReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateReservationButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateReservationButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateReservationButton.Location = new System.Drawing.Point(752, 444);
            this.UpdateReservationButton.Name = "UpdateReservationButton";
            this.UpdateReservationButton.Size = new System.Drawing.Size(203, 60);
            this.UpdateReservationButton.TabIndex = 77;
            this.UpdateReservationButton.Text = "Update Reservation";
            this.UpdateReservationButton.UseVisualStyleBackColor = false;
            this.UpdateReservationButton.Click += new System.EventHandler(this.UpdateReservationButton_Click);
            // 
            // FeeText
            // 
            this.FeeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FeeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FeeText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.FeeText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.FeeText.BorderSize = 0;
            this.FeeText.Enabled = false;
            this.FeeText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FeeText.ForeColor = System.Drawing.Color.DimGray;
            this.FeeText.Location = new System.Drawing.Point(312, 342);
            this.FeeText.MultiLine = false;
            this.FeeText.Name = "FeeText";
            this.FeeText.Padding = new System.Windows.Forms.Padding(7);
            this.FeeText.PasswordChar = false;
            this.FeeText.PlaceHolder = "0$";
            this.FeeText.Size = new System.Drawing.Size(240, 45);
            this.FeeText.TabIndex = 90;
            this.FeeText.Texts = "";
            this.FeeText.Underlined = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(577, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 40);
            this.label2.TabIndex = 91;
            this.label2.Text = "Total Fee ($) :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // TotalFeeText
            // 
            this.TotalFeeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalFeeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalFeeText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.TotalFeeText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TotalFeeText.BorderSize = 0;
            this.TotalFeeText.Enabled = false;
            this.TotalFeeText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TotalFeeText.ForeColor = System.Drawing.Color.DimGray;
            this.TotalFeeText.Location = new System.Drawing.Point(748, 342);
            this.TotalFeeText.MultiLine = false;
            this.TotalFeeText.Name = "TotalFeeText";
            this.TotalFeeText.Padding = new System.Windows.Forms.Padding(7);
            this.TotalFeeText.PasswordChar = false;
            this.TotalFeeText.PlaceHolder = "0$";
            this.TotalFeeText.Size = new System.Drawing.Size(193, 45);
            this.TotalFeeText.TabIndex = 92;
            this.TotalFeeText.Texts = "";
            this.TotalFeeText.Underlined = true;
            // 
            // EditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(978, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(932, 452);
            this.Name = "EditReservationForm";
            this.Text = "EditReservationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditReservationForm_FormClosed);
            this.Load += new System.EventHandler(this.EditReservationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label EditReservationTitleLabel;
        private Label FeeLabel;
        private Label PhoneNumberLabel;
        private Label EventNameLabel;
        private Label LoadingLabel;
        private AdditionalControls.Buttons.RoundedButton UpdateReservationButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox EventNameText;
        private Label label1;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox BranchNameText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox PhoneNumberText;
        private Label TicketsLabel;
        private NumericUpDown TicketsNumeric;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox FeeText;
        private Label label2;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox TotalFeeText;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}