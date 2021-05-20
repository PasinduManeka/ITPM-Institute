using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Institute.Classes;

namespace ABC_Institute
{
    public partial class AddSession : Form
    {

        private Lecturer lecturer = new Lecturer();
        private Session session = new Session();
        

        public AddSession()
        {
            InitializeComponent();
        }


        public void clear()
        {
            f6comboBox0lec1.SelectedIndex = -1;
            f6comboBox0lec2.SelectedIndex = -1;
            f6comboBox1seltag.SelectedItem= -1;
        }

        private void f6btn2clear_Click(object sender, EventArgs e)
        {
            clear();
        }

       
        private void f6btn1next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
       

        private void f6btn3back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void f6btn4clear_Click(object sender, EventArgs e)
        {
            f6comboBox2selGroup.SelectedIndex = -1;
            f6comboBox3selsubj.SelectedIndex = -1;
            f6textBox3noofstu.Text = "";
            f6textBox4duration.Text = "";
            F6textBox5Session.Text = "";
            btnsession.Enabled = true;
        }

        SqlConnection conf;

        private void Form6_Load(object sender, EventArgs e)
        {
            conf = ConnectionManager.GetConnection();
            conf.Open();

            SqlCommand cmd = new SqlCommand("Select Lecturer_Name from Lecturer_Details_Table", conf);

            SqlCommand cmd1 = new SqlCommand("Select Subject_Name,Subject_Code from Subj_Details_Table", conf);

            SqlCommand cmd2 = new SqlCommand("select groupID from student_groups", conf);

            




            DataTable dt = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter(cmd);
            data1.Fill(dt);

            foreach (DataRow dr1 in dt.Rows)
            {

                f6comboBox0lec1.Items.Add(dr1["Lecturer_Name"].ToString());
                f6comboBox0lec2.Items.Add(dr1["Lecturer_Name"].ToString());
            }


            DataTable dt1 = new DataTable();
            SqlDataAdapter data2 = new SqlDataAdapter(cmd1);
            data2.Fill(dt1);

            foreach (DataRow dr2 in dt1.Rows)
            {

                f6comboBox3selsubj.Items.Add(dr2["Subject_Name"].ToString());
                f6comboBox4subjcode.Items.Add(dr2["Subject_Code"].ToString());
            }

            DataTable dt2 = new DataTable();
            SqlDataAdapter data3 = new SqlDataAdapter(cmd2);
            data3.Fill(dt2);

           
                foreach (DataRow dr3 in dt2.Rows)
                {

                    f6comboBox2selGroup.Items.Add(dr3["GroupID"].ToString());

                }

            conf.Close();


        }

        private void f6comboBox1seltag_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (!f6comboBox1seltag.SelectedItem.Equals("Lecture"))
            {
               if (f6comboBox1seltag.SelectedItem.Equals("Tutorial"))
                {
                    f6textBox3noofstu.Text = "120";
                    f6textBox4duration.Text = "1 hours";
                }
                else if (f6comboBox1seltag.SelectedItem.Equals("Lab"))
                {
                    f6textBox3noofstu.Text = "60";
                    f6textBox4duration.Text = "2 hours";
                }
            }
            else
            {
                f6textBox3noofstu.Text = "120";
                f6textBox4duration.Text = "2 hours";
            }
             
        }




      

        SqlConnection con3;

        private void f6btn6save_Click(object sender, EventArgs e)
        {

            
               try
               {
                   con3 = ConnectionManager.GetConnection();
                   con3.Open();
                   

               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
               }

               string q = "insert into Manage_Session_TableN(Lecturer_Name1,Lecturer_Name2,Tag,Group_ID,Subject_Name,Subject_code,No_Of_Students,Duration,Session)" +
                " values ('" + f6comboBox0lec1.SelectedItem + "','" + f6comboBox0lec2.SelectedItem + "','" + f6comboBox1seltag.SelectedItem + "','" + f6comboBox2selGroup.SelectedItem + "','" + f6comboBox3selsubj.SelectedItem + "','" + f6comboBox4subjcode.SelectedItem + "','" + f6textBox3noofstu.Text + "','" + f6textBox4duration.Text + "','" + F6textBox5Session.Text + "')";
                SqlCommand command = new SqlCommand(q, con3);
                command.ExecuteNonQuery();

                MessageBox.Show("sucessfully insert..!!!");
                con3.Close();
               
        }

        private void f6btnGo_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageSession f7 = new ManageSession();
            f7.Show();
        }

        private void f6comboBox2selGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void f6label5selGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnsession_Click(object sender, EventArgs e)
        {
            session.Msession = f6comboBox0lec1.SelectedItem + "-" + f6comboBox0lec2.SelectedItem + "-" + f6comboBox1seltag.SelectedItem + "-" + f6comboBox2selGroup.SelectedItem + "-" + f6comboBox3selsubj.SelectedItem + "-" + f6comboBox4subjcode.SelectedItem + "-" + f6textBox3noofstu.Text + "-" + f6textBox4duration.Text.Trim();
            F6textBox5Session.Text = session.Msession;
            F6textBox5Session.ReadOnly = true;
            btnsession.Enabled = false;
        }
    }
}
