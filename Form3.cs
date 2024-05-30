using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTYSpro.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYSpro
{
    public partial class Form3 : Form
    {
        private Login giris;
        private Temel kod;
        private Tablo ek;

        public Form3(Login a)
        {
            InitializeComponent();
            giris = a;
            kod = new Temel(giris.bag);
            ek = new Tablo(var3,giris.bag);
            DataSet ds = new DataSet();
            ek.Doldur();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked )
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1 .Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (oyunRB.Checked)
                {
                    kod.Ekle(1, var1.Text, var2.Text, var3.Text, Convert.ToInt32(var4.Text));
                    if (checkBox1.Checked)
                    {
                        if (Aday.Checked)
                            kod.Ekle(2, var1.Text, var5.Text, "Aday", Convert.ToInt32(var6.Text));
                        else
                            kod.Ekle(2, var1.Text, var5.Text, "Kazanan", Convert.ToInt32(var6.Text));
                    }
                }
                if (sirketRB.Checked)
                {
                    kod.Ekle(3, var1.Text, var2.Text, var3.Text, Convert.ToInt32(var4.Text));
                }
                MessageBox.Show("İşlem tamamlandı");
            }
            catch
            {
                MessageBox.Show("İşlem yapılamadı \ntüm verileri düzgün girdiğnize emin olun");
            }
        }
        private void oyunRB_Click(object sender, EventArgs e)
        {
            label1.Text = "Oyun Adı";
            label2.Text = "Oyun Türü";
            label3.Text = "Oyun Şirketi";
            label4.Text = "Oyun çıkış yılı";
            checkBox1.Visible = true;
            ek.Doldur();
        }

        private void sirketRB_Click(object sender, EventArgs e)
        {
            label1.Text = "Şirket Adı";
            label2.Text = "Şirket Merkez";
            label3.Text = "Ust Şirketddc";
            label4.Text = "Şirket Yıl";
            checkBox1.Visible = false;
            groupBox1.Visible = false;
            ek.Doldur();
            
        }
    }
}
