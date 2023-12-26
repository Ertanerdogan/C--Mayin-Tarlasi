using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOyna_MouseEnter(object sender, EventArgs e)
        {
            BtnOyna.BackColor = Color.White;
            BtnOyna.ForeColor = Color.Black;
        }

        private void BtnOyna_MouseLeave(object sender, EventArgs e)
        {
            BtnOyna.BackColor = Color.Black;
            BtnOyna.ForeColor = Color.White;
        }
        string kolay;
        private void BtnOyna_Click(object sender, EventArgs e)
        {
            if (RdbKolay.Checked == true || RdbOrta.Checked == true || RdbZor.Checked == true)
            {
                if (RdbKolay.Checked)
                {
                    kolay = "Kolay";
                }
                else if(RdbOrta.Checked)
                {
                    kolay = "Orta";
                }
                else
                {
                    kolay = "Zor";
                }
                oyun ekran = new oyun();
                ekran.kolaylik = kolay;
                ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen oyun modunu seçiniz","Uyarı");
            }
        }
    }
}
