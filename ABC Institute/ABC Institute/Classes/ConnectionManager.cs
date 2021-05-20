using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace ABC_Institute.Classes
{
    class ConnectionManager
    {
        public static SqlConnection newcon;
        public static String constr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            newcon = new SqlConnection(constr);
            return newcon;
        }

       
    }
}

