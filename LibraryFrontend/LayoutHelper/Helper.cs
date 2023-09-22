using FontAwesome.Sharp;
using LibraryUI.AdditionalControls.CustomComboBox;
using System;
using System.Reflection;
using static System.Net.WebRequestMethods;

namespace LibraryUI.LayoutHelper
{
    public static class Helper
    {
        public static void CloseMainForm(object sender)
        {
            IconButton senderButton = (IconButton)sender;

            DialogResult dialogResult = MessageBox.Show
                (
                    "Are you sure you want to log out?",
                    caption: "logging out?",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
                //closes main form and gets back to login form
                senderButton.Parent.Parent.Parent.FindForm().Close();
        }

        //change menu button appearance on click
        public static IconButton? ActiveButton(object senderButton, IconButton? CurrentButton)
        {
            if (senderButton != null)
            {
                DisableButton(CurrentButton);
                //Change active button style

                CurrentButton = (IconButton)senderButton;
                CurrentButton.BackColor = Color.MediumTurquoise;
                CurrentButton.TextAlign = ContentAlignment.MiddleRight;
                CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;   
            }
            return CurrentButton;
        }

        //resets menu button appearance
        public static IconButton? DisableButton(IconButton? CurrentButton)
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.LightSkyBlue;
                CurrentButton.ForeColor = Color.Teal;
                CurrentButton.TextAlign = ContentAlignment.MiddleRight;
                CurrentButton.IconColor = Color.Teal;
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleCenter;
            }
            return CurrentButton;
        }

        //Opens Forms in panels
        public static Form OpenChildForm(Form childForm, Form? CurrentChildForm, Panel FormPanel)
        {
            //close previously opened child form
            CurrentChildForm?.Close();

            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FormPanel.AutoScroll = true;
            FormPanel.VerticalScroll.Enabled = true;
            FormPanel.Controls.Add(childForm);
            FormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            return CurrentChildForm;
        }

        //DataGridView Double Buffer
        public static void DGVDoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo? pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(dgv, setting, null);
        }

        //FlowLayoutpanel Double Buffer
        public static void FLPDoubleBuffered(FlowLayoutPanel flp, bool setting)
        {
            Type panelType = flp.GetType();
            PropertyInfo? pi = panelType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(flp, setting, null);
        }

        //Gets ID From nameAndId KeyValuePair
        public static int GetIdFromComboBox(CustomComboBox comboBox)
        {

            KeyValuePair<string, int> nameAndId = (KeyValuePair<string, int>)comboBox.SelectedItem;

            bool parsed = int.TryParse(nameAndId.Value.ToString(), out int id);
            if(parsed)
                return id;
            throw new Exception("Invalid Id");

        }

        //Gets Name From nameAndId KeyValuePair
        public static string GetNameFromComboBox(CustomComboBox comboBox)
        {
            KeyValuePair<string, int> nameAndId = (KeyValuePair<string, int>)comboBox.SelectedItem;

            string? name = nameAndId.Key.ToString();
            if (string.IsNullOrEmpty(name))
                throw new Exception("Invalid branch id");

            return name;
        }

        //Selects nameAndId KeyValuePair based on Id
        public static KeyValuePair<string, int>? SelectPairById(CustomComboBox comboBox, int id)
        {
            KeyValuePair<string, int> pair = new("name", id);
            foreach (KeyValuePair<string, int> item in comboBox.Items)
            {
                if (item.Value == pair.Value)
                    return item;
            }
            return null;
        }

        //Selects nameAndId KeyValuePair based on Name
        public static KeyValuePair<string, int>? SelectPairByName(CustomComboBox comboBox, string name)
        {
            KeyValuePair<string, int> pair = new(name, 0);
            foreach (KeyValuePair<string, int> item in comboBox.Items)
            {
                if (item.Key.Equals(pair.Key))
                    return item;
            }
            return null;
        }

        public static IconButton? Logout(object sender, IconButton? CurrentButton)
        {
            IconButton? tempButton = CurrentButton;
            CurrentButton = ActiveButton(sender, CurrentButton);
            CloseMainForm(sender);
            if (tempButton != null)
                CurrentButton = ActiveButton(tempButton, CurrentButton);
            else
                CurrentButton = DisableButton(CurrentButton);

            return CurrentButton;
        }

        public static string EscapeSingleQuote(string withSingleQuote)
        {
            return withSingleQuote.Replace("'", "''");
        }
    }
}
