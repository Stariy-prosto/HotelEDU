using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace HotelEDU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "HotelEDU - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (MenuControl.Size.Width > 0 || MenuControl.ItemSize.Height > 0)
                MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
        }

        private void NewReservationButton_Click(object sender, EventArgs e)
        {
            var testForm = new TemplateForm();
            testForm.MdiParent = this;
            testForm.Show();
        }


        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
