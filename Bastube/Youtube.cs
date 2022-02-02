using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;


namespace Bastube
{
    public partial class Youtube : Form
    {
        NReco.VideoConverter.FFMpegConverter ffMpeg = new NReco.VideoConverter.FFMpegConverter();
        string FolderPath;
        string url;
        string videoname = "Bastube";
        string bitrate;
        int MoveStat;
        int Mouse_X;
        int Mouse_Y;
        int pencerestatus = 0;
        public Youtube()
        {
            InitializeComponent();
        }

        private void Youtube_Load(object sender, EventArgs e)
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
            Control.CheckForIllegalCrossThreadCalls = false;
            bopendownloadscreen.Hide();
            rbmp4.Checked = true;
            comboBox2.SelectedIndex = 4;
            comboBox1.Hide();
            panel1.Hide();
            webBrowser1.Hide();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
        }
      
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            Bastube bastube = new Bastube();
            bastube.Show();
            this.Close();
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

        public async Task<bool> downloadvideo() {
          
                var youtube = YouTube.Default;
                var video = await youtube.GetVideoAsync(url);
                lbldurum.Text = "İndirme Başladı";

                if (video.FullName.Contains(".mp4"))
                {
                    videoname = video.FullName.Replace(".mp4", "");
                }
                File.WriteAllBytes(FolderPath + @"\" + videoname + ".mp4", await video.GetBytesAsync());
                lbldurum.Text = "İndirme Tamamlandı";

            
           
            return true;
        }
        public void conventer() {
            backgroundWorker1.RunWorkerAsync();
            try
            {
                ffMpeg.ConvertMedia(FolderPath + @"\" + videoname + ".mp4", null, FolderPath + @"\" + videoname + ".mp3", null,
                      new ConvertSettings()
                      {
                          CustomOutputArgs = " -b:a " + bitrate
                      });
                File.Delete(FolderPath + @"\" + videoname + ".mp4");
                lbldurum.Text = "İndirme Tamamlandı !";
            }
            catch
            {
                timer1.Stop();
                MessageBox.Show("Dönüştürme Başarısız");
                lbldurum.Text = ("Dönüştürme Başarısız");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.ForeColor = Color.DarkSlateGray;
            lbldurum.Text = "Dosya Konumu Seçiliyor...";
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "İndirmek İstediğin Konumu Seç" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    FolderPath = fbd.SelectedPath;
                    timer1.Start();
                    lbldurum.Text = "Dosya Bilgileri Çekiliyor...";
                    url = urltxt.Text;

                    if (rbmp3.Checked == true)
                    {
                        if (comboBox1.SelectedItem.ToString() == "32 kbit/s")
                            bitrate = "32k";
                        else if (comboBox1.SelectedItem.ToString() == "96 kbit/s")
                            bitrate = "96k";
                        else if (comboBox1.SelectedItem.ToString() == "128 kbit/s")
                            bitrate = "128k";
                        else if (comboBox1.SelectedItem.ToString() == "192 kbit/s")
                            bitrate = "192k";
                        else if (comboBox1.SelectedItem.ToString() == "256 kbit/s")
                            bitrate = "256k";
                        else
                            bitrate = "320k";

                        if (await downloadvideo())
                        {
                            lbldurum.Text = "Dönüştürme İşlemi Başladı !";
                            await Task.Run(() => conventer());
                        }

                    }
                    else {
                       await downloadvideo();
                    }
                    }                                                       
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbmp3.Checked == true || rbmp31.Checked == true)
            {
                if (lbldurum.Text == "Dönüştürme İşlemi Başladı !")
                {
                    if (progressBar1.Value < 50)
                        progressBar1.Value = 50;
                }
                else if (lbldurum.Text == "İndirme Tamamlandı !")
                    progressBar1.Value = 100;
                {
                }
            }
            else {
                if (lbldurum.Text == "İndirme Tamamlandı")
                    progressBar1.Value = 100;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                lblyuzde.Text = "%100";
            }
            else
            {
                if (progressBar1.Value != 80)
                {
                    progressBar1.Value += 1;
                    lblyuzde.Text = "%" + Convert.ToString(progressBar1.Value);
                }

            }
        }
      

       
        private void button3_Click_2(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
            comboBox1.SelectedIndex = 4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Hide();
        }

        private void mod1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Dispose();
            WindowState = FormWindowState.Normal;
            lblyuzde.Show();
            lblbastube.Show();
            lblurl.Show();
            lblstat.Show();
            lblformat.Show();
            lbldurum.Show();
            rbmp4.Show();
            rbmp3.Show();
            bopendownloadscreen.Hide();
            if (rbmp3.Checked == true)
            comboBox1.Show();
            else
            comboBox1.Hide();
            btdownload.Show();
            urltxt.Show();
            webBrowser1.Hide();
            panel1.Hide();
            rbmp31.Hide();
            rbmp41.Hide();
            comboBox2.Show();
            this.Width = 687; 
            this.Height = 278;
        }
      
        private void mod2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com");
            lblyuzde.Hide();
            lblbastube.Hide();
            lblurl.Hide();
            lblstat.Hide();
            lblformat.Hide();
            lbldurum.Hide();
            rbmp4.Hide();
            rbmp3.Hide();
            rbmp31.Show();
            rbmp41.Show();
            comboBox2.Hide();
            urltxt.Hide();
            webBrowser1.Show();
            bopendownloadscreen.Show();
            panel1.Show();
            panel1.Height = 0;
            comboBox1.Hide();
            btdownload.Hide();
            WindowState = FormWindowState.Maximized;
        }

      

        private void bopendownloadscreen_Click(object sender, EventArgs e)
        {
            panel1.Height = 92;
            rbmp41.Checked = true;
            comboBox2.Hide();
            bopendownloadscreen.Hide();
        }

        private async void button4_Click_1(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.ForeColor = Color.DarkSlateGray;
            lbldurum.Text = "Dosya Konumu Seçiliyor...";
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "İndirmek İstediğin Konumu Seç" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    FolderPath = fbd.SelectedPath;
                    timer1.Start();
                    lbldurum.Text = "Dosya Bilgileri Çekiliyor...";
                    url = webBrowser1.Url.ToString() ;

                    if (rbmp31.Checked == true)
                    {
                        if (comboBox2.SelectedItem.ToString() == "32 kbit/s")
                            bitrate = "32k";
                        else if (comboBox2.SelectedItem.ToString() == "96 kbit/s")
                            bitrate = "96k";
                        else if (comboBox2.SelectedItem.ToString() == "128 kbit/s")
                            bitrate = "128k";
                        else if (comboBox2.SelectedItem.ToString() == "192 kbit/s")
                            bitrate = "192k";
                        else if (comboBox2.SelectedItem.ToString() == "256 kbit/s")
                            bitrate = "256k";
                        else
                            bitrate = "320k";
                        if (await downloadvideo())
                        {
                            if (progressBar1.Value < 50)
                                progressBar1.Value = 50;
                            lbldurum.Text = "Dönüştürme İşlemi Başladı !";
                            await Task.Run(() => conventer());
                        }

                    }
                    else
                    {
                        await downloadvideo();
                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Hide();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveStat = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveStat == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

       
 