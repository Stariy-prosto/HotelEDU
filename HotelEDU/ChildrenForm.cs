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
    public partial class ChildrenForm : Form
    {
        public ChildrenForm()
        {
            InitializeComponent();
        }

        private void Children1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Children1TextBox.Text) >= 0 && Convert.ToInt32(Children1TextBox.Text) <= 3)
            {
                Age1TextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + 1).ToString();
            }
        }

        private void Children2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Children2TextBox.Text) >= 0 && Convert.ToInt32(Children2TextBox.Text) <= 3)
            {
                Age1TextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + 1).ToString();
            }
        }
    }
}
