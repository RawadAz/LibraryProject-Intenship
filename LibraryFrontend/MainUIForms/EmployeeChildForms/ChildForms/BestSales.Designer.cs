namespace LibraryUI.MainUIForms.EmployeeChildForms.ChildForms
{
    partial class BestSales
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
            this.FormTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeSalesTitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.EmployeeSalesDGV = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRevenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.FormTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalesDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTablePanel
            // 
            this.FormTablePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormTablePanel.ColumnCount = 4;
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.497175F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.80791F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0439F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.445997F));
            this.FormTablePanel.Controls.Add(this.LoadingBar, 0, 2);
            this.FormTablePanel.Controls.Add(this.EmployeeSalesTitleLabel, 0, 0);
            this.FormTablePanel.Controls.Add(this.LoadingLabel, 1, 2);
            this.FormTablePanel.Controls.Add(this.EmployeeSalesDGV, 0, 1);
            this.FormTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTablePanel.Location = new System.Drawing.Point(0, 0);
            this.FormTablePanel.Name = "FormTablePanel";
            this.FormTablePanel.RowCount = 3;
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.95903F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.33784F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.70312F));
            this.FormTablePanel.Size = new System.Drawing.Size(884, 338);
            this.FormTablePanel.TabIndex = 0;
            // 
            // EmployeeSalesTitleLabel
            // 
            this.FormTablePanel.SetColumnSpan(this.EmployeeSalesTitleLabel, 3);
            this.EmployeeSalesTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeSalesTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.EmployeeSalesTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.EmployeeSalesTitleLabel.Name = "EmployeeSalesTitleLabel";
            this.EmployeeSalesTitleLabel.Size = new System.Drawing.Size(309, 60);
            this.EmployeeSalesTitleLabel.TabIndex = 76;
            this.EmployeeSalesTitleLabel.Text = "Employee Sales";
            this.EmployeeSalesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormTablePanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(60, 307);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(407, 31);
            this.LoadingLabel.TabIndex = 79;
            this.LoadingLabel.Text = "Loading employees sales, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // EmployeeSalesDGV
            // 
            this.EmployeeSalesDGV.AutoGenerateColumns = false;
            this.EmployeeSalesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeSalesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeSalesDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.EmployeeSalesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeSalesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeSalesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeSalesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeSalesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.booksSoldDataGridViewTextBoxColumn,
            this.totalRevenueDataGridViewTextBoxColumn});
            this.FormTablePanel.SetColumnSpan(this.EmployeeSalesDGV, 4);
            this.EmployeeSalesDGV.DataSource = this.employeeSalesDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeSalesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeSalesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeSalesDGV.EnableHeadersVisualStyles = false;
            this.EmployeeSalesDGV.GridColor = System.Drawing.Color.Teal;
            this.EmployeeSalesDGV.Location = new System.Drawing.Point(3, 63);
            this.EmployeeSalesDGV.Name = "EmployeeSalesDGV";
            this.EmployeeSalesDGV.ReadOnly = true;
            this.EmployeeSalesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeSalesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeSalesDGV.RowHeadersWidth = 51;
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.EmployeeSalesDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeSalesDGV.RowTemplate.Height = 30;
            this.EmployeeSalesDGV.RowTemplate.ReadOnly = true;
            this.EmployeeSalesDGV.Size = new System.Drawing.Size(878, 228);
            this.EmployeeSalesDGV.TabIndex = 80;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksSoldDataGridViewTextBoxColumn
            // 
            this.booksSoldDataGridViewTextBoxColumn.DataPropertyName = "Books_Sold";
            this.booksSoldDataGridViewTextBoxColumn.HeaderText = "Books Sold";
            this.booksSoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.booksSoldDataGridViewTextBoxColumn.Name = "booksSoldDataGridViewTextBoxColumn";
            this.booksSoldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalRevenueDataGridViewTextBoxColumn
            // 
            this.totalRevenueDataGridViewTextBoxColumn.DataPropertyName = "Total_Revenue";
            this.totalRevenueDataGridViewTextBoxColumn.HeaderText = "Total Revenue ($)";
            this.totalRevenueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalRevenueDataGridViewTextBoxColumn.Name = "totalRevenueDataGridViewTextBoxColumn";
            this.totalRevenueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeSalesDTOBindingSource
            // 
            this.employeeSalesDTOBindingSource.DataSource = typeof(ClassLibrary.Models.Employee.DTO_s.EmployeeSalesDTO);
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
            this.LoadingBar.Location = new System.Drawing.Point(20, 301);
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
            this.LoadingBar.TabIndex = 81;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // BestSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 338);
            this.Controls.Add(this.FormTablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(669, 303);
            this.Name = "BestSales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.BestSales_Load);
            this.Resize += new System.EventHandler(this.BestSales_Resize);
            this.FormTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalesDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTablePanel;
        private Label EmployeeSalesTitleLabel;
        private Label LoadingLabel;
        private BindingSource employeeSalesDTOBindingSource;
        private DataGridView EmployeeSalesDGV;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn booksSoldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalRevenueDataGridViewTextBoxColumn;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}