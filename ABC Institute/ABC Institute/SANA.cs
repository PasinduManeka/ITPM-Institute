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
    public partial class SANA : Form
    {
        public SANA()
        {
            InitializeComponent();
        }

        public void loadData()
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        advancedSessions asd = new advancedSessions();
        SqlConnection conf;

        private void SANA_Load(object sender, EventArgs e)
        {
            //cmbConsectuiveBox1.SelectedText = "null";

            //set default values in combo voxes Consecutive 
            cmbConsectuiveBox1.SelectedText = " -- Select -- ";
            cmbConsectuiveBox2.SelectedText = " -- Select -- ";

            //set default values in combo voxes non overlapping
            //cmbOverlappingSessiion1.SelectedText = " -- Select -- ";
            //cmbOverlappingSessiion1.Items.Add("fdefv");

            //set default values in combo voxes parallel
            //cmbParallelSession1.SelectedText = "-- Select --";
            //cmbParallelSession2.SelectedText = "-- Select --";
            //cmbParallelDuration.SelectedText = "-- Select --";
            //cmbParallelDay.SelectedText = "-- Select --";
            //cmbParallelStartTime.SelectedText = "-- Select --";
            //cmbParallelEndTime.SelectedText = "-- Select --";

            //set consecutive to grid view
            DataTable dtd = asd.selectConsecutive();
            dataConsectuiveGridView1.DataSource = dtd;

            conf = ConnectionManager.GetConnection();
            conf.Open();
            SqlCommand cmd = new SqlCommand("select Session from Manage_Session_TableN", conf);

            DataTable dtd1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter(cmd);
            data1.Fill(dtd1);
            foreach(DataRow dr1 in dtd1.Rows)
            {
                cmbConsectuiveBox1.Items.Add(dr1["Session"].ToString());
                cmbConsectuiveBox2.Items.Add(dr1["Session"].ToString());
                cmbParallelSession1.Items.Add(dr1["Session"].ToString());
                cmbParallelSession2.Items.Add(dr1["Session"].ToString());
                cmbOverlappingSessiion1.Items.Add(dr1["Session"].ToString());
                cmbOverlappingSession2.Items.Add(dr1["Session"].ToString());
            }
            
           
            
            
            /*DataTable dtd2 = asd.selsctSesion();
            foreach(DataRow dr1 in dtd2.Rows)
            {
                cmbConsectuiveBox1.Items.Add(dr1["ms.Session"].ToString());
                cmbConsectuiveBox2.Items.Add(dr1["ms.Session"].ToString());
            }*/

            //Consecutive comboxes
            //cmbConsectuiveBox1.DataSource = dtd2;
            //cmbConsectuiveBox2.DataSource = dtd2;




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            cmbParallelSession1.SelectedText = "--Vslur--";
        }

        private void btnSaveConsecutive_Click(object sender, EventArgs e)
        {
            asd.session1 = cmbConsectuiveBox1.Text;
            asd.session2 = cmbConsectuiveBox2.Text;

            bool success = asd.insertConsecutive(asd);
            if (success == true)
            {
                lblMsgDisplay.Text = "Consecutive Sessions added successsfully.";
            }
            else
            {
                lblMsgDisplay.Text = "Failed to add consecutive sessions.";
            }
            //to refresh the table
            DataTable dt = asd.selectConsecutive();
            dataConsectuiveGridView1.DataSource = dt;
        }

        //Consecutive clear button to clear the text fields
        private void btnConsecutiveClear_Click(object sender, EventArgs e)
        {
            cmbConsectuiveBox1.Text = string.Empty;
            cmbConsectuiveBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        //for the take the row value on to the data fields.
        private void dataConsectuiveGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get row values to the text and combo fields.
            int rowIndex = e.RowIndex;
            textBox1.Text = dataConsectuiveGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            cmbConsectuiveBox1.Text = dataConsectuiveGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cmbConsectuiveBox2.Text = dataConsectuiveGridView1.Rows[rowIndex].Cells[2].Value.ToString();
        }

        //to update the values
        private void btnUpdateConsecutive_Click(object sender, EventArgs e)
        {
            asd.id = int.Parse(textBox1.Text);
            asd.session1 = cmbConsectuiveBox1.Text;
            asd.session2 = cmbConsectuiveBox2.Text;

            bool success = asd.updateConsecutive(asd);
            if (success == true)
            {
                lblMsgDisplay.Text = "Consecutive session updated successfully.";
            }
            else
            {
                lblMsgDisplay.Text = "Faild to update the consecutive session.";
            }
            DataTable dt = asd.selectConsecutive();
            dataConsectuiveGridView1.DataSource = dt;
        }

        private void btnConsecutiveDelete_Click(object sender, EventArgs e)
        {
            asd.id = int.Parse(textBox1.Text);

            bool success = asd.deleteConsecutive(asd);
            if (success == true)
            {
                lblMsgDisplay.Text = "Consecutive session is deleted.";
            }
            else
            {
                lblMsgDisplay.Text = "Faild to delete consecutive session.";
            }
            DataTable dt = asd.selectConsecutive();
            dataConsectuiveGridView1.DataSource = dt;
        }
    }
}
