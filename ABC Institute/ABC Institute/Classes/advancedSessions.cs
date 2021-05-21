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
    class advancedSessions
    {

        public int id { get; set; }

        public string session1 { get; set; }
        public string session2 { get; set; }
        public string duration { get; set; }
        public string day { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }

        static string myconnString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public DataTable selectConsecutive()
        {
            //Databse Connection 
            SqlConnection conn = new SqlConnection(myconnString);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "SELECT* from consecutive";

                //create table connection
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                conn.Open();
                dp.Fill(dt);
            }
            catch(Exception e)
            {
                Console.WriteLine("This is the error:"+e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //get session column for adding comboboxes
        /*public DataTable selsctSesion()
        {
            SqlConnection conn = new SqlConnection(myconnString);
            DataTable dt = new DataTable();
            try
            {
                //sql query for retrieve data
                string sql = "SELECT ms.Session FROM Manage_Session_TableN ms";

                //create table connecetion
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                conn.Open();
                dp.Fill(dt);

            }
            catch(Exception e)
            {
                Console.WriteLine("This is the error:"+e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }*/

        //Insert consecutive data to table
        public bool insertConsecutive(advancedSessions ad)
        {
            bool isSuccess = false;

            //Database connection
            SqlConnection con = new SqlConnection(myconnString);

            try
            {
                //Insert query
                String query = "INSERT INTO consecutive (session1, session2) VALUES (@session1, @session2)";
                
                //create the table cnnection
                SqlCommand cmd = new SqlCommand(query, con);

                //bind values
                cmd.Parameters.AddWithValue("@session1", ad.session1);
                cmd.Parameters.AddWithValue("@session2", ad.session2);

                //Connection open
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("This is the error: "+e.ToString());
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        //update consecutive sessions
        public bool updateConsecutive(advancedSessions ad)
        {
            bool isSuccess = false;

            //databse connection
            SqlConnection con = new SqlConnection(myconnString);

            try
            {
                string sql = "update consecutive set session1=@session1, session2=@session2 where id=@id";

                //create the table connection
                SqlCommand cmd = new SqlCommand(sql, con);

                //bind values
                cmd.Parameters.AddWithValue("@session1", ad.session1);
                cmd.Parameters.AddWithValue("@session2", ad.session2);
                cmd.Parameters.AddWithValue("@id", ad.id);

                //open database connection
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("This is the error:"+e.ToString());
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        } 

        //delete the consecutive sessions
        public bool deleteConsecutive(advancedSessions ad)
        {
            bool isSuccess = false;
            //database connection
            SqlConnection con = new SqlConnection(myconnString);
            try
            {
                string sql = "DELETE FROM consecutive WHERE id=@id ";

                //create the table connection
                SqlCommand cmd = new SqlCommand(sql, con);

                //bind values
                cmd.Parameters.AddWithValue("@id", ad.id);

                //connection open
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
                   
            }
            catch(Exception e)
            {
                Console.WriteLine("This is the err from executive session:"+e.ToString());
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }


    }
}
