using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.AdditionalControls.UnderlinedTextbox
{
    [DefaultEvent("_TextChanged")]
    public partial class UnderlinedTextbox : UserControl
    {
        private string placeHolder = string.Empty;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlined = false;
        private Color borderFocusColor = Color.MediumSlateBlue;
        private bool isFocused = false;

        public UnderlinedTextbox()
        {
            InitializeComponent();

        }

        //Events

        public event EventHandler _TextChanged = delegate { };

        //properties

        [Category("user defined properties")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        
        [Category("user defined properties")]
        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }

        [Category("user defined properties")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        
        [Category("user defined properties")]
        public bool Underlined
        {
            get
            {
                return underlined;
            }
            set
            {
                underlined = value;
                this.Invalidate();
            }
        }
        
        [Category("user defined properties")]
        public string PlaceHolder
        {
            get
            {
                return textBox1.PlaceholderText;
            }
            set
            {
                textBox1.PlaceholderText = value;
            }
        }
        
        [Category("user defined properties")]
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        
        [Category("user defined properties")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        
        [Category("user defined properties")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        
        [Category("user defined properties")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        
        [Category("user defined properties")]
        public string Texts
        {
            get
            {
                return textBox1.Text;
            }
            set 
            { 
                textBox1.Text = value;
            }
        }
        
        [Category("user defined properties")]
        public bool MultiLine
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline= value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics= e.Graphics;

            //draw border

            using(Pen penBorder = new Pen(borderColor, borderSize)) 
            {
                penBorder.Alignment = PenAlignment.Inset;

                if (!isFocused)
                {

                    if (underlined) //underlined style
                    {
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //normal style
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlined) //underlined style
                    {
                        graphics.DrawLine(penBorder, 0, this.Height - 1 , this.Width, this.Height - 1);
                    }
                    else //normal style
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //update control height method
            if(this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }


        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false) 
            { 
                int textHeight = TextRenderer.MeasureText("Text",this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0,textHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void UnderlinedTextbox_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }
    }
}

