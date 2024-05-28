using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace VTYSpro.Class
{
    internal class Temel
    {
        private MySqlConnection conn;
        public Temel(MySqlConnection bag)
        {
            this.conn = bag;
        }

        public void Ekle(/*string ad, string tur,string sirket,string yil*/)
        {
            string sql = "INSERT INTO oyun (`oyunAdi`, `oyunTur`, `oyunYil`, `oyunSirket`) VALUES('dene', 'fe', 2018, 'SIE Santa Monica Studio');";
            MySqlScript script = new MySqlScript(conn, sql);
            script.Execute();
            
        }
    }
}
