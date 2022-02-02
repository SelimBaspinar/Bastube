namespace Bastube
{
    partial class İnstagram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İnstagram));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.thema = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mods = new System.Windows.Forms.ToolStripMenuItem();
            this.basitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instaDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaİndirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.guncellemeKontorl = new System.Windows.Forms.ToolStripMenuItem();
            this.lblbastube = new System.Windows.Forms.Label();
            this.lblpicturekind = new System.Windows.Forms.Label();
            this.lblurl = new System.Windows.Forms.Label();
            this.lblyuzde = new System.Windows.Forms.Label();
            this.lblstat = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.download = new System.Windows.Forms.Button();
            this.urltxt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.vCek = new System.Windows.Forms.Button();
            this.rCek = new System.Windows.Forms.Button();
            this.indır = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbllist = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pausebutton = new System.Windows.Forms.Button();
            this.playbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlar,
            this.hakkında});
            this.menuStrip1.Location = new System.Drawing.Point(4, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(133, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlar
            // 
            this.ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.ayarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thema,
            this.exit,
            this.mods});
            this.ayarlar.ForeColor = System.Drawing.Color.White;
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(56, 20);
            this.ayarlar.Text = "Ayarlar";
            // 
            // thema
            // 
            this.thema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.thema.Name = "thema";
            this.thema.Size = new System.Drawing.Size(102, 22);
            this.thema.Text = "Tema";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 22);
            this.exit.Text = "Çıkış";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mods
            // 
            this.mods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basitToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.instaDownloadToolStripMenuItem,
            this.kopyalaİndirToolStripMenuItem});
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(102, 22);
            this.mods.Text = "Mod";
            // 
            // basitToolStripMenuItem
            // 
            this.basitToolStripMenuItem.Name = "basitToolStripMenuItem";
            this.basitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.basitToolStripMenuItem.Text = "Resim";
            this.basitToolStripMenuItem.Click += new System.EventHandler(this.basitToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // instaDownloadToolStripMenuItem
            // 
            this.instaDownloadToolStripMenuItem.Name = "instaDownloadToolStripMenuItem";
            this.instaDownloadToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.instaDownloadToolStripMenuItem.Text = "İnsta İndir";
            this.instaDownloadToolStripMenuItem.Click += new System.EventHandler(this.instaDownloadToolStripMenuItem_Click);
            // 
            // kopyalaİndirToolStripMenuItem
            // 
            this.kopyalaİndirToolStripMenuItem.Name = "kopyalaİndirToolStripMenuItem";
            this.kopyalaİndirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kopyalaİndirToolStripMenuItem.Text = "Kopyala İndir";
            // 
            // hakkında
            // 
            this.hakkında.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncellemeKontorl});
            this.hakkında.ForeColor = System.Drawing.Color.White;
            this.hakkında.Name = "hakkında";
            this.hakkında.Size = new System.Drawing.Size(69, 20);
            this.hakkında.Text = "Hakkında";
            // 
            // guncellemeKontorl
            // 
            this.guncellemeKontorl.Name = "guncellemeKontorl";
            this.guncellemeKontorl.Size = new System.Drawing.Size(208, 22);
            this.guncellemeKontorl.Text = "Güncellemeleri Kontrol Et";
            // 
            // lblbastube
            // 
            this.lblbastube.AutoSize = true;
            this.lblbastube.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbastube.ForeColor = System.Drawing.Color.White;
            this.lblbastube.Location = new System.Drawing.Point(74, 40);
            this.lblbastube.Name = "lblbastube";
            this.lblbastube.Size = new System.Drawing.Size(134, 37);
            this.lblbastube.TabIndex = 18;
            this.lblbastube.Text = "Bastube";
            // 
            // lblpicturekind
            // 
            this.lblpicturekind.AutoSize = true;
            this.lblpicturekind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpicturekind.ForeColor = System.Drawing.Color.White;
            this.lblpicturekind.Location = new System.Drawing.Point(12, 162);
            this.lblpicturekind.Name = "lblpicturekind";
            this.lblpicturekind.Size = new System.Drawing.Size(118, 24);
            this.lblpicturekind.TabIndex = 31;
            this.lblpicturekind.Text = "Resim Türü :";
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurl.ForeColor = System.Drawing.Color.White;
            this.lblurl.Location = new System.Drawing.Point(12, 126);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(56, 24);
            this.lblurl.TabIndex = 30;
            this.lblurl.Text = "URL :";
            // 
            // lblyuzde
            // 
            this.lblyuzde.AutoSize = true;
            this.lblyuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyuzde.ForeColor = System.Drawing.Color.White;
            this.lblyuzde.Location = new System.Drawing.Point(263, 163);
            this.lblyuzde.Name = "lblyuzde";
            this.lblyuzde.Size = new System.Drawing.Size(35, 24);
            this.lblyuzde.TabIndex = 29;
            this.lblyuzde.Text = "%0";
            // 
            // lblstat
            // 
            this.lblstat.AutoSize = true;
            this.lblstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstat.ForeColor = System.Drawing.Color.White;
            this.lblstat.Location = new System.Drawing.Point(12, 207);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(82, 24);
            this.lblstat.TabIndex = 28;
            this.lblstat.Text = "Durum : ";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldurum.ForeColor = System.Drawing.Color.White;
            this.lbldurum.Location = new System.Drawing.Point(100, 207);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(25, 24);
            this.lbldurum.TabIndex = 27;
            this.lbldurum.Text = "...";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 615);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1108, 10);
            this.progressBar1.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Profil Resmi",
            "Resim"});
            this.comboBox1.Location = new System.Drawing.Point(136, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Location = new System.Drawing.Point(941, 123);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(90, 31);
            this.download.TabIndex = 24;
            this.download.Text = "İndir";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // urltxt
            // 
            this.urltxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.urltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urltxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urltxt.ForeColor = System.Drawing.Color.White;
            this.urltxt.Location = new System.Drawing.Point(96, 125);
            this.urltxt.Multiline = true;
            this.urltxt.Name = "urltxt";
            this.urltxt.Size = new System.Drawing.Size(807, 27);
            this.urltxt.TabIndex = 23;
            this.urltxt.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 223);
            this.listBox1.TabIndex = 33;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // vCek
            // 
            this.vCek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vCek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.vCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vCek.ForeColor = System.Drawing.Color.White;
            this.vCek.Location = new System.Drawing.Point(284, 571);
            this.vCek.Name = "vCek";
            this.vCek.Size = new System.Drawing.Size(90, 31);
            this.vCek.TabIndex = 35;
            this.vCek.Text = "Video Çek";
            this.vCek.UseVisualStyleBackColor = false;
            this.vCek.Click += new System.EventHandler(this.vCek_Click);
            // 
            // rCek
            // 
            this.rCek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rCek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.rCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rCek.ForeColor = System.Drawing.Color.White;
            this.rCek.Location = new System.Drawing.Point(993, 571);
            this.rCek.Name = "rCek";
            this.rCek.Size = new System.Drawing.Size(90, 31);
            this.rCek.TabIndex = 36;
            this.rCek.Text = "Resim Çek";
            this.rCek.UseVisualStyleBackColor = false;
            this.rCek.Click += new System.EventHandler(this.rCek_Click);
            // 
            // indır
            // 
            this.indır.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.indır.BackColor = System.Drawing.Color.White;
            this.indır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indır.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.indır.Location = new System.Drawing.Point(12, 571);
            this.indır.Name = "indır";
            this.indır.Size = new System.Drawing.Size(90, 31);
            this.indır.TabIndex = 37;
            this.indır.Text = "İndir";
            this.indır.UseVisualStyleBackColor = false;
            this.indır.Click += new System.EventHandler(this.indır_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllist.ForeColor = System.Drawing.Color.White;
            this.lbllist.Location = new System.Drawing.Point(2, 82);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(100, 24);
            this.lbllist.TabIndex = 39;
            this.lbllist.Text = "Resim List:";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(4, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(278, 223);
            this.listBox2.TabIndex = 42;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(288, 107);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(795, 458);
            this.webBrowser1.TabIndex = 44;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 338);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(270, 227);
            this.axWindowsMediaPlayer1.TabIndex = 45;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Bastube.Properties.Resources.çizgi1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.button3.Location = new System.Drawing.Point(1005, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Bastube.Properties.Resources._184028_200;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.button2.Location = new System.Drawing.Point(1037, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Bastube.Properties.Resources.cross;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(1069, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bastube.Properties.Resources.arrow_play_logo_vector_23987_136;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pausebutton
            // 
            this.pausebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pausebutton.BackColor = System.Drawing.Color.White;
            this.pausebutton.BackgroundImage = global::Bastube.Properties.Resources.pause_button_png_transparent_pause_buttonpng_images_pluspng_pause_button_png_512_512;
            this.pausebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.pausebutton.Location = new System.Drawing.Point(253, 540);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(29, 25);
            this.pausebutton.TabIndex = 41;
            this.pausebutton.UseVisualStyleBackColor = false;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // playbutton
            // 
            this.playbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playbutton.BackColor = System.Drawing.Color.White;
            this.playbutton.BackgroundImage = global::Bastube.Properties.Resources._580b57fcd9996e24bc43c4f9;
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.playbutton.Location = new System.Drawing.Point(223, 540);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(29, 25);
            this.playbutton.TabIndex = 40;
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(4, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 84);
            this.panel1.TabIndex = 73;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // İnstagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1105, 625);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.indır);
            this.Controls.Add(this.rCek);
            this.Controls.Add(this.vCek);
            this.Controls.Add(this.lblpicturekind);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.lblyuzde);
            this.Controls.Add(this.lblstat);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.download);
            this.Controls.Add(this.urltxt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbastube);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pausebutton);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "İnstagram";
            this.Text = "İnstagram";
            this.Load += new System.EventHandler(this.İnstagram_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ayarlar;
        public System.Windows.Forms.ToolStripMenuItem thema;
        public System.Windows.Forms.ToolStripMenuItem exit;
        public System.Windows.Forms.ToolStripMenuItem mods;
        public System.Windows.Forms.ToolStripMenuItem hakkında;
        public System.Windows.Forms.ToolStripMenuItem guncellemeKontorl;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblbastube;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblpicturekind;
        public System.Windows.Forms.Label lblurl;
        public System.Windows.Forms.Label lblyuzde;
        public System.Windows.Forms.Label lblstat;
        public System.Windows.Forms.Label lbldurum;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button download;
        public System.Windows.Forms.TextBox urltxt;
        public System.Windows.Forms.ToolStripMenuItem basitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem instaDownloadToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kopyalaİndirToolStripMenuItem;
        public System.Windows.Forms.Button vCek;
        public System.Windows.Forms.Button rCek;
        public System.Windows.Forms.Button indır;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Label lbllist;
        public System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        public System.Windows.Forms.Button playbutton;
        public System.Windows.Forms.Button pausebutton;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
    }
}