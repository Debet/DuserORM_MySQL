using MySql.Data.MySqlClient;

namespace Duser
{
    public static class Conn
    {
        private static MySqlConnection _Con = new MySqlConnection("server=HOST;database=DATABASE_NAME;uid=USERNAME;pwd=PASSWORD;");

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


