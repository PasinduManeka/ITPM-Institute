using ABC_Institute.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class ManageLocations : Form
    {

        string RoomType;
        
        public ManageLocations()
        {
            InitializeComponent();
        }

        SQL c = new SQL();

        private void ManageLocations_Load(object sender, EventArgs e)
        {
            //load data on dataGridView
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Lecture Hall";
        }
        private void ML_RoomType_lab_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Laboratory";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //load data on dataGridView
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }

        private void buttonMLupdate_Click(object sender, EventArgs e)
        {
            //Get the data from textboxes
            c.ID = int.Parse(textBoxID_ML.Text);
            c.BName = textBoxBuildingNameML.Text;
            c.RName = textBoxRoomNameML.Text;
            c.RType = RoomType;
            c.Capacity = textBoxCapacityML.Text;

            //update data in database
            bool success = c.Update(c);
            if(success == true)
            {
                //updated successfully
                MessageBox.Show("Details Updated Successfully");

                //Refresh data on dataGridView
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;

                //Call clear method
                Clear();
            }
            else
            {
                //failed update
                MessageBox.Show("Failed to update details. Try Again");
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Load the data to the fields from gridView
            //identify the row which mouse is clicked
            int rowIndex = e.RowIndex;
            textBoxID_ML.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxBuildingNameML.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxRoomNameML.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            if(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString()== "Lecture Hall")
            {
                ML_RoomType_LecHall.Checked=true;
            }
            else if(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString() == "Laboratory")
            {
                ML_RoomType_lab.Checked = true;
            }
            else
            {
                ML_RoomType_LecHall.Checked = false;
                ML_RoomType_lab.Checked = false;
            }
            textBoxCapacityML.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }

        public void Clear()
        {
            textBoxBuildingNameML.Text = "";
            textBoxRoomNameML.Text = "";
            ML_RoomType_LecHall.Checked = false;
            ML_RoomType_lab.Checked = false;
            textBoxCapacityML.Text = "";
        }

        private void buttonMLclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonMLdelete_Click(object sender, EventArgs e)
        {
            //Get data from the dataGridView
            c.ID = Convert.ToInt32(textBoxID_ML.Text);
            bool success = c.Delete(c);
            if(success == true)
            {
                //Successfully deleted
                MessageBox.Show("Location Deleted Successfully");

                //Refresh data on dataGridView
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;

                //Call clear method
                Clear();

            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Location. Try Again");
            }
        }

        private void textBoxID_ML_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchML_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //search function
        private void searchML_TextChanged_1(object sender, EventArgs e)
        {
            searchML.ForeColor = Color.Black;
            string myconnstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            string sql = "SELECT * FROM Add_Location where RoomName LIKE '" + searchML.Text + "%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void searchML_MouseClick_1(object sender, MouseEventArgs e)
        {
            searchML.Text = "";
        }
    }
}
