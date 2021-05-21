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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        location m = new location();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input feilds
            m.Room = comboBoxRoom.Text;
            m.Day = comboBoxDay.Text;
            m.Time = textBoxTime.Text;

            //inserting Data into Databse using the method we creted in pervious episode
            bool success = m.Insert(m);
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
            DataTable dt = m.Select();
            dataGridView3.DataSource = dt;
        }

        //Method to clear feilds 
        public void Clear()
        {
            comboBoxRoom.Text = "";
            comboBoxDay.Text = "";
            textBoxTime.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Load Data on DataGridVeiw
            DataTable dt = m.Select();
            dataGridView3.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the Data from textboxes
            m.ID = int.Parse(textBoxNID.Text);
            m.Room = comboBoxRoom.Text;
            m.Day = comboBoxDay.Text;
            m.Time = textBoxTime.Text;

            //Update Data in Databse
            bool success = m.Update(m);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Data Updated Successfully");

                //Load Data on DataGridVeiw
                DataTable dt = m.Select();
                dataGridView3.DataSource = dt;

                //Call the clear method
                Clear();
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to update Try again....");  
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from Data Grid view and load  it to the textboxes respectively
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;

            textBoxNID.Text = dataGridView3.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxRoom.Text = dataGridView3.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxDay.Text = dataGridView3.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxTime.Text = dataGridView3.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get  Data from the textboxes
            m.ID = int.Parse(textBoxNID.Text);

            bool success = m.Delete(m);
            if (success == true)
            {
                //Deleted Successfully
                MessageBox.Show("The Data deleted successfully");

                //Load Data on DataGridVeiw
                DataTable dt = m.Select();
                dataGridView3.DataSource = dt;
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to delete data Try Again...");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Call clear method here
            Clear();
        }
    }
}
