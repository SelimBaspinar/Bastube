
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bastube
{

    public partial class İnstagram : Form
    {
        int MoveStat;
        int Mouse_X;
        int Mouse_Y;
        int pencerestatus = 0;
        Boolean videodurum = false;
        Boolean modr = false;
        List<String> uname = new List<String>();
        public İnstagram()
        {
            InitializeComponent();
        }

        private void basitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            webBrowser1.Hide();
            comboBox1.SelectedIndex = 0;
            comboBox1.Show();
            modr = true;
            this.Width = 689;
            this.Height = 289;
            pictureBox2.Hide();

            pausebutton.Hide();
            playbutton.Hide();
            rCek.Hide();
            vCek.Hide();
            indır.Hide();
            listBox2.Hide();
            axWindowsMediaPlayer1.Hide();
            download.Show();
            urltxt.Show();
            lblurl.Show();
            lblstat.Show();
            lblpicturekind.Show();
            lbllist.Hide();
            comboBox1.Show();
            lblyuzde.Show();
            lbldurum.Show();
        }

        private void download_Click(object sender, EventArgs e)
        {

            if (modr == true)
            {
              
                    listBox1.Items.Clear();
                    saveFileDialog1.Filter = "Png (*.png)|*.png |Jpeg (*.jpeg)|*.jpeg";
                    resimcek();
                    listBox1.SelectedIndex = Convert.ToString(comboBox1.SelectedItem) == "Profil Resmi" ? 0 : 1;
                    indir();
               

            }
            else
            {

                listBox1.Items.Clear();
                saveFileDialog1.Filter = "Mp4 (*.mp4)|*.mp4 |Wav (*.wav)|*.wav";
                videocek();
                listBox1.SelectedIndex = 0;
                indir();
            }



        }

        private void İnstagram_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Thema == "Light")
            {
                Thema thema = new Thema();
                thema.LigthThema(this);
            }
            else
            {
                Thema thema = new Thema();
                thema.DarkThema(this);
            }
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;

            comboBox1.SelectedIndex = 0;
            modr = true;
            webBrowser1.Navigate("https://www.instagram.com/");
            webBrowser1.Hide();
            this.Width = 689;
            this.Height = 289;
            pictureBox2.Hide();
            listBox1.Hide();
            listBox2.Hide();
            rCek.Hide();
            vCek.Hide();
            indır.Hide();
            axWindowsMediaPlayer1.Hide();
            pausebutton.Hide();
            playbutton.Hide();
            download.Show();
            urltxt.Show();
            lblurl.Show();
            lblstat.Show();
            lblpicturekind.Show();
            lbllist.Hide();
            comboBox1.Show();
            lblyuzde.Show();
            lbldurum.Show();
        }
        public void resimcek()
        {
            HtmlElementCollection link = webBrowser1.Document.GetElementsByTagName("img");
            String instaimglink;
            String instaimgname;
            try
            {
                foreach (HtmlElement linkler in link)
                {
                    instaimglink = linkler.GetAttribute("src");
                    instaimgname = linkler.GetAttribute("alt");

                    if (instaimgname == "")
                    {
                        listBox2.Items.Add("Video Thumbnail");
                    }
                    else
                    {
                        listBox2.Items.Add(instaimgname);
                    }
                    listBox1.Items.Add(instaimglink);
                }
            }
            catch
            {
                MessageBox.Show("Sayfanın Yüklenmesini Bekleyin veya Geçersiz Url", "          Bilgilendirme            ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void videocek()
        {
            try
            {
                String baslink;
                HtmlElementCollection link = webBrowser1.Document.GetElementsByTagName("video");
                
                foreach (HtmlElement linkler in link)
                {
                    baslink = linkler.GetAttribute("src");
                    listBox1.Items.Add(baslink);
                }

            }
            catch
            {
                MessageBox.Show("Sayfanın Yüklenmesini Bekleyin veya Geçersiz Url", "          Bilgilendirme            ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        private void rCek_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox2.Show();
            videodurum = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            pictureBox2.Show();
            axWindowsMediaPlayer1.Hide();
            pausebutton.Hide();
            playbutton.Hide();
            saveFileDialog1.Filter = "Png (*.png)|*.png |Jpeg (*.jpeg)|*.jpeg";
            resimcek();

        }
        private void vCek_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Mp4 (*.mp4)|*.mp4 |Wav (*.wav)|*.wav";
            videodurum = true;
            listBox2.Hide();
            listBox1.Show();
            listBox1.Items.Clear();
            pictureBox2.Hide();
            axWindowsMediaPlayer1.Show();
            pausebutton.Show();
            playbutton.Show();
            videocek();

        }

        private void instaDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1105;
            this.Height = 625;
            pictureBox2.Show();
            webBrowser1.Show();
            rCek.Show();
            vCek.Show();
            indır.Show();
            listBox2.Show();
            axWindowsMediaPlayer1.Hide();
            pausebutton.Hide();
            playbutton.Hide();
            download.Hide();
            urltxt.Hide();
            lblurl.Hide();
            lblstat.Hide();
            lblpicturekind.Hide();
            lbllist.Show();
            comboBox1.Hide();
            lblyuzde.Hide();
            lbldurum.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videodurum == false)
            {
                pictureBox2.ImageLocation = Convert.ToString(listBox1.SelectedItem);
            }
            else
            {
                axWindowsMediaPlayer1.URL = Convert.ToString(listBox1.SelectedItem);
            }
        }
        public void indir()
        {

            saveFileDialog1.ShowDialog();
            String path = saveFileDialog1.FileName;
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(Convert.ToString(listBox1.SelectedItem)), path);
        }
        private void indır_Click(object sender, EventArgs e)
        {

            indir();

        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblyuzde.Text = Convert.ToString(progressBar1.Value);

        }
        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("İndirme Tamamlandı", "        Bilgilendirme         ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            webBrowser1.Hide();
            lbldurum.Hide();
            lblstat.Hide();
            lblpicturekind.Hide();
            modr = false;
            comboBox1.Hide();
            this.Width = 689;
            this.Height = 289;
            pictureBox2.Hide();
            pausebutton.Hide();
            playbutton.Hide();
            rCek.Hide();
            vCek.Hide();
            indır.Hide();
            listBox2.Hide();
            axWindowsMediaPlayer1.Hide();
            download.Show();
            urltxt.Show();
            lblurl.Show();
            lbllist.Hide();
            lblyuzde.Hide();
        }

        private void url_TextChanged(object sender, EventArgs e)
        {

            webBrowser1.Navigate(urltxt.Text);
        }

       

        
        private void button1_Click(object sender, EventArgs e)
        {
            Bastube bastube = new Bastube();
            bastube.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Resim resim = new Resim();
            resim.Show();

            resim.BackgroundImage = pictureBox2.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Bastube bastube = new Bastube();
            bastube.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveStat = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveStat == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveStat = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Thema = "Dark";
            Properties.Settings.Default.Save();
            Thema thema = new Thema();
            thema.DarkThema(this);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Thema = "Light";
            Properties.Settings.Default.Save();
            Thema thema = new Thema();
            thema.LigthThema(this);
        }
    }
}
