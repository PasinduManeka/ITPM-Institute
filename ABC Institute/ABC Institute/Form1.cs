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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GroupClass c = new GroupClass();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Get the values from input fields
            c.yearSemester = comboYearSemester.Text;
            c.programme = comboProgramme.Text;
            c.groupNumber = Convert.ToInt32(numericBatchNumber.Value);
            c.subgroupNumber = Convert.ToInt32(numericGroupNumber.DecimalPlaces);

            c.groupID = c.yearSemester + c.programme + c.groupNumber;
            c.subGroupID = c.groupID + c.subgroupNumber;


            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Group Successfully Created.");
            }
            else
            {
                MessageBox.Show("Faild to create new group. ");
            }


        }
    }
}
