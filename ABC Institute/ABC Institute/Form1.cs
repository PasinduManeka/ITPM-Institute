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
            c.subgroupNumber = Convert.ToInt32(numericGroupNumber.Value);

            c.groupID = textGID.Text;
            c.subGroupID = textSGID.Text;


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

        private void buttonGID_Click(object sender, EventArgs e)
        {
            string yearsemester = comboYearSemester.Text;
            string programme = comboProgramme.Text;
            int groupNumber = Convert.ToInt32(numericBatchNumber.Value);
            int subgroubNumber = Convert.ToInt32(numericGroupNumber.Value);


            textGID.Text = yearsemester + programme + groupNumber;
            textSGID .Text = yearsemester +"."+ programme + groupNumber +"."+ subgroubNumber;


            



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboYearSemester.Text = string.Empty;
            comboProgramme.Text = string.Empty;
            numericBatchNumber.Value = 0;
            numericGroupNumber.Value = 0;
            textGID.Text = string.Empty;
            textSGID.Text = string.Empty;

        }
    }
}
