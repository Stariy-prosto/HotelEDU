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
        SplashScreenForm SplashScreen;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Text = "HotelEDU - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
            //Загрузочное окно
            SplashScreenBackgroundWorker.WorkerReportsProgress = true;
            SplashScreenBackgroundWorker.WorkerSupportsCancellation = true;
            SplashScreen = new SplashScreenForm();
            //Загрузочное окно
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Загрузочное окно
            if (SplashScreenBackgroundWorker.IsBusy != true)
            {
                SplashScreen.Show();
                SplashScreenBackgroundWorker.RunWorkerAsync();
            }
            //Загрузочное окно
        }

        //Загрузочное окно
        private void SplashScreenBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (worker != null)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                }
                else
                {
                    //Обработка команд, выполняющихся перед запуском программы
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        private void SplashScreenBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SplashScreen.Close();
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
        }
        //Загрузочное окно

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (MenuControl.Size.Width > 0 || MenuControl.ItemSize.Height > 0)
                MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
        }

        private void NewReservationButton_Click(object sender, EventArgs e)
        {
            RateQueryForm rateQuery = new RateQueryForm();
            rateQuery.MdiParent = this;
            rateQuery.Show();
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
