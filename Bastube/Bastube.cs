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
    public partial class Bastube : Form
    {
        int MoveStat;
        int Mouse_X;
        int Mouse_Y;
        int pencerestatus=0;
        public Bastube()
        {
            InitializeComponent();          
        }

      

        private void Bastube_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Thema == "Light")
            {
                Thema thema = new Thema();
                thema.LigthThema(this);
            }
            else {
                Thema thema = new Thema();
                thema.DarkThema(this);
            }
            this.Hide();
            btinstagram.FlatAppearance.BorderSize = 0;
            btfacebook.FlatAppearance.BorderSize = 0;
            
            btyoutube.FlatAppearance.BorderSize = 0;
            btnexit.FlatAppearance.BorderSize = 0;
            btnsmall.FlatAppearance.BorderSize = 0;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Youtube youtube = new Youtube();
            youtube.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            İnstagram instagram = new İnstagram();
            instagram.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pencerestatus == 0)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                pencerestatus = +1;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                pencerestatus = 0;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
 

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Thema = "Light";
            Properties.Settings.Default.Save();
            Thema thema = new Thema();
            thema.LigthThema(this);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Thema = "Dark";
            Properties.Settings.Default.Save();
            Thema thema = new Thema();
            thema.DarkThema(this);
           
        }

        private void btfacebook_Click(object sender, EventArgs e)
        {
            Facebook facebook = new Facebook();
            facebook.Show();
            this.Hide();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MoveStat = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveStat == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveStat = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
    }
}
