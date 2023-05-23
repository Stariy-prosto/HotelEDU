using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEDU
{
    public partial class OtherProfileForm : Form
    {
        private string EditMode { get; set; }
        private int ProfileID { get; set; }
        SqlConnection HotelEDUsqlConnection;

        public OtherProfileForm(string ProfileType, string EditMode)
        {
            InitializeComponent();
            TypeTextBox.Text = ProfileType;
            this.EditMode = EditMode;
        }

        private void CountryButton_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("Countries"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    CountryTextBox.Text = references.SelectedValue;
                }
            }
        }

        private void TypeButton_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("ProfileTypes"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    TypeTextBox.Text = references.SelectedValue;
                }
            }
        }

        private void OwnerButton_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("Owners"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    OwnerTextBox.Text = references.SelectedValue;
                }
            }
        }

        private void CurrencyButton_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("Currencies"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    CurrencyTextBox.Text = references.SelectedValue;
                }
            }
        }

        private void Communications1Button_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("CommunicationTypes"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    CommunicationsType1TextBox.Text = references.SelectedValue;
                }
            }
        }

        private void Communications2Button_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("CommunicationTypes"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    CommunicationsType2TextBox.Text = references.SelectedValue;
                }
            }
        }

        private void Communications3Button_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("CommunicationTypes"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    CommunicationsType3TextBox.Text = references.SelectedValue;
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                HotelEDUsqlConnection = new SqlConnection();
                HotelEDUsqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
                HotelEDUsqlConnection.Open();
                switch (EditMode)
                {
                    case "Insert":
                        WriteAccountInformation();
                        GetProfileID();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        EditMode = "Update";
                        MessageBox.Show($"Профиль {AccountTextBox.Text} добавлен!");
                        break;
                    case "Update":
                        WriteAccountInformation();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        MessageBox.Show($"Профиль {AccountTextBox.Text} обновлен!");
                        break;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                HotelEDUsqlConnection.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                HotelEDUsqlConnection = new SqlConnection();
                HotelEDUsqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
                HotelEDUsqlConnection.Open();
                switch (EditMode)
                {
                    case "Insert":
                        WriteAccountInformation();
                        GetProfileID();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        Load_Data();
                        EditMode = "Update";
                        MessageBox.Show($"Профиль {AccountTextBox.Text} добавлен!");
                        break;
                    case "Update":
                        WriteAccountInformation();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        Load_Data();
                        MessageBox.Show($"Профиль {AccountTextBox.Text} обновлен!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                HotelEDUsqlConnection.Close();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TypesProfilesForm profilesForm = new TypesProfilesForm();
            profilesForm.IndividualRadioButton.Enabled = false;
            profilesForm.MdiParent = (MainForm)this.MdiParent;
            profilesForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteAccountInformation()
        {
            ProfileOtherSqlCommand.Connection = HotelEDUsqlConnection;
            if (EditMode == "Update")
                ProfileOtherSqlCommand.Parameters["@profileID"].Value = ProfileID;
            ProfileOtherSqlCommand.Parameters["@mode"].Value = EditMode;
            ProfileOtherSqlCommand.Parameters["@account"].Value = AccountTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@address"].Value = AddressTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@araaddress"].Value = ARAAddressTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@country"].Value = CountryTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@state"].Value = StateTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@city"].Value = CityTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@postalcode"].Value = PostalCodeTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@owner"].Value = OwnerTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@type"].Value = TypeTextBox.Text;
            ProfileOtherSqlCommand.Parameters["@currency"].Value = CurrencyTextBox.Text;
            ProfileOtherSqlCommand.ExecuteNonQuery();
        }

        private void WriteCommunicationInformation()
        {
            CommunicationSqlCommand.Connection = HotelEDUsqlConnection;
            CommunicationSqlCommand.Parameters["@mode"].Value = EditMode;
            CommunicationSqlCommand.Parameters["@profile"].Value = ProfileID;

            if (!String.IsNullOrEmpty(CommunicationsType1TextBox.Text) && !String.IsNullOrEmpty(Communications1TextBox.Text))
            {
                CommunicationSqlCommand.Parameters["@communication"].Value = CommunicationsType1TextBox.Text;
                CommunicationSqlCommand.Parameters["@info"].Value = Communications1TextBox.Text;
                CommunicationSqlCommand.ExecuteNonQuery();
            }

            if (!String.IsNullOrEmpty(CommunicationsType2TextBox.Text) && !String.IsNullOrEmpty(Communications2TextBox.Text))
            {
                CommunicationSqlCommand.Parameters["@communication"].Value = CommunicationsType2TextBox.Text;
                CommunicationSqlCommand.Parameters["@info"].Value = Communications2TextBox.Text;
                CommunicationSqlCommand.ExecuteNonQuery();
            }

            if (!String.IsNullOrEmpty(CommunicationsType3TextBox.Text) && !String.IsNullOrEmpty(Communications3TextBox.Text))
            {
                CommunicationSqlCommand.Parameters["@communication"].Value = CommunicationsType3TextBox.Text;
                CommunicationSqlCommand.Parameters["@info"].Value = Communications3TextBox.Text;
                CommunicationSqlCommand.ExecuteNonQuery();
            }
        }

        private void GetProfileID()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            string query = $"Select top 1 ProfileID from ProfilesOther order by ProfileID desc";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var data = ds.Tables[0];
                    ProfileID = Convert.ToInt32(data.Rows[0].ItemArray[0]);
                }
            }
        }

        private void Load_Data()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            string query = $"Select * from ProfilesOther where ProfileID = {ProfileID}";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var data = ds.Tables[0].Rows[0].ItemArray;
                    CorporateIDTextBox.Text = data[0].ToString();
                    AccountTextBox.Text = data[1].ToString();
                    AddressTextBox.Text = data[2].ToString();
                    ARAAddressTextBox.Text = data[3].ToString();
                    CountryTextBox.Text = data[4].ToString();
                    StateTextBox.Text = data[5].ToString();
                    CityTextBox.Text = data[6].ToString();
                    PostalCodeTextBox.Text = data[7].ToString();
                    OwnerTextBox.Text = data[8].ToString();
                    TypeTextBox.Text = data[9].ToString();
                    CurrencyTextBox.Text = data[10].ToString();              
                }
            }

            query = $"Select CommunicationType ,Info from Communication_ProfileIndividual where ProfileIndividual = {ProfileID}";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        switch (ds.Tables[0].Rows.Count)
                        {
                            case 1:
                                var data = ds.Tables[0].Rows[0].ItemArray;
                                CommunicationsType1TextBox.Text = data[0].ToString();
                                Communications1TextBox.Text = data[1].ToString();
                                break;
                            case 2:
                                data = ds.Tables[0].Rows[0].ItemArray;
                                CommunicationsType1TextBox.Text = data[0].ToString();
                                Communications1TextBox.Text = data[1].ToString();
                                data = ds.Tables[0].Rows[1].ItemArray;
                                CommunicationsType2TextBox.Text = data[0].ToString();
                                Communications2TextBox.Text = data[1].ToString();
                                break;
                            case 3:
                                data = ds.Tables[0].Rows[0].ItemArray;
                                CommunicationsType1TextBox.Text = data[0].ToString();
                                Communications1TextBox.Text = data[1].ToString();
                                data = ds.Tables[0].Rows[1].ItemArray;
                                CommunicationsType2TextBox.Text = data[0].ToString();
                                Communications2TextBox.Text = data[1].ToString();
                                data = ds.Tables[0].Rows[2].ItemArray;
                                CommunicationsType2TextBox.Text = data[0].ToString();
                                Communications2TextBox.Text = data[1].ToString();
                                break;
                        }
                    }
                }
            }
        }
    }
}
