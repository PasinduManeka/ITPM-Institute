using ABC_Institute.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        GroupClass c = new GroupClass();
        Session s = new Session();
       
        //ignore this
        private void Form5_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);


            DataTable dt = s.select();
            DataTable dt2 = s.select();
            dataGridView1.DataSource = dt;
            
        }

        //header check
        CheckBox HeaderCheckBox = new CheckBox();
        bool IsHeaderCheckBox = false;

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox.Size = new Size(15, 15);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
            this.dataGridView2.Controls.Add(HeaderCheckBox);
        }
        
        //header check click event
        private void HeaderCheckBoxClick(CheckBox HcheckBox)
        {
            IsHeaderCheckBox = true;
            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HcheckBox.Checked;
            }
            dataGridView1.RefreshEdit();
            foreach (DataGridViewRow Row in dataGridView2.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chk1"]).Value = HcheckBox.Checked;
            }
            dataGridView2.RefreshEdit();
            IsHeaderCheckBox = false;
        }

        //mouseclick event 
        private void HeaderCheckBox_MouseClick(Object sender , MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);


            DataTable dt = s.select();
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;

        }

        private void btnSaveConsecutive_Click(object sender, EventArgs e)
        {
            String sessionID = "";
            String lectureName = "";
            String subjectCode = "";
            String subjectName = "";
            String groupNumber = "";
            String Tags = "";
            string msg = "";
            string msg2 = "";

            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true)
                {
                    sessionID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    lectureName = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    Tags = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    groupNumber = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    subjectName = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    subjectCode = dataGridView1.Rows[i].Cells[7].Value.ToString();


                    msg += sessionID + "," + lectureName + "," + Tags + "," + groupNumber + "," + subjectName + "," + subjectCode;
                    lblMsgDidaplay.Text = msg;
                }
                


            }

            //groupNumber = dataGridView1.Rows[rowI].Cells[5].Value.ToString();
            //subjectName = dataGridView1.Rows[i].Cells[6].Value.ToString();
            //subjectCode = dataGridView1.Rows[i].Cells[7].Value.ToString();

          

        }

        private void btnSaveParalle_Click(object sender, EventArgs e)
        {
            String sessionID = "";
            String lectureName = "";
            String subjectCode = "";
            String subjectName = "";
            String groupNumber = "";
            String Tags = "";
            string msg = "";
            string msg2 = "";

            for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
            {

                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["chk1"].Value) == true)
                {
                    sessionID = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    lectureName = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    Tags = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    groupNumber = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    subjectName = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    subjectCode = dataGridView2.Rows[i].Cells[7].Value.ToString();


                    msg += sessionID + "," + lectureName + "," + Tags + "," + groupNumber + "," + subjectName + "," + subjectCode;
                    lblDisplayMSG2.Text = msg;
                }



            }
        }

        
        /*
private void btnSaveConsecutive_Click(object sender, CheckBox e)
{
//details get from selected check boxes.
String sessionID = "";
String lectureName = "";
String subjectCode = "";
String subjectName = "";
String groupNumber = "";
String Tags = "";
string msg = "";
string msg2 = "";
int rowIndex = e.;

sessionID = dataGridView1.Rows[i].Cells[1].Value.ToString();
lectureName = dataGridView1.Rows[i].Cells[2].Value.ToString();

//Details set on to label
for (int i=0;i<=dataGridView1.RowCount - 1;i++)
{
if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true)
{
Tags = dataGridView1.Rows[i].Cells[4].Value.ToString();
msg +=  Tags+"," ;
}
}

groupNumber = dataGridView1.Rows[rowI].Cells[5].Value.ToString();
subjectName = dataGridView1.Rows[i].Cells[6].Value.ToString();
subjectCode = dataGridView1.Rows[i].Cells[7].Value.ToString();

msg2 = sessionID+","+ lectureName + ","+ msg + ","+ groupNumber + ","+ subjectName + ","+ subjectCode + ",";



}*/
    }
}
