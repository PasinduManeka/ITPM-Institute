using ABC_Institute.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class MR_Tag : Form
    {

        SQL c = new SQL();
        public MR_Tag()
        {
            InitializeComponent();
        }

       
        private void MR_Tag_Load(object sender, EventArgs e)
        {
            //load data to comboboxes
            DataTable dt = c.comboBoxTag();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1Tag.Items.Add(dr["tagCode"].ToString());
            }

            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                 comboBox2Tag.Items.Add(dr["RoomName"].ToString() + " - " + dr["RoomType"].ToString());
                
            }

        }

        private void comboBox1Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection
            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT tagCode FROM tags where tagCode='" + comboBox1Tag.SelectedItem.ToString() + "'";
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Tag.AppendText("TagCode: " + dr["tagCode"].ToString() + "\r\n");
            }
        }

        private void comboBox2Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2Tag.SelectedItem.ToString() + "'";
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Tag.AppendText("RoomName and RoomType: " + comboBox2Tag.Text.ToString());                
            }
        }

        //clear button
        private void buttonClearTag_Click(object sender, EventArgs e)
        {
            comboBox1Tag.SelectedIndex = 0;
            comboBox2Tag.SelectedIndex = 0;
            textBox1Tag.Text = "";
        }

        private void buttonSubmitTag_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LT_Tag = comboBox1Tag.Text;
            c.LT_RoomName = comboBox2Tag.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Tag(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Tag.");

                //clear if success
                comboBox1Tag.SelectedIndex = 0;
                comboBox2Tag.SelectedIndex = 0;
                textBox1Tag.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Tag. Try Again");
            }
        }
    }
}
