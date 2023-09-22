using ClassLibrary.DataAccess.ClientDataAccess;
using ClassLibrary.Models.Client;
using LibraryUI.LayoutHelper;

namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms
{
    public partial class ViewClientForm : Form
    {
        private readonly ClientDataAccess _clientDataAccess;
        private readonly string _username;

        public ViewClientForm(string username)
        {
            InitializeComponent();
            Helper.DGVDoubleBuffered(ViewClientsDGV, true);
            _username = username;
            _clientDataAccess = new ClientDataAccess();
            ViewClientsDGV.ScrollBars = ScrollBars.Both;
        }

        //Events

        private void SearchComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            string? searchMethod = SearchComboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(searchMethod))
            {
                throw new Exception("Invalid search method");
            }

            if (searchMethod.Equals("All"))
            {
                SearchText.Visible = false;
            }
            else if (searchMethod.Equals("Id"))
            {
                SearchText.Visible = true;
                SearchText.PlaceHolder = "Client Id";
            }
            else if (searchMethod.Equals("First Name"))
            {
                SearchText.Visible = true;
                SearchText.PlaceHolder = "Client First Name";
            }
            else if (searchMethod.Equals("Phone Number"))
            {
                SearchText.Visible = true;
                SearchText.PlaceHolder = "Client Phone Number";
            }
            else
                throw new Exception("Invalid search method");
        }

        public async void GetClientButton_Click(object sender, EventArgs e)
        {

            LoadingBar.Visible = true;
            LoadingLabel.Visible = true;


            try
            {
                string? searchMethod = SearchComboBox.SelectedItem.ToString();

                List<Client> clientList = new();

                switch (searchMethod)
                {
                    case "All":

                        IEnumerable<Client> clients = await _clientDataAccess.GetClients();
                        clientList.AddRange(clients);

                        break;

                    case "Id":

                        string IdText = SearchText.Texts;

                        if (string.IsNullOrEmpty(IdText))
                            throw new Exception("client Id is required");

                        bool parsed = int.TryParse(IdText, out int id);
                        if (!parsed)
                            throw new Exception("Client id should be numeric");

                        Client client = await _clientDataAccess.GetClientById(id);
                        clientList.Add(client);

                        break;

                    case "First Name":

                        string firstName = SearchText.Texts;

                        if(string.IsNullOrEmpty(firstName))
                            throw new Exception("Client first name is required");

                        IEnumerable<Client> clientsByName = await _clientDataAccess.GetClientsByFirstname(firstName);
                        clientList.AddRange(clientsByName);

                        break;
                   
                    case "Phone Number": 

                        string phoneNumber = SearchText.Texts;

                        if (string.IsNullOrEmpty(phoneNumber))
                            throw new Exception("client phone number is required");

                        if (!int.TryParse(phoneNumber, out int phoneNb))
                            throw new Exception("Client phone number should be numeric");

                        Client clientByPhoneNumber = await _clientDataAccess.GetClientsByPhoneNumber(phoneNumber);
                        clientList.Add(clientByPhoneNumber);

                        break;

                    default:

                        throw new Exception("please specify a way of searching");
                }
      
                ViewClientsDGV.DataSource = clientList;
                ViewClientsDGV.Enabled = true;

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

        public void ViewClientForm_Load(object sender, EventArgs e)
        {
            SearchComboBox.SelectedIndex = 0;
            GetClientButton_Click(GetClientButton, e);
        }

        private void ViewClientsDTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                try
                {
                    int row = e.RowIndex;
                    Client client = (Client)ViewClientsDGV.Rows[row].DataBoundItem;
                    int id = client.Id;

                    RentedBooksForm rentedBooks = new(_username, id, this);
                    rentedBooks.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error occured",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                }
            }
        }

        private void ViewClientForm_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width >= 800)
                ViewClientsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            else
                ViewClientsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
