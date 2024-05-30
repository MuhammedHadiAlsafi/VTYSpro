using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        Login giris = new Login();
        

        public Form1()
        {
            InitializeComponent();
            if (giris.durum)
            {
                MessageBox.Show("sisteme bağlandi");
            }
            else
            {
                MessageBox.Show("sisteme bağlanmadi");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                        if (giris.loginC(Kulanici.Text,pas.Text))
                        {
                            this.Hide();
                            Form2 form2 = new Form2(giris);
                            form2.Show();
                        }
                        else
                        {
                            MessageBox.Show("giriş yapılamadı");
                        }
        }
    }
}
