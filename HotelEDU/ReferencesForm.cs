using System;
using System.Collections;
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
    public partial class ReferencesForm : Form
    {
        private string Table { get; set; }


        public string SelectedValue { get; set; }

        public ReferencesForm(string table)
        {
            InitializeComponent();
            Table = table;
            Load_Data();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ReferencesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            string query = $"Select * from {Table} where Code Like '{FindTextBox.Text.ToUpper()}%'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ReferencesDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void Load_Data()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[1].ToString(); 
            string query = $"Select * from {Table}";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ReferencesDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void ReferencesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ReferencesDataGridView.SelectedRows.Count != 0)
                SelectedValue = ReferencesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
