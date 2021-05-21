using ABC_Institute.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ABC_Institute
{
    public partial class MR_Subject : Form
    {

        SQL c = new SQL();
        public MR_Subject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MR_Subject_Load(object sender, EventArgs e)
        {
            //load data into comboBox 
            DataTable dt = c.comboBoxSubject();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1Subject.Items.Add(dr["Subject_Name"].ToString());
            }

            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                comboBox2Subject.Items.Add(dr["RoomName"].ToString());
            }
        }

        private void comboBox1Subject_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Step 1: DB connection
            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT Subject_Name FROM Subj_Details_Table where Subject_Name='" + comboBox1Subject.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Subject.AppendText("\t" + dr["Subject_Name"].ToString() + "\t");
            }
        }

        private void comboBox2Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2Subject.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
           
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Subject.AppendText("\t" + dr["RoomName"].ToString() + "\t");
            }
        }

        private void button1ClearSubject_Click(object sender, EventArgs e)
        {
            comboBox1Subject.SelectedIndex = 0;
            comboBox2Subject.SelectedIndex = 0;
            textBox1Subject.Text = "";
        }

        private void button2SubmitSubject_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LS_Subject = comboBox1Subject.Text;
            c.LS_RoomName = comboBox2Subject.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Subject(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Subject.");

                //clear if success
                comboBox1Subject.SelectedIndex = 0;
                comboBox2Subject.SelectedIndex = 0;
                textBox1Subject.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Subject. Try Again");
            }
        }
    }
}