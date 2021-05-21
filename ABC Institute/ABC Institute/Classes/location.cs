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
    class location
    {
        //Getter and Setter Properties
        //Acting as data Carrier in the App

        public int ID { get; set; }

        public string Room { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }

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
                string sql = "SELECT * FROM location";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL DATA Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Connection Oepn
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close the connection
                conn.Close();
            }
            return dt;

        }

        //Inserting data into databse 
        public bool Insert(location m)
        {
            //Creating a default retunr type abd setting its value to false
            bool isSuccess = false;

            //Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Create a SQL Query to insert data
                string sql = "INSERT INTO location ( MRoom, MDay, MTime) VALUES ( @MRoom, @MDay, @MTime) ";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                Console.WriteLine(m.Room);
                Console.WriteLine(m.Day);
                Console.WriteLine(m.Time);

                //creating parametres to add data
                cmd.Parameters.AddWithValue("@MRoom", m.Room);
                cmd.Parameters.AddWithValue("@MDay", m.Day);
                cmd.Parameters.AddWithValue("@MTime", m.Time);

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
        public bool Update(location m)
        {
            //create a defaule return type and set its default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to update data in the datbase
                string sql = "UPDATE location SET MRoom=@MRoom, MDay=@MDay, MTime=@MTime WHERE MID=@MID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create paramters to add value
                cmd.Parameters.AddWithValue("@MRoom", m.Room);
                cmd.Parameters.AddWithValue("@MDay", m.Day);
                cmd.Parameters.AddWithValue("@MTime", m.Time);
                cmd.Parameters.AddWithValue("@MID", m.ID);

                //Open Databse connection
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
        public bool Delete(location m)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;

            //create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM location WHERE MID=@MID";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MID", m.ID);

                //Open connnection
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
                //close theconnection
                conn.Close();
            }

            return isSuccess;
        }


    }
}
