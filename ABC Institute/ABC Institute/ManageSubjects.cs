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
    public partial class ManageSubjects : Form
    {

      
        public ManageSubjects()
        {
            InitializeComponent();
        }

        // create method to display data

        SqlConnection conM;
        public void display_data()
        {
            conM = ConnectionManager.GetConnection();
            conM.Open();



            SqlCommand cmd = conM.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subj_Details_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2f5SM.DataSource = dt;
            conM.Close();



        }

        // pass display method 
        private void Form5_Load(object sender, EventArgs e)
        {
            display_data();
        }

        //clear button method
        public void clear()
        {
            textBox1f5SubName.Text = "";
            textBox2f5SubCode.Text = "";
            comboBox1f5OffYear.Text = "";
            comboBox2f5OffSemester.Text = "";
            comboBox3f5NoOfLecH.Text = "";
            comboBox4f5NoOfTuteH.Text = "";
            comboBox5f5NoOfLabH.Text = "";
            comboBox6f5NoOfEvalH.Text = "";

        }

        //clear button
        private void button3f5Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        
        private void button1f5AddSubj_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjects f4 = new AddSubjects();
            f4.Show();
        }

        //Delete

        SqlConnection cont;
        private int id;
        private void button4f5Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("you want to delete this data...", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                cont = ConnectionManager.GetConnection();
                cont.Open();

                SqlCommand cmd = cont.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("delete from  Subj_Details_Table where ID ='" + id + "' ", cont);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully deleted this Subject Details");
                cont.Close();
                display_data();

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

        //update
        SqlConnection cony;
        private void button2f5Update_Click(object sender, EventArgs e)
        {

            try
            {

                cony = ConnectionManager.GetConnection();
                cony.Open();

                SqlCommand cmd = cony.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("update Subj_Details_Table set Subject_Name ='" + textBox1f5SubName.Text + "',Subject_Code='" + textBox2f5SubCode.Text + "',Offerd_Year='" + comboBox1f5OffYear.SelectedItem + "',Offerd_Semester='" + comboBox2f5OffSemester.SelectedItem + "',Number_Of_Lecture_Hours ='" + comboBox3f5NoOfLecH.SelectedItem + "',Number_Of_Tutorial_Hours='" + comboBox4f5NoOfTuteH.SelectedItem + "',Number_Of_Lab_Hours='" + comboBox5f5NoOfLabH.SelectedItem + "',Number_Of_Evaluation_Hours='" + comboBox6f5NoOfEvalH.Text + "' where ID = '" + id + "'", cony);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully updated this Subject Details ");
                cony.Close();
                display_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        //data view table
        private void dataGridView2f5SM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2f5SM.Rows[index];
         
           
            id = Convert.ToInt32(dataGridView2f5SM.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            textBox1f5SubName.Text = selectedRow.Cells[1].Value.ToString();
            textBox2f5SubCode.Text = selectedRow.Cells[2].Value.ToString();
            comboBox1f5OffYear.Text = selectedRow.Cells[3].Value.ToString();
            comboBox2f5OffSemester.Text = selectedRow.Cells[4].Value.ToString();
            comboBox3f5NoOfLecH.Text = selectedRow.Cells[5].Value.ToString();
            comboBox4f5NoOfTuteH.Text = selectedRow.Cells[6].Value.ToString();
            comboBox5f5NoOfLabH.Text = selectedRow.Cells[7].Value.ToString();
            comboBox6f5NoOfEvalH.Text = selectedRow.Cells[8].Value.ToString();
        }


       
        

       //search
       // SqlConnection conq;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

           /* conq = ConnectionManager.GetConnection();
            

            SqlCommand cmd = conq.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subj_Details where Subject_Name = '" + textBox1f5SubName.Text + "'";
            conq.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2f5SM.DataSource = dt;
            conq.Close();*/
        }

       
    }
}
