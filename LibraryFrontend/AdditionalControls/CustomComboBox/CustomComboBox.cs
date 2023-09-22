using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Markup;
using System.Runtime.InteropServices;

namespace LibraryUI.AdditionalControls.CustomComboBox
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class CustomComboBox : UserControl
    {

        //Fields
        private Color backColor = Color.Teal;
        private Color iconColor = Color.WhiteSmoke;
        private Color listBackColor = Color.LightSkyBlue;
        private Color listForeColor = Color.Black;
        private Color borderColor = Color.WhiteSmoke;
        private int borderSize = 1;

        //Items
        private readonly ComboBox comboBox;
        private readonly Label labelText;
        private readonly Button buttonIcon;

        //properties
        [Category("Custom Properties")]
        public new Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            { 
                backColor = value; 
                labelText.BackColor= backColor;
                buttonIcon.BackColor= backColor;
            } 
        }
        [Category("Custom Properties")]
        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                buttonIcon.Invalidate(); //redraw icon with new color
            }
        }
        [Category("Custom Properties")]
        public Color ListBackColor
        {
            get 
            {
                return listBackColor;
            }
            set 
            { 
                listBackColor = value; 
                comboBox.BackColor= listBackColor;
            } 
        }
        [Category("Custom Properties")]
        public Color ListForeColor
        {
            get
            {
                return listForeColor;
            }
            set
            {
                listForeColor = value;
                comboBox.ForeColor= listForeColor;
            }
        }
        [Category("Custom Properties")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set 
            { 
                borderColor = value;
                base.BackColor= borderColor; //border color
            }
        }
        [Category("Custom Properties")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize); //bordersize
                AdjustComboBoxDimensions();
            }
        }
        [Category("Custom Properties")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                labelText.ForeColor = value;
            }
        }
        [Category("Custom Properties")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                labelText.Font = value;
                comboBox.Font = value;
            }
        }
        [Category("Custom Properties")]
        public string Texts
        {
            get
            {
                return labelText.Text;
            }
            set
            {
                labelText.Text = value;
            }
        }
        [Category("Custom Properties")]
        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return comboBox.DropDownStyle;
            }
            set
            {
                if (comboBox.DropDownStyle == ComboBoxStyle.Simple)
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.DropDownStyle = value;
            }
        }

        // Data

        [Category("Custom Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return comboBox.Items; }
        }

        [Category("Custom Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return comboBox.DataSource; }
            set { comboBox.DataSource = value; }
        }

        [Category("Custom Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return comboBox.AutoCompleteCustomSource; }
            set { comboBox.AutoCompleteCustomSource = value; }
        }

        [Category("Custom Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return comboBox.AutoCompleteSource; }
            set { comboBox.AutoCompleteSource = value; }
        }

        [Category("Custom Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return comboBox.AutoCompleteMode; }
            set { comboBox.AutoCompleteMode = value; }
        }

        [Category("Custom Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        [Category("Custom Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return comboBox.SelectedIndex; }
            set { comboBox.SelectedIndex = value; }
        }

        [Category("Custom Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedValue
        {
            get { return comboBox.SelectedValue; }
            set { comboBox.SelectedValue = value; }
        }

        [Category("Custom Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return comboBox.DisplayMember; }
            set { comboBox.DisplayMember = value; }
        }

        [Category("Custom Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return comboBox.ValueMember; }
            set { comboBox.ValueMember = value; }
        }

        //Events
        public event EventHandler? OnSelectedIndexChanged; //default event

        public CustomComboBox()
        {
            comboBox= new ComboBox();
            labelText= new Label();
            buttonIcon= new Button();
            this.SuspendLayout();

            //drop down list
            comboBox.BackColor=listBackColor;
            comboBox.Dock=DockStyle.Fill;
            comboBox.Font = new Font(this.Font.Name, 10F);
            comboBox.ForeColor = listForeColor;
            comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //default event
            comboBox.TextChanged += new EventHandler(ComboBox_TextChanged); //refresh shown text

            //Button icon
            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = backColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Cursor = Cursors.Hand;
            buttonIcon.Click += new EventHandler(ButtonIcon_Click); //open drop down list
            buttonIcon.Paint += new PaintEventHandler(ButtonIcon_Paint);

            //Text label

            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.BackColor = backColor;
            labelText.ForeColor = listForeColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(6,0,0,0);
            labelText.Font = new Font(this.Font.Name, 10F);
            labelText.Click += new EventHandler(Text_Click); //select combo box

            //user control
            this.Controls.Add(buttonIcon);  //2
            this.Controls.Add(labelText);   //1
            this.Controls.Add(comboBox);    //0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.WhiteSmoke;
            this.Padding = new Padding(borderSize); //bordersize
            base.BackColor = borderColor; //border color
            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }

        //private methods

        private void AdjustComboBoxDimensions()
        {
            comboBox.Width = labelText.Width;
            comboBox.Location = new Point()
            {
                X = this.Width - this.Padding.Right - comboBox.Width,
                Y= labelText.Bottom- comboBox.Height 

            };
        }

        //Event methods

        private void Text_Click(object? sender, EventArgs e)
        {
            //Select the combo box
            comboBox.Select();
            if(comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBox.DroppedDown= true; //opens dropdown list
        }

        private void ButtonIcon_Paint(object? sender, PaintEventArgs e)
        {
            //fields
            int iconHeight = 6;
            int iconWidth = 14;
            var rectIcon = new Rectangle(
                (buttonIcon.Width - iconWidth)/2,
                (buttonIcon.Height - iconHeight) / 2,
                iconWidth,
                iconHeight 
                );
            Graphics graph = e.Graphics;

            //draw down arrow icon

            using GraphicsPath path = new();
            using Pen pen = new(iconColor, 2);
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            //line starting from initial axis to lower midpoint
            path.AddLine(
                rectIcon.X,
                rectIcon.Y,
                rectIcon.X + (iconWidth / 2),
                rectIcon.Bottom
                );
            //line starting from end of previos line to the upper right
            path.AddLine(
                rectIcon.X + (iconWidth / 2),
                rectIcon.Bottom,
                rectIcon.Right,
                rectIcon.Y
                );
            //draw created path
            graph.DrawPath(pen, path);
        }

        private void ButtonIcon_Click(object? sender, EventArgs e)
        {
            //opens dropdown list
            comboBox.Select();
            comboBox.DroppedDown = true; 
        }

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            //Refresh text
            labelText.Text = comboBox.Text; 
        }

        //default Event
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            OnSelectedIndexChanged?.Invoke(sender, e);
            
            //refresh text
            labelText.Text = comboBox.Text;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomComboBox
            // 
            this.Name = "CustomComboBox";
            this.ResumeLayout(false);

        }
    }
}
