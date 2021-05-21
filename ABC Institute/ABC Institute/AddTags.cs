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
    public partial class AddTags : Form
    {
        public AddTags()
        {
            InitializeComponent();
        }

        Tags tg = new Tags();
        SqlConnection conf;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            tg.subjectName = cmbSubjects.Text;
            tg.subjectCode = cmbSubCode.Text;
            tg.tagCode = cmbTagCode.Text;
            tg.rTag = comboRTag.Text;

            bool success = tg.Insert(tg);

            if (success == true)
            {
                if(MessageBox.Show("Do You want to move \'Manage Tags\'?", "Tag is ceated...", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    ManageTags f4 = new ManageTags();
                    f4.Show();
                }
                else
                {

                }
                //MessageBox.Show("Tag is created.....");
            }
            else
            {
                MessageBox.Show("Tag has not created. Try again..........");
            }
        }

        private void buttonClear3_Click(object sender, EventArgs e)
        {
            cmbSubjects.Text = string.Empty;
            cmbSubCode.Text = string.Empty;
            cmbTagCode.Text = string.Empty;
            comboRTag.Text = string.Empty;

            
        }

        private void AddTags_Load(object sender, EventArgs e)
        {
            conf = ConnectionManager.GetConnection();
            conf.Open();
            SqlCommand cmd = new SqlCommand("select distinct Subject_Name from Subj_Details_Table", conf);

            DataTable dtd1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter(cmd);
            data1.Fill(dtd1);
            foreach(DataRow dr1 in dtd1.Rows)
            {
                cmbSubjects.Items.Add(dr1["Subject_Name"].ToString());
            }

            //subject code
            conf = ConnectionManager.GetConnection();
            conf.Open();
            SqlCommand cmd1 = new SqlCommand("select distinct Subject_Code from Subj_Details_Table",conf);

            DataTable dt2 =new DataTable();
            SqlDataAdapter dtd2 = new SqlDataAdapter(cmd1);
            dtd2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                cmbSubCode.Items.Add(dr2["Subject_Code"].ToString());
            }
        }
    }
}
