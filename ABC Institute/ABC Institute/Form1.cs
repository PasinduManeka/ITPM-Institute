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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        adding a =new adding();

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            //Get the values from the input feilds
            a.noOfWorking = comboBoxNumberWorking.Text;
            a.workingdays = textBoxDays.Text;
            a.hours = comboBoxhrs.Text;
            a.minutes = comboBoxminutes.Text;

            //inserting Data into Databse using the method we creted in pervious episode
            bool success = a.Insert(a);
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
            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Data on DataGridVeiw
            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        //Method to clear feilds 
        public void Clear()
        {
            comboBoxNumberWorking.Text = "";
            textBoxDays.Text = "";
            comboBoxhrs.Text = "";
            comboBoxminutes.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the Data from textboxes
            a.ID = int.Parse(textBoxAddingID.Text);
            a.noOfWorking = comboBoxNumberWorking.Text;
            a.workingdays = textBoxDays.Text;
            a.hours = comboBoxhrs.Text;
            a.minutes = comboBoxminutes.Text;

            //Update data in Database
            bool success = a.Update(a);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Data Updated Successfully");

                //Load Data on DataGridVeiw
                DataTable dt = a.Select();
                dataGridView1.DataSource = dt;

                //Call the clear method
                Clear();
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to update Try again....");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from Data Grid view and load  it to the textboxes respectively
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            textBoxAddingID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxNumberWorking.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxDays.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxhrs.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxminutes.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            //Call clear method here
            Clear();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            //Get Data From the textboxes
            a.ID = int.Parse(textBoxAddingID.Text);

            bool success = a.Delete(a);
            if (success == true)
            {
                //Deleted Successfully
                MessageBox.Show("The data Deleted Successfully");

                //Load Data on DataGridVeiw
                DataTable dt = a.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete Try again.....");
            }
        }
    }
}
