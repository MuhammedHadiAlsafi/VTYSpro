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
    internal class login
    {
        private string username;
        private string password;
        private MySqlConnection conn;

        public bool durum=false;

        public login()
        {
           
            string connStr = "server=127.0.0.1;uid=root;" +
                                "pwd=12345;database=pro";
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
            string sql = "SELECT exName,exPes FROM executive where exName='"+username+"'and exPes="+ password;
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr.Read();
        }
    }
}
