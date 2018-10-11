using MySql.Data.MySqlClient;

namespace Duser
{
    public static class Conn
    {
        private static MySqlConnection _Con = new MySqlConnection("server=mysql39.unoeuro.com;database=duser_net_db;uid=duser_net;pwd=Obsengud78;");

        public static MySqlConnection CreateConnection()
        {
            var cn = _Con;
            cn.Open();
            return cn;
        }

        public static MySqlConnection GetCon()
        {
            var cn = _Con;
           
            return cn;
        }
    }
}


