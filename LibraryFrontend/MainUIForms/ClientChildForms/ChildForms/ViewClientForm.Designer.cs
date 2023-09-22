namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms
{
    partial class ViewClientForm
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
            this.ViewEmployeeLayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchText = new LibraryUI.AdditionalControls.UnderlinedTextbox.UnderlinedTextbox();
            this.SearchComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.GetClientButton = new System.Windows.Forms.Button();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ViewClientTitleLabel = new System.Windows.Forms.Label();
            this.ViewClientsDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedBooks = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.ViewEmployeeLayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewClientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewEmployeeLayoutpanel
            // 
            this.ViewEmployeeLayoutpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewEmployeeLayoutpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewEmployeeLayoutpanel.ColumnCount = 4;
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.502636F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.82074F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.85589F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.732865F));
            this.ViewEmployeeLayoutpanel.Controls.Add(this.SearchText, 1, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.SearchComboBox, 2, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.GetClientButton, 2, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingLabel, 1, 4);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewClientTitleLabel, 0, 0);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewClientsDGV, 0, 3);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingBar, 0, 4);
            this.ViewEmployeeLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEmployeeLayoutpanel.ForeColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ViewEmployeeLayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeeLayoutpanel.Name = "ViewEmployeeLayoutpanel";
            this.ViewEmployeeLayoutpanel.RowCount = 5;
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.54658F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.937888F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.50311F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.998444F));
            this.ViewEmployeeLayoutpanel.Size = new System.Drawing.Size(1094, 649);
            this.ViewEmployeeLayoutpanel.TabIndex = 13;
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
            this.SearchText.Location = new System.Drawing.Point(480, 124);
            this.SearchText.MultiLine = false;
            this.SearchText.Name = "SearchText";
            this.SearchText.Padding = new System.Windows.Forms.Padding(7);
            this.SearchText.PasswordChar = false;
            this.SearchText.PlaceHolder = "";
            this.SearchText.Size = new System.Drawing.Size(221, 43);
            this.SearchText.TabIndex = 10;
            this.SearchText.Texts = "";
            this.SearchText.Underlined = true;
            this.SearchText.Visible = false;
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchComboBox.BackColor = System.Drawing.Color.Teal;
            this.SearchComboBox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.BorderSize = 1;
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.Items.AddRange(new object[] {
            "All",
            "Id",
            "First Name",
            "Phone Number"});
            this.SearchComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SearchComboBox.Location = new System.Drawing.Point(756, 125);
            this.SearchComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.SearchComboBox.Size = new System.Drawing.Size(200, 42);
            this.SearchComboBox.TabIndex = 1;
            this.SearchComboBox.Texts = "All";
            this.SearchComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SearchComboBox_OnSelectedIndexChanged);
            // 
            // GetClientButton
            // 
            this.GetClientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetClientButton.BackColor = System.Drawing.Color.Teal;
            this.GetClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetClientButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetClientButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GetClientButton.Location = new System.Drawing.Point(756, 192);
            this.GetClientButton.Name = "GetClientButton";
            this.GetClientButton.Size = new System.Drawing.Size(200, 42);
            this.GetClientButton.TabIndex = 5;
            this.GetClientButton.Text = "View Client";
            this.GetClientButton.UseVisualStyleBackColor = false;
            this.GetClientButton.Click += new System.EventHandler(this.GetClientButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(74, 612);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(279, 37);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading Clients, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // ViewClientTitleLabel
            // 
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewClientTitleLabel, 2);
            this.ViewClientTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ViewClientTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ViewClientTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ViewClientTitleLabel.Name = "ViewClientTitleLabel";
            this.ViewClientTitleLabel.Size = new System.Drawing.Size(383, 113);
            this.ViewClientTitleLabel.TabIndex = 56;
            this.ViewClientTitleLabel.Text = "View Clients";
            this.ViewClientTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewClientsDGV
            // 
            this.ViewClientsDGV.AutoGenerateColumns = false;
            this.ViewClientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewClientsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewClientsDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ViewClientsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewClientsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewClientsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewClientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewClientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.currentlyRentedDataGridViewTextBoxColumn,
            this.RentedBooks});
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewClientsDGV, 4);
            this.ViewClientsDGV.DataSource = this.clientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewClientsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewClientsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewClientsDGV.EnableHeadersVisualStyles = false;
            this.ViewClientsDGV.GridColor = System.Drawing.Color.Teal;
            this.ViewClientsDGV.Location = new System.Drawing.Point(3, 251);
            this.ViewClientsDGV.Name = "ViewClientsDGV";
            this.ViewClientsDGV.ReadOnly = true;
            this.ViewClientsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewClientsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewClientsDGV.RowHeadersWidth = 51;
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ViewClientsDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewClientsDGV.RowTemplate.Height = 30;
            this.ViewClientsDGV.RowTemplate.ReadOnly = true;
            this.ViewClientsDGV.Size = new System.Drawing.Size(1088, 348);
            this.ViewClientsDGV.TabIndex = 57;
            this.ViewClientsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewClientsDTV_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Nb";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentlyRentedDataGridViewTextBoxColumn
            // 
            this.currentlyRentedDataGridViewTextBoxColumn.DataPropertyName = "Currently_Rented";
            this.currentlyRentedDataGridViewTextBoxColumn.HeaderText = "Rented Books";
            this.currentlyRentedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentlyRentedDataGridViewTextBoxColumn.Name = "currentlyRentedDataGridViewTextBoxColumn";
            this.currentlyRentedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RentedBooks
            // 
            this.RentedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentedBooks.HeaderText = "Books Info";
            this.RentedBooks.MinimumWidth = 6;
            this.RentedBooks.Name = "RentedBooks";
            this.RentedBooks.ReadOnly = true;
            this.RentedBooks.Text = "view books";
            this.RentedBooks.UseColumnTextForButtonValue = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ClassLibrary.Models.Client.Client);
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
            this.LoadingBar.Location = new System.Drawing.Point(34, 612);
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
            // ViewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 649);
            this.Controls.Add(this.ViewEmployeeLayoutpanel);
            this.Name = "ViewClientForm";
            this.Text = "ViewClientForm";
            this.Load += new System.EventHandler(this.ViewClientForm_Load);
            this.Resize += new System.EventHandler(this.ViewClientForm_Resize);
            this.ViewEmployeeLayoutpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewClientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ViewEmployeeLayoutpanel;
        private AdditionalControls.UnderlinedTextbox.UnderlinedTextbox SearchText;
        private AdditionalControls.CustomComboBox.CustomComboBox SearchComboBox;
        private Button GetClientButton;
        private Label LoadingLabel;
        private Label ViewClientTitleLabel;
        private BindingSource clientBindingSource;
        private DataGridView ViewClientsDGV;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentlyRentedDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn RentedBooks;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}