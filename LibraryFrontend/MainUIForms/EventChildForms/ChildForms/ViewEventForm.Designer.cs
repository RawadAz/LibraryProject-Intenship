namespace LibraryUI.MainUIForms.EventChildForms.ChildForms
{
    partial class ViewEventForm
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
            this.LoadingBar = new CircularProgressBar.CircularProgressBar();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SearchEventLabel = new System.Windows.Forms.Label();
            this.SearchComboBox = new LibraryUI.AdditionalControls.CustomComboBox.CustomComboBox();
            this.EventsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FormTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTablePanel
            // 
            this.FormTablePanel.AutoScroll = true;
            this.FormTablePanel.ColumnCount = 5;
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46778F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54262F));
            this.FormTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17671F));
            this.FormTablePanel.Controls.Add(this.LoadingBar, 0, 3);
            this.FormTablePanel.Controls.Add(this.TitleLabel, 0, 0);
            this.FormTablePanel.Controls.Add(this.LoadingLabel, 1, 3);
            this.FormTablePanel.Controls.Add(this.SearchEventLabel, 2, 1);
            this.FormTablePanel.Controls.Add(this.SearchComboBox, 3, 1);
            this.FormTablePanel.Controls.Add(this.EventsFlowLayoutPanel, 0, 2);
            this.FormTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTablePanel.Location = new System.Drawing.Point(0, 0);
            this.FormTablePanel.Name = "FormTablePanel";
            this.FormTablePanel.RowCount = 4;
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.FormTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTablePanel.Size = new System.Drawing.Size(962, 519);
            this.FormTablePanel.TabIndex = 2;
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
            this.LoadingBar.Location = new System.Drawing.Point(11, 482);
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
            this.FormTablePanel.SetColumnSpan(this.TitleLabel, 3);
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(385, 83);
            this.TitleLabel.TabIndex = 64;
            this.TitleLabel.Text = "Our Events";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadingLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadingLabel.Location = new System.Drawing.Point(51, 484);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(195, 35);
            this.LoadingLabel.TabIndex = 63;
            this.LoadingLabel.Text = "Searching, please wait..";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LoadingLabel.Visible = false;
            // 
            // SearchEventLabel
            // 
            this.SearchEventLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchEventLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchEventLabel.ForeColor = System.Drawing.Color.Teal;
            this.SearchEventLabel.Location = new System.Drawing.Point(471, 104);
            this.SearchEventLabel.Name = "SearchEventLabel";
            this.SearchEventLabel.Size = new System.Drawing.Size(154, 28);
            this.SearchEventLabel.TabIndex = 65;
            this.SearchEventLabel.Text = "Search Events :";
            this.SearchEventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchComboBox.BackColor = System.Drawing.Color.Teal;
            this.SearchComboBox.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SearchComboBox.BorderSize = 4;
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SearchComboBox.ListBackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchComboBox.ListForeColor = System.Drawing.Color.Black;
            this.SearchComboBox.Location = new System.Drawing.Point(631, 99);
            this.SearchComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Padding = new System.Windows.Forms.Padding(4);
            this.SearchComboBox.Size = new System.Drawing.Size(200, 38);
            this.SearchComboBox.TabIndex = 66;
            this.SearchComboBox.Texts = "";
            this.SearchComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SearchComboBox_OnSelectedIndexChanged);
            // 
            // EventsFlowLayoutPanel
            // 
            this.EventsFlowLayoutPanel.AutoScroll = true;
            this.FormTablePanel.SetColumnSpan(this.EventsFlowLayoutPanel, 5);
            this.EventsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EventsFlowLayoutPanel.Location = new System.Drawing.Point(5, 149);
            this.EventsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.EventsFlowLayoutPanel.Name = "EventsFlowLayoutPanel";
            this.EventsFlowLayoutPanel.Size = new System.Drawing.Size(952, 322);
            this.EventsFlowLayoutPanel.TabIndex = 67;
            this.EventsFlowLayoutPanel.WrapContents = false;
            this.EventsFlowLayoutPanel.Resize += new System.EventHandler(this.EventsFlowLayoutPanel_Resize);
            // 
            // ViewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 519);
            this.Controls.Add(this.FormTablePanel);
            this.Name = "ViewEventForm";
            this.Text = "ViewEventForm";
            this.Load += new System.EventHandler(this.ViewEventForm_Load);
            this.Resize += new System.EventHandler(this.ViewEventForm_Resize);
            this.FormTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel FormTablePanel;
        private Label TitleLabel;
        private Label LoadingLabel;
        private Label SearchEventLabel;
        private AdditionalControls.CustomComboBox.CustomComboBox SearchComboBox;
        private FlowLayoutPanel EventsFlowLayoutPanel;
        private CircularProgressBar.CircularProgressBar LoadingBar;
    }
}