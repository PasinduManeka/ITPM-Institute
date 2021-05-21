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

            //parallel
            DataTable dtd3 = asd.selectParallel();
            dataGridParallelView1.DataSource = dtd3;

            //overlap
            DataTable dtd4 = asd.selectOverlap();
            dataOverlappingGridView1.DataSource = dtd3;

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

       
        //Consecutive
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

        //to delete the values
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

        //to added parallel sessions
        private void btnParallelSave_Click(object sender, EventArgs e)
        {
            asd.session1 = cmbParallelSession1.Text;
            asd.session2 = cmbParallelSession2.Text;
            asd.duration = cmbParallelDuration.Text;
            asd.day = cmbParallelDay.Text;
            asd.startTime = cmbParallelStartTime.Text;
            asd.endTime = cmbParallelEndTime.Text;

            bool success = asd.insertParallel(asd);

            if (success == true)
            {
                MessageBox.Show("Successfully added the parallel sessions.");
            }
            else
            {
                MessageBox.Show("Try again.. Faild to added parallel sessions.");
            }
            
            DataTable dt = asd.selectParallel();
            dataGridParallelView1.DataSource = dt;
        }

        //parallel data table header click event
        private void dataGridParallelView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtParallelID.Text = dataGridParallelView1.Rows[rowIndex].Cells[0].Value.ToString();
            cmbParallelSession1.Text = dataGridParallelView1.Rows[rowIndex].Cells[1].Value.ToString();
            cmbParallelSession2.Text = dataGridParallelView1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbParallelDuration.Text= dataGridParallelView1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbParallelDay.Text = dataGridParallelView1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbParallelStartTime.Text = dataGridParallelView1.Rows[rowIndex].Cells[5].Value.ToString();
            cmbParallelEndTime.Text = dataGridParallelView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        //parallel clear button
        private void btnParallelClear_Click(object sender, EventArgs e)
        {
            cmbParallelSession1.Text = string.Empty;
            cmbParallelSession2.Text = string.Empty;
            txtParallelID.Text = string.Empty;
            cmbParallelDuration.Text = string.Empty;
            cmbParallelDay.Text = string.Empty;
            cmbParallelStartTime.Text = string.Empty;
            cmbParallelEndTime.Text = string.Empty;

        }

        //update parallel
        private void btnParallelUpdate_Click(object sender, EventArgs e)
        {
            //assign to setters
            asd.id = int.Parse(txtParallelID.Text);
            asd.session1 = cmbParallelSession1.Text;
            asd.session2 = cmbParallelSession2.Text;
            asd.duration = cmbParallelDuration.Text;
            asd.day = cmbParallelDay.Text;
            asd.startTime = cmbParallelStartTime.Text;
            asd.endTime = cmbParallelEndTime.Text;

            bool success = asd.updateParallel(asd);

            if (success == true)
            {
                MessageBox.Show("Succesfully updated the parallel sesion.");
            }
            else
            {
                MessageBox.Show("Fails to update the parallel session.");
            }
            DataTable dt = asd.selectParallel();
            dataGridParallelView1.DataSource = dt;

        }

        //delete parallel
        private void btnParallelDelete_Click(object sender, EventArgs e)
        {
            asd.id = int.Parse(txtParallelID.Text);

            bool success = asd.deleteParallel(asd);

            if (success == true)
            {
                MessageBox.Show("Successfully deleted the parallel session.");
            }else if (success == false)
            {
                MessageBox.Show("Faild to delete the parallel session.");
            }
            DataTable dt = asd.selectParallel();
            dataGridParallelView1.DataSource = dt;
        }




        //Non Overlapping
        private void dataOverlappingGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtOverlappingSession.Text = dataGridParallelView1.Rows[rowIndex].Cells[0].Value.ToString();
            cmbOverlappingSessiion1.Text = dataGridParallelView1.Rows[rowIndex].Cells[1].Value.ToString();
            cmbOverlappingSession2.Text = dataGridParallelView1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbOverlappingDuration.Text = dataGridParallelView1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbOverlappingDay.Text = dataGridParallelView1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbOverlappingStartDate.Text = dataGridParallelView1.Rows[rowIndex].Cells[5].Value.ToString();
            cmbOverlappingEndTime.Text = dataGridParallelView1.Rows[rowIndex].Cells[6].Value.ToString();

        }

        private void btnOverlappingSave_Click(object sender, EventArgs e)
        {
            asd.session1 = cmbOverlappingSessiion1.Text;
            asd.session2 = cmbOverlappingSession2.Text;
            asd.duration = cmbOverlappingDuration.Text;
            asd.day = cmbOverlappingDay.Text;
            asd.startTime = cmbOverlappingStartDate.Text;
            asd.endTime = cmbOverlappingEndTime.Text;

            bool success = asd.insertOverlap(asd);
            if (success == true)
            {
                MessageBox.Show("non Overlapping sessions added.");
            }
            else if (success == false)
            {
                MessageBox.Show("Faild to added non overlap session");
            }
        }

        //overlap clear
        private void btnOverlappingClear_Click(object sender, EventArgs e)
        {
            txtOverlappingSession.Text = string.Empty;
            cmbOverlappingSessiion1.Text = string.Empty;
            cmbOverlappingSession2.Text = string.Empty;
            cmbOverlappingDuration.Text = string.Empty;
            cmbOverlappingDay.Text = string.Empty;
            cmbOverlappingStartDate.Text = string.Empty;
            cmbOverlappingEndTime.Text = string.Empty;
        }

        //overlap update
        private void tbnOverlappingUpdate_Click(object sender, EventArgs e)
        {
            asd.id = int.Parse(txtOverlappingSession.Text);
            asd.session1 = cmbOverlappingSessiion1.Text;
            asd.session2 = cmbOverlappingSession2.Text;
            asd.duration = cmbOverlappingDuration.Text;
            asd.day = cmbOverlappingDay.Text;
            asd.startTime = cmbOverlappingStartDate.Text;
            asd.endTime = cmbOverlappingEndTime.Text;

            bool success = asd.updateOverlap(asd);
            if (success == true)
            {
                MessageBox.Show("Non overlapping session updated successfully.");
            }
            else if (success == false)
            {
                MessageBox.Show("Faild to update the non overlap session.");
            }

        }
        //overlap deleting


        private void btnOverlappingDelete_Click(object sender, EventArgs e)
        {
            asd.id = int.Parse(txtOverlappingSession.Text);

            bool success = asd.deleteoverlap(asd);
            if (success == true)
            {
                MessageBox.Show("Successfully delete the none overlapping session.");
            }
            else if (success == false)
            {
                MessageBox.Show("Faild to delete the none overlapping session.");
            }
            
        }

        

    }
}
