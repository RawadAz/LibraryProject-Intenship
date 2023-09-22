using ClassLibrary.DataAccess.EventDataAccess;
using ClassLibrary.DataAccess.ReservationDataAccess;
using ClassLibrary.Models.Reservation;
using ClassLibrary.Models.Reservation.DTO;

namespace LibraryUI.MainUIForms.ReservationsChildForms.ChildForms;

public partial class EditReservationForm : Form
{
    private readonly ReservationDataAccess _reservationDataAccess;
    private readonly EventDataAccess _eventDataAccess;

    private readonly ReservationDTO _reservation;
    private EditReservationDTO _tempReservation = new();
    private readonly Form _form;
    private int availableTickets;

    public EditReservationForm(ReservationDTO reservation, Form form)
    {
        InitializeComponent();
        CenterToScreen();

        _reservationDataAccess = new ReservationDataAccess();
        _eventDataAccess = new EventDataAccess();

        _reservation = reservation;
        _form = form;
    }

    //Events

    private async void EditReservationForm_Load(object sender, EventArgs e)
    {
        FillReservationInfo();
        await GetAvaialableTickets();
        TicketsNumeric.Maximum = availableTickets;
    }

    private async Task GetAvaialableTickets()
    {
        try
        {
            availableTickets = await _eventDataAccess.GetAvaialableTickets(_reservation.Event_Id);
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

    private void ResetButton_Click(object sender, EventArgs e)
    {
        FillReservationInfo();
    }

    private async void UpdateReservationButton_Click(object sender, EventArgs e)
    {
        try
        {
            EditReservationDTO reservation = ReservationInputsVerified();

            if (reservation.Equals(_tempReservation))
                return;

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string reservationUpdated = await _reservationDataAccess.UpdateReservation(reservation);

            _tempReservation = reservation;

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                reservationUpdated,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
            );

            await GetAvaialableTickets();
            TicketsNumeric.Maximum = availableTickets;

        }
        catch (Exception ex)
        {

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
        }
    }

    private void EditReservationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        ViewReservationsForm form = (ViewReservationsForm) _form;
        Control[] getReservationButton = _form.Controls.Find("GetReservationsButton", true);
        if(getReservationButton[0] != null)
            form.GetReservationsButton_Click(getReservationButton[0], e);
    }

    private void TicketsNumeric_ValueChanged(object sender, EventArgs e)
    {
        TotalFeeText.Texts = (int.Parse(TicketsNumeric.Value.ToString()) * _reservation.Fee) + "$";
    }

    //Functions

    private void FillReservationInfo()
    {
        EventNameText.Texts = _reservation.Event;
        BranchNameText.Texts = _reservation.Branch;
        PhoneNumberText.Texts = _reservation.Client_Phone_Number;
        TicketsNumeric.Value = _reservation.Nb_Of_Tickets;
        FeeText.Texts = $"{_reservation.Fee} $";
        TotalFeeText.Texts = $"{_reservation.Total_Fee} $";
        FillTempReservation();

    }
        
    private EditReservationDTO ReservationInputsVerified()  
    {

        bool ticketsParsed = int.TryParse(TicketsNumeric.Value.ToString(), out int tickets);
        if (!ticketsParsed)
            throw new Exception("Number of tickets should be numeric");
        if ((tickets <= 0))
            throw new Exception("client should reserve at least 1 ticket");

        return new EditReservationDTO()
        {
            Event_Id = _tempReservation.Event_Id,
            Client_Phone_Number = _tempReservation.Client_Phone_Number,
            Nb_Of_Tickets = tickets,
        };
    }

    private void FillTempReservation()
    {
        _tempReservation.Event_Id = _reservation.Event_Id;
        _tempReservation.Client_Phone_Number = _reservation.Client_Phone_Number;
        _tempReservation.Nb_Of_Tickets = _reservation.Nb_Of_Tickets;
    }
}
