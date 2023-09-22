using FontAwesome.Sharp;
using LibraryUI.LayoutHelper;
using LibraryUI.MainUIForms.TransactionChildForms.ChildForms;

namespace LibraryUI.MainUIForms.TransactionChildForms
{
    public partial class EmpTransactionMainChildForm : Form
    {
        private IconButton? CurrentButton;
        private Form? CurrentChildForm;

        public EmpTransactionMainChildForm()
        {
            InitializeComponent();
        }

        //Events

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            CurrentButton = Helper.Logout(sender, CurrentButton);
        }

        private void ViewTransactionsButton_Click(object sender, EventArgs e)
        {
            CurrentButton = Helper.ActiveButton(sender, CurrentButton);
            CurrentChildForm = Helper.OpenChildForm(new EmpViewTransactionsForm(), CurrentChildForm, FormPanel);
        }

        private void TransactionMainChildForm_Load(object sender, EventArgs e)
        {
            CurrentButton = Helper.ActiveButton(ViewTransactionsButton, CurrentButton);
            CurrentChildForm = Helper.OpenChildForm(new EmpViewTransactionsForm(), CurrentChildForm, FormPanel);
        }

    }
}
