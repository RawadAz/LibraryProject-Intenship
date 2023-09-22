using ClassLibrary.DataAccess.TransactionDataAccess;
using ClassLibrary.Models.SaleInfo;
using LibraryUI.MainUIForms.BookChildForms.ChildForms;
using LibraryUI.MainUIForms.ClientChildForms.ChildForms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using Size = System.Drawing.Size;

namespace LibraryUI.AdditionalControls.BookInfoHolder
{
    [DefaultEvent("OnClick")]
    public partial class BookHolder : UserControl
    {
        private readonly TransactionDataAccess _TransactionDataAccess;

        private int bookId;
        private int transaction_Id;
        private Color iconColor = Color.Teal;
        private string bookNameText = "Name";
        private string authorNameText = "Author";
        private string categoryText = "Category";
        private string purchasePriceText = "0";
        private string rentPriceText = "0";
        private string availableCopiesText = "0";
        private string branchNameText = "branch";
        private Color backColor = Color.LightSkyBlue;
        private Size size = new(330, 247);
        private string copiesText = "Available Copies";
        private bool purchaseButtonVisible = true;
        private bool rentButtonVisible = true;
        private bool returnButtonVisible = false;
        

        private readonly string _Username;

        public BookHolder(string username)
        {
            InitializeComponent();
            _TransactionDataAccess = new TransactionDataAccess();
            _Username = username;
        }

        [Category("Book Info")]
        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                BookIconPicture.IconColor = value;
            }
        }

        [Category("Book Info")]
        public string BookNameText
        { 
            get 
            { 
                return bookNameText; 
            }
            set
            {
                bookNameText = value.ToUpperInvariant();
                NameLabelText.Text = value.ToUpperInvariant();
            }
        }

        [Category("Book Info")]
        public string AuthorNameText
        {
            get
            {
                return authorNameText;
            }
            set
            {
                authorNameText = value;
                AuthorTextLabel.Text = value;
            }
        }

        [Category("Book Info")]
        public string CategoryText
        {
            get
            {
                return categoryText;
            }
            set
            {
                categoryText = value;
                CategoryTextLabel.Text = value;
            }
        }

        [Category("Book Info")]
        public string PurchasePriceText
        {
            get
            {
                return purchasePriceText;
            }
            set 
            { 
                purchasePriceText = value;
                PurchasePriceTextLabel.Text = value;
            }
        }

        [Category("Book Info")]
        public string RentPriceText
        {
            get
            {
                return rentPriceText;
            }
            set
            {
                rentPriceText = value;
                RentPriceTextLabel.Text = value;
            }
        }

        [Category("Book Info")]
        public string AvailableCopiesText
        {
            get
            {
                return availableCopiesText;
            }
            set
            {
                availableCopiesText = value;
                AvailableCopiesTextLabel.Text = value;
            }
        }

        [Category("Book Info")]
        public string BranchNameText
        {
            get 
            { 
                return branchNameText; 
            }
            set
            {
                branchNameText = value;
                branchTextLabel.Text = value;
            }
        }

        [Category("Book Info")]
        public new Color BackColor
        {
            get 
            { 
                return backColor;
            }
            set
            {
                backColor = value;
                HolderPanel.BackColor = backColor;

            }
        }
        [Category("Book Info")]
        public Size Size1
        {
            get
            {
                base.Size = size;
                return size;
            }

            set
            {
                size = value;
            }
        }
        [Category("Book Info")]
        public int BookId
        {
            get
            {
                return bookId;
            }

            set
            {
                bookId = value;
            }
        }
        [Category("Book Info")]
        public bool PurchaseButtonVisible
        {
            get
            {
                return purchaseButtonVisible;
            }

            set
            {
                PurchaseButton.Enabled = value;
                PurchaseButton.Visible = value;
                purchaseButtonVisible = value;
            }
        }
        [Category("Book Info")]
        public bool RentButtonVisible
        {
            get
            {
                return rentButtonVisible;
            }

            set
            {
                RentButton.Enabled = value;
                RentButton.Visible = value;
                rentButtonVisible = value;
            }
        }
        [Category("Book Info")]
        public string CopiesText
        {
            get
            {
                return copiesText;
            }

            set
            {
                AvailableCopiesTitleLabel.Text = value;
                copiesText = value;
            }
        }
        [Category("Book Info")]
        public bool ReturnButtonVisible
        {
            get
            {
                return returnButtonVisible;
            }

            set
            {
                ReturnButton.Enabled = value;
                ReturnButton.Visible = value;
                returnButtonVisible = value;
            }
        }
        [Category("Book Info")]
        public int Transaction_Id
        {
            get
            {
                return transaction_Id;
            }

            set
            {
                transaction_Id = value;
            }
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {

            SaleInfoModel saleInfo = new()
            {
                Id = bookId,
                Book_Name = BookNameText,
                Branch_Name = BranchNameText,
                Available_Copies = int.Parse(availableCopiesText),
                Purchase_Price = double.Parse(purchasePriceText[..^1]),
                Rent_Price = double.Parse(rentPriceText[..^1]),
                Sale_Type = "Purchase"

            };

            Form form = this.Parent.FindForm();

            MakeSaleForm makeSaleForm = new (_Username, saleInfo, form);
            
            makeSaleForm.ShowDialog();
            
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            SaleInfoModel saleInfo = new()
            {
                Id = bookId,
                Book_Name = BookNameText,
                Branch_Name = BranchNameText,
                Available_Copies = int.Parse(availableCopiesText),
                Purchase_Price = double.Parse(purchasePriceText[..^1]),
                Rent_Price = double.Parse(rentPriceText[..^1]),
                Sale_Type = "Rent"

            };

            Form form = this.Parent.FindForm();

            MakeSaleForm makeSaleForm = new(_Username, saleInfo, form);
            makeSaleForm.ShowDialog();
        }

        private void BookInfoButton_Click(object sender, EventArgs e)
        {
            BookInfoForm form = new(bookId);
            form.ShowDialog();
        }

        private async void ReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to return this book",
                        caption: "Confimation Message",
                        MessageBoxButtons.YesNo,
                        icon: MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.No)
                    return;
                
                string bookReturned = await _TransactionDataAccess.ReturnBook(transaction_Id);

                MessageBox.Show(
                bookReturned,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );

                RentedBooksForm form = (RentedBooksForm) this.Parent.FindForm();
                await form.FillRentedBooksPanel();
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
            }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
                           Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int borderRadius = 35;

            float borderThickness = 1.75f;
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(this.Parent.BackColor, borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            this.Invalidate(true);
            base.OnSizeChanged(e);
        }

    }
}
