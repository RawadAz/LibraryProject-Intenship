using ClassLibrary.Models.Transaction.DTOs;

namespace LibraryUI.MainUIForms.BookChildForms.ChildForms
{
    partial class ReturnDatesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.ReturnDatesTitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SearchButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.BranchNameLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ReturnDatesDTV = new System.Windows.Forms.DataGridView();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDatesDTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDateDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.002216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.99895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.02543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.30621F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.62767F));
            this.tableLayoutPanel1.Controls.Add(this.LoadingBar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ReturnDatesTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadingLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.SearchButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BranchNameLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BookNameLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BranchNameComboBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.SearchLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnDatesDTV, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BookNameComboBox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 528);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.LoadingBar.Location = new System.Drawing.Point(12, 491);
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
            this.LoadingBar.TabIndex = 76;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // ReturnDatesTitleLabel
            // 
            this.ReturnDatesTitleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ReturnDatesTitleLabel, 3);
            this.ReturnDatesTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnDatesTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ReturnDatesTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ReturnDatesTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ReturnDatesTitleLabel.Name = "ReturnDatesTitleLabel";
            this.ReturnDatesTitleLabel.Size = new System.Drawing.Size(436, 105);
            this.ReturnDatesTitleLabel.TabIndex = 1;
            this.ReturnDatesTitleLabel.Text = "Return Dates";
            this.ReturnDatesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(52, 493);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(296, 35);
            this.LoadingLabel.TabIndex = 61;
            this.LoadingLabel.Text = "Retrieving return dates, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.BackColor = System.Drawing.Color.Teal;
            this.SearchButton.BorderRadius = 30;
            this.tableLayoutPanel1.SetColumnSpan(this.SearchButton, 2);
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.Location = new System.Drawing.Point(148, 344);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(194, 60);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BranchNameLabel
            // 
            this.BranchNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BranchNameLabel.Location = new System.Drawing.Point(59, 236);
            this.BranchNameLabel.Name = "BranchNameLabel";
            this.BranchNameLabel.Size = new System.Drawing.Size(134, 41);
            this.BranchNameLabel.TabIndex = 4;
            this.BranchNameLabel.Text = "Branch Name :";
            this.BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.BookNameLabel.Location = new System.Drawing.Point(59, 168);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(134, 31);
            this.BookNameLabel.TabIndex = 3;
            this.BookNameLabel.Text = "Book Name :";
            this.BookNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BranchNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.BorderSize = 4;
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(199, 239);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 38);
            this.BranchNameComboBox.TabIndex = 73;
            this.BranchNameComboBox.Texts = "";
            this.BranchNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BranchNameComboBox_OnSelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.Color.Teal;
            this.SearchLabel.Location = new System.Drawing.Point(445, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.tableLayoutPanel1.SetRowSpan(this.SearchLabel, 2);
            this.SearchLabel.Size = new System.Drawing.Size(518, 131);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Want to check return dates? Enter the needed info and search";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ReturnDatesDTV
            // 
            this.ReturnDatesDTV.AutoGenerateColumns = false;
            this.ReturnDatesDTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnDatesDTV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReturnDatesDTV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ReturnDatesDTV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReturnDatesDTV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDatesDTV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReturnDatesDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnDatesDTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNameDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.copiesDataGridViewTextBoxColumn});
            this.ReturnDatesDTV.DataSource = this.returnDateDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDatesDTV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReturnDatesDTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnDatesDTV.EnableHeadersVisualStyles = false;
            this.ReturnDatesDTV.GridColor = System.Drawing.Color.Teal;
            this.ReturnDatesDTV.Location = new System.Drawing.Point(445, 134);
            this.ReturnDatesDTV.Name = "ReturnDatesDTV";
            this.ReturnDatesDTV.ReadOnly = true;
            this.ReturnDatesDTV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDatesDTV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ReturnDatesDTV.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.ReturnDatesDTV, 3);
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ReturnDatesDTV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDatesDTV.RowTemplate.Height = 30;
            this.ReturnDatesDTV.RowTemplate.ReadOnly = true;
            this.ReturnDatesDTV.Size = new System.Drawing.Size(518, 309);
            this.ReturnDatesDTV.TabIndex = 74;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // copiesDataGridViewTextBoxColumn
            // 
            this.copiesDataGridViewTextBoxColumn.DataPropertyName = "Copies";
            this.copiesDataGridViewTextBoxColumn.HeaderText = "Copies";
            this.copiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.copiesDataGridViewTextBoxColumn.Name = "copiesDataGridViewTextBoxColumn";
            this.copiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDTOBindingSource
            // 
            this.returnDateDTOBindingSource.DataSource = typeof(ClassLibrary.Models.Transaction.DTOs.ReturnDateDTO);
            // 
            // BookNameComboBox
            // 
            this.BookNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BookNameComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BookNameComboBox.BorderSize = 4;
            this.BookNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BookNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BookNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BookNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BookNameComboBox.Location = new System.Drawing.Point(199, 164);
            this.BookNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BookNameComboBox.Name = "BookNameComboBox";
            this.BookNameComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.BookNameComboBox.Size = new System.Drawing.Size(228, 38);
            this.BookNameComboBox.TabIndex = 75;
            this.BookNameComboBox.Texts = "";
            // 
            // ReturnDatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(983, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReturnDatesForm";
            this.Text = "ReturnDatesForm";
            this.Load += new System.EventHandler(this.ReturnDatesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDatesDTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDateDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ReturnDatesTitleLabel;
        private Label SearchLabel;
        private Label BookNameLabel;
        private Label BranchNameLabel;
        private AdditionalControls.Buttons.RoundedButton SearchButton;
        private Label LoadingLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private BindingSource returnDateDTOBindingSource;
        private DataGridView ReturnDatesDTV;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copiesDataGridViewTextBoxColumn;
        private AdditionalControls.CustomComboBox.CustomComboBox BookNameComboBox;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}