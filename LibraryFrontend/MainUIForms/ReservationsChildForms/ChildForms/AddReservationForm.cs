using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.DataAccess.ReservationDataAccess;
using ClassLibrary.Models.Reservation.DTO;
using LibraryUI.MainUIForms.ClientChildForms.ChildForms;
using LibraryUI.MainUIForms.EventChildForms.ChildForms;

namespace LibraryUI.MainUIForms.ReservationsChildForms.ChildForms;

public partial class AddReservationForm : Form
{
    private readonly ClientDataAccess _clientDataAccess;
    private readonly ReservationDataAccess _reservationDataAccess;

    private readonly ViewEventForm _viewEventForm;
    private readonly int _eventId;
    private readonly string _eventName;
    private readonly string _branchName;
    private readonly double _fee;
    private int _availableTickets;

    public AddReservationForm(ViewEventForm form,int eventId, string eventName, string branchName, double fee, int availableTickets)
    {
        InitializeComponent();
        CenterToScreen();

        _clientDataAccess = new ClientDataAccess();
        _reservationDataAccess = new ReservationDataAccess();

        _viewEventForm = form;
        _eventId = eventId;
        _eventName = eventName;
        _branchName = branchName;
        _fee = fee;
        _availableTickets = availableTickets;
    }

    //Events

    private async void AddReservationForm_Load(object sender, EventArgs e)
    {
        FillEventInfo();
        await FillPhoneNumberComboBox();
        TicketsNumeric.Maximum = _availableTickets;
    }

    private void TicketsNumeric_ValueChanged(object sender, EventArgs e)
    {
        TotalFeeText.Text = (int.Parse(TicketsNumeric.Value.ToString()) * _fee) + "$";
    }

    private async void AddReservationButton_Click(object sender, EventArgs e)
    {
        try
        {
            EditReservationDTO reservation = ReservationInputsVerified();

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string eventAdded = await _reservationDataAccess.AddReservation(reservation);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            eventAdded,
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
            );

            _availableTickets -= reservation.Nb_Of_Tickets;
            TicketsNumeric.Maximum = _availableTickets;

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

    private void AddNewClientLabelButton_Click(object sender, EventArgs e)
    {
        AddClientForm addClient = new(this.FindForm());
        addClient.ShowDialog();
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        PhoneNumberComboBox.SelectedIndex = 0;
        TicketsNumeric.Value = 1;
    }

    //Functions

    public async Task FillPhoneNumberComboBox()
    {
        try
        {
            IEnumerable<string> phoneNumbers = await _clientDataAccess.GetClientPhoneNumbers();
            PhoneNumberComboBox.DataSource = phoneNumbers;

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

    private void FillEventInfo()
    {
        EventNameText.Text = _eventName;
        BranchNameText.Text = _branchName;
        FeeText.Text = $"{_fee} $";
        TotalFeeText.Text = $"{_fee} $";
        TicketsNumeric.Value = 1;
        TicketsNumeric.Maximum = _availableTickets;
    }

    private EditReservationDTO ReservationInputsVerified()
    {
        string? phoneNumber = PhoneNumberComboBox.SelectedItem.ToString();
        if (phoneNumber == null)
            throw new Exception("Client phone number is required");
        
        bool parsed = int.TryParse(TicketsNumeric.Value.ToString(), out int tickets);
        if (!parsed) 
            throw new Exception("tickets count should be numeric");
        if (tickets <= 0) 
            throw new Exception("Client need to at lease reserve 1 ticket");

        return new EditReservationDTO()
        {
            Event_Id = _eventId,
            Client_Phone_Number = phoneNumber,
            Nb_Of_Tickets = tickets
        };

    }

    private void AddReservationForm_FormClosed(object sender, FormClosedEventArgs e)
    {

        Control[] controls = _viewEventForm.Controls.Find("SearchComboBox", true);
        _viewEventForm.SearchComboBox_OnSelectedIndexChanged(controls[0], EventArgs.Empty);
    }
}
