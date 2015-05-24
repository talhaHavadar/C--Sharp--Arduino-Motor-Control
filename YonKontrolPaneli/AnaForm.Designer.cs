namespace YonKontrolPaneli
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.gbBaglanti = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBaglan = new System.Windows.Forms.Button();
            this.cbPortList = new System.Windows.Forms.ComboBox();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.gbKontrol = new System.Windows.Forms.GroupBox();
            this.btOnMotor = new System.Windows.Forms.Button();
            this.btSag = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSol = new System.Windows.Forms.Button();
            this.btAlcal = new System.Windows.Forms.Button();
            this.btYuksel = new System.Windows.Forms.Button();
            this.btGeri = new System.Windows.Forms.Button();
            this.btSolaDon = new System.Windows.Forms.Button();
            this.btIleri = new System.Windows.Forms.Button();
            this.btSagaDon = new System.Windows.Forms.Button();
            this.gbMotorlar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbSolMotor = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pbSagMotor = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pbArkaMotor = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pbOnMotor = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbSesliKomut = new System.Windows.Forms.CheckBox();
            this.gbBaglanti.SuspendLayout();
            this.gbKontrol.SuspendLayout();
            this.gbMotorlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBaglanti
            // 
            this.gbBaglanti.Controls.Add(this.label1);
            this.gbBaglanti.Controls.Add(this.btBaglan);
            this.gbBaglanti.Controls.Add(this.cbPortList);
            this.gbBaglanti.Location = new System.Drawing.Point(12, 12);
            this.gbBaglanti.Name = "gbBaglanti";
            this.gbBaglanti.Size = new System.Drawing.Size(276, 69);
            this.gbBaglanti.TabIndex = 0;
            this.gbBaglanti.TabStop = false;
            this.gbBaglanti.Text = "Port Bağlantısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Portlar : ";
            // 
            // btBaglan
            // 
            this.btBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBaglan.Location = new System.Drawing.Point(185, 19);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(75, 38);
            this.btBaglan.TabIndex = 1;
            this.btBaglan.Text = "Bağlan";
            this.btBaglan.UseVisualStyleBackColor = true;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
            // 
            // cbPortList
            // 
            this.cbPortList.FormattingEnabled = true;
            this.cbPortList.Location = new System.Drawing.Point(58, 29);
            this.cbPortList.Name = "cbPortList";
            this.cbPortList.Size = new System.Drawing.Size(121, 21);
            this.cbPortList.TabIndex = 0;
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // gbKontrol
            // 
            this.gbKontrol.Controls.Add(this.cbSesliKomut);
            this.gbKontrol.Controls.Add(this.btOnMotor);
            this.gbKontrol.Controls.Add(this.btSag);
            this.gbKontrol.Controls.Add(this.btSol);
            this.gbKontrol.Controls.Add(this.btAlcal);
            this.gbKontrol.Controls.Add(this.btYuksel);
            this.gbKontrol.Controls.Add(this.btGeri);
            this.gbKontrol.Controls.Add(this.btSolaDon);
            this.gbKontrol.Controls.Add(this.btIleri);
            this.gbKontrol.Controls.Add(this.btSagaDon);
            this.gbKontrol.Location = new System.Drawing.Point(12, 87);
            this.gbKontrol.Name = "gbKontrol";
            this.gbKontrol.Size = new System.Drawing.Size(276, 335);
            this.gbKontrol.TabIndex = 1;
            this.gbKontrol.TabStop = false;
            this.gbKontrol.Text = "Kontrol Paneli";
            // 
            // btOnMotor
            // 
            this.btOnMotor.BackColor = System.Drawing.Color.Transparent;
            this.btOnMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOnMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOnMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btOnMotor.ForeColor = System.Drawing.Color.Black;
            this.btOnMotor.ImageKey = "on48.png";
            this.btOnMotor.Location = new System.Drawing.Point(117, 126);
            this.btOnMotor.Name = "btOnMotor";
            this.btOnMotor.Size = new System.Drawing.Size(42, 42);
            this.btOnMotor.TabIndex = 8;
            this.btOnMotor.Text = "ON";
            this.btOnMotor.UseVisualStyleBackColor = false;
            this.btOnMotor.Click += new System.EventHandler(this.btOnMotor_Click);
            // 
            // btSag
            // 
            this.btSag.Enabled = false;
            this.btSag.ImageIndex = 2;
            this.btSag.ImageList = this.ımageList1;
            this.btSag.Location = new System.Drawing.Point(185, 118);
            this.btSag.Name = "btSag";
            this.btSag.Size = new System.Drawing.Size(85, 59);
            this.btSag.TabIndex = 7;
            this.btSag.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.White;
            this.ımageList1.Images.SetKeyName(0, "geri64.png");
            this.ımageList1.Images.SetKeyName(1, "ileri64.png");
            this.ımageList1.Images.SetKeyName(2, "sag64.png");
            this.ımageList1.Images.SetKeyName(3, "sagadön64.png");
            this.ımageList1.Images.SetKeyName(4, "sol64.png");
            this.ımageList1.Images.SetKeyName(5, "soladön48.png");
            this.ımageList1.Images.SetKeyName(6, "on48.png");
            // 
            // btSol
            // 
            this.btSol.Enabled = false;
            this.btSol.ImageIndex = 4;
            this.btSol.ImageList = this.ımageList1;
            this.btSol.Location = new System.Drawing.Point(6, 118);
            this.btSol.Name = "btSol";
            this.btSol.Size = new System.Drawing.Size(85, 59);
            this.btSol.TabIndex = 6;
            this.btSol.UseVisualStyleBackColor = true;
            // 
            // btAlcal
            // 
            this.btAlcal.Enabled = false;
            this.btAlcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAlcal.Location = new System.Drawing.Point(81, 304);
            this.btAlcal.Name = "btAlcal";
            this.btAlcal.Size = new System.Drawing.Size(114, 25);
            this.btAlcal.TabIndex = 5;
            this.btAlcal.Text = "Alçal";
            this.btAlcal.UseVisualStyleBackColor = true;
            this.btAlcal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btAlcal_MouseDown);
            this.btAlcal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btAlcal_MouseUp);
            // 
            // btYuksel
            // 
            this.btYuksel.Enabled = false;
            this.btYuksel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btYuksel.Location = new System.Drawing.Point(81, 277);
            this.btYuksel.Name = "btYuksel";
            this.btYuksel.Size = new System.Drawing.Size(114, 25);
            this.btYuksel.TabIndex = 4;
            this.btYuksel.Text = "Yüksel";
            this.btYuksel.UseVisualStyleBackColor = true;
            this.btYuksel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btYuksel_MouseDown);
            this.btYuksel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btYuksel_MouseUp);
            // 
            // btGeri
            // 
            this.btGeri.Enabled = false;
            this.btGeri.ImageIndex = 0;
            this.btGeri.ImageList = this.ımageList1;
            this.btGeri.Location = new System.Drawing.Point(109, 199);
            this.btGeri.Name = "btGeri";
            this.btGeri.Size = new System.Drawing.Size(59, 72);
            this.btGeri.TabIndex = 3;
            this.btGeri.UseVisualStyleBackColor = true;
            this.btGeri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGeri_MouseDown);
            this.btGeri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btGeri_MouseUp);
            // 
            // btSolaDon
            // 
            this.btSolaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSolaDon.Enabled = false;
            this.btSolaDon.ImageIndex = 5;
            this.btSolaDon.ImageList = this.ımageList1;
            this.btSolaDon.Location = new System.Drawing.Point(201, 277);
            this.btSolaDon.Name = "btSolaDon";
            this.btSolaDon.Size = new System.Drawing.Size(69, 52);
            this.btSolaDon.TabIndex = 2;
            this.btSolaDon.UseVisualStyleBackColor = true;
            // 
            // btIleri
            // 
            this.btIleri.Enabled = false;
            this.btIleri.ImageIndex = 1;
            this.btIleri.ImageList = this.ımageList1;
            this.btIleri.Location = new System.Drawing.Point(109, 19);
            this.btIleri.Name = "btIleri";
            this.btIleri.Size = new System.Drawing.Size(59, 72);
            this.btIleri.TabIndex = 1;
            this.btIleri.UseVisualStyleBackColor = true;
            this.btIleri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btIleri_MouseDown);
            this.btIleri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btIleri_MouseUp);
            // 
            // btSagaDon
            // 
            this.btSagaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSagaDon.Enabled = false;
            this.btSagaDon.ImageIndex = 3;
            this.btSagaDon.ImageList = this.ımageList1;
            this.btSagaDon.Location = new System.Drawing.Point(6, 277);
            this.btSagaDon.Name = "btSagaDon";
            this.btSagaDon.Size = new System.Drawing.Size(69, 52);
            this.btSagaDon.TabIndex = 0;
            this.btSagaDon.UseVisualStyleBackColor = true;
            // 
            // gbMotorlar
            // 
            this.gbMotorlar.Controls.Add(this.label5);
            this.gbMotorlar.Controls.Add(this.pbSolMotor);
            this.gbMotorlar.Controls.Add(this.label4);
            this.gbMotorlar.Controls.Add(this.pbSagMotor);
            this.gbMotorlar.Controls.Add(this.label3);
            this.gbMotorlar.Controls.Add(this.pbArkaMotor);
            this.gbMotorlar.Controls.Add(this.label2);
            this.gbMotorlar.Controls.Add(this.pbOnMotor);
            this.gbMotorlar.Location = new System.Drawing.Point(12, 428);
            this.gbMotorlar.Name = "gbMotorlar";
            this.gbMotorlar.Size = new System.Drawing.Size(276, 137);
            this.gbMotorlar.TabIndex = 2;
            this.gbMotorlar.TabStop = false;
            this.gbMotorlar.Text = "Motorlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(197, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sol Motor";
            // 
            // pbSolMotor
            // 
            this.pbSolMotor.Location = new System.Drawing.Point(6, 106);
            this.pbSolMotor.Name = "pbSolMotor";
            this.pbSolMotor.Size = new System.Drawing.Size(189, 23);
            this.pbSolMotor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(198, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sağ Motor";
            // 
            // pbSagMotor
            // 
            this.pbSagMotor.Location = new System.Drawing.Point(6, 77);
            this.pbSagMotor.Name = "pbSagMotor";
            this.pbSagMotor.Size = new System.Drawing.Size(189, 23);
            this.pbSagMotor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(198, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arka Mot.";
            // 
            // pbArkaMotor
            // 
            this.pbArkaMotor.Location = new System.Drawing.Point(6, 48);
            this.pbArkaMotor.Name = "pbArkaMotor";
            this.pbArkaMotor.Size = new System.Drawing.Size(189, 23);
            this.pbArkaMotor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ön Motor";
            // 
            // pbOnMotor
            // 
            this.pbOnMotor.Location = new System.Drawing.Point(6, 19);
            this.pbOnMotor.Name = "pbOnMotor";
            this.pbOnMotor.Size = new System.Drawing.Size(189, 23);
            this.pbOnMotor.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = ".....";
            // 
            // cbSesliKomut
            // 
            this.cbSesliKomut.AutoSize = true;
            this.cbSesliKomut.Location = new System.Drawing.Point(9, 20);
            this.cbSesliKomut.Name = "cbSesliKomut";
            this.cbSesliKomut.Size = new System.Drawing.Size(81, 17);
            this.cbSesliKomut.TabIndex = 9;
            this.cbSesliKomut.Text = "Sesli Komut";
            this.cbSesliKomut.UseVisualStyleBackColor = true;
            this.cbSesliKomut.CheckedChanged += new System.EventHandler(this.cbSesliKomut_CheckedChanged);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 574);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbMotorlar);
            this.Controls.Add(this.gbKontrol);
            this.Controls.Add(this.gbBaglanti);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaForm";
            this.Text = "Yön Kontrol Paneli";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.gbBaglanti.ResumeLayout(false);
            this.gbBaglanti.PerformLayout();
            this.gbKontrol.ResumeLayout(false);
            this.gbKontrol.PerformLayout();
            this.gbMotorlar.ResumeLayout(false);
            this.gbMotorlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBaglanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBaglan;
        private System.Windows.Forms.ComboBox cbPortList;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.GroupBox gbKontrol;
        private System.Windows.Forms.Button btSagaDon;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btSag;
        private System.Windows.Forms.Button btSol;
        private System.Windows.Forms.Button btAlcal;
        private System.Windows.Forms.Button btYuksel;
        private System.Windows.Forms.Button btGeri;
        private System.Windows.Forms.Button btSolaDon;
        private System.Windows.Forms.Button btIleri;
        private System.Windows.Forms.GroupBox gbMotorlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbOnMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbSolMotor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbSagMotor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbArkaMotor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btOnMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSesliKomut;
    }
}

