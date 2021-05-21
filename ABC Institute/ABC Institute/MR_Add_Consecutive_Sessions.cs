using ABC_Institute.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class MR_Add_Consecutive_Sessions : Form
    {

        SQL c = new SQL();
        public MR_Add_Consecutive_Sessions()
        {
            InitializeComponent();
        }

        private void MR_Add_Consecutive_Sessions_Load(object sender, EventArgs e)
        {
            if(MR_Consecutive_Sessions.successCon == true)
            {
                comboBox1addSession.Text = MR_Consecutive_Sessions.sendtextCon;
                comboBox1addSession.Items.Add(MR_Consecutive_Sessions.sendtextCon);
                textBox1addSession.AppendText(MR_Consecutive_Sessions.sendtextCon);
            }
            else
            {
                DataTable dt = c.comboBoxSession();
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1addSession.Items.Add(dr["Session"].ToString());
                }
            }



            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                comboBox2addSession.Items.Add(dr["RoomName"].ToString());
            }

        }

        private void comboBox1addSession_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBox1addSession.AppendText(comboBox1addSession.SelectedItem + " ");
        }

        private void comboBox2addSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection
            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2addSession.SelectedItem.ToString() + "'";
            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1addSession.AppendText("\r\nRoom Name: " + dr["RoomName"].ToString() + "\t");
            }
        }

        private void button1ClearAddSession_Click(object sender, EventArgs e)
        {
            comboBox1addSession.SelectedIndex = 0;
            comboBox2addSession.SelectedIndex = 0;
            textBox1addSession.Text = "";
        }

        private void button2SubmitAddSession_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LCS_ConSession = comboBox1addSession.Text;
            c.LCS_RoomName = comboBox2addSession.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Consecutive_session(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Session.");

                //clear if success
                comboBox1addSession.SelectedIndex = 0;
                comboBox2addSession.SelectedIndex = 0;
                textBox1addSession.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Session. Try Again");
            }
        }
    }
}
