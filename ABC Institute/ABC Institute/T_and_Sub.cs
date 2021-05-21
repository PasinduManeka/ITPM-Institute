using ABC_Institute.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ABC_Institute
{
    public partial class T_and_Sub : Form
    {
        SQL c = new SQL();
        public T_and_Sub()
        {
            InitializeComponent();
        }

        private void T_and_Sub_Load(object sender, EventArgs e)
        {
            //load data to comboboxes
            DataTable dt = c.comboBoxTag();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1TagnSub.Items.Add(dr["Tag"].ToString());
            }

            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                comboBox2TagnSub.Items.Add(dr["RoomName"].ToString());
            }

            DataTable dts = c.comboBoxSubject();
            foreach (DataRow dr in dts.Rows)
            {
                comboBox3TagnSub.Items.Add(dr["Subject_Name"].ToString());
            }
        }

        private void comboBox1TagnSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection
            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT relatedTag FROM tags where relatedTag='" + comboBox1TagnSub.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                textBox1TagnSub.AppendText("\t" + dr["Tag"].ToString() + "\t");
            }
        }

        private void comboBox3TagnSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection
            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT Subject_Name FROM Subj_Details_Table where Subject_Name='" + comboBox3TagnSub.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
           
            foreach (DataRow dr in dt.Rows)
            {
                textBox1TagnSub.AppendText("\t" + dr["Subject_Name"].ToString() + "\t");
            }
        }

        private void comboBox2TagnSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2TagnSub.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                textBox1TagnSub.AppendText("\t" + dr["RoomName"].ToString() + "\t");
            }
        }

        private void buttonClearTagnSub_Click(object sender, EventArgs e)
        {
            comboBox1TagnSub.SelectedIndex = 0;
            comboBox2TagnSub.SelectedIndex = 0;
            comboBox3TagnSub.SelectedIndex = 0;
            textBox1TagnSub.Text = "";

        }

        private void buttonSubmitTagnSub_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LTS_Tag = comboBox1TagnSub.Text;
            c.LTS_Subject = comboBox3TagnSub.Text;
            c.LTS_RoomName = comboBox2TagnSub.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Tag_n_Sub(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Tag and Subject.");

                //clear if success
                comboBox1TagnSub.SelectedIndex = 0;
                comboBox2TagnSub.SelectedIndex = 0;
                comboBox3TagnSub.SelectedIndex = 0;
                textBox1TagnSub.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Tag and Subject. Try Again");
            }
        }
    }
}
