using MySql.Data.MySqlClient;

namespace NoteTakingApp
{
    public static class Connection
    {
        public static MySqlConnection conn = new MySqlConnection();
        private static string server = "127.0.0.1;";
        private static string database = "notes;";
        private static string Uid = "root;";
        private static string password = "Cezarica1@;";
        

        public static MySqlConnection DataSource()
        {
            conn = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return conn;
        }
        
    }
}