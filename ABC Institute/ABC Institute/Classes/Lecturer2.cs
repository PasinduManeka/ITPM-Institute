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
    class Lecturer2
    {
        //Getter and Setter Properties
        //Acting as data Carrier in the App

        public int LecID { get; set; }

        public string lecturer { get; set; }

        public string YearSem { get; set; }

        public string LGroup { get; set; }

        public string subGroup { get; set; }

        public string session { get; set; }

        public string LeTime { get; set; }

        public string LeDay { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data From the databse
        public DataTable Select()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing the SQL Query
                string sql = "SELECT * FROM available";
                SqlCommand cmd = new SqlCommand(sql, conn);
               

                //Creating SQL DATA Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open the connection
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close the connection
                conn.Close();
            }
            return dt;
        }

        //Inserting data into databse
        public bool Insert(Lecturer2 l)
        {
            //Creating a default retunr type abd setting its value to false
            bool isSuccess = false;

            //Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Create a SQL Query to insert data
                string sql = "INSERT INTO available (Lecturer, YearSem, LGroup, SGroup, SessionID, Ltime, Lday) VALUES (@Lecturer, @YearSem, @LGroup, @SGroup, @SessionID, @Ltime, @Lday)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                Console.WriteLine(l.lecturer);
                Console.WriteLine(l.YearSem);
                Console.WriteLine(l.LGroup);
                Console.WriteLine(l.subGroup);
                Console.WriteLine(l.session);
                Console.WriteLine(l.LeTime);
                Console.WriteLine(l.LeDay);

                //creating parametres to add data
                cmd.Parameters.AddWithValue("@Lecturer", l.lecturer);
                cmd.Parameters.AddWithValue("@YearSem", l.YearSem);
                cmd.Parameters.AddWithValue("@LGroup", l.LGroup);
                cmd.Parameters.AddWithValue("@SGroup", l.subGroup);
                cmd.Parameters.AddWithValue("@SessionID", l.session);
                cmd.Parameters.AddWithValue("@Ltime", l.LeTime);
                cmd.Parameters.AddWithValue("@Lday", l.LeDay);

                //Connection Open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of the rows will be greater than zero else value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return isSuccess;
        }

        //Method to update data in the databse
        public bool Update(Lecturer2 l)
        {
            //create a defaule return type and set its default value to false
            bool isSuccess = false;

            //Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to update data in the datbase
                string sql = "UPDATE available SET Lecturer=@Lecturer, YearSem=@YearSem, LGroup=@LGroup, SGroup=@SGroup, SessionID=@SessionID, Ltime=@Ltime, Lday=@Lday WHERE aid=@aid";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create parameters to add value
                cmd.Parameters.AddWithValue("@Lecturer", l.lecturer);
                cmd.Parameters.AddWithValue("@YearSem", l.YearSem);
                cmd.Parameters.AddWithValue("@LGroup", l.LGroup);
                cmd.Parameters.AddWithValue("@SGroup", l.subGroup);
                cmd.Parameters.AddWithValue("@SessionID", l.session);
                cmd.Parameters.AddWithValue("@Ltime", l.LeTime);
                cmd.Parameters.AddWithValue("@Lday", l.LeDay);
                cmd.Parameters.AddWithValue("@aid", l.LecID);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of the rows will be greater than zero else value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return isSuccess;
        }

        //Method to delete Data from Database
        public bool Delete (Lecturer2 l)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;

            //create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to delete data
                string sql = "DELETE FROM available WHERE aid=@aid";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@aid", l.LecID);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of the rows will be greater than zero else value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return isSuccess;
        }
    }
}
