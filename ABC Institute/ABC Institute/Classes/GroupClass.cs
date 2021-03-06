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
        public int groupNumber { get; set; }
        public int subgroupNumber { get; set; }
        public string groupID { get; set; }
        public string subGroupID { get; set; }

        public string slec1 { get; set; }
        public string slec2 { get; set; }
        public string tags { get; set; }
        public string subjectCode { get; set; }


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
                String sql = "INSERT INTO student_groups (academicyearsemester, programme, groupNumber, subGroupNumber, subGroupId, groupID) VALUES (@academicyearsemester, @programme, " +
                    "@groupNumber, @subGroupNumber, @subGroupId, @groupID)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, con);

                //bind values
                cmd.Parameters.AddWithValue("@academicyearsemester", gc.yearSemester);
                cmd.Parameters.AddWithValue("@programme", gc.programme);
                cmd.Parameters.AddWithValue("@groupNumber", gc.groupNumber);
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
                String sql = "UPDATE student_groups SET academicyearsemester=@academicyearsemester, programme=@programme, groupNumber=@groupNumber, subGroupNumber=@subGroupNumber, subGroupId=@subGroupId, groupID=@groupID " +
                    "WHERE id = @id";

                //bind values
                SqlCommand cmd = new SqlCommand(sql, con);

                // Console.WriteLine(gc.id);
                //onsole.WriteLine(gc.yearSemester);
                //Console.WriteLine(gc.programme);
                //Console.WriteLine(gc.groupNumber);

                cmd.Parameters.AddWithValue("@academicyearsemester", gc.yearSemester);
                cmd.Parameters.AddWithValue("@programme", gc.programme);
                cmd.Parameters.AddWithValue("@groupNumber", gc.groupNumber);
                cmd.Parameters.AddWithValue("@subGroupNumber", gc.subgroupNumber);
                cmd.Parameters.AddWithValue("@subGroupId", gc.subGroupID);
                cmd.Parameters.AddWithValue("@groupID", gc.groupID);
                cmd.Parameters.AddWithValue("@id", gc.id);

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
                Console.WriteLine(e);
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

            try
            {
                String sql = "DELETE FROM student_groups WHERE id = @id ";

                SqlCommand cmd = new SqlCommand(sql, con);

                //bind values
                cmd.Parameters.AddWithValue("@id", gc.id);

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
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        //insert consecutive sessions
        public bool insert(GroupClass gs)
        {
            bool isSuccess = false;
            //Database connection
            SqlConnection con = new SqlConnection(myconnString);

            try
            {
                //table connection
                string sql = "insert into consecutive (lecture_name1, lecture_name2, tags, subject_code) select Lecture_name1, Lecture_name2, Tag, Subject_code from Session_Details ";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, con);

                //bind values
                cmd.Parameters.AddWithValue("@lecture_name1", gs.slec1);
                cmd.Parameters.AddWithValue("@lecture_name1", gs.slec2);
                cmd.Parameters.AddWithValue("@tags", gs.tags);
                cmd.Parameters.AddWithValue("@subject_code", gs.subjectCode);

                //Connection open here
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
                Console.WriteLine("This is the error in consecutive sessions:" + e.ToString());
            }
            finally
            {
                con.Close();
            }


            return isSuccess;
        }


    }
}
