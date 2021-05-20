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
    public partial class ManageStudentGroups : Form
    {
        public ManageStudentGroups()
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
            c.id = int.Parse(textSearch.Text);
            c.yearSemester = comboYearSemester2.Text;
            c.programme = comboProgrammer2.Text;
            c.groupNumber = Convert.ToInt32(numericUpGNumber2.Value);
            c.subgroupNumber = Convert.ToInt32(numericSGNumber2.Value);
            c.groupID = textGID2.Text;
            c.subGroupID = textSGID2.Text;

            bool success = c.Update(c);

            if (success == true)
            {
                MessageBox.Show("Updated.........");
            }
            else
            {
                MessageBox.Show("Failed to update. Try Again...");
            }

            DataTable dt = c.Select();
            dataGridViewGroups.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.id= Convert.ToInt32(textSearch.Text);
            /*if (textSearch.Text = "")
            {

            }*/
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
                        textGID2.Text = (read["groupID"].ToString());
                        textSGID2.Text = (read["subGroupId"].ToString());
                    }
                    read.Close();
                }
            }
            finally
            {
                con.Close();

            }

            
        }

        private void buttonGenerate2_Click(object sender, EventArgs e)
        {
            String yearsemester = comboYearSemester2.Text;
            String programmer = comboProgrammer2.Text;
            int groupNumber = Convert.ToInt32(numericUpGNumber2.Value);
            int subGroupNum = Convert.ToInt32(numericSGNumber2.Value);

            textGID2.Text = yearsemester + programmer + groupNumber;
            textSGID2.Text = yearsemester + programmer + groupNumber + "." + subGroupNum;
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textSearch.Text = string.Empty;
            textID.Text = string.Empty;
            comboYearSemester2.Text = string.Empty;
            comboProgrammer2.Text = string.Empty;
            numericUpGNumber2.Value = 0;
            numericSGNumber2.Value = 0;
            textGID2.Text = string.Empty;
            textSGID2.Text = string.Empty;
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(textSearch.Text);
            bool success = c.DeleteGroups(c);

            if (success = true)
            {
                MessageBox.Show("Record Deleted.....");
            }
            else if(success = false)
            {
                MessageBox.Show("Record is not deleted.....");
            }
            DataTable dt = c.Select();
            dataGridViewGroups.DataSource = dt;
        }

        private void dataGridViewGroups_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textID.Text = dataGridViewGroups.Rows[rowIndex].Cells[0].Value.ToString();
            comboYearSemester2.Text = dataGridViewGroups.Rows[rowIndex].Cells[1].Value.ToString();
            comboProgrammer2.Text = dataGridViewGroups.Rows[rowIndex].Cells[2].Value.ToString();
            numericUpGNumber2.Value = Convert.ToInt32(dataGridViewGroups.Rows[rowIndex].Cells[3].Value.ToString());
            numericSGNumber2.Value = Convert.ToInt32(dataGridViewGroups.Rows[rowIndex].Cells[4].Value.ToString());
            textSGID2.Text = dataGridViewGroups.Rows[rowIndex].Cells[5].Value.ToString();
            textGID2.Text = dataGridViewGroups.Rows[rowIndex].Cells[6].Value.ToString();
        }
    }
}
