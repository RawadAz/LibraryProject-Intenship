using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.Models.Client;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms;

public partial class EditClientForm : Form
{
    private readonly ClientDataAccess _clientDataAccess;
    private Client tempClient = new();

    public EditClientForm()
    {
        InitializeComponent();
        _clientDataAccess = new ClientDataAccess();
    }

    //Events

    private void ResetButton_Click(object sender, EventArgs e)
    {
        FirstNameText.Texts = tempClient.First_Name;
        LastNameText.Texts = tempClient.Last_Name;
        PhoneNumberText.Texts = tempClient.Phone_Number;
    }

    private async void EditClientForm_Load(object sender, EventArgs e)
    {
        await FillClientIdComboBox();
    }

    private async void ClientIdComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        await FillClientInfo();
    }

    private async void UpdateClientButton_Click(object sender, EventArgs e)
    {
        try
        {
            Client client = ClientInputsVerified();

            if (client.Equals(tempClient))
                return;

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            tempClient = client;

            string clientUpdated = await _clientDataAccess.UpdateClient(client);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            clientUpdated,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
            );

        }
        catch(Exception ex)
        {
            MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
        }
    }

    //Functions

    private async Task FillClientIdComboBox()
    {
        try
        {
            IEnumerable<int> ids = await _clientDataAccess.GetAllClientIds();

            ClientIdComboBox.DataSource = ids;
            ClientIdComboBox.DisplayMember = ids.First().ToString();

        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
    }

    private async Task FillClientInfo()
    {
        try
        {
            bool parsed = int.TryParse(ClientIdComboBox.SelectedItem.ToString(), out int clientId);
            if (!parsed)
                throw new Exception("Invalid client id");

            Client client = await _clientDataAccess.GetClientById(clientId);

            FirstNameText.Texts = client.First_Name;
            LastNameText.Texts = client.Last_Name;
            PhoneNumberText.Texts = client.Phone_Number;

            tempClient = client;

        }
        catch (Exception ex)
        {
            MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
        }
    }

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
            Id = tempClient.Id,
            First_Name = firstName,
            Last_Name = lastName,
            Phone_Number = phoneNumber,
            Currently_Rented = tempClient.Currently_Rented
        };
    }

}
