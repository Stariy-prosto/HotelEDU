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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Закрытие формы ReservationForm
            this.Close();
        }

        private void NameSelectButton_Click(object sender, EventArgs e)
        {
            ProfileSearchForm profileSearchForm = new ProfileSearchForm();
            profileSearchForm.MdiParent = (MainForm)this.MdiParent;
            profileSearchForm.Show();
        }
    }
}
