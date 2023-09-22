using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.EmployeeChildForms.ChildForms;

namespace LibraryUI.MainUIForms.EmployeeChildForms;


public partial class EmployeeMainChildForm : Form
{

    private IconButton? CurrentButton;
    private Form? CurrentChildForm;


    public EmployeeMainChildForm()
    {
        InitializeComponent();
    }

    //Events

    private void EmployeeMainChildForm_Load(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(ViewEmployeesButton, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new ViewEmployeeForm(), CurrentChildForm, FormPanel);
    }

    private void ViewEmployeesButton_Click(object sender, EventArgs e)
    {
        if (CurrentButton!=null && !CurrentButton.Equals(sender))
        {
            CurrentButton = Helper.ActiveButton(sender, CurrentButton);
            CurrentChildForm = Helper.OpenChildForm(new ViewEmployeeForm(), CurrentChildForm, FormPanel);
        }
    }

    private void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new AddEmployeeForm(), CurrentChildForm, FormPanel);
    }

    private void UpdateEmployeeButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new UpdateEmployeeForm(), CurrentChildForm, FormPanel);
    }

    private void RemoveEmployeebutton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.ActiveButton(sender, CurrentButton);
        CurrentChildForm = Helper.OpenChildForm(new RemoveEmployeeForm(), CurrentChildForm, FormPanel);
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        CurrentButton = Helper.Logout(sender, CurrentButton);
    }
}
