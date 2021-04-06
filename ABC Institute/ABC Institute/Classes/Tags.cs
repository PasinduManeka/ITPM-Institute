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
    class Tags
    {
        public int tagID { get; set; }
        public string subjectName { get; set; }
        public string subjectCode { get; set; }
        public string tagCode { get; set; }
        public string rTag { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        //Selecting Data from Database
        public DataTable select()
        {
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT* FROM tags";
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();
                adapter.Fill(dt);


            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return dt;

        }

        //Insert method
        public bool Insert(Tags tg)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connString);

            try
            {

                //Console.WriteLine(tg.tagID);
                Console.WriteLine(tg.subjectName);
                Console.WriteLine(tg.tagCode);
                Console.WriteLine(tg.subjectCode);


                string sql = "INSERT INTO tags (subjectName, tagCode, subjectCode, relatedTag) VALUES (@subjectName, @tagCode, " +
                    "@subjectCode, @relatedCode)";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@subjectName", tg.subjectName);
                cmd.Parameters.AddWithValue("@tagCode", tg.tagCode);
                cmd.Parameters.AddWithValue("@subjectCode", tg.subjectCode);
                cmd.Parameters.AddWithValue("@relatedCode", tg.rTag);

                //Open the connection
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
            catch
            {

            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        //Update the values.
        public bool Update(Tags tg)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connString);

            try
            {
                //SQL to update in the database
                String sql = "UPDATE tags SET  subjectName = @subjectName, tagCode = @tagCode, subjectCode = @subjectCode, relatedTag = @relatedTag " +
                    "WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Console.WriteLine(tg.tagID);
                //Console.WriteLine(tg.subjectName);
                //Console.WriteLine(tg.tagCode);
                //Console.WriteLine(tg.subjectCode);

                cmd.Parameters.AddWithValue("@subjectName", tg.subjectName);
                cmd.Parameters.AddWithValue("@tagCode", tg.tagCode);
                cmd.Parameters.AddWithValue("@subjectCode", tg.subjectCode);
                cmd.Parameters.AddWithValue("@relatedTag", tg.rTag);
                cmd.Parameters.AddWithValue("@id", tg.tagID);

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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;

        }

        //Delete values in databse

        public bool DeleteTags(Tags tg)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connString);

            try
            {
                String sql = "DELETE FROM tags WHERE id = @id ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", tg.tagID);

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



    }
}
