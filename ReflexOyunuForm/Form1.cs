using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexOyunuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hak;
        int skor;
        int sayac=80;
        bool bayrak = false;
        bool bayrak2 = false;

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBaslat.Enabled = false;
            

            string[] yön = { "yukarı", "aşağı", "sağ", "sol"};
            string[] sasıtrma = {"yukarı değil","aşağı değil","sağ değil","sol değil" };

            Random rnd = new Random();
            int randomSayı = rnd.Next(4);

            lblOrta.Text = yön[randomSayı];
        }

        private void Key_Press_Up(object sender, KeyEventArgs e)
        {
            string[] yön = { "yukarı", "aşağı", "sağ", "sol"};
            string[] sasırtma = { "yukarı değil", "aşağı değil", "sağ değil", "sol değil" };

            Random rnd = new Random();
            int randomSayı = rnd.Next(4);

            hak = 1;
            string algılananTus="";

            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                algılananTus= e.KeyCode.ToString();

                if (algılananTus=="Up")
                {
                    algılananTus = "yukarı";
                }
                else if (algılananTus=="Down")
                {
                    algılananTus = "aşağı";
                }
                else if (algılananTus=="Right")
                {
                    algılananTus = "sağ";
                }
                else if (algılananTus=="Left")
                {
                    algılananTus = "sol";
                }
            }

            if (lblOrta.Text!=algılananTus)
            {
                bayrak2 = true;
                hak = hak - 1;
                MessageBox.Show("Kaybettiniz\nDurum: Yanlış tuşa basıldı.", "Sonuç Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                randomSayı = rnd.Next(4);
                lblOrta.Text = yön[randomSayı];
                skor++;
                bayrak = true;
                lblSkor2.Text = Convert.ToString(skor);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                if (bayrak2==true && sayac==0)
                {

                }
                else if (bayrak2==false && sayac==0)
                {
                    timer1.Stop();
                    MessageBox.Show("Kaybettiniz\nDurum: Süre bitti.", "Sonuç Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            else
            {
                sayac = sayac - 1;
                PrograssBar.Value = sayac;
            }

            if (sayac<90 &&bayrak==true )
            {
                bayrak = false;
                sayac = 80;
            }
        }
    }
}
