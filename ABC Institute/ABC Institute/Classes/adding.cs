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
    class adding
    {
        //Getter and Setter Properties
        //Acting as data Carrier in the App

        public int ID { get; set; }

        public string noOfWorking { get; set; }

        public string workingdays { get; set; }

        public string hours { get; set; }

        public string minutes { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        //Selecting Data From the databse
        public DataTable Select()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing the SQL Query
                string sql = "SELECT * FROM adding";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                //Creating SQL DATA Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }catch(Exception e)
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
        public bool Insert (adding a)
        {
            //Creating a default retunr type abd setting its value to false
            bool isSuccess = false;

            //Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Create a SQL Query to insert data
                string sql = "INSERT INTO adding (noOfWorkingDays, workingdays, hours, minutes) VALUES (@noOfWorkingDays, @workingdays, @hours, @minutes)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                Console.WriteLine(a.noOfWorking);
                Console.WriteLine(a.workingdays);
                Console.WriteLine(a.hours);
                Console.WriteLine(a.minutes);
                
                //creating parametres to add data
                cmd.Parameters.AddWithValue("@noOfWorkingDays", a.noOfWorking);
                cmd.Parameters.AddWithValue("@workingdays", a.workingdays);
                cmd.Parameters.AddWithValue("@hours", a.hours);
                cmd.Parameters.AddWithValue("@minutes", a.minutes);

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
            catch(Exception e)
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
        public bool Update(adding a)
        {
            //create a defaule return type and set its default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql to update data in the datbase
                string sql = "UPDATE adding SET noOfWorkingDays=@noOfWorkingDays, workingdays=@workingdays, hours=@hours, minutes=@minutes WHERE id=@id";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

           
                //create paramters to add value
                cmd.Parameters.AddWithValue("@noOfWorkingDays", a.noOfWorking);
                cmd.Parameters.AddWithValue("@workingdays", a.workingdays);
                cmd.Parameters.AddWithValue("@hours", a.hours);
                cmd.Parameters.AddWithValue("@minutes", a.minutes);
                cmd.Parameters.AddWithValue("@id", a.ID);

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
            catch (Exception e)
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
        public bool Delete(adding a)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;

            //create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM adding WHERE id=@id";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", a.ID);

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
            catch (Exception e)
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
