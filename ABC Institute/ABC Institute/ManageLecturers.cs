using ABC_Institute.Classes;
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


namespace ABC_Institute
{
    public partial class ManageLecturers : Form
    {
        private Lecturer lecturer = new Lecturer();

        public int ID;


        public ManageLecturers()
        {
            InitializeComponent();
        }
        SqlConnection conl;
        public void disp_data()
        {
            conl = ConnectionManager.GetConnection();
            conl.Open();



            SqlCommand cmd = conl.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lecturer_Details_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewf3LM.DataSource = dt;
            conl.Close();



        }


        private void Form3_Load(object sender, EventArgs e)
        {
            disp_data();
        }


        private void btnf3Addlecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLecturers ad = new AddLecturers();
            ad.Show();



        }

        public void clear()
        {
            textBox1f3EmpID.Text = "";
            textBox2f3LecName.Text = "";
            comboBox1f3Center.Text = "";
            comboBox2f3Faculty.Text = "";
            comboBox3f3Dept.Text = "";
            comboBox4f3Building.Text = "";
            comboBox5f3Level.Text = "";
            textBox3f3Rank.Text = "";
            comboBox5f3Level.Enabled = true;
            btn5f3GenarateRank.Enabled = true;
        }

        private void btn3f3Clear_Click(object sender, EventArgs e)
        {
            clear();
        }



        private void btn5f3GenarateRank_Click(object sender, EventArgs e)
        {
            if (textBox1f3EmpID.Text == string.Empty)
            {
                textBox1f3EmpID.Focus();
                MessageBox.Show("Please Enter empID", "Error");
            }

            else if (textBox1f3EmpID.Text.Length != 6)
            {
                textBox1f3EmpID.Focus();
                MessageBox.Show("Please Enter Valid Employee ID, Employee ID should be 6 digits", "Error");
            }

            else if (comboBox5f3Level.SelectedIndex == -1)
            {
                comboBox5f3Level.Focus();
                MessageBox.Show("please Select Level", "Error");
            }

            else
            {

                lecturer.Rank = comboBox5f3Level.SelectedItem + "." + textBox1f3EmpID.Text.Trim();
                textBox3f3Rank.Text = lecturer.Rank;
                textBox3f3Rank.ReadOnly = true;
                comboBox5f3Level.Enabled = false;
                btn5f3GenarateRank.Enabled = false;
            }
        }

        private void comboBox2f3Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3f3Dept.Items.Clear();

            if (comboBox2f3Faculty.SelectedItem.Equals("Computing"))
            {
                comboBox3f3Dept.Items.Add("Information Technology");
                comboBox3f3Dept.Items.Add("Software Engineering");
                comboBox3f3Dept.Items.Add("Cyber Security");
                comboBox3f3Dept.Items.Add("Data Science");
                comboBox3f3Dept.Items.Add("Information System engineering");
                comboBox3f3Dept.Items.Add("Computer Systems and Network");
                comboBox3f3Dept.Items.Add("Interactive Media");
            }
            else if (comboBox2f3Faculty.SelectedItem.Equals("Engineering"))
            {
                comboBox3f3Dept.Items.Add("Civil Engineering");
                comboBox3f3Dept.Items.Add("Electrical & Electronic Engineering");
                comboBox3f3Dept.Items.Add("Mechanical Engineering");
                comboBox3f3Dept.Items.Add("Mechatronic");
                comboBox3f3Dept.Items.Add("Materials Engineering");
                comboBox3f3Dept.Items.Add("Architecture");
                comboBox3f3Dept.Items.Add("Quantity Surveying");
            }
            else if (comboBox2f3Faculty.SelectedItem.Equals("Business"))
            {
                comboBox3f3Dept.Items.Add("Accounting & Finance");
                comboBox3f3Dept.Items.Add("Business Analytics");
                comboBox3f3Dept.Items.Add("Human Capital Management");
                comboBox3f3Dept.Items.Add("Marketing Management");
                comboBox3f3Dept.Items.Add("Logistics & Supply Chain Management");
                comboBox3f3Dept.Items.Add("Business Management");
            }
            else if (comboBox2f3Faculty.SelectedItem.Equals("Humanities and Science"))
            {
                comboBox3f3Dept.Items.Add("Biotechnology");
                comboBox3f3Dept.Items.Add("Education");
                comboBox3f3Dept.Items.Add("Law");
                comboBox3f3Dept.Items.Add("Mathematics");
                comboBox3f3Dept.Items.Add("Nursing");
                comboBox3f3Dept.Items.Add("Psychology");
            }
            else if (comboBox2f3Faculty.SelectedItem.Equals("School of Architecture"))
            {
                comboBox3f3Dept.Items.Add("Architecture");
            }
            else if (comboBox2f3Faculty.SelectedItem.Equals("Graduate Studies and research"))
            {
                comboBox3f3Dept.Items.Add("Information Technology");
                comboBox3f3Dept.Items.Add("Information Management");
                comboBox3f3Dept.Items.Add("Information Systems");
                comboBox3f3Dept.Items.Add("Information Technology – Cyber Security");
                comboBox3f3Dept.Items.Add("Business Administration");
                comboBox3f3Dept.Items.Add("Philosophy (MPhil)");
                comboBox3f3Dept.Items.Add("Philosophy (PhD)");
            }
            else if (comboBox2f3Faculty.SelectedItem.Equals("school of Hospitality and culinary"))
            {
                comboBox3f3Dept.Items.Add("Hospitality Management");
                comboBox3f3Dept.Items.Add("Commercial Cookery");
                comboBox3f3Dept.Items.Add("Event Management");
                comboBox3f3Dept.Items.Add("Patisserie Programme");
            }
        }

        SqlConnection connection;

        private void btn4f3Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("you want to delete this data...","delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    connection = ConnectionManager.GetConnection();
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd = new SqlCommand("delete from  Lecturer_Details_Table where ID ='" + ID + "' ", connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("sucessfully deleted");

                    connection.Close();
                    disp_data();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Not Deleted Data...");
            }

        }


        SqlConnection cons;
        private void btn2f3Update_Click(object sender, EventArgs e)
        {
            try
            {

                cons = ConnectionManager.GetConnection();
                cons.Open();

                SqlCommand cmd = cons.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("update Lecturer_Details_Table set Employee_ID ='" + textBox1f3EmpID.Text + "',Lecturer_Name='" + textBox2f3LecName.Text + "',Center='" + comboBox1f3Center.SelectedItem + "',Faculty='" + comboBox2f3Faculty.SelectedItem + "',Department ='" + comboBox3f3Dept.SelectedItem + "',Building='" + comboBox4f3Building.SelectedItem + "',Llevel='" + comboBox5f3Level.SelectedItem + "',Rank='" + textBox3f3Rank.Text + "' where ID = '" + ID + "'", cons);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully updated ");
                cons.Close();
                disp_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewf3LM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewf3LM.Rows[index];
            ID = Convert.ToInt32(dataGridViewf3LM.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1f3EmpID.Text = selectedRow.Cells[1].Value.ToString();
            textBox2f3LecName.Text = selectedRow.Cells[2].Value.ToString();
            comboBox1f3Center.Text = selectedRow.Cells[3].Value.ToString();
            comboBox2f3Faculty.Text = selectedRow.Cells[4].Value.ToString();
            comboBox3f3Dept.Text = selectedRow.Cells[5].Value.ToString();
            comboBox4f3Building.Text = selectedRow.Cells[6].Value.ToString();
            comboBox5f3Level.Text = selectedRow.Cells[7].Value.ToString();
            textBox3f3Rank.Text = selectedRow.Cells[8].Value.ToString();

        }

    }
}
