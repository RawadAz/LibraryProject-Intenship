namespace LibraryUI.MainUIForms.BookChildForms.ChildForms
{
    partial class EditbookForm
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
            this.FormTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.RentPriceLabel = new System.Windows.Forms.Label();
            this.RentPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AddBookTitleLabel = new System.Windows.Forms.Label();
            this.PurchasePriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.PurchasePricelabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.BookCopiesLabel = new System.Windows.Forms.Label();
            this.BookCopiesNumeric = new System.Windows.Forms.NumericUpDown();
            this.EditDeletePanel = new System.Windows.Forms.Panel();
            this.DeletebookRB = new System.Windows.Forms.RadioButton();
            this.EditBookRB = new System.Windows.Forms.RadioButton();
            this.DescriptionText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.AuthorNameText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.BookNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.CategoryText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.UpdateOrDeleteBookButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.FormTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCopiesNumeric)).BeginInit();
            this.EditDeletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTablePanel
            // 
            this.FormTablePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTablePanel.ColumnCount = 5;
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.19959F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.03259F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.9776F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.87008F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.299212F));
            this.FormTablePanel.Controls.Add(this.RentPriceLabel, 2, 3);
            this.FormTablePanel.Controls.Add(this.RentPriceNumeric, 3, 3);
            this.FormTablePanel.Controls.Add(this.DescriptionLabel, 0, 5);
            this.FormTablePanel.Controls.Add(this.AddBookTitleLabel, 0, 0);
            this.FormTablePanel.Controls.Add(this.PurchasePriceNumeric, 3, 2);
            this.FormTablePanel.Controls.Add(this.CategoryLabel, 0, 3);
            this.FormTablePanel.Controls.Add(this.AuthorNameLabel, 0, 2);
            this.FormTablePanel.Controls.Add(this.PurchasePricelabel, 2, 2);
            this.FormTablePanel.Controls.Add(this.BookNameLabel, 0, 1);
            this.FormTablePanel.Controls.Add(this.BranchNameLabel, 2, 1);
            this.FormTablePanel.Controls.Add(this.BookCopiesLabel, 0, 4);
            this.FormTablePanel.Controls.Add(this.BookCopiesNumeric, 1, 4);
            this.FormTablePanel.Controls.Add(this.EditDeletePanel, 2, 0);
            this.FormTablePanel.Controls.Add(this.DescriptionText, 1, 5);
            this.FormTablePanel.Controls.Add(this.AuthorNameText, 1, 2);
            this.FormTablePanel.Controls.Add(this.BranchNameComboBox, 3, 1);
            this.FormTablePanel.Controls.Add(this.BookNameComboBox, 1, 1);
            this.FormTablePanel.Controls.Add(this.CategoryText, 1, 3);
            this.FormTablePanel.Controls.Add(this.UpdateOrDeleteBookButton, 3, 5);
            this.FormTablePanel.Controls.Add(this.ResetButton, 3, 6);
            this.FormTablePanel.Controls.Add(this.LoadingLabel, 3, 7);
            this.FormTablePanel.Controls.Add(this.LoadingBar, 2, 6);
            this.FormTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTablePanel.Location = new System.Drawing.Point(0, 0);
            this.FormTablePanel.Name = "FormTablePanel";
            this.FormTablePanel.RowCount = 8;
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16129F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.032258F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.Size = new System.Drawing.Size(1016, 637);
            this.FormTablePanel.TabIndex = 1;
            // 
            // RentPriceLabel
            // 
            this.RentPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RentPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentPriceLabel.ForeColor = System.Drawing.Color.Teal;
            this.RentPriceLabel.Location = new System.Drawing.Point(501, 303);
            this.RentPriceLabel.Name = "RentPriceLabel";
            this.RentPriceLabel.Size = new System.Drawing.Size(143, 25);
            this.RentPriceLabel.TabIndex = 61;
            this.RentPriceLabel.Text = "Rent price :";
            this.RentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RentPriceNumeric
            // 
            this.RentPriceNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentPriceNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RentPriceNumeric.DecimalPlaces = 2;
            this.RentPriceNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentPriceNumeric.ForeColor = System.Drawing.Color.Teal;
            this.RentPriceNumeric.Location = new System.Drawing.Point(682, 298);
            this.RentPriceNumeric.Name = "RentPriceNumeric";
            this.RentPriceNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RentPriceNumeric.Size = new System.Drawing.Size(190, 34);
            this.RentPriceNumeric.TabIndex = 69;
            this.RentPriceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Teal;
            this.DescriptionLabel.Location = new System.Drawing.Point(64, 431);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(157, 68);
            this.DescriptionLabel.TabIndex = 63;
            this.DescriptionLabel.Text = "Description :";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddBookTitleLabel
            // 
            this.FormTablePanel.SetColumnSpan(this.AddBookTitleLabel, 2);
            this.AddBookTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddBookTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.AddBookTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.AddBookTitleLabel.Name = "AddBookTitleLabel";
            this.AddBookTitleLabel.Size = new System.Drawing.Size(347, 115);
            this.AddBookTitleLabel.TabIndex = 55;
            this.AddBookTitleLabel.Text = "Edit Book";
            this.AddBookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchasePriceNumeric
            // 
            this.PurchasePriceNumeric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PurchasePriceNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PurchasePriceNumeric.DecimalPlaces = 2;
            this.PurchasePriceNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PurchasePriceNumeric.ForeColor = System.Drawing.Color.Teal;
            this.PurchasePriceNumeric.Location = new System.Drawing.Point(682, 221);
            this.PurchasePriceNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PurchasePriceNumeric.Name = "PurchasePriceNumeric";
            this.PurchasePriceNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PurchasePriceNumeric.Size = new System.Drawing.Size(190, 34);
            this.PurchasePriceNumeric.TabIndex = 68;
            this.PurchasePriceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.ForeColor = System.Drawing.Color.Teal;
            this.CategoryLabel.Location = new System.Drawing.Point(64, 303);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(157, 25);
            this.CategoryLabel.TabIndex = 58;
            this.CategoryLabel.Text = "Category :";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuthorNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.AuthorNameLabel.Location = new System.Drawing.Point(64, 226);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(157, 25);
            this.AuthorNameLabel.TabIndex = 60;
            this.AuthorNameLabel.Text = "Author Name :";
            this.AuthorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PurchasePricelabel
            // 
            this.PurchasePricelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchasePricelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PurchasePricelabel.ForeColor = System.Drawing.Color.Teal;
            this.PurchasePricelabel.Location = new System.Drawing.Point(501, 226);
            this.PurchasePricelabel.Name = "PurchasePricelabel";
            this.PurchasePricelabel.Size = new System.Drawing.Size(143, 25);
            this.PurchasePricelabel.TabIndex = 57;
            this.PurchasePricelabel.Text = "Purchase Price :";
            this.PurchasePricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BookNameLabel.Location = new System.Drawing.Point(64, 149);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(157, 25);
            this.BookNameLabel.TabIndex = 56;
            this.BookNameLabel.Text = "Book Name :";
            this.BookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(501, 149);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(143, 25);
            this.BranchNameLabel.TabIndex = 78;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookCopiesLabel
            // 
            this.BookCopiesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookCopiesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookCopiesLabel.ForeColor = System.Drawing.Color.Teal;
            this.BookCopiesLabel.Location = new System.Drawing.Point(64, 380);
            this.BookCopiesLabel.Name = "BookCopiesLabel";
            this.BookCopiesLabel.Size = new System.Drawing.Size(157, 25);
            this.BookCopiesLabel.TabIndex = 62;
            this.BookCopiesLabel.Text = "Book Copies :";
            this.BookCopiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookCopiesNumeric
            // 
            this.BookCopiesNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookCopiesNumeric.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BookCopiesNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookCopiesNumeric.ForeColor = System.Drawing.Color.Teal;
            this.BookCopiesNumeric.Location = new System.Drawing.Point(227, 375);
            this.BookCopiesNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.BookCopiesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BookCopiesNumeric.Name = "BookCopiesNumeric";
            this.BookCopiesNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BookCopiesNumeric.Size = new System.Drawing.Size(236, 34);
            this.BookCopiesNumeric.TabIndex = 71;
            this.BookCopiesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BookCopiesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EditDeletePanel
            // 
            this.FormTablePanel.SetColumnSpan(this.EditDeletePanel, 2);
            this.EditDeletePanel.Controls.Add(this.DeletebookRB);
            this.EditDeletePanel.Controls.Add(this.EditBookRB);
            this.EditDeletePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditDeletePanel.Location = new System.Drawing.Point(470, 3);
            this.EditDeletePanel.Name = "EditDeletePanel";
            this.EditDeletePanel.Size = new System.Drawing.Size(477, 117);
            this.EditDeletePanel.TabIndex = 80;
            // 
            // DeletebookRB
            // 
            this.DeletebookRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeletebookRB.AutoSize = true;
            this.DeletebookRB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletebookRB.ForeColor = System.Drawing.Color.Teal;
            this.DeletebookRB.Location = new System.Drawing.Point(251, 83);
            this.DeletebookRB.Name = "DeletebookRB";
            this.DeletebookRB.Size = new System.Drawing.Size(161, 29);
            this.DeletebookRB.TabIndex = 1;
            this.DeletebookRB.Text = "Remove a Book";
            this.DeletebookRB.UseVisualStyleBackColor = true;
            // 
            // EditBookRB
            // 
            this.EditBookRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBookRB.AutoSize = true;
            this.EditBookRB.Checked = true;
            this.EditBookRB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBookRB.ForeColor = System.Drawing.Color.Teal;
            this.EditBookRB.Location = new System.Drawing.Point(33, 83);
            this.EditBookRB.Name = "EditBookRB";
            this.EditBookRB.Size = new System.Drawing.Size(155, 29);
            this.EditBookRB.TabIndex = 0;
            this.EditBookRB.TabStop = true;
            this.EditBookRB.Text = "Update a Book";
            this.EditBookRB.UseVisualStyleBackColor = true;
            this.EditBookRB.CheckedChanged += new System.EventHandler(this.EditBookRB_CheckedChanged);
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionText.BorderColor = System.Drawing.Color.Teal;
            this.DescriptionText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.DescriptionText.BorderSize = 2;
            this.FormTablePanel.SetColumnSpan(this.DescriptionText, 2);
            this.DescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionText.ForeColor = System.Drawing.Color.Black;
            this.DescriptionText.Location = new System.Drawing.Point(227, 434);
            this.DescriptionText.MultiLine = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionText.PasswordChar = false;
            this.DescriptionText.PlaceHolder = "Description";
            this.DescriptionText.Size = new System.Drawing.Size(449, 122);
            this.DescriptionText.TabIndex = 81;
            this.DescriptionText.Texts = "";
            this.DescriptionText.Underlined = false;
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AuthorNameText.BorderColor = System.Drawing.Color.Teal;
            this.AuthorNameText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.AuthorNameText.BorderSize = 2;
            this.AuthorNameText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorNameText.ForeColor = System.Drawing.Color.Black;
            this.AuthorNameText.Location = new System.Drawing.Point(227, 218);
            this.AuthorNameText.MultiLine = false;
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Padding = new System.Windows.Forms.Padding(7);
            this.AuthorNameText.PasswordChar = false;
            this.AuthorNameText.PlaceHolder = "Author Name";
            this.AuthorNameText.Size = new System.Drawing.Size(236, 40);
            this.AuthorNameText.TabIndex = 83;
            this.AuthorNameText.Texts = "";
            this.AuthorNameText.Underlined = true;
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BranchNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BranchNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.BorderSize = 4;
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(682, 142);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 38);
            this.BranchNameComboBox.TabIndex = 84;
            this.BranchNameComboBox.Texts = "";
            this.BranchNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BranchIdComboBox_OnSelectedIndexChanged);
            // 
            // BookNameComboBox
            // 
            this.BookNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BookNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BookNameComboBox.BorderSize = 4;
            this.BookNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BookNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BookNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BookNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BookNameComboBox.Location = new System.Drawing.Point(227, 142);
            this.BookNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BookNameComboBox.Name = "BookNameComboBox";
            this.BookNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BookNameComboBox.Size = new System.Drawing.Size(236, 38);
            this.BookNameComboBox.TabIndex = 85;
            this.BookNameComboBox.Texts = "";
            this.BookNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BookNameComboBox_OnSelectedIndexChanged);
            // 
            // CategoryText
            // 
            this.CategoryText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryText.BorderColor = System.Drawing.Color.Teal;
            this.CategoryText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.CategoryText.BorderSize = 2;
            this.CategoryText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryText.ForeColor = System.Drawing.Color.Black;
            this.CategoryText.Location = new System.Drawing.Point(227, 295);
            this.CategoryText.MultiLine = false;
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Padding = new System.Windows.Forms.Padding(7);
            this.CategoryText.PasswordChar = false;
            this.CategoryText.PlaceHolder = "Category";
            this.CategoryText.Size = new System.Drawing.Size(236, 40);
            this.CategoryText.TabIndex = 86;
            this.CategoryText.Texts = "";
            this.CategoryText.Underlined = true;
            // 
            // UpdateOrDeleteBookButton
            // 
            this.UpdateOrDeleteBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateOrDeleteBookButton.BackColor = System.Drawing.Color.Teal;
            this.UpdateOrDeleteBookButton.BorderRadius = 25;
            this.UpdateOrDeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateOrDeleteBookButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateOrDeleteBookButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateOrDeleteBookButton.Location = new System.Drawing.Point(751, 502);
            this.UpdateOrDeleteBookButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateOrDeleteBookButton.Name = "UpdateOrDeleteBookButton";
            this.UpdateOrDeleteBookButton.Size = new System.Drawing.Size(199, 57);
            this.UpdateOrDeleteBookButton.TabIndex = 87;
            this.UpdateOrDeleteBookButton.Text = "Update Book";
            this.UpdateOrDeleteBookButton.UseVisualStyleBackColor = false;
            this.UpdateOrDeleteBookButton.Click += new System.EventHandler(this.UpdateOrDeleteBookButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ResetButton.BorderRadius = 25;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(844, 559);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 47);
            this.ResetButton.TabIndex = 88;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormTablePanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(682, 610);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(281, 27);
            this.LoadingLabel.TabIndex = 76;
            this.LoadingLabel.Text = "Updating book, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
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
            this.LoadingBar.Location = new System.Drawing.Point(642, 600);
            this.LoadingBar.MarqueeAnimationSpeed = 2000;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.OuterMargin = -25;
            this.LoadingBar.OuterWidth = 26;
            this.LoadingBar.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.LoadingBar.ProgressWidth = 22;
            this.FormTablePanel.SetRowSpan(this.LoadingBar, 2);
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
            this.LoadingBar.TabIndex = 89;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // EditbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 637);
            this.Controls.Add(this.FormTablePanel);
            this.Name = "EditbookForm";
            this.Text = "EditbookForm";
            this.Load += new System.EventHandler(this.EditbookForm_Load);
            this.FormTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCopiesNumeric)).EndInit();
            this.EditDeletePanel.ResumeLayout(false);
            this.EditDeletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTablePanel;
        private Label BookNameLabel;
        private Label RentPriceLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox DescriptionText;
        private NumericUpDown RentPriceNumeric;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private Label DescriptionLabel;
        private Label AddBookTitleLabel;
        private Label LoadingLabel;
        private NumericUpDown PurchasePriceNumeric;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox CategoryText;
        private Label CategoryLabel;
        private Label AuthorNameLabel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox AuthorNameText;
        private Label PurchasePricelabel;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private Label BookCopiesLabel;
        private NumericUpDown BookCopiesNumeric;
        private Label BranchNameLabel;
        private Panel EditDeletePanel;
        private RadioButton DeletebookRB;
        private RadioButton EditBookRB;
        private AdditionalControls.CustomComboBox.CustomComboBox BookNameComboBox;
        private AdditionalControls.Buttons.RoundedButton UpdateOrDeleteBookButton;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}