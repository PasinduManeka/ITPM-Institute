using ABC_Institute.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class ManageTags : Form
    {
        public ManageTags()
        {
            InitializeComponent();
        }
        ConnectionManager conf;

        Tags tg = new Tags();
        static string connString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable dt = tg.select();
            dataGridViewTags.DataSource = dt;

            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("select distinct Subject_Name from Subj_Details_Table", con);

            DataTable dtd1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter(cmd);
            data1.Fill(dtd1);
            foreach (DataRow dr1 in dtd1.Rows)
            {
                cmbUpdateSubjectName.Items.Add(dr1["Subject_Name"].ToString());
            }

            SqlConnection con1 = new SqlConnection(connString);
            SqlCommand cmd1 = new SqlCommand("select distinct Subject_Code from Subj_Details_Table", con1);

            DataTable dtd2 = new DataTable();
            SqlDataAdapter data2 = new SqlDataAdapter(cmd1);
            data2.Fill(dtd2);
            foreach(DataRow dr2 in dtd2.Rows)
            {
                cmbUpdateCode.Items.Add(dr2["Subject_Code"].ToString());
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //get text field value
            tg.tagID = Convert.ToInt32(textBoxSearch.Text);

            //get data from databse and assign to text fieds.
            SqlConnection con = new SqlConnection(connString);
            string selectSql = "select* from tags WHERE id=@id";
            SqlCommand com = new SqlCommand(selectSql, con);
            com.Parameters.AddWithValue("@id", tg.tagID);

            try
            {
                con.Open();
                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        textBoxTagID.Text = (read["id"].ToString());
                        cmbUpdateSubjectName.Text = (read["subjectName"].ToString());
                        cmbUpdateTagCode.Text = (read["tagCode"].ToString());
                        cmbUpdateCode.Text = (read["subjectCode"].ToString());
                        comboRTags.Text = (read["relatedTag"].ToString());


                    }
                    read.Close();
                }
            }
            finally
            {
                con.Close();

            }



        }

       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cmbUpdateSubjectName.Text = string.Empty;
            cmbUpdateTagCode.Text = string.Empty;
            cmbUpdateCode.Text = string.Empty;
            textBoxTagID.Text = string.Empty;
            comboRTags.Text = string.Empty;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            tg.tagID = Convert.ToInt32( textBoxTagID.Text);
            tg.subjectName = cmbUpdateSubjectName.Text;
            tg.tagCode = cmbUpdateTagCode.Text;
            tg.subjectCode = cmbUpdateCode.Text;
            tg.rTag = comboRTags.Text;

            bool success = tg.Update(tg);

            if (success == true)
            {
                MessageBox.Show("Record is Updated....");
            }
            else
            {
                MessageBox.Show("Record has not updated. Try again");
            }

            DataTable dt = tg.select();
            dataGridViewTags.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            tg.tagID = Convert.ToInt32(textBoxTagID.Text);

            bool success = tg.DeleteTags(tg);

            if (success == true)
            {
                MessageBox.Show("Record is Deleted");
            }
            else
            {
                MessageBox.Show("Record has not deleted. Try Again.....");
            }

            DataTable dt = tg.select();
            dataGridViewTags.DataSource = dt;

        }

        //get the data fro data grid
        private void dataGridViewTags_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textBoxTagID.Text = dataGridViewTags.Rows[rowIndex].Cells[0].Value.ToString();
            cmbUpdateSubjectName.Text = dataGridViewTags.Rows[rowIndex].Cells[1].Value.ToString();
            cmbUpdateTagCode.Text = dataGridViewTags.Rows[rowIndex].Cells[2].Value.ToString();
            cmbUpdateCode.Text = dataGridViewTags.Rows[rowIndex].Cells[3].Value.ToString();
            comboRTags.Text = dataGridViewTags.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
