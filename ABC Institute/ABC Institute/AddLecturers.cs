
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
using ABC_Institute.Classes;

namespace ABC_Institute
{
    public partial class AddLecturers : Form
    {

        private Lecturer lecturer = new Lecturer();
       
        public AddLecturers()
        {
            InitializeComponent();
        }

        public void clear()
        {
            textBox1f2EmpID.Text = "";
            textBox2f2LecName.Text = "";
            comboBox1f2Center.Text = "";
            comboBox2f2Faculty.Text = "";
            comboBox3f2Dept.Text = "";
            comboBox4f2Building.Text = "";
            comboBox5f2Level.Text = "";
            textBox3f2Rank.Text = "";
            comboBox5f2Level.Enabled = true;
            button3f2GenarateRank.Enabled = true;
        }
       
        private void button2f2Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3f2GenarateRank_Click(object sender, EventArgs e)
        {
            if (textBox1f2EmpID.Text == string.Empty)
            {
                textBox1f2EmpID.Focus();
                MessageBox.Show("Please Enter empID", "Error");
            }

            else if (textBox1f2EmpID.Text.Length != 6)
            {
                textBox1f2EmpID.Focus();
                MessageBox.Show("Please Enter Valid Employee ID, Employee ID should be 6 digits", "Error");
            }

            else if (comboBox5f2Level.SelectedIndex == -1)
            {
                comboBox5f2Level.Focus();
                MessageBox.Show("please Select Level", "Error");
            }

            else
            {

                lecturer.Rank = comboBox5f2Level.SelectedItem + "." + textBox1f2EmpID.Text.Trim();
                textBox3f2Rank.Text = lecturer.Rank;
                textBox3f2Rank.ReadOnly = true;
                comboBox5f2Level.Enabled = false;
                button3f2GenarateRank.Enabled = false;
            }
        }

        private void comboBox2f2Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3f2Dept.Items.Clear();

            if (comboBox2f2Faculty.SelectedItem.Equals("Computing"))
            {
                comboBox3f2Dept.Items.Add("Information Technology");
                comboBox3f2Dept.Items.Add("Software Engineering");
                comboBox3f2Dept.Items.Add("Cyber Security");
                comboBox3f2Dept.Items.Add("Data Science");
                comboBox3f2Dept.Items.Add("Information System engineering");
                comboBox3f2Dept.Items.Add("Computer Systems and Network");
                comboBox3f2Dept.Items.Add("Interactive Media");
            }
            else if (comboBox2f2Faculty.SelectedItem.Equals("Engineering"))
            {
                comboBox3f2Dept.Items.Add("Civil Engineering");
                comboBox3f2Dept.Items.Add("Electrical & Electronic Engineering");
                comboBox3f2Dept.Items.Add("Mechanical Engineering");
                comboBox3f2Dept.Items.Add("Mechatronic");
                comboBox3f2Dept.Items.Add("Materials Engineering");
                comboBox3f2Dept.Items.Add("Architecture");
                comboBox3f2Dept.Items.Add("Quantity Surveying");
            }
            else if (comboBox2f2Faculty.SelectedItem.Equals("Business"))
            {
                comboBox3f2Dept.Items.Add("Accounting & Finance");
                comboBox3f2Dept.Items.Add("Business Analytics");
                comboBox3f2Dept.Items.Add("Human Capital Management");
                comboBox3f2Dept.Items.Add("Marketing Management");
                comboBox3f2Dept.Items.Add("Logistics & Supply Chain Management");
                comboBox3f2Dept.Items.Add("Business Management");
            }
            else if (comboBox2f2Faculty.SelectedItem.Equals("Humanities and Science"))
            {
                comboBox3f2Dept.Items.Add("Biotechnology");
                comboBox3f2Dept.Items.Add("Education");
                comboBox3f2Dept.Items.Add("Law");
                comboBox3f2Dept.Items.Add("Mathematics");
                comboBox3f2Dept.Items.Add("Nursing");
                comboBox3f2Dept.Items.Add("Psychology");
            }
            else if (comboBox2f2Faculty.SelectedItem.Equals("School of Architecture"))
            {
                comboBox3f2Dept.Items.Add("Architecture");
            }
            else if (comboBox2f2Faculty.SelectedItem.Equals("Graduate Studies and research"))
            {
                comboBox3f2Dept.Items.Add("Information Technology");
                comboBox3f2Dept.Items.Add("Information Management");
                comboBox3f2Dept.Items.Add("Information Systems");
                comboBox3f2Dept.Items.Add("Information Technology – Cyber Security");
                comboBox3f2Dept.Items.Add("Information Technology – Enterprise Applications Development");
                comboBox3f2Dept.Items.Add("Business Administration");
                comboBox3f2Dept.Items.Add("Philosophy (MPhil)");
                comboBox3f2Dept.Items.Add("Philosophy (PhD)");
            }
            else if (comboBox2f2Faculty.SelectedItem.Equals("school of Hospitality and culinary"))
            {
                comboBox3f2Dept.Items.Add("Hospitality Management");
                comboBox3f2Dept.Items.Add("Commercial Cookery");
                comboBox3f2Dept.Items.Add("Event Management");
                comboBox3f2Dept.Items.Add("Patisserie Programme");
            }
            //cmbfaculty.SelectedIndex = -1;
        }


             //set connection
             SqlConnection con;
        private void button1f2Save_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                MessageBox.Show("sucessfully insert..!!!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string q = "insert into Lecturer_Details_Table(Employee_ID ,Lecturer_Name,Center,Faculty,Department,Building,Llevel,Rank) values ('" + textBox1f2EmpID.Text + "','" + textBox2f2LecName.Text + "','" + comboBox1f2Center.SelectedItem + "','" + comboBox2f2Faculty.SelectedItem + "','" + comboBox3f2Dept.SelectedItem + "','" + comboBox4f2Building.SelectedItem + "','" + comboBox5f2Level.SelectedItem + "','" + textBox3f2Rank.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageLecturers f3 = new ManageLecturers();
            f3.Show();

        }

        private void AddLecturers_Load(object sender, EventArgs e)
        {

        }
    }
}
