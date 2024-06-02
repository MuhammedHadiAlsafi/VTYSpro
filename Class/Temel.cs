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
        public void Silme(int tablo,string var1)
        {
            string sql = "call Silme(" + tablo + ",'" + var1 + "');";
            MySqlScript script = new MySqlScript(conn, sql);
            script.Execute();
        }
        public void Guncelleme(int tablo, string var1, string var2, string var3, int var4)
        {
            string sql = "call Guncelleme(" + tablo + ",'" + var1 + "','" + var2 + "','" + var3 + "'," + var4 + ")";
            MySqlScript script = new MySqlScript(conn, sql);
            script.Execute();
        }
    }
}
/*CREATE DEFINER=`root`@`localhost` PROCEDURE `Ekleme`(IN TABLO INT,IN var1 varchar(50),IN var2 varchar(50),IN var3 varchar(50),IN var4 INT)
BEGIN
	IF(TABLO = 1)then
		INSERT INTO oyun (`oyunAdi`,`oyunTur`,`oyunSirket`,`oyunYil`) VALUES(var1,var2,var3,var4);
	elseif(TABLO = 2) then
		INSERT INTO gameawards (`gaOyun`,`gaKato`,`gaSonuc`,`gaYear`) VALUES(var1,var2,var3,var4);
	elseif(TABLO = 3) then
		INSERT INTO sirket (`sirketAdi`,`sirketMerkez`,`ustSirket`,`sirkertKur`) VALUES(var1,var2,var3,var4);
	end if;
END*/
