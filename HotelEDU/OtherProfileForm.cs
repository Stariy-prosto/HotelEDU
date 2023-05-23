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
    public partial class OtherProfileForm : Form
    {
        private string EditMode { get; set; }

        public OtherProfileForm(string ProfileType, string EditMode)
        {
            InitializeComponent();
            TypeTextBox.Text = ProfileType;
            this.EditMode = EditMode;
        }
    }
}
