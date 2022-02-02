using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bastube
{
    public partial class Facebook : Form
    {
        int MoveStat;
        int Mouse_X;
        int Mouse_Y;
        int pencerestatus = 0;
        List<String> uname = new List<String>();
        public Facebook()
        {
            InitializeComponent();
        }
        private void Facebook_Load(object sender, EventArgs e)
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
            webBrowser1.Navigate("https://www.facebook.com/");
            webBrowser1.Hide();
            this.Width = 689;
            this.Height = 289;
            listBox1.Hide();
            download.Show();
            urltxt.Show();
            lblurl.Show();
            lblstat.Show();
            lblyuzde.Show();
            lbldurum.Show();
        }
        private void basitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            webBrowser1.Hide();
            this.Width = 689;
            this.Height = 289;
            download.Show();
            urltxt.Show();
            lblurl.Show();
            lblstat.Show();
            lblyuzde.Show();
            lbldurum.Show();
        }

        private void download_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
                saveFileDialog1.Filter = "Png (*.png)|*.png |Jpeg (*.jpeg)|*.jpeg";
            WB_Yuklenmesini_Bekle();
                resimcek();
            try
            {
                listBox1.SelectedIndex = 1;
                indir();
            }
            catch {
                MessageBox.Show("Lütfen Geçerli Bir Url Giriniz Url'nin Resim İçerdiğine Emin Olun Video Henüz Desteklenmiyor!!");
            }
        }


        public void resimcek()
        {
            HtmlElementCollection link = webBrowser1.Document.GetElementsByTagName("img");
            String instaimglink;
            try
            {
                foreach (HtmlElement linkler in link)
                {
                    instaimglink = linkler.GetAttribute("src");
                    listBox1.Items.Add(instaimglink);
                }
            }
            catch
            {
                MessageBox.Show("Sayfanın Yüklenmesini Bekleyin veya Geçersiz Url", "          Bilgilendirme            ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void WB_Yuklenmesini_Bekle()
        {
            WebBrowserReadyState loadStatus = default(WebBrowserReadyState);
            int beklemeSuresi = 100000;
            int sayac = 0;
            while (true)
            {
                loadStatus = webBrowser1.ReadyState;
                Application.DoEvents();

                if ((sayac > beklemeSuresi) || (loadStatus == WebBrowserReadyState.Uninitialized) || (loadStatus == WebBrowserReadyState.Loading) || (loadStatus == WebBrowserReadyState.Interactive))
                {
                    break;
                }
                sayac += 1;
            }
            sayac = 0;
            while (true)
            {
                loadStatus = webBrowser1.ReadyState;
                Application.DoEvents();

                if (loadStatus == WebBrowserReadyState.Complete)
                {
                    break;
                }

                sayac += 1;
            }
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

