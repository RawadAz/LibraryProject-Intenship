using ClassLibrary.Models.Client;
using LibraryUI.MainUIForms.ReservationsChildForms.ChildForms;
using ClassLibrary.DataAccess.ClientDataAccess;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms;

public partial class AddClientForm : Form
{
    private readonly ClientDataAccess _clientDataAccess;
    private readonly Form? _form;

    public AddClientForm(Form? form = null)
    {
        InitializeComponent();
        CenterToScreen();
        _clientDataAccess = new ClientDataAccess();
        _form = form;
    }

    //Events

    private async void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        try
        {
            Client client = ClientInputsVerified();

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string bookAdded = await _clientDataAccess.AddClient(client);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            bookAdded,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
            );

        }
        catch (Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        FirstNameText.Texts = string.Empty;
        LastNameText.Texts = string.Empty;
        PhoneNumberText.Texts = string.Empty;
    }

    private async void AddClientForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (_form == null)
            return;
        AddReservationForm form = (AddReservationForm)_form;
        await form.FillPhoneNumberComboBox();
    }

    //Functions

    private Client ClientInputsVerified()
    {
        string firstName = FirstNameText.Texts;
        if (string.IsNullOrEmpty(firstName))
            throw new Exception("Client first name is required");
        if (firstName.Contains('\''))
            firstName = Helper.EscapeSingleQuote(firstName);

        string lastName = LastNameText.Texts;
        if (string.IsNullOrEmpty(lastName))
            throw new Exception("Client last name is required");
        if (lastName.Contains('\''))
            lastName = Helper.EscapeSingleQuote(lastName);

        string phoneNumber = PhoneNumberText.Texts;
        if (string.IsNullOrEmpty(phoneNumber))
            throw new Exception("Client phone number is required");
        if (phoneNumber.Contains('\''))
            phoneNumber = Helper.EscapeSingleQuote(phoneNumber);

        return new Client()
            {
                Id = 0,
                First_Name = firstName,
                Last_Name = lastName,
                Phone_Number = phoneNumber,
                Currently_Rented = 0
            };
    }
}
