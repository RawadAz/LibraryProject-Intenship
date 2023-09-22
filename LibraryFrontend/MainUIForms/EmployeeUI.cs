using FontAwesome.Sharp;
using LibraryUI.MainUIForms.BookChildForms;
using LibraryUI.MainUIForms.BranchChildForms.ChildForms;
using LibraryUI.MainUIForms.ClientChildForms;
using LibraryUI.MainUIForms.EventChildForms;
using LibraryUI.MainUIForms.ReservationsChildForms;
using LibraryUI.MainUIForms.SettingsChildForm;
using LibraryUI.MainUIForms.TransactionChildForms;
using System.Runtime.InteropServices;

namespace LibraryUI.MainUIForms;

public partial class EmployeeUI : Form
{
    //fields
    private IconButton? CurrentButton;
    private readonly Panel LeftBorderButton;
    private Form? CurrentChildForm;
    private readonly LoginForm _LoginForm;

    private readonly string _Username;

    private readonly int leftBorderSize = 0;
    private readonly int borderSize = 5;
    private Size formSize; //stores normal size on minimize or maximize

    public EmployeeUI(LoginForm loginForm, string Username)
    {
        InitializeComponent();
        CenterToScreen();
        this.Padding = new Padding(leftBorderSize, 0, borderSize, borderSize); //border size
        this.BackColor = Color.Teal;
        this.DoubleBuffered = true;

        _LoginForm = loginForm;
        _Username = Username;

        LeftBorderButton = new Panel
        {
            Size = new Size(7, 80)
        };
        MenuPanel.Controls.Add(LeftBorderButton);

    }

    //Events

    private void BookMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        OpenChildForm(new EmpBookMainChildForm(_Username));
    }

    private void EventsMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        OpenChildForm(new EmpEventMainChildForm());
    }

    private void TransactionsMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        OpenChildForm(new EmpTransactionMainChildForm());
    }

    private void ReservationsMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        OpenChildForm(new ReservationsMainChildForm());
    }

    private void ClientsMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        OpenChildForm(new ClientMainChildForm(_Username));
    }

    private void BranchMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        new BranchLocationsForm(this).ShowDialog();
    }

    private void CloseApp(object sender, FormClosedEventArgs e)
    {
        _LoginForm.Show();
    }

    private void SettingsMenuButton_Click(object sender, EventArgs e)
    {
        ActiveButton(sender);
        OpenChildForm(new SettingsMainForm(_Username));
    }

    private  void EmployeeUI_Load(object sender, EventArgs e)
    {
        BookMenuButton_Click(BookMenuButton, e);
    }

    private void TaskBarPanel_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void Exitbutton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void MinimizeButton_Click(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Normal)
            formSize = this.ClientSize;
        this.WindowState = FormWindowState.Minimized;
    }

    private void MaximizeButton_Click(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Normal)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Maximized;
            MaximizeButton.IconChar = IconChar.WindowRestore;
        }
        else
        {
            if (this.Padding.Right != borderSize) //restores main border size
                this.Padding = new Padding(leftBorderSize,0, borderSize, borderSize);
            this.WindowState = FormWindowState.Normal;
            this.Size = formSize;
            MaximizeButton.IconChar = IconChar.WindowMaximize;
        }
    }

    private void Exitbutton_MouseLeave(object sender, EventArgs e)
    {
        Exitbutton.BackColor = Color.Teal;
    }

    private void Exitbutton_MouseEnter(object sender, EventArgs e)
    {
        Exitbutton.BackColor = Color.Crimson;
    }

    //Functions

    //change menu button appearance on click
    private void ActiveButton(object senderButton)
    {
        if (senderButton != null)
        {
            DisableButton();
            //Change active button style

            CurrentButton = (IconButton)senderButton;
            CurrentButton.BackColor = Color.SkyBlue;
            CurrentButton.ForeColor = Color.Teal;
            CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
            CurrentButton.IconColor = Color.Teal;
            CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            CurrentButton.ImageAlign = ContentAlignment.MiddleRight;

            //leftBoderPanel
            LeftBorderButton.Name = "LeftBorderButton";
            LeftBorderButton.BackColor = Color.LightGoldenrodYellow;
            LeftBorderButton.Location = new Point(0, CurrentButton.Location.Y);
            LeftBorderButton.Visible = true;
            LeftBorderButton.BringToFront();
        }
    }

    //resets menu button appearance
    public void DisableButton()
    {
        if (CurrentButton != null)
        {
            CurrentButton.BackColor = Color.Teal;
            CurrentButton.ForeColor = Color.WhiteSmoke;
            CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
            CurrentButton.IconColor = Color.WhiteSmoke; ;
            CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CurrentButton.ImageAlign = ContentAlignment.MiddleCenter;
        }
    }

    private void OpenChildForm(Form childForm)
    {
        CurrentChildForm?.Close();

        CurrentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        FormPanel.Controls.Add(childForm);
        FormPanel.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
    }

    //Imported Functions

    //Drag Form
    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    //overridden methods

    protected override void WndProc(ref Message message)
    {
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        const int SC_RESTORE = 0xF120; //Restore form (Before)

        //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
        if (message.Msg == WM_SYSCOMMAND)
        {
            int wParam = (message.WParam.ToInt32() & 0xFFF0);
            if (wParam == SC_MINIMIZE)  //Before
                formSize = this.ClientSize;
            if (wParam == SC_RESTORE)// Restored form(Before)
                this.Size = formSize;
        }

        base.WndProc(ref message);

    }
}
