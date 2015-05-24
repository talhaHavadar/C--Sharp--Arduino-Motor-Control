using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Threading;

namespace YonKontrolPaneli
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        /*
         * 0 - Ön motor
         * 1 - Arka Motor
         * 2 - Sağ Motor
         * 3 - Sol Motor
         */

        #region variables
        private SpeechRecognitionEngine dinle = new SpeechRecognitionEngine();
        private string[] sesliKomutlar = new string[] { "Up", "Down", "Balance", "Yüksel", "Alçal", "Dengele" };
        private String[] ports = null;
        private bool baglanti = false;
        private bool btIleriPress = false;
        private bool btGeriPress = false;
        private bool btYukselPress = false;
        private Control[] formKontrolElemanlari = null;
        private bool btAlcalPress = false;
        private static int onMotorGucu = 0;
        private static int arkaMotorGucu = 0;
        private static int sagMotorGucu = 0;
        private static int solMotorGucu = 0;
        private static int motorDengeGucu = 90;
        private byte onMotor = Convert.ToByte(onMotorGucu);
        private byte arkaMotor = Convert.ToByte(arkaMotorGucu);
        private byte sagMotor = Convert.ToByte(sagMotorGucu);
        private byte solMotor = Convert.ToByte(solMotorGucu);
        private Thread basla;
        #endregion

        #region functions

        private void kontrolPaneliElemanlariEnabled(bool durum)
        {
            for (int i = 0; i < formKontrolElemanlari.Length; i++)
            {
                formKontrolElemanlari[i].Enabled = durum;
            }
        }

        private void komutlarıEkle(string[] komutlar)
        {
            Choices gelenKomutlar = new Choices(komutlar);
            GrammarBuilder gBuilder = new GrammarBuilder(gelenKomutlar);
            Grammar grammer = new Grammar(gBuilder);
            dinle.LoadGrammar(grammer);
            
        }

        private void dinlemeyiBaslat()
        {
            dinle.SpeechDetected += dinle_SpeechDetected;
            dinle.SpeechRecognized += dinle_SpeechRecognized;
            dinle.SpeechRecognitionRejected += dinle_SpeechRecognitionRejected;
            dinle.RecognizeCompleted += dinle_RecognizeCompleted;
            
            basla = new Thread(delegate()
            {
                dinle.SetInputToDefaultAudioDevice();
                dinle.RecognizeAsync(RecognizeMode.Single);
            });
            basla.Start();

        }

        void dinle_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            dinle.RecognizeAsync();
            label6.Text += " Komut işlendi.";
        }

        void dinle_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            label6.Text = "Komut reddedildi!!";
        }

        void dinle_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Up" || e.Result.Text == "Yüksel")
            {
                label6.Text = "Up";
                for (int i = 0; i < 10; i++)
                {
                    tumMotorlarıYukselt();
                }
                
            }
            else if (e.Result.Text == "Balance" || e.Result.Text == "Dengele")
            {
                label6.Text = "Balance";
                motorlariDengele();
            }
            else if (e.Result.Text == "Down" || e.Result.Text == "Alçal")
            {
                label6.Text = "Down";
                for (int i = 0; i < 10; i++)
                {
                    tumMotorlariAlcalt();
                }
            }
        }

        void dinle_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            label6.Text = "Dinleme yapılıyor...";
        }

        private void motorlariDengele()
        {
            onMotorGucu = motorDengeGucu;
            arkaMotorGucu = motorDengeGucu;
            sagMotorGucu = motorDengeGucu;
            solMotorGucu = motorDengeGucu;
            onMotor = Convert.ToByte(onMotorGucu);
            arkaMotor = Convert.ToByte(arkaMotorGucu);
            sagMotor = Convert.ToByte(sagMotorGucu);
            solMotor = Convert.ToByte(solMotorGucu);
            updateProgressBars();
            port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
        }

        private void motorlariDurdur()
        {
            onMotorGucu = 0;
            arkaMotorGucu = 0;
            sagMotorGucu = 0;
            solMotorGucu = 0;

            onMotor = Convert.ToByte(onMotorGucu);
            arkaMotor = Convert.ToByte(arkaMotorGucu);
            sagMotor = Convert.ToByte(sagMotorGucu);
            solMotor = Convert.ToByte(solMotorGucu);
            updateProgressBars();
            port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
        }

        private void tumMotorlariAlcalt(){
            if (onMotorGucu == motorDengeGucu && arkaMotorGucu == motorDengeGucu && sagMotorGucu == motorDengeGucu && solMotorGucu == motorDengeGucu)
            {
                motorlariDurdur();
            }
            else
            {
                if (onMotorGucu > 0) { onMotorGucu -= 5; }
                if (arkaMotorGucu > 0) { arkaMotorGucu -= 5; }
                if (sagMotorGucu > 0) { sagMotorGucu -= 5; }
                if (solMotorGucu > 0) { solMotorGucu -= 5; }
                onMotor = Convert.ToByte(onMotorGucu);
                arkaMotor = Convert.ToByte(arkaMotorGucu);
                sagMotor = Convert.ToByte(sagMotorGucu);
                solMotor = Convert.ToByte(solMotorGucu);
                updateProgressBars();
                port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
            }
            
        }

        private void tumMotorlarıYukselt()
        {

            if (onMotorGucu == 0 && arkaMotorGucu == 0 && solMotorGucu == 0 && sagMotorGucu == 0)
            {
                onMotorGucu = motorDengeGucu;
                arkaMotorGucu = motorDengeGucu;
                solMotorGucu = motorDengeGucu;
                sagMotorGucu = motorDengeGucu;
            }
            else
            {
                if (onMotorGucu < 255) { onMotorGucu += 5; }
                if (arkaMotorGucu < 255) { arkaMotorGucu += 5; }
                if (sagMotorGucu < 255) { sagMotorGucu += 5; }
                if (solMotorGucu < 255) { solMotorGucu += 5; }
                
            }

            onMotor = Convert.ToByte(onMotorGucu);
            arkaMotor = Convert.ToByte(arkaMotorGucu);
            sagMotor = Convert.ToByte(sagMotorGucu);
            solMotor = Convert.ToByte(solMotorGucu);
            updateProgressBars();
            port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
        }

        private int yuzdeAl(int byteDegeri)
        {
            return (byteDegeri*100)/255;
        }

        private void updateProgressBars()
        {
            pbArkaMotor.Value = yuzdeAl(arkaMotorGucu);
            pbOnMotor.Value = yuzdeAl(onMotorGucu);
            pbSagMotor.Value = yuzdeAl(sagMotorGucu);
            pbSolMotor.Value = yuzdeAl(solMotorGucu);
        }
        
        #endregion
        private void AnaForm_Load(object sender, EventArgs e)
        {
            formKontrolElemanlari = new Control[gbKontrol.Controls.Count];
            gbKontrol.Controls.CopyTo(formKontrolElemanlari,0);
            komutlarıEkle(sesliKomutlar);
            ports = SerialPort.GetPortNames();
            cbPortList.DataSource = ports;
            gbKontrol.Enabled = false;
            gbMotorlar.Enabled = false;
        }

       

        private void btBaglan_Click(object sender, EventArgs e)
        {
            port.PortName = (string)cbPortList.SelectedItem;
            port.Open();
            MessageBox.Show(port.PortName + " portuna başarıyla bağlanıldı.");
            gbBaglanti.Enabled = false;
            gbKontrol.Enabled = true;
            gbMotorlar.Enabled = true;
            baglanti = true;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btIleriPress)
            {
                if (arkaMotorGucu < 255) { arkaMotorGucu += 15; }
                if (solMotorGucu < 255) { solMotorGucu += 15; }
                if (arkaMotorGucu > 255)
                {
                    arkaMotorGucu = 255;
                }
                if (solMotorGucu > 255)
                {
                    solMotorGucu = 255;
                }
                arkaMotor = Convert.ToByte(arkaMotorGucu);
                solMotor = Convert.ToByte(solMotorGucu);
                updateProgressBars();
                port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
            }
            else if (btGeriPress)
            {
                if (onMotorGucu < 255) { onMotorGucu += 15; }
                if (sagMotorGucu < 255) { sagMotorGucu += 15; }
                if (onMotorGucu > 255)
                {
                    onMotorGucu = 255;
                }
                if (sagMotorGucu > 255)
                {
                    sagMotorGucu = 255;
                }
                onMotor = Convert.ToByte(onMotorGucu);
                sagMotor = Convert.ToByte(sagMotorGucu);
                updateProgressBars();
                port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
            }
            else if (btYukselPress){
                tumMotorlarıYukselt();
            }
            else if (btAlcalPress)
            {
                tumMotorlariAlcalt();
            }
        }

        private void btIleri_MouseDown(object sender, MouseEventArgs e)
        {
            btIleriPress = true;
        }

        private void btIleri_MouseUp(object sender, MouseEventArgs e)
        {
            btIleriPress = false;
            motorlariDengele();
            
        }

        private void btYuksel_MouseDown(object sender, MouseEventArgs e)
        {
            btYukselPress = true;
        }

        private void btYuksel_MouseUp(object sender, MouseEventArgs e)
        {
            btYukselPress = false;
            motorlariDengele();
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write(new byte[] { onMotor, arkaMotor, sagMotor, solMotor }, 0, 4);
            }

        }

        int[] controllerMotorVerileri = {0,0,0,0};

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                controllerMotorVerileri[i] = port.ReadByte();  
            }
        }

        private void btAlcal_MouseDown(object sender, MouseEventArgs e)
        {
            btAlcalPress = true;
        }

        private void btAlcal_MouseUp(object sender, MouseEventArgs e)
        {
            btAlcalPress = false;
        }

        private void btOnMotor_Click(object sender, EventArgs e)
        {
            
            if (btOnMotor.Text == "ON")
            {
                btOnMotor.Text = "OFF";
                
                motorlariDengele();
                kontrolPaneliElemanlariEnabled(true);
                /*
                btIleri.Enabled = true;
                btGeri.Enabled = true;
                btYuksel.Enabled = true;
                btAlcal.Enabled = true;
                btSag.Enabled = true;
                cbSesliKomut.Enabled = true;
                btSol.Enabled = true;
                btSagaDon.Enabled = true;
                btSolaDon.Enabled = true;*/
            }
            else
            {
                btOnMotor.Text = "ON";
                motorlariDurdur();
                kontrolPaneliElemanlariEnabled(false);
                /*
                btIleri.Enabled = false;
                btGeri.Enabled = false;
                btYuksel.Enabled = false;
                btAlcal.Enabled = false;
                btSag.Enabled = false;
                btSol.Enabled = false;
                btSagaDon.Enabled = false;
                btSolaDon.Enabled = false;
                cbSesliKomut.Enabled = false;
                */
            }
        }

        private void cbSesliKomut_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSesliKomut.Checked)
            {
                dinlemeyiBaslat();
            }
            else
            {

            }
        }

        private void btGeri_MouseDown(object sender, MouseEventArgs e)
        {
            btGeriPress = true;
        }


        private void btGeri_MouseUp(object sender, MouseEventArgs e)
        {
            btGeriPress = false;
            motorlariDengele();
        }







    }
}
