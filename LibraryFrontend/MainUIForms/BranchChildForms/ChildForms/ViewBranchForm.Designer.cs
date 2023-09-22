namespace LibraryUI.MainUIForms.BranchChildForms.ChildForms
{
    partial class ViewBranchForm
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
            this.BranchNameComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ViewBranchTitleLabel = new System.Windows.Forms.Label();
            this.ViewBranchDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newBranchLabel = new System.Windows.Forms.Label();
            this.AddNewBranchLabelButton = new System.Windows.Forms.Label();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.ViewEmployeeLayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBranchDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewEmployeeLayoutpanel
            // 
            this.ViewEmployeeLayoutpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewEmployeeLayoutpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewEmployeeLayoutpanel.ColumnCount = 4;
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ViewEmployeeLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ViewEmployeeLayoutpanel.Controls.Add(this.BranchNameComboBox, 2, 1);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingLabel, 1, 3);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewBranchTitleLabel, 0, 0);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.ViewBranchDGV, 0, 2);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.newBranchLabel, 2, 3);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.AddNewBranchLabelButton, 3, 3);
            this.ViewEmployeeLayoutpanel.Controls.Add(this.LoadingBar, 0, 3);
            this.ViewEmployeeLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEmployeeLayoutpanel.ForeColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeLayoutpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ViewEmployeeLayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.ViewEmployeeLayoutpanel.Name = "ViewEmployeeLayoutpanel";
            this.ViewEmployeeLayoutpanel.RowCount = 4;
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.99408F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.99385F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.16879F));
            this.ViewEmployeeLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.843281F));
            this.ViewEmployeeLayoutpanel.Size = new System.Drawing.Size(1013, 721);
            this.ViewEmployeeLayoutpanel.TabIndex = 15;
            // 
            // BranchNameComboBox
            // 
            this.BranchNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BranchNameComboBox.BackColor = System.Drawing.Color.Teal;
            this.BranchNameComboBox.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.BorderSize = 1;
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.BranchNameComboBox, 2);
            this.BranchNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchNameComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BranchNameComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BranchNameComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.BranchNameComboBox.ListForeColor = System.Drawing.Color.Black;
            this.BranchNameComboBox.Location = new System.Drawing.Point(659, 141);
            this.BranchNameComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.BranchNameComboBox.Name = "BranchNameComboBox";
            this.BranchNameComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.BranchNameComboBox.Size = new System.Drawing.Size(200, 42);
            this.BranchNameComboBox.TabIndex = 1;
            this.BranchNameComboBox.Texts = "";
            this.BranchNameComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BranchNameComboBox_OnSelectedIndexChanged);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(53, 684);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(449, 37);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading Branches, please wait...";
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
            this.ViewBranchTitleLabel.Size = new System.Drawing.Size(406, 108);
            this.ViewBranchTitleLabel.TabIndex = 56;
            this.ViewBranchTitleLabel.Text = "Our Branches";
            this.ViewBranchTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewBranchDGV
            // 
            this.ViewBranchDGV.AutoGenerateColumns = false;
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
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.managerIdDataGridViewTextBoxColumn,
            this.managerStartDateDataGridViewTextBoxColumn,
            this.Edit});
            this.ViewEmployeeLayoutpanel.SetColumnSpan(this.ViewBranchDGV, 4);
            this.ViewBranchDGV.DataSource = this.branchBindingSource;
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
            this.ViewBranchDGV.Location = new System.Drawing.Point(3, 219);
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
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.ViewBranchDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewBranchDGV.RowTemplate.Height = 30;
            this.ViewBranchDGV.RowTemplate.ReadOnly = true;
            this.ViewBranchDGV.Size = new System.Drawing.Size(1007, 427);
            this.ViewBranchDGV.TabIndex = 57;
            this.ViewBranchDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewBranchDGV_CellContentClick);
            this.ViewBranchDGV.Resize += new System.EventHandler(this.ViewBranchDGV_Resize);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 191;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 191;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 192;
            // 
            // managerIdDataGridViewTextBoxColumn
            // 
            this.managerIdDataGridViewTextBoxColumn.DataPropertyName = "Manager_Id";
            this.managerIdDataGridViewTextBoxColumn.HeaderText = "Manager Id";
            this.managerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerIdDataGridViewTextBoxColumn.Name = "managerIdDataGridViewTextBoxColumn";
            this.managerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerIdDataGridViewTextBoxColumn.Width = 191;
            // 
            // managerStartDateDataGridViewTextBoxColumn
            // 
            this.managerStartDateDataGridViewTextBoxColumn.DataPropertyName = "Manager_Start_Date";
            this.managerStartDateDataGridViewTextBoxColumn.HeaderText = "Manager Start Date";
            this.managerStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerStartDateDataGridViewTextBoxColumn.Name = "managerStartDateDataGridViewTextBoxColumn";
            this.managerStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerStartDateDataGridViewTextBoxColumn.Width = 191;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::LibraryUI.Properties.Resources.pencil;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 125;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(ClassLibrary.Models.Branch.Branch);
            // 
            // newBranchLabel
            // 
            this.newBranchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newBranchLabel.BackColor = System.Drawing.Color.Transparent;
            this.newBranchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.newBranchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newBranchLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newBranchLabel.Location = new System.Drawing.Point(538, 663);
            this.newBranchLabel.Name = "newBranchLabel";
            this.newBranchLabel.Size = new System.Drawing.Size(267, 43);
            this.newBranchLabel.TabIndex = 72;
            this.newBranchLabel.Text = "Opening a new branch?";
            this.newBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewBranchLabelButton
            // 
            this.AddNewBranchLabelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddNewBranchLabelButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNewBranchLabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewBranchLabelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddNewBranchLabelButton.ForeColor = System.Drawing.Color.Teal;
            this.AddNewBranchLabelButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddNewBranchLabelButton.Location = new System.Drawing.Point(811, 663);
            this.AddNewBranchLabelButton.Name = "AddNewBranchLabelButton";
            this.AddNewBranchLabelButton.Size = new System.Drawing.Size(101, 43);
            this.AddNewBranchLabelButton.TabIndex = 73;
            this.AddNewBranchLabelButton.Text = "Click here";
            this.AddNewBranchLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewBranchLabelButton.Click += new System.EventHandler(this.AddNewBranchLabelButton_Click);
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
            this.LoadingBar.Location = new System.Drawing.Point(13, 684);
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
            this.LoadingBar.TabIndex = 74;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // ViewBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 721);
            this.Controls.Add(this.ViewEmployeeLayoutpanel);
            this.Name = "ViewBranchForm";
            this.Text = "ViewBranchForm";
            this.Load += new System.EventHandler(this.ViewBranchForm_Load);
            this.ViewEmployeeLayoutpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewBranchDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ViewEmployeeLayoutpanel;
        private AdditionalControls.CustomComboBox.CustomComboBox BranchNameComboBox;
        private Label LoadingLabel;
        private Label ViewBranchTitleLabel;
        private DataGridView ViewBranchDGV;
        private BindingSource branchBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn managerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn managerStartDateDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Edit;
        private Label newBranchLabel;
        private Label AddNewBranchLabelButton;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}