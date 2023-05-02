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
            //Начальная настройка главной формы
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Text = "HotelEDU - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //Изменение размера вкладок tabPanel при изменении размеров окна
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
                    System.Threading.Thread.Sleep(3000);
                    //Команды, выполняемые перед запуском программы
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
            //Изменение размера вкладок tabPanel при изменении размеров окна
            if (MenuControl.Size.Width > 0 || MenuControl.ItemSize.Height > 0)
                MenuControl.ItemSize = new Size(MenuControl.Size.Width / MenuControl.TabPages.Count - 1, MenuControl.ItemSize.Height);
        }

        private void NewReservationButton_Click(object sender, EventArgs e)
        {
            //Открытие формы RateQueryForm как дочернее окно
            RateQueryForm rateQuery = new RateQueryForm();
            rateQuery.MdiParent = this;
            rateQuery.Show();
        }


        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            //Открытие формы RateQueryForm как дочернее окно
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Завершение работы без сохранения
            Application.Exit();
        }
    }
}
