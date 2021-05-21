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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Lecturer2 l = new Lecturer2();

        private void buttonLAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input feilds
            l.lecturer = comboBoxLecturer.Text;
            l.YearSem = comboBoxYS.Text;
            l.LGroup = comboBoxGroup.Text;
            l.subGroup = comboBoxSubgroup.Text;
            l.session = comboBoxSesID.Text;
            l.LeTime = textBoxTime.Text;
            l.LeDay = comboBoxdates.Text;

            //inserting Data into Databse using the method we creted in pervious episode
            bool success = l.Insert(l);
            if (success == true)
            {
                //successfully Inserted
                MessageBox.Show("Data is added successfully");
                //call the clear method here
                Clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add data. Please try again.....");
            }
            //Load Data on DataGridVeiw
            DataTable dt = l.Select();
            dataGridViewL.DataSource = dt;
            


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        //Method to clear feilds 
        public void Clear()
        {
            comboBoxLecturer.Text = "";
            comboBoxYS.Text = "";
            comboBoxGroup.Text = "";
            comboBoxSubgroup.Text = "";
            comboBoxSesID.Text = "";
            textBoxTime.Text = "";
            comboBoxdates.Text = "";
        }

        private void buttonLupdate_Click(object sender, EventArgs e)
        {
            //Get the Data from textboxes
            l.LecID = int.Parse(textBoxLID.Text);
            l.lecturer = comboBoxLecturer.Text;
            l.YearSem = comboBoxYS.Text;
            l.LGroup = comboBoxGroup.Text;
            l.subGroup = comboBoxSubgroup.Text;
            l.session = comboBoxSesID.Text;
            l.LeTime = textBoxTime.Text;
            l.LeDay = comboBoxdates.Text;

            //Update data in Database
            bool success = l.Update(l);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Data Updated Successfully");

                //Load Data on DataGridVeiw
                DataTable dt = l.Select();
                dataGridViewL.DataSource = dt;

                //Call the clear method
                Clear();
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to update Try again....");
            }
        }

        private void dataGridViewL_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from Data Grid view and load  it to the textboxes respectively
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;

            textBoxLID.Text = dataGridViewL.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxLecturer.Text = dataGridViewL.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxYS.Text = dataGridViewL.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxGroup.Text = dataGridViewL.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxSubgroup.Text = dataGridViewL.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxSesID.Text = dataGridViewL.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxTime.Text = dataGridViewL.Rows[rowIndex].Cells[6].Value.ToString();
            comboBoxdates.Text = dataGridViewL.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Call clear method here
            Clear();
        }

        private void buttonLDelete_Click(object sender, EventArgs e)
        {
            //Get  Data from the textboxes
            l.LecID = int.Parse(textBoxLID.Text);

            bool success = l.Delete(l);
            if (success == true)
            {
                //Deleted Successfully
                MessageBox.Show("The Data deleted successfully");

                //Load Data on DataGridVeiw
                DataTable dt = l.Select();
                dataGridViewL.DataSource = dt;
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to delete data Try Again...");            
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Load Data on DataGridVeiw
            DataTable dt = l.Select();
            dataGridViewL.DataSource = dt;
        }
    }
}
