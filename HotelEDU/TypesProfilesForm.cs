﻿using System;
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
    public partial class TypesProfilesForm : Form
    {
        public TypesProfilesForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (IndividualRadioButton.Checked == true )
            {
                IndividualProfileForm individualProfile = new IndividualProfileForm("Insert");
                individualProfile.MdiParent = (MainForm)this.MdiParent;
                individualProfile.Show();
            }
            else
            {
                if (CompanyRadioButton.Checked == true)
                {
                    OtherProfileForm otherProfile = new OtherProfileForm("CO", "Insert");
                    otherProfile.MdiParent = (MainForm)this.MdiParent;
                    otherProfile.Show();
                }
                else if (TravelAgentRadioButton.Checked == true)
                {
                    OtherProfileForm otherProfile = new OtherProfileForm("TA", "Insert");
                    otherProfile.MdiParent = (MainForm)this.MdiParent;
                    otherProfile.Show();
                }
                else if (SourceRadioButton.Checked == true)
                {
                    OtherProfileForm otherProfile = new OtherProfileForm("SO", "Insert");
                    otherProfile.MdiParent = (MainForm)this.MdiParent;
                    otherProfile.Show();
                }
                else if (GroupRadioButton.Checked == true)
                {
                    OtherProfileForm otherProfile = new OtherProfileForm("GP", "Insert");
                    otherProfile.MdiParent = (MainForm)this.MdiParent;
                    otherProfile.Show();
                }
                else if (ContactRadioButton.Checked == true)
                {
                    OtherProfileForm otherProfile = new OtherProfileForm("CT", "Insert");
                    otherProfile.MdiParent = (MainForm)this.MdiParent;
                    otherProfile.Show();
                }   
            }
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
