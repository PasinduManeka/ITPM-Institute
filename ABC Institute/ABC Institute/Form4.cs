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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Tags tg = new Tags();
        static string connString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
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
                        textSubjectName.Text = (read["subjectName"].ToString());
                        textTagCode.Text = (read["tagCode"].ToString());
                        textSubjectCode.Text = (read["subjectCode"].ToString());
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

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable dt = tg.select();
            dataGridViewTags.DataSource = dt;
        }
    }
}
