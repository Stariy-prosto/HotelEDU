using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEDU
{
    public partial class IndividualProfileForm : Form
    {
        private string EditMode { get; set; }
        private int ProfileID { get; set; }
        SqlConnection HotelEDUsqlConnection;

        public IndividualProfileForm(string editMode)
        {
            InitializeComponent();
            this.EditMode = editMode;
        }

        public IndividualProfileForm(string editMode, int profileID)
        {
            InitializeComponent();
            EditMode = editMode;
            ProfileID = profileID;
            Load_Data();
        }

        private void DateOfBitrhCalendarButton_Click(object sender, EventArgs e)
        {
            using (CalendarForm calendarForm = new CalendarForm())
            {
                if (calendarForm.ShowDialog() == DialogResult.OK)
                {
                    DateOfBirthMaskedTextBox.Text = calendarForm.SelectedDate;
                }
            }
        }

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            using (ReferencesForm references = new ReferencesForm("Languages"))
            {
                if (references.ShowDialog() == DialogResult.OK)
                {
                    LanguageTextBox.Text = references.SelectedValue;
                }
            }
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
                        WriteIndividualInformation();
                        GetProfileID();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        EditMode = "Update";
                        MessageBox.Show($"Пользователь {LastNameTextBox.Text} {FirstNameTextBox.Text} {MiddleNameTextBox.Text} добавлен!");
                        break;
                    case "Update":
                        WriteIndividualInformation();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        MessageBox.Show($"Пользователь {LastNameTextBox.Text} {FirstNameTextBox.Text} {MiddleNameTextBox.Text} обновлен!");
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
                        WriteIndividualInformation();
                        GetProfileID();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        Load_Data();
                        EditMode = "Update";
                        MessageBox.Show($"Пользователь {LastNameTextBox.Text} {FirstNameTextBox.Text} {MiddleNameTextBox.Text} добавлен!");
                        break;
                    case "Update":
                        WriteIndividualInformation();
                        if (CommunicationsType1TextBox.Text != null && Communications1TextBox.Text != null ||
                            CommunicationsType2TextBox.Text != null && Communications2TextBox.Text != null ||
                            CommunicationsType3TextBox.Text != null && Communications3TextBox.Text != null)
                            WriteCommunicationInformation();
                        Load_Data();
                        MessageBox.Show($"Пользователь {LastNameTextBox.Text} {FirstNameTextBox.Text} {MiddleNameTextBox.Text} обновлен!");
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
            IndividualProfileForm profileForm = new IndividualProfileForm("Insert");
            profileForm.MdiParent = (MainForm)this.MdiParent;
            profileForm.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteIndividualInformation()
        {
            ProfileIndividualsqlCommand.Connection = HotelEDUsqlConnection;
            if (EditMode == "Update")
                ProfileIndividualsqlCommand.Parameters["@profileID"].Value = ProfileID;
            ProfileIndividualsqlCommand.Parameters["@mode"].Value = EditMode;
            ProfileIndividualsqlCommand.Parameters["@lastname"].Value = LastNameTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@firstname"].Value = FirstNameTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@middlename"].Value = MiddleNameTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@language"].Value = LanguageTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@address"].Value = AddressTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@homeaddress"].Value = HomeAddressTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@city"].Value = CityTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@postalcode"].Value = PostalCodeTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@country"].Value = CountryTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@state"].Value = StateTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@solutation"].Value = SalutationTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@currency"].Value = CurrencyTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@dateofbirth"].Value = DateOfBirthMaskedTextBox.Text;
            ProfileIndividualsqlCommand.Parameters["@passport"].Value = PassportTextButton.Text;
            ProfileIndividualsqlCommand.ExecuteNonQuery();
        }

        private void WriteCommunicationInformation()
        {
            CommunicationSqlCommand.Connection = HotelEDUsqlConnection;
            CommunicationSqlCommand.Parameters["@mode"].Value = EditMode;
            CommunicationSqlCommand.Parameters["@profile"].Value = ProfileID;
            
            if(!String.IsNullOrEmpty(CommunicationsType1TextBox.Text) && !String.IsNullOrEmpty(Communications1TextBox.Text))
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

        private void Load_Data()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            string query = $"Select * from ProfileIndividual where ProfileID = {ProfileID}";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    var data = ds.Tables[0].Rows[0].ItemArray;
                    this.Text = $"Individual Profile ID - {data[0].ToString()}";
                    ClientIDTextBox.Text = data[0].ToString();
                    LastNameTextBox.Text = data[1].ToString();
                    FirstNameTextBox.Text = data[2].ToString();
                    MiddleNameTextBox.Text = data[3].ToString();
                    LanguageTextBox.Text = data[4].ToString();
                    AddressTextBox.Text = data[5].ToString();
                    HomeAddressTextBox.Text = data[6].ToString();
                    CityTextBox.Text = data[7].ToString();
                    PostalCodeTextBox.Text = data[8].ToString();
                    CountryTextBox.Text = data[9].ToString();
                    StateTextBox.Text = data[10].ToString();
                    SalutationTextBox.Text = data[11].ToString();
                    CurrencyTextBox.Text = data[12].ToString();
                    DateOfBirthMaskedTextBox.Text = data[13].ToString();
                    PassportTextButton.Text = data[14].ToString();
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

        private void GetProfileID()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            string query = $"Select top 1 ProfileID from ProfileIndividual order by ProfileID desc";
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


    }
}
