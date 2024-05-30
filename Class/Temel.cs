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

        public void Ekle(int tablo,string var1,string var2,string var3,int var4)
        {
            string sql = "call Ekleme("+tablo+",'"+var1+"','"+var2+"','"+var3+ "',"+var4+");";
            MySqlScript script = new MySqlScript(conn, sql);
            script.Execute();
        }
        public void Sil(int tablo,string var1)
        {
            string sql = "call Ekleme(" + tablo + ",'" + var1 + "');";
            MySqlScript script = new MySqlScript(conn, sql);
            script.Execute();
        }
        public void Guncelleme(int tablo, string var1)
        {
            string sql = "call Ekleme(" + tablo + ",'" + var1 + "');";
            MySqlScript script = new MySqlScript(conn, sql);
            script.Execute();
        }
    }
}
