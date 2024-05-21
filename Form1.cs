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
        login girs = new login();
        public Form1()
        {
            InitializeComponent();
            if (girs.durum)
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

            if (girs.loginC(Kulanici.Text,pas.Text))
            {
                this.Hide();
                Form2 form2 = new Form2();
                Form form1 = this;
                form2.Show();
            }
            else
            {
                MessageBox.Show("giriş yapılamadı");
            }
        }
    }
}
