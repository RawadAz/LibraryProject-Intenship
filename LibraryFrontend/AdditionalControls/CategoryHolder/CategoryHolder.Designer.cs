namespace LibraryUI.AdditionalControls.CategoryHolder
{
    partial class CategoryHolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryTitleLabel = new System.Windows.Forms.Label();
            this.CategoryLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CategoryTitleLabel
            // 
            this.CategoryTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryTitleLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CategoryTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.CategoryTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.CategoryTitleLabel.Name = "CategoryTitleLabel";
            this.CategoryTitleLabel.Padding = new System.Windows.Forms.Padding(10);
            this.CategoryTitleLabel.Size = new System.Drawing.Size(1038, 88);
            this.CategoryTitleLabel.TabIndex = 1;
            this.CategoryTitleLabel.Text = "Top Selling";
            this.CategoryTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CategoryLayoutPanel
            // 
            this.CategoryLayoutPanel.AutoScroll = true;
            this.CategoryLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryLayoutPanel.Location = new System.Drawing.Point(0, 88);
            this.CategoryLayoutPanel.Name = "CategoryLayoutPanel";
            this.CategoryLayoutPanel.Size = new System.Drawing.Size(1038, 308);
            this.CategoryLayoutPanel.TabIndex = 2;
            // 
            // CategoryHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoryLayoutPanel);
            this.Controls.Add(this.CategoryTitleLabel);
            this.Name = "CategoryHolder";
            this.Size = new System.Drawing.Size(1038, 396);
            this.ResumeLayout(false);

        }

        #endregion

        private Label CategoryTitleLabel;
        private FlowLayoutPanel CategoryLayoutPanel;
    }
}
