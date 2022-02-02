namespace Bastube
{
    partial class Youtube
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Youtube));
            this.urltxt = new System.Windows.Forms.TextBox();
            this.btdownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbldurum = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.lblstat = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblyuzde = new System.Windows.Forms.Label();
            this.lblbastube = new System.Windows.Forms.Label();
            this.lblurl = new System.Windows.Forms.Label();
            this.lblformat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.thema = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mods = new System.Windows.Forms.ToolStripMenuItem();
            this.mod1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mod2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mod3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.guncellemeKontorl = new System.Windows.Forms.ToolStripMenuItem();
            this.rbmp4 = new System.Windows.Forms.RadioButton();
            this.rbmp3 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbmp41 = new System.Windows.Forms.RadioButton();
            this.rbmp31 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bopendownloadscreen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.urltxt.Location = new System.Drawing.Point(96, 115);
            this.urltxt.Multiline = true;
            this.urltxt.Name = "urltxt";
            this.urltxt.Size = new System.Drawing.Size(376, 27);
            this.urltxt.TabIndex = 5;
            // 
            // btdownload
            // 
            this.btdownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btdownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.btdownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdownload.ForeColor = System.Drawing.Color.White;
            this.btdownload.Location = new System.Drawing.Point(492, 113);
            this.btdownload.Name = "btdownload";
            this.btdownload.Size = new System.Drawing.Size(94, 31);
            this.btdownload.TabIndex = 6;
            this.btdownload.Text = "İndir";
            this.btdownload.UseVisualStyleBackColor = false;
            this.btdownload.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(687, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldurum.ForeColor = System.Drawing.Color.White;
            this.lbldurum.Location = new System.Drawing.Point(100, 197);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(25, 24);
            this.lbldurum.TabIndex = 9;
            this.lbldurum.Text = "...";
            // 
            // sfd
            // 
            this.sfd.Filter = "Mp4 |*.mp4|Mp3 |*.mp3|M4a |*.m4a|FLV |*.flv|Avi |*.avi|Wav |*.wav";
            // 
            // lblstat
            // 
            this.lblstat.AutoSize = true;
            this.lblstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstat.ForeColor = System.Drawing.Color.White;
            this.lblstat.Location = new System.Drawing.Point(12, 197);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(82, 24);
            this.lblstat.TabIndex = 12;
            this.lblstat.Text = "Durum : ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblyuzde
            // 
            this.lblyuzde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblyuzde.AutoSize = true;
            this.lblyuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyuzde.ForeColor = System.Drawing.Color.White;
            this.lblyuzde.Location = new System.Drawing.Point(13, 237);
            this.lblyuzde.Name = "lblyuzde";
            this.lblyuzde.Size = new System.Drawing.Size(35, 24);
            this.lblyuzde.TabIndex = 13;
            this.lblyuzde.Text = "%0";
            // 
            // lblbastube
            // 
            this.lblbastube.AutoSize = true;
            this.lblbastube.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbastube.ForeColor = System.Drawing.Color.White;
            this.lblbastube.Location = new System.Drawing.Point(54, 31);
            this.lblbastube.Name = "lblbastube";
            this.lblbastube.Size = new System.Drawing.Size(134, 37);
            this.lblbastube.TabIndex = 0;
            this.lblbastube.Text = "Bastube";
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurl.ForeColor = System.Drawing.Color.White;
            this.lblurl.Location = new System.Drawing.Point(12, 116);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(56, 24);
            this.lblurl.TabIndex = 14;
            this.lblurl.Text = "URL :";
            // 
            // lblformat
            // 
            this.lblformat.AutoSize = true;
            this.lblformat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblformat.ForeColor = System.Drawing.Color.White;
            this.lblformat.Location = new System.Drawing.Point(12, 152);
            this.lblformat.Name = "lblformat";
            this.lblformat.Size = new System.Drawing.Size(79, 24);
            this.lblformat.TabIndex = 15;
            this.lblformat.Text = "Format :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlar,
            this.hakkında});
            this.menuStrip1.Location = new System.Drawing.Point(0, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(133, 24);
            this.menuStrip1.TabIndex = 16;
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
            this.thema.Size = new System.Drawing.Size(180, 22);
            this.thema.Text = "Tema";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 22);
            this.exit.Text = "Çıkış";
            // 
            // mods
            // 
            this.mods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mod1ToolStripMenuItem,
            this.mod2ToolStripMenuItem,
            this.mod3ToolStripMenuItem});
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(180, 22);
            this.mods.Text = "Mod";
            // 
            // mod1ToolStripMenuItem
            // 
            this.mod1ToolStripMenuItem.Name = "mod1ToolStripMenuItem";
            this.mod1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mod1ToolStripMenuItem.Text = "Klasik";
            this.mod1ToolStripMenuItem.Click += new System.EventHandler(this.mod1ToolStripMenuItem_Click);
            // 
            // mod2ToolStripMenuItem
            // 
            this.mod2ToolStripMenuItem.Name = "mod2ToolStripMenuItem";
            this.mod2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mod2ToolStripMenuItem.Text = "Browser";
            this.mod2ToolStripMenuItem.Click += new System.EventHandler(this.mod2ToolStripMenuItem_Click);
            // 
            // mod3ToolStripMenuItem
            // 
            this.mod3ToolStripMenuItem.Name = "mod3ToolStripMenuItem";
            this.mod3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mod3ToolStripMenuItem.Text = "Mod 3";
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
            // rbmp4
            // 
            this.rbmp4.AutoSize = true;
            this.rbmp4.ForeColor = System.Drawing.Color.White;
            this.rbmp4.Location = new System.Drawing.Point(96, 155);
            this.rbmp4.Name = "rbmp4";
            this.rbmp4.Size = new System.Drawing.Size(47, 17);
            this.rbmp4.TabIndex = 17;
            this.rbmp4.TabStop = true;
            this.rbmp4.Text = "MP4";
            this.rbmp4.UseVisualStyleBackColor = true;
            this.rbmp4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbmp3
            // 
            this.rbmp3.AutoSize = true;
            this.rbmp3.ForeColor = System.Drawing.Color.White;
            this.rbmp3.Location = new System.Drawing.Point(149, 155);
            this.rbmp3.Name = "rbmp3";
            this.rbmp3.Size = new System.Drawing.Size(47, 17);
            this.rbmp3.TabIndex = 18;
            this.rbmp3.TabStop = true;
            this.rbmp3.Text = "MP3";
            this.rbmp3.UseVisualStyleBackColor = true;
            this.rbmp3.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "32 kbit/s",
            "96 kbit/s",
            "128 kbit/s",
            "192 kbit/s",
            "256 kbit/s",
            "320 kbit/s"});
            this.comboBox1.Location = new System.Drawing.Point(214, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 78);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(687, 200);
            this.webBrowser1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbmp41);
            this.panel1.Controls.Add(this.rbmp31);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(455, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 92);
            this.panel1.TabIndex = 22;
            // 
            // rbmp41
            // 
            this.rbmp41.AutoSize = true;
            this.rbmp41.ForeColor = System.Drawing.Color.White;
            this.rbmp41.Location = new System.Drawing.Point(16, 17);
            this.rbmp41.Name = "rbmp41";
            this.rbmp41.Size = new System.Drawing.Size(47, 17);
            this.rbmp41.TabIndex = 23;
            this.rbmp41.TabStop = true;
            this.rbmp41.Text = "MP4";
            this.rbmp41.UseVisualStyleBackColor = true;
            this.rbmp41.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbmp31
            // 
            this.rbmp31.AutoSize = true;
            this.rbmp31.ForeColor = System.Drawing.Color.White;
            this.rbmp31.Location = new System.Drawing.Point(16, 61);
            this.rbmp31.Name = "rbmp31";
            this.rbmp31.Size = new System.Drawing.Size(47, 17);
            this.rbmp31.TabIndex = 23;
            this.rbmp31.TabStop = true;
            this.rbmp31.Text = "MP3";
            this.rbmp31.UseVisualStyleBackColor = true;
            this.rbmp31.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "32 kbit/s",
            "96 kbit/s",
            "128 kbit/s",
            "192 kbit/s",
            "256 kbit/s",
            "320 kbit/s"});
            this.comboBox2.Location = new System.Drawing.Point(110, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(110, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 23;
            this.button4.Text = "İndir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Bastube.Properties.Resources.çizgi1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.button3.Location = new System.Drawing.Point(585, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Bastube.Properties.Resources._184028_200;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.button2.Location = new System.Drawing.Point(617, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Bastube.Properties.Resources.cross;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(650, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bastube.Properties.Resources.arrow_play_logo_vector_23987_136;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bopendownloadscreen
            // 
            this.bopendownloadscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bopendownloadscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(72)))), ((int)(((byte)(67)))));
            this.bopendownloadscreen.BackgroundImage = global::Bastube.Properties.Resources.download_button_1722967_1465259;
            this.bopendownloadscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bopendownloadscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bopendownloadscreen.ForeColor = System.Drawing.Color.White;
            this.bopendownloadscreen.Location = new System.Drawing.Point(631, 225);
            this.bopendownloadscreen.Name = "bopendownloadscreen";
            this.bopendownloadscreen.Size = new System.Drawing.Size(42, 41);
            this.bopendownloadscreen.TabIndex = 21;
            this.bopendownloadscreen.UseVisualStyleBackColor = false;
            this.bopendownloadscreen.Click += new System.EventHandler(this.bopendownloadscreen_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 72);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // Youtube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(687, 278);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btdownload);
            this.Controls.Add(this.rbmp3);
            this.Controls.Add(this.rbmp4);
            this.Controls.Add(this.lblyuzde);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblformat);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbastube);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblstat);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.urltxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bopendownloadscreen);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Youtube";
            this.Text = "Youtube";
            this.Load += new System.EventHandler(this.Youtube_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox urltxt;
        public System.Windows.Forms.Button btdownload;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label lbldurum;
        public System.Windows.Forms.SaveFileDialog sfd;
        public System.Windows.Forms.Label lblstat;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblyuzde;
        public System.Windows.Forms.Label lblbastube;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblurl;
        public System.Windows.Forms.Label lblformat;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ayarlar;
        public System.Windows.Forms.ToolStripMenuItem exit;
        public System.Windows.Forms.ToolStripMenuItem thema;
        public System.Windows.Forms.ToolStripMenuItem mods;
        public System.Windows.Forms.ToolStripMenuItem hakkında;
        public System.Windows.Forms.ToolStripMenuItem guncellemeKontorl;
        public System.Windows.Forms.RadioButton rbmp4;
        public System.Windows.Forms.RadioButton rbmp3;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ToolStripMenuItem mod1ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mod2ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mod3ToolStripMenuItem;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.Button bopendownloadscreen;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton rbmp41;
        public System.Windows.Forms.RadioButton rbmp31;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
    }
}