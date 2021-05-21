using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ABC_Institute.Classes
{

    class SQL
    {
        //getters and setters
        public int ID { get; set; }
        public string BName { get; set; }
        public string RName { get; set; }
        public string RType { get; set; }
        public string Capacity { get; set; }
        public string LL_RoomName { get; set; }
        public string LL_Lecturer { get; set; }
        public string LS_RoomName { get; set; }
        public string LS_Subject { get; set; }
        public string LG_RoomName { get; set; }
        public string LG_Group { get; set; }
        public string LT_RoomName { get; set; }
        public string LT_Tag { get; set; }
        public string LSe_Session { get; set; }
        public string LSe_RoomName { get; set; }
        public string LTS_Tag { get; set; }
        public string LTS_Subject { get; set; }
        public string LTS_RoomName { get; set; }
        public string LCS_RoomName { get; set; }
        public string LCS_ConSession { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        //Selecting data from DB
        public DataTable Select()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT * FROM Add_Location";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into DB
        public bool Insert(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Add_Location(BuildingName, RoomName, RoomType, Capacity) VALUES (@BuildingName, @RoomName, @RoomType, @Capacity)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@BuildingName", c.BName);
                cmd.Parameters.AddWithValue("@RoomName", c.RName);
                cmd.Parameters.AddWithValue("@RoomType", c.RType);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in DB from our application
        public bool Update(SQL c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in DB
                string sql = "UPDATE Add_Location SET BuildingName=@BuildingName, RoomName=@RoomName, RoomType=@RoomType, Capacity=@Capacity WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add value
                cmd.Parameters.AddWithValue("@BuildingName", c.BName);
                cmd.Parameters.AddWithValue("@RoomName", c.RName);
                cmd.Parameters.AddWithValue("@RoomType", c.RType);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }


        //method to delete data from DB
        public bool Delete(SQL c)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;

            //create SQL connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to delete data
                string sql = "DELETE FROM Add_Location WHERE ID=@ID";

                //creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run successfully then the value of rows is greater than 0 else its value is 0
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


        public int LabForChart()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT TOP 1 Numbers FROM LabForStat ORDER BY ID DESC";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }
        public int LecHallForChart()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT TOP 1 No FROM LecHallForStat ORDER BY ID DESC";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

        public bool InsertToLabTable(SQL c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in DB
                string sql = "INSERT INTO LabForStat(Numbers) SELECT COUNT(ID) FROM Add_Location WHERE RoomType LIKE 'La%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }

        public bool InsertToLecTable(SQL c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in DB
                string sql = "INSERT INTO LecHallForStat(No) SELECT COUNT(ID) FROM Add_Location WHERE RoomType LIKE 'Le%'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //open DB connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }

        public int GetNoOfRows()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(ID) FROM Add_Location";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

        /*
        public int GetNoOfRowsOfLab()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(Numbers) FROM LabForStat";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }
        public int GetNoOfRowsofLecHall()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(No) FROM LecHallForStat";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }*/


        //get the latest lecturer for statistics
        public string LatestLecturer()
        {
            string s = "";

            SqlConnection Conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT TOP 1 Lecturer_Name FROM Lecturer_Details_Table ORDER BY ID DESC";
            SqlCommand Comm1 = new SqlCommand(sqlText, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s = DR1.GetValue(0).ToString();

            }

            Conn.Close();

            return s;
        }

        //get the latest student group for statistics
        public string LatestGroup()
        {
            string s = "";

            SqlConnection Conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT TOP 1 groupID FROM student_groups ORDER BY id DESC";
            SqlCommand Comm1 = new SqlCommand(sqlText, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s = DR1.GetValue(0).ToString();

            }

            Conn.Close();

            return s;
        }

        //get the latest student group for statistics
        public string LatestSubject()
        {
            string s = "";

            SqlConnection Conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT TOP 1 Subject_Name FROM Subj_Details_Table ORDER BY ID DESC";
            SqlCommand Comm1 = new SqlCommand(sqlText, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s = DR1.GetValue(0).ToString();

            }

            Conn.Close();

            return s;
        }

        //for the number of Subjects
        public int NumOfSubjects()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(ID) FROM Subj_Details_Table";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

        //for the number of Lecturers
        public int NumOfLecturers()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(ID) FROM Lecturer_Details_Table";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

        //for the number of studentGroups
        public int NumOfStudentGroups()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            String sqlText = "SELECT COUNT(id) FROM student_groups";

            // Create the connection and the command.
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            conn.Open();
            // Execute the scalar SQL statement and store results.
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }

        //MR_Lecturers code starts from here
        //get database data to comboBoxes
        public DataTable comboBoxLecturer()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT Lecturer_Name FROM Lecturer_Details_Table";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable comboBoxRoom()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT RoomName, RoomType FROM Add_Location";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertToLocation_Lecturers(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_Lecturer(RoomName, Lecturer) VALUES (@RoomName, @Lecturer)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@RoomName", c.LL_RoomName);
                cmd.Parameters.AddWithValue("@Lecturer", c.LL_Lecturer);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }
        //MR_Lecturers code end here


        //MR_Subject code starts here
        public DataTable comboBoxSubject()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT Subject_Name FROM Subj_Details_Table";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        public bool InsertToLocation_Subject(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_Subject(RoomName, Subject) VALUES (@RoomName, @Subject)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@RoomName", c.LS_RoomName);
                cmd.Parameters.AddWithValue("@Subject", c.LS_Subject);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }


        //MR_Group code starts here
        public DataTable comboBoxGroup()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT groupID FROM student_groups";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertToLocation_Group(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_Group(RoomName, [Group]) VALUES (@RoomName, @Group)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@RoomName", c.LG_RoomName);
                cmd.Parameters.AddWithValue("@Group", c.LG_Group);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }


        //Code for Tag starts here
        public DataTable comboBoxTag()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT tagCode FROM tags order by tagCode DESC";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertToLocation_Tag(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_Tag(RoomName, Tag) VALUES (@RoomName, @Tag)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@RoomName", c.LT_RoomName);
                cmd.Parameters.AddWithValue("@Tag", c.LT_Tag);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }


        //Session code starts here
        public DataTable comboBoxSession()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT Session FROM Session";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertToLocation_Session(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_Session(RoomName, SessionID) VALUES (@RoomName, @Session)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@RoomName", c.LSe_RoomName);
                cmd.Parameters.AddWithValue("@Session", c.LSe_Session);

                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }

        //Tag n Sub code starts here
        public bool InsertToLocation_Tag_n_Sub(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_Tag_n_Sub(Tag, Subject, RoomName) VALUES (@Tag, @Subject, @RoomName)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@Tag", c.LTS_Tag);
                cmd.Parameters.AddWithValue("@Subject", c.LTS_Subject);
                cmd.Parameters.AddWithValue("@RoomName", c.LTS_RoomName);
                
                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }


        //consecutive sessions
        public DataTable Select_consecutive_sessions()
        {
            //Step 1: DB connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing sql query
                string sql = "SELECT * FROM Manage_Session_TableN";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertToLocation_Consecutive_session(SQL c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //STEP 1: Connect DB
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: Create a Sql query to insert data
                string sql = "INSERT INTO Location_ConsecutiveSessions(RoomName, ConSession) VALUES (@RoomName, @ConSession)";

                //Creating SQL commandusing sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@RoomName", c.LCS_RoomName);
                cmd.Parameters.AddWithValue("@ConSession", c.LCS_ConSession);
                
                //Open the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of rows will be greater than 0 else its value will be 0
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
                conn.Close();
            }
            return isSuccess;
        }

       
    }
}
