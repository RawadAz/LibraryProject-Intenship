using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.EventChildForms.ChildForms;

namespace LibraryUI.MainUIForms.EventChildForms;

public partial class EmpEventMainChildForm : Form
{
    private IconButton? CurrentButton;
    private Form? CurrentChildForm;

    public EmpEventMainChildForm()
    {
        InitializeComponent();
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }

    private void ViewEventsButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ViewEventForm(), CurrentChildForm, FormPanel);
    }

    private void EventMainChildForm_Load(object sender, EventArgs e)
    {
        ViewEventsButton_Click(ViewEventsButton, e);
    }
}
