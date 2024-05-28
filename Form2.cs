using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTYSpro.Class;

namespace VTYSpro
{
    public partial class Form2 : Form
    {
        private Login giris;
        private Tablo tablo;
        private string TabloAd;
        
        public Form2(Login a)
        {
            InitializeComponent();
            giris = a;
            tablo = new Tablo(Veritablo,giris.bag);
            if(giris.yetki == "R2")
            {
                Ekle.Visible = false;
                favore.Visible = true;
            }
            else
            {
                favore.Visible = false;
                Ekle.Visible = true;
            }
        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(giris);
            form3.ShowDialog();
        }

        private void Oyun_Click(object sender, EventArgs e)
        {
            tablo.select("oyun");
            TabloAd = "oyun";
        }
        private void GameAw_Click(object sender, EventArgs e)
        {
            tablo.select("gameawards");
            TabloAd = "gameawards";
        }

        private void Sirket_Click(object sender, EventArgs e)
        {
            tablo.select("sirket");
            TabloAd = "sirket";
        }

        private void favore_Click(object sender, EventArgs e)
        {
            tablo.select("favorite");
            TabloAd = "favorite";
        }
    }
}
