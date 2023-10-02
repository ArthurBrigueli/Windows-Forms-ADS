using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artApp
{
    internal class conexaoDAL
    {
        
        public static string path = Directory.GetCurrentDirectory() + "\\cadastro.db";
       

    
        private static SQLiteConnection sqliteConnection;

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}
