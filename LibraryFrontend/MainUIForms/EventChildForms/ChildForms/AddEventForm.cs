using ClassLibrary.Models.Event;
using ClassLibrary.Models.IdAndNameDTO;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;
using ClassLibrary.DataAccess.BranchDataAccess;
using ClassLibrary.DataAccess.EventDataAccess;

namespace LibraryUI.MainUIForms.EventChildForms.ChildForms;

public partial class AddEventForm : Form
{
    private readonly BranchDataAccess _branchDataAccess;
    private readonly EventDataAccess _eventDataAccess;
    private readonly Dispatcher _dispatcher;

    public AddEventForm()
    {
        InitializeComponent();
        _branchDataAccess = new BranchDataAccess();
        _eventDataAccess = new EventDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private async void AddEventForm_Load(object sender, EventArgs e)
    {
        EventDatePicker.Value = DateTime.Now;
        EventDatePicker.MinDate = DateTime.Now;
        ReccurenceComboBox.SelectedIndex = 0;
        await FillBranchNameComboBox();
        BranchNameComboBox.SelectedIndex = 0;
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        EventDatePicker.Value = DateTime.Now;
        ReccurenceComboBox.SelectedIndex = 0;
        BranchNameComboBox.SelectedIndex = 0;
        EventNameText.Texts = string.Empty;
        DescriptionText.Texts = string.Empty;
        AvailableSeatsNumeric.Value = 1;
        FeeNumeric.Value = 1;
    }

    private async void AddEventButton_Click(object sender, EventArgs e)
    {
        try
        {
            Event @event = EventInputsVerified();

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;

            string eventAdded = await _eventDataAccess.AddEvent(@event);

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;

            MessageBox.Show(
            eventAdded,
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

    private Event EventInputsVerified()
    {
        string? eventName = EventNameText.Texts;
        if (string.IsNullOrEmpty(eventName))
            throw new Exception("Event name is required");
        if (eventName.Contains('\''))
            eventName = Helper.EscapeSingleQuote(eventName);

        string? eventDate = EventDatePicker.Value.ToString("yyyy-MM-dd");
        if (string.IsNullOrEmpty(eventDate))
            throw new Exception("Event date is required");

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
        if(string.IsNullOrEmpty(reccurence))
            throw new Exception("Event Reccurence is required");
        if (reccurence.Contains('\''))
            reccurence = Helper.EscapeSingleQuote(reccurence);

        string? description = DescriptionText.Texts;
        if(string.IsNullOrEmpty(description))
            throw new Exception("Event description is required");
        if (description.Contains('\''))
            description = Helper.EscapeSingleQuote(description);

        return new Event()
        {
            Name= eventName,
            Branch_id= branchId,
            Date= eventDate,
            Available_seats = availableSeats,
            Fee= fee,
            Recurrence = reccurence,
            Description = description
        };
    }
}
