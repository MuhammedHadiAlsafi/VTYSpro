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

namespace VTYSpro.Class
{
    
    public class Tablo
    {
        private DataGridView DGV;
        private MySqlConnection conn;
        public Tablo(DataGridView alan, MySqlConnection bag) {
            this.DGV = alan; 
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

    }
}
