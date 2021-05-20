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
    public partial class ManageSession : Form
    {

        private Session s1 = new Session();
        public int ID;

        public ManageSession()
        {
            InitializeComponent();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession f6 = new AddSession();
            f6.Show();
        }

      
        private void btn5View_Click(object sender, EventArgs e)
        {
            View v1 = new View();
            v1.Show();

            
        }

        private void f7btn2clear_Click(object sender, EventArgs e)
        {
            f7comboBox0.SelectedIndex = -1;
            f7comboBox00.SelectedIndex=-1;
            f7comboBox1.SelectedItem = -1;
            f7comboBox2.SelectedIndex = -1;
            f7comboBox3.SelectedIndex = -1;
            f7comboBox6.SelectedIndex = -1;
            f7textBox3.Text = string.Empty;
            f7textBox4.Text = string.Empty;
            f7textBox5.Text = string.Empty;
            
        }

        SqlConnection conp;

        private void Form7_Load(object sender, EventArgs e)
        {
            display_Sessiondata();

            conp = ConnectionManager.GetConnection();
            conp.Open();

            SqlCommand cmd1 = new SqlCommand("Select Lecturer_Name from Lecturer_Details_Table", conp);

            SqlCommand cmd2 = new SqlCommand("Select Subject_Name,Subject_Code from Subj_Details_Table", conp);

            SqlCommand cmd3 = new SqlCommand("select groupID from student_groups", conp);



            DataTable dt = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            data1.Fill(dt);

            foreach (DataRow dr1 in dt.Rows)
            {

                f7comboBox0.Items.Add(dr1["Lecturer_Name"].ToString());
                f7comboBox00.Items.Add(dr1["Lecturer_Name"].ToString());
            }


            DataTable dt1 = new DataTable();
            SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
            data2.Fill(dt1);

            foreach (DataRow dr2 in dt1.Rows)
            {

                f7comboBox3.Items.Add(dr2["Subject_Name"].ToString());
                f7comboBox6.Items.Add(dr2["Subject_Code"].ToString());
            }

            DataTable dt2 = new DataTable();
            SqlDataAdapter data3 = new SqlDataAdapter(cmd3);
            data3.Fill(dt2);


            foreach (DataRow dr3 in dt2.Rows)
            {

                f7comboBox2.Items.Add(dr3["GroupID"].ToString());

            }

            conp.Close();

        }


        private void f7dataGridView1MS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = f7dataGridView1MS.Rows[index];
            ID = Convert.ToInt32(f7dataGridView1MS.Rows[e.RowIndex].Cells[0].Value.ToString());
            f7comboBox0.Text = selectedRow.Cells[1].Value.ToString();
            f7comboBox00.Text = selectedRow.Cells[2].Value.ToString();
            f7comboBox1.Text = selectedRow.Cells[3].Value.ToString();
            f7comboBox2.Text = selectedRow.Cells[4].Value.ToString();
            f7comboBox3.Text = selectedRow.Cells[5].Value.ToString();
            f7comboBox6.Text = selectedRow.Cells[6].Value.ToString();
            f7textBox3.Text = selectedRow.Cells[7].Value.ToString();
            f7textBox4.Text = selectedRow.Cells[8].Value.ToString();
            f7textBox5.Text = selectedRow.Cells[9].Value.ToString();

        

        }

        SqlConnection con4;
        public void display_Sessiondata()
        {
            con4 = ConnectionManager.GetConnection();
            con4.Open();



            SqlCommand cmd = con4.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Manage_Session_TableN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            f7dataGridView1MS.DataSource = dt;
            con4.Close();



        }

        SqlConnection cont;
        private void f7btn4Delete_Click(object sender, EventArgs e)
        {
            try
            {
                cont = ConnectionManager.GetConnection();
                cont.Open();

                SqlCommand cmd = cont.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("delete from  Manage_Session_TableN where ID ='" + ID + "' ", cont);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully deleted this Session Details");
                cont.Close();
                display_Sessiondata();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        SqlConnection cony;
        private void f7btn3update_Click(object sender, EventArgs e)
        {
            try
            {

                cony = ConnectionManager.GetConnection();
                cony.Open();

                SqlCommand cmd = cony.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("update Manage_Session_TableN set Lecturer_Name1 ='" + f7comboBox0.SelectedItem + "',Lecturer_Name2='" + f7comboBox00.SelectedItem + "',Tag='" + f7comboBox1.SelectedItem + "',Group_ID='" + f7comboBox2.SelectedItem + "',Subject_Name ='" + f7comboBox3.SelectedItem + "', Subject_code ='" + f7comboBox6.SelectedItem + "',No_Of_Students='" + f7textBox3.Text + "',Duration='" + f7textBox4.Text + "',Session='" + f7textBox5.Text + "' where ID = '" + ID + "'", cony);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully updated this Session Details ");
                cony.Close();
                display_Sessiondata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void f7comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!f7comboBox1.SelectedItem.Equals("Lecture"))
            {
                if (f7comboBox1.SelectedItem.Equals("Tutorial"))
                {
                    f7textBox3.Text = "120";
                    f7textBox4.Text = "1 hours";
                }
                else if (f7comboBox1.SelectedItem.Equals("Lab"))
                {
                    f7textBox3.Text = "60";
                    f7textBox4.Text = "2 hours";
                }
            }
            else
            {
                f7textBox3.Text = "120";
                f7textBox4.Text = "2 hours";
            }

        }

       
        private void f7dataGridView1MS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void f7btnsesion_Click(object sender, EventArgs e)
        {
            s1.Msession = f7comboBox0.SelectedItem + "-" + f7comboBox00.SelectedItem + "-" + f7comboBox1.SelectedItem + "-" + f7comboBox2.SelectedItem + "-" + f7comboBox3.SelectedItem + "-" + f7comboBox6.SelectedItem + "-" + f7textBox3.Text + "-" + f7textBox4.Text.Trim();
            f7textBox5.Text = s1.Msession;
            f7textBox5.ReadOnly = true;
            f7btnsesion.Enabled = false;
        }
    }
}
