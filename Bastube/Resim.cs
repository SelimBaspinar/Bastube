using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bastube
{
    public partial class Resim : Form
    {
        int MoveStat;
        int Mouse_X;
        int Mouse_Y;
        public Resim()
        {
            InitializeComponent();
        }

        private void Resim_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Interval = 1;
        }

       
        private void timer2_Tick(object sender, EventArgs e)
        {
            int k;
            this.Width = 680;
            for (k = 0;k<400;k++) {

                this.Height = k;
                
            }
            timer2.Stop();
      }
    
        private void Resim_MouseDown(object sender, MouseEventArgs e)
        {
            MoveStat = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void Resim_MouseUp(object sender, MouseEventArgs e)
        {
            MoveStat = 0;
        }


        private void Resim_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Resim_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveStat == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
    }
}
