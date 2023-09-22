using ClassLibrary.DataAccess.ClientDataAccess;
using FontAwesome.Sharp;

namespace LibraryUI.MainUIForms.ClientChildForms.ChildForms;

public partial class RemoveClientForm : Form
{

    private readonly ClientDataAccess _clientDataAccess;
    private readonly List<int> _idsToBeDeleted = new();
    private bool IsInitializing = true; //prevents adding an id to above list on load

    public RemoveClientForm()
    {
        InitializeComponent();
        _clientDataAccess = new ClientDataAccess();
    }

    //Events

    private void RemoveSingleRB_CheckedChanged(object sender, EventArgs e)
    {
        if (RemoveSingleRB.Checked)
        {
            SingleClientIdComboBox.Enabled = true;
            MultipleClientIdComboBox.Enabled = false;
            ResetButton.Enabled = false;
            _idsToBeDeleted.Clear();
            ToBeRemovedFLP.Controls.Clear();
            RemoveButton.Text = "Remove Client";
            LoadingLabel.Text = "Removing Client, please wait...";
        }
        else
        {
            SingleClientIdComboBox.Enabled = false;
            MultipleClientIdComboBox.Enabled = true;
            ResetButton.Enabled = true;
            RemoveButton.Text = "Remove Clients";
            LoadingLabel.Text = "Removing Clients, please wait...";

        }
    }

    private async void RemoveButton_Click(object sender, EventArgs e)
    {

        try
        {
            if (RemoveSingleRB.Checked)
            {
                bool parsed = int.TryParse(SingleClientIdComboBox.SelectedItem.ToString(), out int id);

                if (!parsed)
                    throw new Exception("Id should be a number");

                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to remove the selected client",
                    caption: "Confimation Message",
                    MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.No)
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeDeleted = await _clientDataAccess.DeleteClient(id);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                    employeeDeleted,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
            }
            else
            {
                if (!_idsToBeDeleted.Any())
                    throw new Exception("Please select at least one client to be deleted");

                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete the selected client(s)",
                    caption: "Confimation Message",
                    MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.No)
                    return;

                LoadingBar.Visible = true;
                LoadingLabel.Visible = true;

                string employeeDeleted = await _clientDataAccess.DeleteMultipleClients(_idsToBeDeleted);

                LoadingBar.Visible = false;
                LoadingLabel.Visible = false;

                MessageBox.Show(
                    employeeDeleted,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
            }

            IsInitializing = true;

            await FillSingleClientIdComboBox();
            await FillMultipleClientIdComboBox();

            ToBeRemovedFLP.Controls.Clear();

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

            ToBeRemovedFLP.Controls.Clear();

        }
    }

    private async void RemoveClientForm_Load(object sender, EventArgs e)
    {
        await FillSingleClientIdComboBox();
        await FillMultipleClientIdComboBox();
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        _idsToBeDeleted.Clear();
        ToBeRemovedFLP.Controls.Clear();
    }

    private void MultipleClientIdComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (!IsInitializing)
        {
            string? id = MultipleClientIdComboBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(id))
            {
                if (!_idsToBeDeleted.Contains(int.Parse(id)))
                {
                    AddIdToFLP(id);
                    _idsToBeDeleted.Add(int.Parse(id));
                }
            }
        }
    }

    private void Remove_Id_From_List(IconButton sender, EventArgs e)
    {
        _idsToBeDeleted.RemoveAt(_idsToBeDeleted.IndexOf(int.Parse(sender.Text)));
        sender.Dispose();
    }

    //Functions

    private async Task<IEnumerable<int>> GetAllClientIds()
    {
        return await _clientDataAccess.GetAllClientIds();
    }

    private async Task FillSingleClientIdComboBox()
    {
        try
        {
            IEnumerable<int> ids = await GetAllClientIds();

            SingleClientIdComboBox.DataSource = ids;
            SingleClientIdComboBox.DisplayMember = ids.First().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
        }
    }

    private async Task FillMultipleClientIdComboBox()
    {

        try
        {
            IEnumerable<int> ids = await GetAllClientIds();

            MultipleClientIdComboBox.DataSource = ids;
            MultipleClientIdComboBox.DisplayMember = ids.First().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }
        IsInitializing = false;
    }

    private void AddIdToFLP(string id)
    {
        IconButton button = new()
        {
            Size = new Size(120, 40),
            BackColor = Color.LightSkyBlue,
            FlatStyle = FlatStyle.Flat,
            Text = $"{id}",
            IconChar = IconChar.Remove,
            IconColor = Color.Teal,
            ForeColor = Color.Teal,
            TextImageRelation = TextImageRelation.TextBeforeImage,
            TextAlign = ContentAlignment.MiddleLeft,
            ImageAlign = ContentAlignment.MiddleCenter,
            IconSize = 34,
            Font = new Font("Segoe UI", 12)
        };

        button.Click += new EventHandler((sender, e) => Remove_Id_From_List(button, EventArgs.Empty));

        ToBeRemovedFLP.Controls.Add(button);
    }

}
