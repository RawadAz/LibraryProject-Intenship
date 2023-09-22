namespace LibraryUI.MainUIForms.BookChildForms.ChildForms
{
    partial class HomeForm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderPictureBox = new System.Windows.Forms.PictureBox();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.TopSellingFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopSellingLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).BeginInit();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HeaderPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1050, 160);
            this.HeaderPanel.TabIndex = 26;
            // 
            // HeaderPictureBox
            // 
            this.HeaderPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HeaderPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPictureBox.Image = global::LibraryUI.Properties.Resources.banner_1;
            this.HeaderPictureBox.InitialImage = null;
            this.HeaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.HeaderPictureBox.Name = "HeaderPictureBox";
            this.HeaderPictureBox.Size = new System.Drawing.Size(1050, 160);
            this.HeaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeaderPictureBox.TabIndex = 29;
            this.HeaderPictureBox.TabStop = false;
            // 
            // FormPanel
            // 
            this.FormPanel.AutoScroll = true;
            this.FormPanel.Controls.Add(this.CategoriesPanel);
            this.FormPanel.Controls.Add(this.TopSellingFlowLayoutPanel);
            this.FormPanel.Controls.Add(this.TopSellingLabel);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 160);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1050, 613);
            this.FormPanel.TabIndex = 27;
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.AutoSize = true;
            this.CategoriesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesPanel.Location = new System.Drawing.Point(0, 389);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(1050, 0);
            this.CategoriesPanel.TabIndex = 31;
            // 
            // TopSellingFlowLayoutPanel
            // 
            this.TopSellingFlowLayoutPanel.AutoScroll = true;
            this.TopSellingFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopSellingFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSellingFlowLayoutPanel.Location = new System.Drawing.Point(0, 88);
            this.TopSellingFlowLayoutPanel.Name = "TopSellingFlowLayoutPanel";
            this.TopSellingFlowLayoutPanel.Size = new System.Drawing.Size(1050, 301);
            this.TopSellingFlowLayoutPanel.TabIndex = 30;
            // 
            // TopSellingLabel
            // 
            this.TopSellingLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopSellingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSellingLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TopSellingLabel.ForeColor = System.Drawing.Color.Teal;
            this.TopSellingLabel.Location = new System.Drawing.Point(0, 0);
            this.TopSellingLabel.Name = "TopSellingLabel";
            this.TopSellingLabel.Padding = new System.Windows.Forms.Padding(10);
            this.TopSellingLabel.Size = new System.Drawing.Size(1050, 88);
            this.TopSellingLabel.TabIndex = 29;
            this.TopSellingLabel.Text = "Top Selling";
            this.TopSellingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 773);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.HeaderPanel);
            this.DoubleBuffered = true;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).EndInit();
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderPanel;
        private PictureBox HeaderPictureBox;
        private Panel FormPanel;
        private Panel CategoriesPanel;
        private FlowLayoutPanel TopSellingFlowLayoutPanel;
        private Label TopSellingLabel;
    }
}