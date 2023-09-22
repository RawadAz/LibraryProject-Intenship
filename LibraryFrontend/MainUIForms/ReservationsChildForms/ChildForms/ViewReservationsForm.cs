using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.DataAccess.EventDataAccess;
using ClassLibrary.DataAccess.ReservationDataAccess;
using ClassLibrary.Models.IdAndNameDTO;
using ClassLibrary.Models.Reservation.DTO;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;

namespace LibraryUI.MainUIForms.ReservationsChildForms.ChildForms;

public partial class ViewReservationsForm : Form
{
    private readonly ClientDataAccess _clientDataAccess;
    private readonly ReservationDataAccess _reservationDataAccess;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly EventDataAccess _eventDataAccess;
    private readonly Dispatcher _dispatcher;

    public ViewReservationsForm()
    {
        InitializeComponent();
        Helper.DGVDoubleBuffered(ViewReservationsDGV, true);
        _clientDataAccess = new ClientDataAccess();
        _reservationDataAccess = new ReservationDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _eventDataAccess = new EventDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }
    
    //Events

    private async void ViewReservationsForm_Load(object sender, EventArgs e)
    {
        SearchComboBox.SelectedIndex = 0;
        await FillBranchNameComboBox();
        GetReservationsButton_Click(GetReservationsButton, e);
    }

    private async void SearchComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if(SearchComboBox.SelectedItem.Equals("All")) 
        {
            EventOrPhoneNumberComboBox.Visible = false;
            EventOrPhoneNumberLabel.Visible= false;
            BranchNameComboBox.Visible = false;
            BranchNameLabel.Visible = false;
        }
        if (SearchComboBox.SelectedItem.Equals("Event"))
        {
            EventOrPhoneNumberComboBox.Visible = true;
            EventOrPhoneNumberLabel.Visible = true;
            EventOrPhoneNumberLabel.Text = "Event Name :";
            BranchNameComboBox.Visible = true;
            BranchNameLabel.Visible = true;
            await FillEventNameComboBox();
        }
        if (SearchComboBox.SelectedItem.Equals("Client Phone Nb"))
        {
            EventOrPhoneNumberComboBox.Visible = true;
            EventOrPhoneNumberLabel.Visible = true;
            EventOrPhoneNumberLabel.Text = "Phone Number :";
            BranchNameComboBox.Visible = false;
            BranchNameLabel.Visible = false;
            await FillPhoneNumberComboBox();
        }
    }

    private void ViewReservationsDGV_Resize(object sender, EventArgs e)
    {
        if (ViewReservationsDGV.Width < 900)
            ViewReservationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        else
        {
            ViewReservationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

    public async void GetReservationsButton_Click(object sender, EventArgs e)
    {
        LoadingBar.Visible = true;
        LoadingLabel.Visible = true;

        try
        {
            string? searchMethod = SearchComboBox.SelectedItem.ToString();

            List<ReservationDTO> reservationsList = new();
            switch (searchMethod)
            {
                case "All":

                    IEnumerable<ReservationDTO> reservations = 
                        await _reservationDataAccess.GetAllReservations();

                    reservationsList.AddRange(reservations);

                    break;

                case "Client Phone Nb":

                    string? phoneNumber = EventOrPhoneNumberComboBox.SelectedItem.ToString();

                    IEnumerable<ReservationDTO> reservationsByPhoneNb = 
                        await _reservationDataAccess.GetReservationByPhoneNumber(phoneNumber);

                    reservationsList.AddRange(reservationsByPhoneNb);

                    break;

                case "Event":

                    string? eventName = EventOrPhoneNumberComboBox.SelectedItem.ToString();
                    string branchName = Helper.GetNameFromComboBox(BranchNameComboBox);

                    IEnumerable<ReservationDTO> reservationsByEvent =
                        await _reservationDataAccess.GetReservationsByEvent(eventName, branchName);

                    reservationsList.AddRange(reservationsByEvent);

                    break;
                
                default:

                    throw new Exception("please specify a way of searching");
            }

            ViewReservationsDGV.DataSource = reservationsList;
            ViewReservationsDGV.Enabled = true;

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

        }
        catch (Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            ex.Message,
            "Error occured",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
            );
        }
    }

    private async void ViewReservationsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            //delete button index is 10
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show
                    (
                        "Are you sure you want to cancel this reservation?",
                        caption: "Confimation Message",
                        MessageBoxButtons.YesNo,
                        icon: MessageBoxIcon.Question
                    );
                if (dialogResult == DialogResult.No)
                    return;

                int row = e.RowIndex;
                ReservationDTO reservation = (ReservationDTO)ViewReservationsDGV.Rows[row].DataBoundItem;

                DeleteReservationDTO deleteReservation = new()
                {
                    Event_Id = reservation.Event_Id,
                    Client_Phone_Number = reservation.Client_Phone_Number
                };

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeDeleted = await _reservationDataAccess.DeleteReservation(deleteReservation);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                    employeeDeleted,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );

                GetReservationsButton_Click(GetReservationsButton, e);

            }
            //edit button index is 9
            if (e.ColumnIndex == 9 && e.RowIndex >= 0)
            {

                int row = e.RowIndex;
                ReservationDTO reservation = (ReservationDTO)ViewReservationsDGV.Rows[row].DataBoundItem;

                EditReservationForm editTransactionsForm = new(reservation, this);
                editTransactionsForm.ShowDialog();

            }
        }
        catch (Exception ex)
        {
            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
                ex.Message,
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
    }

    private async void BranchNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (SearchComboBox.SelectedItem.Equals("Event"))
        {
            await FillEventNameComboBox();
        }
    }

    //Functions

    private async Task FillBranchNameComboBox()
    {
        try
        {
            IEnumerable<NameAndIdDTO> namesAndIds = await _branchDataAccess.GetBranchIdsAndNames();

            Dictionary<string, int> namesAndIdsDict = new();

            await Task.Run(() =>
            {
                Dictionary<string, int> temp = new();

                foreach (var nameAndId in namesAndIds)
                {
                    temp.Add(key: nameAndId.Name, value: nameAndId.Id);
                }
                _dispatcher.Invoke(() =>
                {
                    namesAndIdsDict.Clear();
                    namesAndIdsDict = temp;
                });
            });

            if (namesAndIdsDict.Count > 0)
            {

                BranchNameComboBox.DataSource = new BindingSource(namesAndIdsDict, null);
                BranchNameComboBox.DisplayMember = "Key";
                BranchNameComboBox.ValueMember = "Value";
            }
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

    private async Task FillEventNameComboBox()
    {
        try
        {
            int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

            IEnumerable<string> events = await _eventDataAccess.GetEventNamesByBranchId(branchId);
            EventOrPhoneNumberComboBox.DataSource = events;

        }
        catch (Exception ex)
        {

            EventOrPhoneNumberComboBox.DataSource = new List<string>();
            EventOrPhoneNumberComboBox.Texts = string.Empty;

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
    }

    private async Task FillPhoneNumberComboBox()
    {
        try
        {
            IEnumerable<string> phoneNumbers = await _clientDataAccess.GetClientPhoneNumbers();
            EventOrPhoneNumberComboBox.DataSource = phoneNumbers;

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
}
