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
    class GroupClass
    {
        //Getters and Setters
        public int id{ get; set; }
        public string yearSemester { get; set; }
        public string programme { get; set; }
        public int groupchNumber { get; set; }
        public int subgroupNumber { get; set; }
        public string groupID { get; set; }
        public string subGroupID { get; set; }

        static string myconnString =ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //Connection
            SqlConnection con = new SqlConnection(myconnString);
            DataTable dt = new DataTable();
            try
            {
                //Sql quesry
                String sql = "SELECT* FROM student_groups";
                //create connection
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        //Inserting data to Database
        public bool Insert(GroupClass gc)
        {
            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            //Connect Databse
            SqlConnection con = new SqlConnection(myconnString);
            try
            {
                //SQL query to data insert
                String sql = "INSERT INTO student_groups (academicyearsemester, programme, groupNumber, subGroupNumber, subGroupId, groupID) VALUES (@academicyearsemester, @programme, @groupNumber, @subGroupNumber, @subGroupId, @groupID)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@academicyearsemester", gc.yearSemester);
                cmd.Parameters.AddWithValue("@programme", gc.programme);
                cmd.Parameters.AddWithValue("@groupNumber", gc.groupchNumber);
                cmd.Parameters.AddWithValue("@subGroupNumber", gc.subgroupNumber);
                cmd.Parameters.AddWithValue("@subGroupId", gc.subGroupID);
                cmd.Parameters.AddWithValue("@groupID", gc.groupID);

                //Connection open here
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows>0)
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
                con.Close();
            }
            return isSuccess;
        } 


        //Update the existing data
        public bool Update(GroupClass gc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnString);

            try
            {
                //SQL to update in the database
                String sql = "UPDATE student_groups SET academicyearsemester=@academicyearsemester, programme=@programme, groupNumber=@groupNumber, subGroupNumber=@subGroupNumber, subGroupId=@subGroupId, groupID=@groupID" +
                    "WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@academicyearsemester", gc.yearSemester);
                cmd.Parameters.AddWithValue("@programme", gc.programme);
                cmd.Parameters.AddWithValue("@groupNumber", gc.groupchNumber);
                cmd.Parameters.AddWithValue("@subGroupNumber", gc.subgroupNumber);
                cmd.Parameters.AddWithValue("@subGroupId", gc.subGroupID);
                cmd.Parameters.AddWithValue("@groupID", gc.groupID);
                cmd.Parameters.AddWithValue("id", gc.id);

                //Open Databse Connection

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

            }
            finally
            {
                con.Close();
            }
            return isSuccess;

        }

        //Delete the existing data
        public bool DeleteGroups(GroupClass gc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnString);

            String sql = "DELETE FROM tudent_groups WHERE id = @id ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", gc.id);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }

            try
            {

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }


    }
}
