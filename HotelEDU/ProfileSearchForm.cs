using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEDU
{
    public partial class ProfileSearchForm : Form
    {
        public ProfileSearchForm()
        {
            InitializeComponent();
            Load_Data();
        }

        private void Load_Data()
        {
            


        }



        private void CityButton_Click(object sender, EventArgs e)
        {

        }

        private void MemTypeButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = String.Empty;
            FirstNameTextBox.Text = String.Empty;
            ViewByComboBox.SelectedIndex = -1;
            CityTextBox.Text = String.Empty;
            MemTypeTextBox.Text = String.Empty;
            CommunicationTextBox.Text = String.Empty;
            PassportTextBox.Text = String.Empty;
            ShowInavtiveCheckBox.Checked = false;
            NegRatesCheckBox.Checked = false;
        }

        private void ViewByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            
            TypesProfilesForm typesProfiles = new TypesProfilesForm();
            typesProfiles.MdiParent = (MainForm)this.MdiParent;
            typesProfiles.Show();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            IndividualProfileForm profileForm = new IndividualProfileForm("Update", 1002);
            profileForm.MdiParent = (MainForm)this.MdiParent;
            profileForm.Show();
        }
    }
}
