using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYSpro.Class
{
    
    public class Tablo
    {
        private DataGridView DGV;
        private MySqlConnection conn;
        private ComboBox CB;
        public Tablo(DataGridView alan, MySqlConnection bag) {
            this.DGV = alan; 
            this.conn = bag;
        }
        public Tablo(ComboBox cb, MySqlConnection bag)
        {
            this.CB = cb;
            this.conn = bag;
        }
        public void select(string tablo)
        {
            string sql = "call TemelTablo('"+tablo+"')";
            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DGV.DataSource = dt;
        }
        public void select2(string tablo,string con)
        {
            string sql = "call OyunAra('%"+con+"%')";
            MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            DGV.DataSource = dt;
        }
        public void Doldur()
        {
            string query = "select sirketAdi from sirket";
            MySqlDataAdapter da = new MySqlDataAdapter(query,conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "sirketAdi");
            CB.DisplayMember = "sirketAdi";
            CB.ValueMember = "sirketAdi";
            CB.DataSource = ds.Tables["sirketAdi"];
            CB.SelectedIndex = 0;
        }
        public void Doldur2()
        {
            string query = "select oyunAdi from oyun";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "oyunAdi");
            CB.DisplayMember = "oyunAdi";
            CB.ValueMember = "oyunAdi";
            CB.DataSource = ds.Tables["oyunAdi"];
            CB.SelectedIndex = 0;
        }


    }
}
