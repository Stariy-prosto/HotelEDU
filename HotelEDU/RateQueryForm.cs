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

        private void ArrivalCalendarButton_Click(object sender, EventArgs e)
        {
            using(CalendarForm calendarForm = new CalendarForm())
            {
                if(calendarForm.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(DepartureTextBox.Text))
                    {
                        if (Convert.ToDateTime(calendarForm.SelectedDate) > Convert.ToDateTime(DepartureTextBox.Text))
                            MessageBox.Show("Дата въезда должна быть меньше даты выезда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            ArrivalTextBox.Text = calendarForm.SelectedDate;
                    }
                    else
                        ArrivalTextBox.Text = calendarForm.SelectedDate;
                }
            }
        }

        private void ArrivalTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(DepartureTextBox.Text))
                NightsTextBox.Text = (Convert.ToDateTime(DepartureTextBox.Text) - Convert.ToDateTime(ArrivalTextBox.Text)).Days.ToString();
        }

        private void DepartureCalendarButton_Click(object sender, EventArgs e)
        {
            using (CalendarForm calendarForm = new CalendarForm())
            {
                if (calendarForm.ShowDialog() == DialogResult.OK)
                {
                    if (Convert.ToDateTime(calendarForm.SelectedDate) < Convert.ToDateTime(ArrivalTextBox.Text))
                        MessageBox.Show("Дата выезда должна быть меньше даты въезда","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        DepartureTextBox.Text = calendarForm.SelectedDate;
                }
            }
        }

        private void DepartureTextBox_TextChanged(object sender, EventArgs e)
        {
            NightsTextBox.Text = (Convert.ToDateTime(DepartureTextBox.Text) - Convert.ToDateTime(ArrivalTextBox.Text)).Days.ToString();
        }

        private void CildrenButton_Click(object sender, EventArgs e)
        {
            ChildrenForm children = new ChildrenForm();
            children.ShowDialog();
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

        private void Age1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Age1TextBox.Text))
                ChildrenTextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + Convert.ToInt32(Age2TextBox.Text) + Convert.ToInt32(Age3TextBox.Text)).ToString();
            else
                ChildrenTextBox.Text = (Convert.ToInt32(Age2TextBox.Text) + Convert.ToInt32(Age3TextBox.Text)).ToString();
        }

        private void Age1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void Age2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Age2TextBox.Text))
                ChildrenTextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + Convert.ToInt32(Age2TextBox.Text) + Convert.ToInt32(Age3TextBox.Text)).ToString();
            else
                ChildrenTextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + Convert.ToInt32(Age3TextBox.Text)).ToString();
        }

        private void Age2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void Age3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Age3TextBox.Text))
                ChildrenTextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + Convert.ToInt32(Age2TextBox.Text) + Convert.ToInt32(Age3TextBox.Text)).ToString();
            else
                ChildrenTextBox.Text = (Convert.ToInt32(Age1TextBox.Text) + Convert.ToInt32(Age2TextBox.Text)).ToString();               
        }

        private void Age3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void AdultsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void NoOfRoomsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
 