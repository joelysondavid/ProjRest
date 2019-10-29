using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceProject.Connection
{
    public sealed class DBConnection
    {
        private static volatile SqlConnection instance;
        private DBConnection() { }
        public static SqlConnection DB_Connection
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlConnection(@"Data Source=JDKS-PC\SQLEXPRESS; Initial Catalog=Restaurante; Integrated Security=True");
                }
                return instance;
            }
        }
    }
}
