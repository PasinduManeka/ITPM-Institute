using ABC_Institute.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class MR_Group : Form
    {
        SQL c = new SQL();
        public MR_Group()
        {
            InitializeComponent();
        }

        private void MR_Group_Load(object sender, EventArgs e)
        {
            //load data to the combobox
            DataTable dt = c.comboBoxGroup();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1Group.Items.Add(dr["groupID"].ToString());
            }

            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                comboBox2Group.Items.Add(dr["RoomName"].ToString());
            }
        }

        private void comboBox1Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT groupID FROM student_groups where groupID='" + comboBox1Group.SelectedItem.ToString() + "'";
           
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
           
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
           
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Group.AppendText("\t" + dr["groupID"].ToString() + "\t");
            }
        }

        private void comboBox2Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2Group.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Group.AppendText("\t" + dr["RoomName"].ToString() + "\t");
            }
        }

        private void button1ClearGroup_Click(object sender, EventArgs e)
        {
            comboBox1Group.SelectedIndex = 0;
            comboBox2Group.SelectedIndex = 0;
            textBox1Group.Text = "";
        }

        private void button2SubmitGroup_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LG_Group = comboBox1Group.Text;
            c.LG_RoomName = comboBox2Group.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Group(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Group.");

                //clear if success
                comboBox1Group.SelectedIndex = 0;
                comboBox2Group.SelectedIndex = 0;
                textBox1Group.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Group. Try Again");
            }
        }
    }
}
