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
    public partial class LoadingScreen : Form
    {
     

        public LoadingScreen()
        {

            InitializeComponent();
           
        }

   

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
           
            progressBar1.Maximum = 50;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.Value += 1;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                Bastube bastube = new Bastube();
                bastube.Show();
                this.Hide();
                timer1.Enabled = false;
                timer1.Stop();
                
            }
        }

       
    }
}
