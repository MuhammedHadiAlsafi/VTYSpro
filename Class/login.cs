using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace VTYSpro.Class
{
     public class Login
    {
        private string username;
        private string password;
        private MySqlConnection conn;

        public bool durum=false;
        public string yetki;

        public MySqlConnection bag { get { return conn;} set { conn = value; } }

        public Login()
        {
           
            string connStr = "server=127.0.0.1;uid=root;" +
                                "pwd=12345;database=odev";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                durum = true;
            }
            catch (Exception ex)
            {
                durum = false;
            }
        }
        public bool loginC(string username, string password)
        {
            string sql = "SELECT kullaniciAdi,kullaniciPas,kullaniciYetki FROM kullanici where kullaniciAdi='" + username+ "' and kullaniciPas='" + password+"'";
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {   
                yetki = rdr.GetString(2);
                rdr.Close();
                durum = true;
                return true;
            }
            else
            {
                rdr.Close();
                durum = false;
                return false;
            }
        }
        ~Login()
        {
            conn.Close();
        }
    }
}
