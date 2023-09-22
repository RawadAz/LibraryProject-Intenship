using ClassLibrary.Models.Event.DTO;
using ClassLibrary.Models.IdAndNameDTO;
using LibraryUI.AdditionalControls.EventHolder;
using LibraryUI.LayoutHelper;
using System.Windows.Threading;
using ClassLibrary.DataAccess.EventDataAccess;

namespace LibraryUI.MainUIForms.EventChildForms.ChildForms;

public partial class ViewEventForm : Form
{
    private readonly EventDataAccess _eventDataAccess;
    private readonly Dispatcher _dispatcher;

    public ViewEventForm()
    {
        InitializeComponent();
        Helper.FLPDoubleBuffered(EventsFlowLayoutPanel, true);

        _eventDataAccess = new EventDataAccess();
        _dispatcher = Dispatcher.CurrentDispatcher;
    }

    //Events

    private async void ViewEventForm_Load(object sender, EventArgs e)
    {
        await FillSearchComboBox();
        SearchComboBox.SelectedIndex = 0;
    }

    public async void SearchComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int eventId = Helper.GetIdFromComboBox(SearchComboBox);
        await FillEventsFLP(eventId);
        EventsFlowLayoutPanel_Resize(EventsFlowLayoutPanel, e);
    }

    private void ViewEventForm_Resize(object sender, EventArgs e)
    {
        EventsFlowLayoutPanel_Resize(sender, e);
    }

    private void EventsFlowLayoutPanel_Resize(object sender, EventArgs e)
    {
        int count = EventsFlowLayoutPanel.Controls.Count;

        if(count > 0) 
        {
            EventsFlowLayoutPanel.Controls[0].Width = EventsFlowLayoutPanel.Width - 30;
        }
    }

    //Functions

    public async Task FillSearchComboBox()
    {
        try
        {
            IEnumerable<NameAndIdDTO> namesAndIds = await _eventDataAccess.GetEventIdsAndNames();

            Dictionary<string, int> namesAndIdsDict = new();

            await Task.Run(() =>
            {
                Dictionary<string, int> temp = new();

                temp.Add(key: "All", value: 0);

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
                SearchComboBox.DataSource = new BindingSource(namesAndIdsDict, null);
                SearchComboBox.DisplayMember = "Key";
                SearchComboBox.ValueMember = "Value";
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

    private async Task FillEventsFLP(int eventId)
    {
        try
        {
            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;
            if (eventId == 0)
            {
                IEnumerable<EventDTO>? eventList = await _eventDataAccess.GetAllEvents();

                if (eventList != null && eventList.Any())
                {
                    var eventHolders = new List<EventHolder>();

                    await Task.Run(() =>
                    {
                        foreach (var @event in eventList)
                        {
                            EventHolder eventHolder = new(this)
                            {
                                EventNameText = @event.Name,
                                EventDateText = @event.Date,
                                BranchNameText = @event.Branch_Name,
                                AvailableSeats = @event.Available_seats + " seats",
                                Fee = @event.Fee + "$",
                                Reccurence = @event.Recurrence,
                                Description = @event.Description,
                                Branch_Id = @event.Branch_id ?? 0,
                                Event_Id = @event.Id,
                                Numeric_Fee = @event.Fee,
                                Numeric_Available_Seats = @event.Available_seats
                            };

                            eventHolders.Add(eventHolder);
                        }
                        _dispatcher.Invoke(() =>
                        {
                            EventsFlowLayoutPanel.Controls.Clear();

                            foreach (var eventHolder in eventHolders)
                            {
                                EventsFlowLayoutPanel.Controls.Add(eventHolder);
                                eventHolder.AutoSize = false;
                                eventHolder.Dock = DockStyle.Top;
                            }
                            EventsFlowLayoutPanel.Controls[0].Dock = DockStyle.None;
                        });
                    });
                }

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;
            }
            else
            {
                EventDTO @event = await _eventDataAccess.GetEventByID(eventId);

                EventHolder eventHolder = new(this)
                {
                    EventNameText = @event.Name,
                    EventDateText = @event.Date,
                    BranchNameText = @event.Branch_Name,
                    AvailableSeats = $"{@event.Available_seats} seats",
                    Fee = $"{@event.Fee} $",
                    Reccurence = @event.Recurrence,
                    Description = @event.Description,
                    Branch_Id = @event.Branch_id ?? 0,
                    Event_Id = @event.Id,
                    Numeric_Fee = @event.Fee,
                    Numeric_Available_Seats = @event.Available_seats
                };

                EventsFlowLayoutPanel.Controls.Clear();
                EventsFlowLayoutPanel.Controls.Add(eventHolder);
            }

            LoadingBar.Visible = false;
            LoadingLabel.Visible = false;
            
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


}
