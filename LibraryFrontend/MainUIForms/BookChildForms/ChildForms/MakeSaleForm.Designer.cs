namespace LibraryUI.MainUIForms.BookChildForms.ChildForms
{
    partial class MakeSaleForm
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
            this.FormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EnterInfoLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BranchNameLabek = new System.Windows.Forms.Label();
            this.BookNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.BranchNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SaleTypeLabel = new System.Windows.Forms.Label();
            this.UsernameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.SaleTypeComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.MakeSaleButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ClientPhoneNumberLabel = new System.Windows.Forms.Label();
            this.CopiesNumeric = new System.Windows.Forms.NumericUpDown();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationNumeric = new System.Windows.Forms.NumericUpDown();
            this.LatePenaltyLabel = new System.Windows.Forms.Label();
            this.LatePenaltyNumeric = new System.Windows.Forms.NumericUpDown();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.newClientLabel = new System.Windows.Forms.Label();
            this.AddNewClientLabelButton = new System.Windows.Forms.Label();
            this.ClientPhoneNbComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.FormTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopiesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatePenaltyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTableLayoutPanel
            // 
            this.FormTableLayoutPanel.ColumnCount = 6;
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75852F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.32425F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4742F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.27167F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.497566F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTableLayoutPanel.Controls.Add(this.LoadingBar, 0, 8);
            this.FormTableLayoutPanel.Controls.Add(this.TitleLabel, 1, 0);
            this.FormTableLayoutPanel.Controls.Add(this.EnterInfoLabel, 1, 1);
            this.FormTableLayoutPanel.Controls.Add(this.BookNameLabel, 1, 2);
            this.FormTableLayoutPanel.Controls.Add(this.BranchNameLabek, 1, 3);
            this.FormTableLayoutPanel.Controls.Add(this.BookNameText, 2, 2);
            this.FormTableLayoutPanel.Controls.Add(this.BranchNameText, 2, 3);
            this.FormTableLayoutPanel.Controls.Add(this.UsernameLabel, 3, 1);
            this.FormTableLayoutPanel.Controls.Add(this.SaleTypeLabel, 3, 2);
            this.FormTableLayoutPanel.Controls.Add(this.UsernameText, 4, 1);
            this.FormTableLayoutPanel.Controls.Add(this.SaleTypeComboBox, 4, 2);
            this.FormTableLayoutPanel.Controls.Add(this.ResetButton, 4, 7);
            this.FormTableLayoutPanel.Controls.Add(this.MakeSaleButton, 4, 6);
            this.FormTableLayoutPanel.Controls.Add(this.ClientPhoneNumberLabel, 1, 4);
            this.FormTableLayoutPanel.Controls.Add(this.CopiesNumeric, 2, 5);
            this.FormTableLayoutPanel.Controls.Add(this.CopiesLabel, 1, 5);
            this.FormTableLayoutPanel.Controls.Add(this.DurationLabel, 1, 6);
            this.FormTableLayoutPanel.Controls.Add(this.DurationNumeric, 2, 6);
            this.FormTableLayoutPanel.Controls.Add(this.LatePenaltyLabel, 1, 7);
            this.FormTableLayoutPanel.Controls.Add(this.LatePenaltyNumeric, 2, 7);
            this.FormTableLayoutPanel.Controls.Add(this.TotalPriceLabel, 3, 4);
            this.FormTableLayoutPanel.Controls.Add(this.TotalPriceText, 4, 4);
            this.FormTableLayoutPanel.Controls.Add(this.LoadingLabel, 1, 8);
            this.FormTableLayoutPanel.Controls.Add(this.newClientLabel, 3, 8);
            this.FormTableLayoutPanel.Controls.Add(this.AddNewClientLabelButton, 4, 8);
            this.FormTableLayoutPanel.Controls.Add(this.ClientPhoneNbComboBox, 2, 4);
            this.FormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FormTableLayoutPanel.Name = "FormTableLayoutPanel";
            this.FormTableLayoutPanel.RowCount = 9;
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54422F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54422F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.693877F));
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.972789F));
            this.FormTableLayoutPanel.Size = new System.Drawing.Size(1027, 588);
            this.FormTableLayoutPanel.TabIndex = 0;
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
            this.LoadingBar.Location = new System.Drawing.Point(14, 551);
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
            this.LoadingBar.TabIndex = 73;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleLabel.AutoSize = true;
            this.FormTableLayoutPanel.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.TitleLabel.Location = new System.Drawing.Point(54, 50);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(214, 38);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Making a Sale?";
            // 
            // EnterInfoLabel
            // 
            this.EnterInfoLabel.AutoSize = true;
            this.FormTableLayoutPanel.SetColumnSpan(this.EnterInfoLabel, 2);
            this.EnterInfoLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EnterInfoLabel.ForeColor = System.Drawing.Color.Teal;
            this.EnterInfoLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EnterInfoLabel.Location = new System.Drawing.Point(54, 88);
            this.EnterInfoLabel.Name = "EnterInfoLabel";
            this.EnterInfoLabel.Size = new System.Drawing.Size(289, 31);
            this.EnterInfoLabel.TabIndex = 0;
            this.EnterInfoLabel.Text = "Please enter the needed info";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BookNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BookNameLabel.Location = new System.Drawing.Point(54, 188);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(237, 46);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "Book Name :";
            this.BookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BranchNameLabek
            // 
            this.BranchNameLabek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchNameLabek.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabek.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabek.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BranchNameLabek.Location = new System.Drawing.Point(54, 250);
            this.BranchNameLabek.Name = "BranchNameLabek";
            this.BranchNameLabek.Size = new System.Drawing.Size(237, 46);
            this.BranchNameLabek.TabIndex = 0;
            this.BranchNameLabek.Text = "Branch Name :";
            this.BranchNameLabek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookNameText
            // 
            this.BookNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BookNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BookNameText.BorderColor = System.Drawing.Color.Transparent;
            this.BookNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.BookNameText.BorderSize = 2;
            this.BookNameText.Enabled = false;
            this.BookNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookNameText.ForeColor = System.Drawing.Color.Black;
            this.BookNameText.Location = new System.Drawing.Point(297, 188);
            this.BookNameText.MultiLine = false;
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Padding = new System.Windows.Forms.Padding(7);
            this.BookNameText.PasswordChar = false;
            this.BookNameText.PlaceHolder = "Name";
            this.BookNameText.Size = new System.Drawing.Size(212, 43);
            this.BookNameText.TabIndex = 0;
            this.BookNameText.Texts = "";
            this.BookNameText.Underlined = true;
            // 
            // BranchNameText
            // 
            this.BranchNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BranchNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameText.BorderColor = System.Drawing.Color.Transparent;
            this.BranchNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.BranchNameText.BorderSize = 2;
            this.BranchNameText.Enabled = false;
            this.BranchNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchNameText.ForeColor = System.Drawing.Color.Black;
            this.BranchNameText.Location = new System.Drawing.Point(297, 250);
            this.BranchNameText.MultiLine = false;
            this.BranchNameText.Name = "BranchNameText";
            this.BranchNameText.Padding = new System.Windows.Forms.Padding(7);
            this.BranchNameText.PasswordChar = false;
            this.BranchNameText.PlaceHolder = "Name";
            this.BranchNameText.Size = new System.Drawing.Size(212, 43);
            this.BranchNameText.TabIndex = 0;
            this.BranchNameText.Texts = "";
            this.BranchNameText.Underlined = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.Teal;
            this.UsernameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UsernameLabel.Location = new System.Drawing.Point(515, 128);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(193, 48);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username :";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaleTypeLabel
            // 
            this.SaleTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaleTypeLabel.ForeColor = System.Drawing.Color.Teal;
            this.SaleTypeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SaleTypeLabel.Location = new System.Drawing.Point(515, 176);
            this.SaleTypeLabel.Name = "SaleTypeLabel";
            this.SaleTypeLabel.Size = new System.Drawing.Size(193, 58);
            this.SaleTypeLabel.TabIndex = 0;
            this.SaleTypeLabel.Text = "Sale Type  :";
            this.SaleTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsernameText
            // 
            this.UsernameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsernameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameText.BorderColor = System.Drawing.Color.Transparent;
            this.UsernameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.UsernameText.BorderSize = 2;
            this.UsernameText.Enabled = false;
            this.UsernameText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UsernameText.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameText.Location = new System.Drawing.Point(714, 128);
            this.UsernameText.MultiLine = false;
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Padding = new System.Windows.Forms.Padding(7);
            this.UsernameText.PasswordChar = false;
            this.UsernameText.PlaceHolder = "username";
            this.UsernameText.Size = new System.Drawing.Size(172, 45);
            this.UsernameText.TabIndex = 0;
            this.UsernameText.Texts = "";
            this.UsernameText.Underlined = true;
            // 
            // SaleTypeComboBox
            // 
            this.SaleTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaleTypeComboBox.BackColor = System.Drawing.Color.Teal;
            this.SaleTypeComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SaleTypeComboBox.BorderSize = 4;
            this.SaleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaleTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaleTypeComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaleTypeComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SaleTypeComboBox.Items.AddRange(new object[] {
            "Purchase",
            "Rent"});
            this.SaleTypeComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SaleTypeComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SaleTypeComboBox.Location = new System.Drawing.Point(714, 186);
            this.SaleTypeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SaleTypeComboBox.Name = "SaleTypeComboBox";
            this.SaleTypeComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.SaleTypeComboBox.Size = new System.Drawing.Size(204, 45);
            this.SaleTypeComboBox.TabIndex = 50;
            this.SaleTypeComboBox.Texts = "";
            this.SaleTypeComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SaleTypeComboBox_OnSelectedIndexChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ResetButton.BorderRadius = 25;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(833, 487);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 47);
            this.ResetButton.TabIndex = 70;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MakeSaleButton
            // 
            this.MakeSaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeSaleButton.BackColor = System.Drawing.Color.Teal;
            this.MakeSaleButton.BorderRadius = 25;
            this.MakeSaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeSaleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MakeSaleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MakeSaleButton.Location = new System.Drawing.Point(758, 432);
            this.MakeSaleButton.Margin = new System.Windows.Forms.Padding(0);
            this.MakeSaleButton.Name = "MakeSaleButton";
            this.MakeSaleButton.Size = new System.Drawing.Size(191, 55);
            this.MakeSaleButton.TabIndex = 60;
            this.MakeSaleButton.Text = "Make Sale";
            this.MakeSaleButton.UseVisualStyleBackColor = false;
            this.MakeSaleButton.Click += new System.EventHandler(this.MakeSaleButton_Click);
            // 
            // ClientPhoneNumberLabel
            // 
            this.ClientPhoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientPhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.ClientPhoneNumberLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ClientPhoneNumberLabel.Location = new System.Drawing.Point(54, 316);
            this.ClientPhoneNumberLabel.Name = "ClientPhoneNumberLabel";
            this.ClientPhoneNumberLabel.Size = new System.Drawing.Size(237, 46);
            this.ClientPhoneNumberLabel.TabIndex = 0;
            this.ClientPhoneNumberLabel.Text = "Client Phone Nb :";
            this.ClientPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CopiesNumeric
            // 
            this.CopiesNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopiesNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CopiesNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopiesNumeric.ForeColor = System.Drawing.Color.Teal;
            this.CopiesNumeric.Location = new System.Drawing.Point(297, 388);
            this.CopiesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CopiesNumeric.Name = "CopiesNumeric";
            this.CopiesNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CopiesNumeric.Size = new System.Drawing.Size(200, 34);
            this.CopiesNumeric.TabIndex = 20;
            this.CopiesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CopiesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CopiesNumeric.ValueChanged += new System.EventHandler(this.CopiesNumeric_ValueChanged);
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopiesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopiesLabel.ForeColor = System.Drawing.Color.Teal;
            this.CopiesLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CopiesLabel.Location = new System.Drawing.Point(54, 388);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(237, 37);
            this.CopiesLabel.TabIndex = 0;
            this.CopiesLabel.Text = "Copies :";
            this.CopiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DurationLabel.ForeColor = System.Drawing.Color.Teal;
            this.DurationLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DurationLabel.Location = new System.Drawing.Point(54, 450);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(237, 37);
            this.DurationLabel.TabIndex = 0;
            this.DurationLabel.Text = "Duration(months) :";
            this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DurationNumeric
            // 
            this.DurationNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DurationNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DurationNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DurationNumeric.ForeColor = System.Drawing.Color.Teal;
            this.DurationNumeric.Location = new System.Drawing.Point(297, 450);
            this.DurationNumeric.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DurationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationNumeric.Name = "DurationNumeric";
            this.DurationNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DurationNumeric.Size = new System.Drawing.Size(200, 34);
            this.DurationNumeric.TabIndex = 30;
            this.DurationNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DurationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LatePenaltyLabel
            // 
            this.LatePenaltyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LatePenaltyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LatePenaltyLabel.ForeColor = System.Drawing.Color.Teal;
            this.LatePenaltyLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LatePenaltyLabel.Location = new System.Drawing.Point(54, 507);
            this.LatePenaltyLabel.Name = "LatePenaltyLabel";
            this.LatePenaltyLabel.Size = new System.Drawing.Size(237, 37);
            this.LatePenaltyLabel.TabIndex = 0;
            this.LatePenaltyLabel.Text = "Late Penalty(%) : ";
            this.LatePenaltyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LatePenaltyNumeric
            // 
            this.LatePenaltyNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LatePenaltyNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LatePenaltyNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatePenaltyNumeric.ForeColor = System.Drawing.Color.Teal;
            this.LatePenaltyNumeric.Location = new System.Drawing.Point(297, 507);
            this.LatePenaltyNumeric.Name = "LatePenaltyNumeric";
            this.LatePenaltyNumeric.Size = new System.Drawing.Size(200, 34);
            this.LatePenaltyNumeric.TabIndex = 40;
            this.LatePenaltyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LatePenaltyNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.Teal;
            this.TotalPriceLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TotalPriceLabel.Location = new System.Drawing.Point(515, 304);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(193, 58);
            this.TotalPriceLabel.TabIndex = 0;
            this.TotalPriceLabel.Text = "Total Price :";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalPriceText.BorderColor = System.Drawing.Color.Transparent;
            this.TotalPriceText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.TotalPriceText.BorderSize = 2;
            this.TotalPriceText.Enabled = false;
            this.TotalPriceText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceText.ForeColor = System.Drawing.Color.DimGray;
            this.TotalPriceText.Location = new System.Drawing.Point(714, 314);
            this.TotalPriceText.MultiLine = false;
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.Padding = new System.Windows.Forms.Padding(7);
            this.TotalPriceText.PasswordChar = false;
            this.TotalPriceText.PlaceHolder = "0$";
            this.TotalPriceText.Size = new System.Drawing.Size(172, 45);
            this.TotalPriceText.TabIndex = 0;
            this.TotalPriceText.Texts = "";
            this.TotalPriceText.Underlined = true;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormTableLayoutPanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(54, 557);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(289, 31);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Transaction is being processed, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // newClientLabel
            // 
            this.newClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.newClientLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.newClientLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newClientLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newClientLabel.Location = new System.Drawing.Point(584, 547);
            this.newClientLabel.Name = "newClientLabel";
            this.newClientLabel.Size = new System.Drawing.Size(124, 41);
            this.newClientLabel.TabIndex = 71;
            this.newClientLabel.Text = "New Client?";
            this.newClientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewClientLabelButton
            // 
            this.AddNewClientLabelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewClientLabelButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNewClientLabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewClientLabelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddNewClientLabelButton.ForeColor = System.Drawing.Color.Teal;
            this.AddNewClientLabelButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddNewClientLabelButton.Location = new System.Drawing.Point(714, 547);
            this.AddNewClientLabelButton.Name = "AddNewClientLabelButton";
            this.AddNewClientLabelButton.Size = new System.Drawing.Size(138, 41);
            this.AddNewClientLabelButton.TabIndex = 72;
            this.AddNewClientLabelButton.Text = "Add to clients";
            this.AddNewClientLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewClientLabelButton.Click += new System.EventHandler(this.AddNewClientLabelButton_Click);
            // 
            // ClientPhoneNbComboBox
            // 
            this.ClientPhoneNbComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClientPhoneNbComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ClientPhoneNbComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientPhoneNbComboBox.BackColor = System.Drawing.Color.Teal;
            this.ClientPhoneNbComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ClientPhoneNbComboBox.BorderSize = 4;
            this.ClientPhoneNbComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ClientPhoneNbComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientPhoneNbComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ClientPhoneNbComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientPhoneNbComboBox.ListForeColor = System.Drawing.Color.Black;
            this.ClientPhoneNbComboBox.Location = new System.Drawing.Point(297, 310);
            this.ClientPhoneNbComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.ClientPhoneNbComboBox.Name = "ClientPhoneNbComboBox";
            this.ClientPhoneNbComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientPhoneNbComboBox.Size = new System.Drawing.Size(200, 38);
            this.ClientPhoneNbComboBox.TabIndex = 95;
            this.ClientPhoneNbComboBox.Texts = "";
            // 
            // MakeSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1027, 588);
            this.Controls.Add(this.FormTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(857, 519);
            this.Name = "MakeSaleForm";
            this.Text = "MakeSaleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MakeSaleForm_FormClosed);
            this.Load += new System.EventHandler(this.MakeSaleForm_Load);
            this.FormTableLayoutPanel.ResumeLayout(false);
            this.FormTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopiesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatePenaltyNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTableLayoutPanel;
        private Label BranchNameLabek;
        private Label TitleLabel;
        private Label EnterInfoLabel;
        private Label BookNameLabel;
        private Label ClientPhoneNumberLabel;
        private Label DurationLabel;
        private Label LatePenaltyLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox BookNameText;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox BranchNameText;
        private NumericUpDown DurationNumeric;
        private NumericUpDown LatePenaltyNumeric;
        private Label UsernameLabel;
        private Label SaleTypeLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox UsernameText;
        private AdditionalControls.CustomComboBox.CustomComboBox SaleTypeComboBox;
        private AdditionalControls.Buttons.RoundedButton MakeSaleButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private Label CopiesLabel;
        private NumericUpDown CopiesNumeric;
        private Label TotalPriceLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox TotalPriceText;
        private Label LoadingLabel;
        private Label newClientLabel;
        private Label AddNewClientLabelButton;
        private CircularProgressBar.CircularProgressBar LoadingBar;
        private AdditionalControls.CustomComboBox.CustomComboBox ClientPhoneNbComboBox;
    }
}