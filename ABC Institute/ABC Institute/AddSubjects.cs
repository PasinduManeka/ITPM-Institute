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
    public partial class AddSubjects : Form
    {
        private Subject subject = new Subject();

        public AddSubjects()
        {
            InitializeComponent();
        }

        public void clear()
        {
            textBox1f4SubName.Text = "";
            textBox2f4SubCode.Text = "";
            comboBox1f4OffYear.Text = "";
            comboBox2f4OffSemester.Text = "";
            comboBox3f4NoOfLecH.Text = "";
            comboBox4f4NoOfTuteH.Text = "";
            comboBox5f4NoOfLabH.Text = "";
            comboBox6f4NoOfEvalH.Text = "";


        }

        private void btn2f4_Click(object sender, EventArgs e)
        {
            clear();
        }

        SqlConnection cons;
        private void button1f4Save_Click(object sender, EventArgs e)
        {
            try
            {
                cons = ConnectionManager.GetConnection();
                cons.Open();
                MessageBox.Show("sucessfully insert..!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string q = "insert into Subj_Details_Table(Subject_Name,Subject_Code,Offerd_Year,Offerd_Semester,Number_Of_Lecture_Hours,Number_Of_tutorial_Hours,Number_Of_Lab_Hours,Number_Of_Evaluation_Hours) values ('" + textBox1f4SubName.Text + "','" + textBox2f4SubCode.Text + "','" + comboBox1f4OffYear.SelectedItem + "','" + comboBox2f4OffSemester.SelectedItem + "','" + comboBox3f4NoOfLecH.SelectedItem + "','" + comboBox4f4NoOfTuteH.SelectedItem + "','" + comboBox5f4NoOfLabH.SelectedItem + "','" + comboBox6f4NoOfEvalH.SelectedItem + "')";
            SqlCommand cmd = new SqlCommand(q, cons);
            cmd.ExecuteNonQuery();
            cons.Close();
        }

       

        private void btn3f4goback_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageSubjects f5 = new ManageSubjects();
            f5.Show();
        }

        private void AddSubjects_Load(object sender, EventArgs e)
        {

        }
    }
}
