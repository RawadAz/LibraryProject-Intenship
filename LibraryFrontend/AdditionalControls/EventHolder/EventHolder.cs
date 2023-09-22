using LibraryUI.MainUIForms.EventChildForms.ChildForms;
using LibraryUI.MainUIForms.ReservationsChildForms.ChildForms;
using System.ComponentModel;

namespace LibraryUI.AdditionalControls.EventHolder
{
    public partial class EventHolder : UserControl
    {
        private readonly ViewEventForm _form;

        private Color backColor = Color.Teal;
        private Color foreColor = Color.WhiteSmoke;
        private Color buttonColor = Color.LightSkyBlue;
        private Color buttonForeColor = Color.Teal;
        private string buttonText = "Reserve a Seat";
        private string eventNameText = "Event Name";
        private string eventDateText = "Event Date";
        private string branchNameText = "Branch Name";
        private string availableSeats = "Seats";
        private string fee = "0$";
        private string reccurence = "None";
        private string description = "Description";
        private int event_Id;
        private int branch_Id;
        private int numeric_Available_Seats;
        private double numeric_Fee;

        public EventHolder(ViewEventForm form)
        {
            InitializeComponent();
            _form = form;
        }

        [Category("EventHolderInfo")]
        public new Color BackColor
        {
            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
                DescriptionText.BackColor = BackColor;
                HolderPanel.BackColor = backColor;
            }
        }

        [Category("EventHolderInfo")]
        public new Color ForeColor
        {
            get
            {
                return foreColor;
            }

            set
            {
                
                foreColor = value;
                HolderPanel.ForeColor = foreColor;
                EventNameLabel.ForeColor = foreColor;
                EventDateLabel.ForeColor = foreColor;
                DescriptionText.ForeColor = foreColor;
                BranchNameTitleLabel.ForeColor = foreColor;
                branchNameTextLabel.ForeColor = foreColor;
                AvaialableSeatsTitleLabel.ForeColor = foreColor;
                AvailableSeatsTextLabel.ForeColor = foreColor;
                ReccurenceTitleLabel.ForeColor = foreColor;
                ReccurenceTextLabel.ForeColor = foreColor;
            }
        }

        [Category("EventHolderInfo")]
        public Color ButtonColor
        {
            get
            {
                return buttonColor;
            }

            set
            {
                buttonColor = value;
                ReserveSeatbutton.BackColor = buttonColor;
            }
        }

        [Category("EventHolderInfo")]
        public Color ButtonForeColor
        {
            get
            {
                return buttonForeColor;
            }

            set
            {
                buttonForeColor = value;
                ReserveSeatbutton.ForeColor = buttonForeColor;
            }
        }

        [Category("EventHolderInfo")]
        public string ButtonText
        {
            get
            {
                return buttonText;
            }

            set
            {
                buttonText = value;
                ReserveSeatbutton.Text = buttonText;
            }
        }

        [Category("EventHolderInfo")]
        public string EventNameText 
        { 
            get
            {
                return eventNameText;
            }
            set
            {
                eventNameText = value;
                EventNameLabel.Text = eventNameText;
            } 
        }

        [Category("EventHolderInfo")]
        public string EventDateText 
        { 
            get
            {
                return eventDateText;
            }
            set
            {
                eventDateText = value;
                EventDateLabel.Text = eventDateText;
            } 
        }

        [Category("EventHolderInfo")]
        public string BranchNameText 
        {
            get
            {
                return branchNameText;
            }
            set
            {
                branchNameText = value;
                branchNameTextLabel.Text = branchNameText;
            } 
        }

        [Category("EventHolderInfo")]
        public string AvailableSeats 
        {
            get
            {
                return availableSeats;
            }
            set
            {           
                availableSeats = value;
                AvailableSeatsTextLabel.Text = availableSeats;
            } 
        }

        [Category("EventHolderInfo")]
        public string Reccurence
        { 
            get
            {
                return reccurence;
            }
            set
            {
                reccurence = value;
                ReccurenceTextLabel.Text = reccurence;
            } 
        }

        [Category("EventHolderInfo")]
        public string Description 
        { 
            get
            {
                return description;
            }
            set
            {
                description = value;
                DescriptionText.Text = description;
            }
        }

        [Category("EventHolderInfo")]
        public int Event_Id 
        { 
            get
            {
                return event_Id;
            }
            set
            {
                event_Id = value;
            } 
        }

        [Category("EventHolderInfo")]
        public int Branch_Id 
        { 
            get
            {
                return branch_Id;
            }
            set
            {
                branch_Id = value;
            } 
        }

        [Category("EventHolderInfo")]
        public string Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
                FeeText.Text = fee;
            }
        }

        [Category("EventHolderInfo")]
        public double Numeric_Fee
        {
            get
            {
                return numeric_Fee;
            }

            set
            {
                numeric_Fee = value;
            }
        }

        [Category("EventHolderInfo")]
        public int Numeric_Available_Seats
        {
            get
            {
                return numeric_Available_Seats;
            }

            set
            {
                numeric_Available_Seats = value;
            }
        }

        private void ReserveSeatbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EventNameText))
                throw new Exception("Event Not Found");
            if(string.IsNullOrEmpty(BranchNameText))
                throw new Exception("Event branch Not Found");

            AddReservationForm form = new(_form,Event_Id, EventNameText, BranchNameText, Numeric_Fee, Numeric_Available_Seats);
            form.ShowDialog();
        }
    }
}
