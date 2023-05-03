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
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            if (resolution.Width <= 1366 || resolution.Height <= 768)
                this.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            else
                this.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Открытие формы RateQueryDetailsForm как дочернее окно
            RateQueryDetailsForm rateQueryDetails = new RateQueryDetailsForm();
            rateQueryDetails.MdiParent = (MainForm)this.ParentForm;
            rateQueryDetails.Show();
        }
    }
}
