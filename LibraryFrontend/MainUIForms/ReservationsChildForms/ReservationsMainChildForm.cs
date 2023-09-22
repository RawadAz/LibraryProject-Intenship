using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.ReservationsChildForms.ChildForms;

namespace LibraryUI.MainUIForms.ReservationsChildForms;

public partial class ReservationsMainChildForm : Form
{
    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    public ReservationsMainChildForm()
    {
        InitializeComponent();
    }

    //Events

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }

    private void ViewReservationsButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ViewReservationsForm(), CurrentChildForm, FormPanel);
    }

    private void ReservationsMainChildForm_Load(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(ViewReservationsButton, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ViewReservationsForm(), CurrentChildForm, FormPanel);
    }
}
