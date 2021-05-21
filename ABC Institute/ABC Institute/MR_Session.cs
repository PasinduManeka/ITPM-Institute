using ABC_Institute.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class MR_Session : Form
    {
        SQL c = new SQL();
        public MR_Session()
        {
            InitializeComponent();
        }

        private void MR_Session_Load(object sender, EventArgs e)
        {
            //get selected session details to the combobox
            if (MR_Consecutive_Sessions.success == true)
            {
                comboBox1Session.Text = MR_Consecutive_Sessions.sendtext;
                comboBox1Session.Items.Add(MR_Consecutive_Sessions.sendtext);
                textBox1Session.AppendText(MR_Consecutive_Sessions.sendtext + "\r\n");
            }
                                    
            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                comboBox2Session.Items.Add(dr["RoomName"].ToString());
            }

          
        }

        private void comboBox1Session_SelectedIndexChanged(object sender, EventArgs e)
        {        
            textBox1Session.AppendText("\t" + comboBox1Session.SelectedItem + "\t");
        }

        private void comboBox2Session_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2Session.SelectedItem.ToString() + "'";
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Session.AppendText("\r\nRoom Name: " + dr["RoomName"].ToString());
            }
        }

        private void textBox1Session_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1ClearSession_Click(object sender, EventArgs e)
        {
            comboBox1Session.SelectedIndex = 0;
            comboBox2Session.SelectedIndex = 0;
            textBox1Session.Text = "";
        }

        private void button2SubmitSession_Click(object sender, EventArgs e)
        {

            //Get the values from the input fields
            c.LSe_Session = comboBox1Session.Text;
            c.LSe_RoomName = comboBox2Session.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Session(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Session.");

                //clear if success
                comboBox1Session.Text = "";
                comboBox2Session.Text = "";
                textBox1Session.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Session. Try Again");
            }
        }

       
    }
}
