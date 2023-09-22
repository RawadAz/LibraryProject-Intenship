namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms
{
    partial class RentedBooksForm
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
            this.RentedBookTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RentedBooksTitleLabel = new System.Windows.Forms.Label();
            this.RentedBooksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NoRentedBooksLabel = new System.Windows.Forms.Label();
            this.RentedBookTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentedBookTableLayoutPanel
            // 
            this.RentedBookTableLayoutPanel.ColumnCount = 2;
            this.RentedBookTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.875F));
            this.RentedBookTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.125F));
            this.RentedBookTableLayoutPanel.Controls.Add(this.RentedBooksTitleLabel, 0, 0);
            this.RentedBookTableLayoutPanel.Controls.Add(this.RentedBooksFlowLayoutPanel, 0, 1);
            this.RentedBookTableLayoutPanel.Controls.Add(this.NoRentedBooksLabel, 1, 0);
            this.RentedBookTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentedBookTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RentedBookTableLayoutPanel.Name = "RentedBookTableLayoutPanel";
            this.RentedBookTableLayoutPanel.RowCount = 3;
            this.RentedBookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RentedBookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.RentedBookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RentedBookTableLayoutPanel.Size = new System.Drawing.Size(1001, 486);
            this.RentedBookTableLayoutPanel.TabIndex = 0;
            // 
            // RentedBooksTitleLabel
            // 
            this.RentedBookTableLayoutPanel.SetColumnSpan(this.RentedBooksTitleLabel, 2);
            this.RentedBooksTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.RentedBooksTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.RentedBooksTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.RentedBooksTitleLabel.Name = "RentedBooksTitleLabel";
            this.RentedBooksTitleLabel.Size = new System.Drawing.Size(413, 93);
            this.RentedBooksTitleLabel.TabIndex = 1;
            this.RentedBooksTitleLabel.Text = "Rented Books";
            this.RentedBooksTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RentedBooksFlowLayoutPanel
            // 
            this.RentedBooksFlowLayoutPanel.AutoScroll = true;
            this.RentedBooksFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.RentedBookTableLayoutPanel.SetColumnSpan(this.RentedBooksFlowLayoutPanel, 2);
            this.RentedBooksFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentedBooksFlowLayoutPanel.Location = new System.Drawing.Point(3, 468);
            this.RentedBooksFlowLayoutPanel.Name = "RentedBooksFlowLayoutPanel";
            this.RentedBooksFlowLayoutPanel.Size = new System.Drawing.Size(995, 15);
            this.RentedBooksFlowLayoutPanel.TabIndex = 26;
            // 
            // NoRentedBooksLabel
            // 
            this.RentedBookTableLayoutPanel.SetColumnSpan(this.NoRentedBooksLabel, 2);
            this.NoRentedBooksLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoRentedBooksLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoRentedBooksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoRentedBooksLabel.ForeColor = System.Drawing.Color.Teal;
            this.NoRentedBooksLabel.Location = new System.Drawing.Point(3, 93);
            this.NoRentedBooksLabel.Name = "NoRentedBooksLabel";
            this.NoRentedBooksLabel.Size = new System.Drawing.Size(995, 372);
            this.NoRentedBooksLabel.TabIndex = 27;
            this.NoRentedBooksLabel.Text = "Client is not renting any books at the moment";
            this.NoRentedBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoRentedBooksLabel.Visible = false;
            // 
            // RentedBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1001, 486);
            this.Controls.Add(this.RentedBookTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(549, 470);
            this.Name = "RentedBooksForm";
            this.Text = "Client Rented Books";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentedBooksForm_FormClosed);
            this.Load += new System.EventHandler(this.RentedBooksForm_Load);
            this.RentedBookTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel RentedBookTableLayoutPanel;
        private Label RentedBooksTitleLabel;
        private FlowLayoutPanel RentedBooksFlowLayoutPanel;
        private Label NoRentedBooksLabel;
    }
}