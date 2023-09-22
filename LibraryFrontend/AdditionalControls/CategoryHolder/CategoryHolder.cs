using LibraryUI.LayoutHelper;
using System.ComponentModel;

namespace LibraryUI.AdditionalControls.CategoryHolder
{
    public partial class CategoryHolder : UserControl
    {

        private string titleText = string.Empty;
        private Color titleColor = Color.Teal;
        private Font titleFont = new("Tahoma", 16, FontStyle.Italic);
        


        public CategoryHolder()
        {
            InitializeComponent();
            Helper.FLPDoubleBuffered(CategoryFlowLayoutPanel, true);
        }

        [Category("Title")]
        public string TitleText
        {
            get
            {
                return titleText;
            }

            set
            {
                titleText = value;
                CategoryTitleLabel.Text = titleText;
            }
        }

        [Category("Title")]
        public Color TitleColor
        {
            get
            {
                return titleColor;
            }

            set
            {
                titleColor = value;
                CategoryTitleLabel.ForeColor = titleColor;
            }
        }

        [Category("Title")]
        public Font TitleFont
        {
            get
            {
                return titleFont;
            }

            set
            {
                titleFont = value;
                CategoryTitleLabel.Font = titleFont;
            }
        }

        public FlowLayoutPanel CategoryFlowLayoutPanel
        {
            get
            {
                CategoryLayoutPanel.VerticalScroll.Enabled = true;
                return CategoryLayoutPanel;
            }
        }

    }
}
