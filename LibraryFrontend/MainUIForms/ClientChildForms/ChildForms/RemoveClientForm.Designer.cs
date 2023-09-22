namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms
{
    partial class RemoveClientForm
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
            this.RemoveEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.RemoveSingleRB = new System.Windows.Forms.RadioButton();
            this.SingleEmployeeIdLabel = new System.Windows.Forms.Label();
            this.SingleClientIdComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.RemoveMultipleRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MultipleClientIdComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.ToBeRemovedFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.ResetButton = new LibraryUI.AdditionalControls.Buttons.RoundedButton();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.91525F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.55932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.77966F));
            this.tableLayoutPanel1.Controls.Add(this.LoadingBar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.RemoveEmployeeTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveSingleRB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SingleEmployeeIdLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.SingleClientIdComboBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.RemoveMultipleRB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.MultipleClientIdComboBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ToBeRemovedFLP, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.LoadingLabel, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1219, 620);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RemoveEmployeeTitleLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RemoveEmployeeTitleLabel, 4);
            this.RemoveEmployeeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.RemoveEmployeeTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.RemoveEmployeeTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.RemoveEmployeeTitleLabel.Name = "RemoveEmployeeTitleLabel";
            this.RemoveEmployeeTitleLabel.Size = new System.Drawing.Size(492, 124);
            this.RemoveEmployeeTitleLabel.TabIndex = 96;
            this.RemoveEmployeeTitleLabel.Text = "Remove Client(s)";
            this.RemoveEmployeeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveSingleRB
            // 
            this.RemoveSingleRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSingleRB.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.RemoveSingleRB, 2);
            this.RemoveSingleRB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveSingleRB.ForeColor = System.Drawing.Color.Teal;
            this.RemoveSingleRB.Location = new System.Drawing.Point(162, 138);
            this.RemoveSingleRB.Name = "RemoveSingleRB";
            this.RemoveSingleRB.Size = new System.Drawing.Size(380, 45);
            this.RemoveSingleRB.TabIndex = 97;
            this.RemoveSingleRB.TabStop = true;
            this.RemoveSingleRB.Text = "   Remove A Client";
            this.RemoveSingleRB.UseVisualStyleBackColor = true;
            this.RemoveSingleRB.CheckedChanged += new System.EventHandler(this.RemoveSingleRB_CheckedChanged);
            // 
            // SingleEmployeeIdLabel
            // 
            this.SingleEmployeeIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SingleEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SingleEmployeeIdLabel.ForeColor = System.Drawing.Color.Teal;
            this.SingleEmployeeIdLabel.Location = new System.Drawing.Point(314, 197);
            this.SingleEmployeeIdLabel.Name = "SingleEmployeeIdLabel";
            this.SingleEmployeeIdLabel.Size = new System.Drawing.Size(228, 40);
            this.SingleEmployeeIdLabel.TabIndex = 98;
            this.SingleEmployeeIdLabel.Text = "Select a Client Id:";
            this.SingleEmployeeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SingleEmployeeIdLabel.UseMnemonic = false;
            // 
            // SingleClientIdComboBox
            // 
            this.SingleClientIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SingleClientIdComboBox.BackColor = System.Drawing.Color.Teal;
            this.SingleClientIdComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SingleClientIdComboBox.BorderSize = 4;
            this.SingleClientIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SingleClientIdComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SingleClientIdComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SingleClientIdComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SingleClientIdComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SingleClientIdComboBox.Location = new System.Drawing.Point(548, 197);
            this.SingleClientIdComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SingleClientIdComboBox.Name = "SingleClientIdComboBox";
            this.SingleClientIdComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.SingleClientIdComboBox.Size = new System.Drawing.Size(210, 39);
            this.SingleClientIdComboBox.TabIndex = 99;
            this.SingleClientIdComboBox.Texts = "";
            // 
            // RemoveMultipleRB
            // 
            this.RemoveMultipleRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.RemoveMultipleRB, 2);
            this.RemoveMultipleRB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveMultipleRB.ForeColor = System.Drawing.Color.Teal;
            this.RemoveMultipleRB.Location = new System.Drawing.Point(162, 262);
            this.RemoveMultipleRB.Name = "RemoveMultipleRB";
            this.RemoveMultipleRB.Size = new System.Drawing.Size(380, 45);
            this.RemoveMultipleRB.TabIndex = 100;
            this.RemoveMultipleRB.Text = "   Remove Multiple Clients";
            this.RemoveMultipleRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(314, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 101;
            this.label1.Text = "Select a Client Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // MultipleClientIdComboBox
            // 
            this.MultipleClientIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MultipleClientIdComboBox.BackColor = System.Drawing.Color.Teal;
            this.MultipleClientIdComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.MultipleClientIdComboBox.BorderSize = 4;
            this.MultipleClientIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MultipleClientIdComboBox.Enabled = false;
            this.MultipleClientIdComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MultipleClientIdComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.MultipleClientIdComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.MultipleClientIdComboBox.ListForeColor = System.Drawing.Color.Black;
            this.MultipleClientIdComboBox.Location = new System.Drawing.Point(548, 321);
            this.MultipleClientIdComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.MultipleClientIdComboBox.Name = "MultipleClientIdComboBox";
            this.MultipleClientIdComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.MultipleClientIdComboBox.Size = new System.Drawing.Size(210, 39);
            this.MultipleClientIdComboBox.TabIndex = 102;
            this.MultipleClientIdComboBox.Texts = "";
            this.MultipleClientIdComboBox.OnSelectedIndexChanged += new System.EventHandler(this.MultipleClientIdComboBox_OnSelectedIndexChanged);
            // 
            // ToBeRemovedFLP
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ToBeRemovedFLP, 3);
            this.ToBeRemovedFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToBeRemovedFLP.Location = new System.Drawing.Point(80, 392);
            this.ToBeRemovedFLP.Margin = new System.Windows.Forms.Padding(20);
            this.ToBeRemovedFLP.Name = "ToBeRemovedFLP";
            this.tableLayoutPanel1.SetRowSpan(this.ToBeRemovedFLP, 2);
            this.ToBeRemovedFLP.Size = new System.Drawing.Size(687, 145);
            this.ToBeRemovedFLP.TabIndex = 103;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackColor = System.Drawing.Color.Teal;
            this.RemoveButton.BorderRadius = 35;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveButton.Location = new System.Drawing.Point(842, 417);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(228, 63);
            this.RemoveButton.TabIndex = 104;
            this.RemoveButton.Text = "Remove Client";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.LightGray;
            this.ResetButton.BorderRadius = 35;
            this.ResetButton.Enabled = false;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.Teal;
            this.ResetButton.Location = new System.Drawing.Point(938, 486);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(132, 59);
            this.ResetButton.TabIndex = 105;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.LoadingLabel, 2);
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(63, 583);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(300, 37);
            this.LoadingLabel.TabIndex = 107;
            this.LoadingLabel.Text = "Removing client, please wait...";
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
            this.LoadingBar.Location = new System.Drawing.Point(23, 583);
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
            this.LoadingBar.TabIndex = 108;
            this.LoadingBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingBar.Value = 68;
            this.LoadingBar.Visible = false;
            // 
            // RemoveClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RemoveClientForm";
            this.Text = "RemoveClientForm";
            this.Load += new System.EventHandler(this.RemoveClientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label RemoveEmployeeTitleLabel;
        private RadioButton RemoveSingleRB;
        private Label SingleEmployeeIdLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox SingleClientIdComboBox;
        private RadioButton RemoveMultipleRB;
        private Label label1;
        private AdditionalControls.CustomComboBox.CustomComboBox MultipleClientIdComboBox;
        private FlowLayoutPanel ToBeRemovedFLP;
        private AdditionalControls.Buttons.RoundedButton RemoveButton;
        private AdditionalControls.Buttons.RoundedButton ResetButton;
        private Label LoadingLabel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}