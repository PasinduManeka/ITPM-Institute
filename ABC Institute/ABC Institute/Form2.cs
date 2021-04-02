using ABC_Institute.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC_Institute
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        GroupClass c = new GroupClass();
        static string myconnString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textGID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridViewGroups.DataSource = dt;
        }

        private void buttonUpdate2_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.id= Convert.ToInt32(textSearch.Text);
            SqlConnection con = new SqlConnection(myconnString);
            string selectSql = "select* from student_groups WHERE id=@id";
            SqlCommand com = new SqlCommand(selectSql, con);
            com.Parameters.AddWithValue("@id", c.id);

            try
            {
                con.Open();
                using(SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        textID.Text = (read["id"].ToString());
                        comboYearSemester2.Text = (read["academicyearsemester"].ToString());
                        comboProgrammer2.Text = (read["programme"].ToString());
                        numericUpGNumber2.Value = Convert.ToInt32((read["groupNumber"].ToString()));
                        numericSGNumber2.Value = Convert.ToInt32((read["subGroupNumber"].ToString()));
                        textGID2.Text = (read["subGroupId"].ToString());
                        textSGID2.Text = (read["groupID"].ToString());
                    }
                    read.Close();
                }
            }
            finally
            {
                con.Close();

            }

        }
    }
}
