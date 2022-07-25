using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESOFT_STMS.Helper
{
    public static class DBHelper
    {
        private static string connectionString = "Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True";

        public static string getConnectionString()
        {
            return connectionString;
        }
    }
}
