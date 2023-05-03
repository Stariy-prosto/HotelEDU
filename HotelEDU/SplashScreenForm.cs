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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            if (resolution.Width <= 1366 || resolution.Height <= 768)
                this.Font = new Font("Segoe UI", 5.5F, FontStyle.Regular, GraphicsUnit.Point);
            //950; 530
            else
                this.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);

        }

    }
}
