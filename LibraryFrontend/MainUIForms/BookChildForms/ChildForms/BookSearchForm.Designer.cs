namespace LibraryUI.MainUIForms.BookChildForms.ChildForms
{
    partial class BookSearchForm
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
            this.FormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.SearchResultFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTitleLabel = new System.Windows.Forms.Label();
            this.SearchMethodLabel = new System.Windows.Forms.Label();
            this.SearchMethodComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.SearchButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.SearchText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SearchResultLabel = new System.Windows.Forms.Label();
            this.FormTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTableLayout
            // 
            this.FormTableLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTableLayout.ColumnCount = 5;
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.99197F));
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.29719F));
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.2249F));
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80723F));
            this.FormTableLayout.Controls.Add(this.LoadingBar, 3, 3);
            this.FormTableLayout.Controls.Add(this.SearchResultFlowPanel, 0, 4);
            this.FormTableLayout.Controls.Add(this.SearchTitleLabel, 0, 0);
            this.FormTableLayout.Controls.Add(this.SearchMethodLabel, 2, 1);
            this.FormTableLayout.Controls.Add(this.SearchMethodComboBox, 3, 1);
            this.FormTableLayout.Controls.Add(this.SearchButton, 3, 2);
            this.FormTableLayout.Controls.Add(this.SearchText, 2, 2);
            this.FormTableLayout.Controls.Add(this.LoadingLabel, 4, 3);
            this.FormTableLayout.Controls.Add(this.SearchResultLabel, 0, 3);
            this.FormTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FormTableLayout.Name = "FormTableLayout";
            this.FormTableLayout.RowCount = 5;
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.96063F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3937F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1811F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70866F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.75591F));
            this.FormTableLayout.Size = new System.Drawing.Size(996, 635);
            this.FormTableLayout.TabIndex = 0;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.LoadingBar.AnimationSpeed = 500;
            this.LoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingBar.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadingBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.LoadingBar.InnerMargin = 2;
            this.LoadingBar.InnerWidth = -1;
            this.LoadingBar.Location = new System.Drawing.Point(691, 233);
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
            // SearchResultFlowPanel
            // 
            this.SearchResultFlowPanel.AutoScroll = true;
            this.SearchResultFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.FormTableLayout.SetColumnSpan(this.SearchResultFlowPanel, 5);
            this.SearchResultFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultFlowPanel.Location = new System.Drawing.Point(3, 300);
            this.SearchResultFlowPanel.Name = "SearchResultFlowPanel";
            this.SearchResultFlowPanel.Size = new System.Drawing.Size(990, 332);
            this.SearchResultFlowPanel.TabIndex = 63;
            // 
            // SearchTitleLabel
            // 
            this.FormTableLayout.SetColumnSpan(this.SearchTitleLabel, 2);
            this.SearchTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SearchTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.SearchTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchTitleLabel.Name = "SearchTitleLabel";
            this.SearchTitleLabel.Size = new System.Drawing.Size(420, 95);
            this.SearchTitleLabel.TabIndex = 54;
            this.SearchTitleLabel.Text = "Searching For a Book?";
            this.SearchTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchMethodLabel
            // 
            this.SearchMethodLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchMethodLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchMethodLabel.ForeColor = System.Drawing.Color.Teal;
            this.SearchMethodLabel.Location = new System.Drawing.Point(519, 113);
            this.SearchMethodLabel.Name = "SearchMethodLabel";
            this.SearchMethodLabel.Size = new System.Drawing.Size(145, 28);
            this.SearchMethodLabel.TabIndex = 55;
            this.SearchMethodLabel.Text = "Search By :";
            this.SearchMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchMethodComboBox
            // 
            this.SearchMethodComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchMethodComboBox.BackColor = System.Drawing.Color.Teal;
            this.SearchMethodComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SearchMethodComboBox.BorderSize = 4;
            this.FormTableLayout.SetColumnSpan(this.SearchMethodComboBox, 2);
            this.SearchMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchMethodComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchMethodComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SearchMethodComboBox.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Category"});
            this.SearchMethodComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchMethodComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SearchMethodComboBox.Location = new System.Drawing.Point(713, 108);
            this.SearchMethodComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SearchMethodComboBox.Name = "SearchMethodComboBox";
            this.SearchMethodComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.SearchMethodComboBox.Size = new System.Drawing.Size(236, 38);
            this.SearchMethodComboBox.TabIndex = 56;
            this.SearchMethodComboBox.Texts = "";
            this.SearchMethodComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SearchMethodComboBox_OnSelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.BackColor = System.Drawing.Color.Teal;
            this.SearchButton.BorderRadius = 25;
            this.FormTableLayout.SetColumnSpan(this.SearchButton, 2);
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.Location = new System.Drawing.Point(757, 172);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(149, 45);
            this.SearchButton.TabIndex = 57;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchText.BorderColor = System.Drawing.Color.Teal;
            this.SearchText.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.SearchText.BorderSize = 2;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchText.ForeColor = System.Drawing.Color.Black;
            this.SearchText.Location = new System.Drawing.Point(481, 173);
            this.SearchText.MultiLine = false;
            this.SearchText.Name = "SearchText";
            this.SearchText.Padding = new System.Windows.Forms.Padding(7);
            this.SearchText.PasswordChar = false;
            this.SearchText.PlaceHolder = "";
            this.SearchText.Size = new System.Drawing.Size(183, 43);
            this.SearchText.TabIndex = 59;
            this.SearchText.Texts = "";
            this.SearchText.Underlined = true;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(731, 230);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(195, 35);
            this.LoadingLabel.TabIndex = 60;
            this.LoadingLabel.Text = "Searching, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LoadingLabel.Visible = false;
            // 
            // SearchResultLabel
            // 
            this.SearchResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormTableLayout.SetColumnSpan(this.SearchResultLabel, 2);
            this.SearchResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchResultLabel.ForeColor = System.Drawing.Color.Teal;
            this.SearchResultLabel.Location = new System.Drawing.Point(3, 230);
            this.SearchResultLabel.Name = "SearchResultLabel";
            this.SearchResultLabel.Padding = new System.Windows.Forms.Padding(10);
            this.SearchResultLabel.Size = new System.Drawing.Size(420, 67);
            this.SearchResultLabel.TabIndex = 62;
            this.SearchResultLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 635);
            this.Controls.Add(this.FormTableLayout);
            this.Name = "BookSearchForm";
            this.Text = "BookSearchForm";
            this.Load += new System.EventHandler(this.BookSearchForm_Load);
            this.FormTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTableLayout;
        private Label SearchTitleLabel;
        private Label SearchMethodLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox SearchMethodComboBox;
        private AdditionalControls.Buttons.RoundedButton SearchButton;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox SearchText;
        private Label LoadingLabel;
        private Label SearchResultLabel;
        private FlowLayoutPanel SearchResultFlowPanel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}