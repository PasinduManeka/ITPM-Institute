using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Institute.Classes
{
    class Session
    {
        public int id { get; set; }
        public string Slec1 { get; set; }
        public string Slec2 { get; set; }
        public string Tag { get; set; }
        public string Sgroup { get; set; }
        public string Ssubj { get; set; }
        public string Sscode { get; set; }
        public string OnOfStudent { get; set; }
        public string Duration { get; set; }

        static string myconnString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        //retrive data
        public DataTable select()
        {
            //Database Connection
            SqlConnection conn = new SqlConnection(myconnString);
            DataTable dt = new DataTable();
            try
            {
                //sql query for table connection
                string sql = "SELECT* FROM Session_Details";

                //create connection
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                conn.Open();
                sd.Fill(dt);
            }
            catch(Exception e)
            {
                Console.WriteLine("This is the error:" + e.ToString());
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

    }
}
