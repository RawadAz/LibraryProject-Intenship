namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms
{
    partial class BranchLocationsForm
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
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ViewBranchTitleLabel = new System.Windows.Forms.Label();
            this.ViewBranchDGV = new System.Windows.Forms.DataGridView();
            this.branchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchLocationDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.ViewEmployeeLayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBranchDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchLocationDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewEmployeeLayoutpanel
            // 
            this.ViewEmployeeLayoutpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewEmployeeLayoutpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewEmployeeLayoutpanel.ColumnCount = 4;
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.304499F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.52249F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingLabel, 1, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewBranchTitleLabel, 0, 0);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewBranchDGV, 0, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingBar, 0, 2);
            this.ViewEmployeeLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEmployeeLayoutpanel.ForeColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ViewEmployeeLayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeeLayoutpanel.Name = "ViewEmployeeLayoutpanel";
            this.ViewEmployeeLayoutpanel.RowCount = 3;
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.91022F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.46749F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.62229F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ViewEmployeeLayoutpanel.Size = new System.Drawing.Size(898, 323);
            this.ViewEmployeeLayoutpanel.TabIndex = 16;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(77, 286);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(449, 37);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading locations, please wait...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingLabel.Visible = false;
            // 
            // ViewBranchTitleLabel
            // 
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewBranchTitleLabel, 2);
            this.ViewBranchTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ViewBranchTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.ViewBranchTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ViewBranchTitleLabel.Name = "ViewBranchTitleLabel";
            this.ViewBranchTitleLabel.Size = new System.Drawing.Size(406, 74);
            this.ViewBranchTitleLabel.TabIndex = 56;
            this.ViewBranchTitleLabel.Text = "Our Branches";
            this.ViewBranchTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewBranchDGV
            // 
            this.ViewBranchDGV.AllowUserToDeleteRows = false;
            this.ViewBranchDGV.AutoGenerateColumns = false;
            this.ViewBranchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewBranchDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewBranchDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ViewBranchDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewBranchDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBranchDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewBranchDGV.ColumnHeadersHeight = 40;
            this.ViewBranchDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branchNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewBranchDGV, 4);
            this.ViewBranchDGV.DataSource = this.branchLocationDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBranchDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewBranchDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBranchDGV.EnableHeadersVisualStyles = false;
            this.ViewBranchDGV.GridColor = System.Drawing.Color.Teal;
            this.ViewBranchDGV.Location = new System.Drawing.Point(3, 77);
            this.ViewBranchDGV.Name = "ViewBranchDGV";
            this.ViewBranchDGV.ReadOnly = true;
            this.ViewBranchDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBranchDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewBranchDGV.RowHeadersWidth = 51;
            this.ViewBranchDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBranchDGV.RowTemplate.Height = 30;
            this.ViewBranchDGV.RowTemplate.ReadOnly = true;
            this.ViewBranchDGV.Size = new System.Drawing.Size(892, 199);
            this.ViewBranchDGV.TabIndex = 57;
            this.ViewBranchDGV.Resize += new System.EventHandler(this.BranchLocationDGV_Resize);
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "Branch_Name";
            this.branchNameDataGridViewTextBoxColumn.FillWeight = 30F;
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "Branch Name";
            this.branchNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            this.branchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.FillWeight = 70F;
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchLocationDTOBindingSource
            // 
            this.branchLocationDTOBindingSource.DataSource = typeof(ClassLibrary.Models.Branch.DTO.BranchLocationDTO);
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
            this.LoadingBar.Location = new System.Drawing.Point(37, 286);
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
            // BranchLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 323);
            this.Controls.Add(this.ViewEmployeeLayoutpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(596, 370);
            this.Name = "BranchLocationsForm";
            this.Text = "Branches Locations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BranchLocationsForm_FormClosed);
            this.Load += new System.EventHandler(this.BranchLocationForm_Load);
            this.ViewEmployeeLayoutpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewBranchDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchLocationDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ViewEmployeeLayoutpanel;
        private Label LoadingLabel;
        private Label ViewBranchTitleLabel;
        private DataGridView ViewBranchDGV;
        private BindingSource branchLocationDTOBindingSource;
        private DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}