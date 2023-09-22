using ClassLibrary.Models.Event;
using ClassLibrary.Models.Event.DTO;
using ClassLibrary.Models.IdAndNameDTO;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;
using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.EventDataAccess;

namespace LibraryUI.MainUIForms.EventChildForms.ChildForms;

public partial class EditEventForm : Form
{
    private readonly EventDataAccess _eventDataAccess;
    private readonly BranchDataAccess _branchDataAccess;
    private readonly Dispatcher _dispatcher;
    private Event tempEvent = new();

    public EditEventForm()
    {
        InitializeComponent();
        _eventDataAccess = new EventDataAccess();
        _branchDataAccess = new BranchDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private async void EditEvents_Load(object sender, EventArgs e)
    {
        await FillBranchNameComboBox();
        await FillEventNameComboBox();
        ReccurenceComboBox.SelectedIndex = 0;
    }

    private void EditEventRB_CheckedChanged(object sender, EventArgs e)
    {
        if (EditEventRB.Checked)
        {
            BranchNameComboBox.Enabled = true;
            EventDatePicker.Enabled = true;
            ReccurenceComboBox.Enabled = true;
            AvailableSeatsNumeric.Enabled = true;
            FeeNumeric.Enabled = true;
            DescriptionText.Enabled = true;
            EditEventButton.Text = "Update Event";
            EditEventButton.BackColor = Color.Teal;
            ResetButton.Enabled = true;
            LoadingLabel.Text = "Updating Event, please wait..";
        }
        else
        {
            BranchNameComboBox.Enabled = false;
            EventDatePicker.Enabled = false;
            ReccurenceComboBox.Enabled = false;
            AvailableSeatsNumeric.Enabled = false;
            FeeNumeric.Enabled = false;
            DescriptionText.Enabled = false;
            EditEventButton.Text = "Remove Event";
            EditEventButton.BackColor = Color.Crimson;
            ResetButton.Enabled = false;
            LoadingLabel.Text = "Removing Event, please wait..";
        }
    }

    private async void EventNameComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int eventId = Helper.GetIdFromComboBox(EventNameComboBox);
        await FillEventInfo(eventId);
    }

    private async void EditEventButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (EditEventRB.Checked)
            {

                Event @event = EventInfoValidated();

                if (@event.Equals(tempEvent))
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string eventUpdated = await _eventDataAccess.UpdateEvent(@event);

                tempEvent = @event;

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                eventUpdated,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
            }
            else
            {
                int eventId = Helper.GetIdFromComboBox(EventNameComboBox);

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string eventDeleted = await _eventDataAccess.DeleteEvent(eventId);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                eventDeleted,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );

                await FillEventNameComboBox();

            }
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

    //Functions

    private async Task FillEventInfo(int eventId)
    {
        try
        {
            EventDTO eventDTO = await _eventDataAccess.GetEventByID(eventId);

            var eventNamepair = Helper.SelectPairById(EventNameComboBox, eventId);
            var branchNamePair = Helper.SelectPairByName(BranchNameComboBox, eventDTO.Branch_Name);

            EventNameComboBox.SelectedIndex = EventNameComboBox.Items.IndexOf(eventNamepair);
            BranchNameComboBox.SelectedIndex = BranchNameComboBox.Items.IndexOf(branchNamePair);
            EventDatePicker.Value = DateTime.Parse(eventDTO.Date);
            ReccurenceComboBox.SelectedIndex = ReccurenceComboBox.Items.IndexOf(eventDTO.Recurrence);
            AvailableSeatsNumeric.Value = eventDTO.Available_seats;
            FeeNumeric.Value = (decimal)eventDTO.Fee;
            DescriptionText.Texts = eventDTO.Description;

            //Update TempEvent;
            tempEvent.Id = eventId;
            tempEvent.Name = eventDTO.Name;
            tempEvent.Date = eventDTO.Date;
            tempEvent.Branch_id = eventDTO.Branch_id;
            tempEvent.Available_seats = eventDTO.Available_seats;
            tempEvent.Fee = eventDTO.Fee;
            tempEvent.Recurrence = eventDTO.Recurrence;
            tempEvent.Description = eventDTO.Description;
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
            IEnumerable<NameAndIdDTO> namesAndIds = await _eventDataAccess.GetEventIdsAndNames();

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
                EventNameComboBox.DataSource = new BindingSource(namesAndIdsDict, null);
                EventNameComboBox.DisplayMember = "Key";
                EventNameComboBox.ValueMember = "Value";
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

    private Event EventInfoValidated()
    {
        int eventId = Helper.GetIdFromComboBox(EventNameComboBox);

        string eventName = Helper.GetNameFromComboBox(EventNameComboBox);

        string? eventDate = EventDatePicker.Value.ToString("yyyy-MM-dd");
        if (string.IsNullOrEmpty(eventDate))
            throw new Exception("Event date is required");
        if (eventName.Contains('\''))
            eventName = Helper.EscapeSingleQuote(eventName);

        int branchId = Helper.GetIdFromComboBox(BranchNameComboBox);

        bool seatsParsed = int.TryParse(AvailableSeatsNumeric.Value.ToString(), out int availableSeats);
        if (!seatsParsed)
            throw new Exception("Event seats should be numeric");
        if (availableSeats < 0)
            throw new Exception("event seats value should at least be 1");

        bool feeParsed = double.TryParse(FeeNumeric.Value.ToString(), out double fee);
        if (!feeParsed)
            throw new Exception("Reservation fee should be numeric");
        if (availableSeats < 0)
            throw new Exception("Reservation fee value should be positive");

        string? reccurence = ReccurenceComboBox.SelectedItem.ToString();
        if (string.IsNullOrEmpty(reccurence))
            throw new Exception("Event Reccurence is required");
        if (reccurence.Contains('\''))
            reccurence = Helper.EscapeSingleQuote(reccurence);

        string? description = DescriptionText.Texts;
        if (string.IsNullOrEmpty(description))
            throw new Exception("Event description is required");
        if (description.Contains('\''))
            description = Helper.EscapeSingleQuote(description);

        return new Event()
        {
            Id= eventId,
            Name = eventName,
            Branch_id = branchId,
            Date = eventDate,
            Available_seats = availableSeats,
            Fee = fee,
            Recurrence = reccurence,
            Description = description
        };
    }
}
