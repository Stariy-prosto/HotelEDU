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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
        }

        private void NewReservationButton_Click(object sender, EventArgs e)
        {
            var testForm = new test();
            testForm.MdiParent = this;
            testForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
