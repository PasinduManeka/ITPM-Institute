using ABC_Institute.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class MR_Lecturer : Form
    {
        SQL c = new SQL();

        public MR_Lecturer()
        {
            InitializeComponent();
        }

        private void MR_Lecturer_Load(object sender, EventArgs e)
        {
            //load data to combo boxes
            DataTable dt = c.comboBoxLecturer();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1Lecturer.Items.Add(dr["Lecturer_Name"].ToString() + " " );
            }

            DataTable dtr = c.comboBoxRoom();
            foreach(DataRow dr in dtr.Rows)
            {
                comboBox2Lecturer.Items.Add(dr["RoomName"].ToString());
            }
        }

        private void comboBox1Lecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

                //Step 2: Writing sql query
                string sql = "SELECT DISTINCT Lecturer_Name FROM Lecturer_Details_Table where Lecturer_Name='" + comboBox1Lecturer.SelectedItem.ToString() + "'";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
            {
                textBox1Lecturer.AppendText("Lecturer Name: " + dr["Lecturer_Name"].ToString());
            }
        }

        private void comboBox2Lecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2Lecturer.SelectedItem.ToString() + "'";
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {             
                textBox1Lecturer.AppendText("\r\nRoomName: "+dr["RoomName"].ToString());
            }
        }

        private void textBox1Lecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1ClearLecturer_Click(object sender, EventArgs e)
        {
            comboBox1Lecturer.SelectedIndex = 0;
            comboBox2Lecturer.SelectedIndex = 0;
            textBox1Lecturer.Text = "";
        }

        private void button2SubmitLecturer_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LL_Lecturer = comboBox1Lecturer.Text;
            c.LL_RoomName = comboBox2Lecturer.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Lecturers(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the lecturer.");

                //clear if success
                comboBox1Lecturer.SelectedIndex = 0;
                comboBox2Lecturer.SelectedIndex = 0;
                textBox1Lecturer.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Lecturer. Try Again");
            }
        }
    }
}
