using MayınTarlası.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class oyun : Form
    {
        public string kolaylik;
        public oyun()
        {
            InitializeComponent();
        }
        int mayin_sayi;
        int sayi;
        Random rand = new Random();
        List<int> mayinlar = new List<int>();
        private void mayin_olustur()
        {
            for(int i = 0;i<mayin_sayi;i++)
            {
                uret:
                    sayi = rand.Next(1,99);
                    if(mayinlar.Contains(sayi))
                    {
                        goto uret;
                    }
                    mayinlar.Add(sayi);
            }
        }

        private void tarla_olustur()
        {
            for(int i = 0;i<100;i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if(mayinlar.Contains(i))
                {
                    button.Tag = 1;
                }
                else
                {
                    button.Text = "";
                    button.Tag = 0;
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
        }
        int skor = 0;
        private void button_Click(object sender, EventArgs e)
        {
            Button secilen = sender as Button;
            if(secilen.Tag.ToString() == "1")
            {
                secilen.BackgroundImage = Resources.mayin_png;
                secilen.BackColor = Color.Red;
                secilen.Enabled = false;
                for(int i = 0;i<tableLayoutPanel1.Controls.Count;i++)
                {
                    if(mayinlar.Contains(i))
                    {
                        tableLayoutPanel1.Controls[i].Enabled = false;
                        tableLayoutPanel1.Controls[i].BackgroundImage = Resources.mayin_png;
                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i].Enabled = false;
                        tableLayoutPanel1.Controls[i].BackColor = Color.Green;
                    }
                }
            }
            else
            {
                if(kolaylik == "Kolay")
                {
                    skor += 10;
                }
                else if(kolaylik == "Orta")
                {
                    skor += 20;
                }
                else
                {
                    skor += 30;
                }
                LblSkor.Text = "SKOR : " + skor;
                secilen.BackColor = Color.Green;
                secilen.Enabled = false;
            }
            
        }

        private void oyun_Load(object sender, EventArgs e)
        {
            LblZorluk.Text = "Zorluk : " + kolaylik;
            if (kolaylik == "Kolay")
            {
                mayin_sayi = 10;
            }
            else if(kolaylik == "Orta")
            {
                mayin_sayi = 20;
            }
            else
            {
                mayin_sayi = 30;
            }
            LblSayi.Text = "Mayınlar : " + mayin_sayi;
            mayin_olustur();
            tarla_olustur();
        }
    }
}
