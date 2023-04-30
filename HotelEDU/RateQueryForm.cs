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
    public partial class RateQueryForm : Form
    {
        public RateQueryForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            RateQueryDetailsForm rateQueryDetails = new RateQueryDetailsForm();
            rateQueryDetails.MdiParent = (MainForm)this.ParentForm;
            rateQueryDetails.Show();
        }
    }
}
