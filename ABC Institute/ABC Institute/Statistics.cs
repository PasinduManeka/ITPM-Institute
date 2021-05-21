using ITPM_Location.LocationClasses;
using System;
using System.Windows.Forms;

namespace ITPM_Location
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        SQL c = new SQL();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartStat_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            //inserting data in to separate tables
            bool successLab = c.InsertToLabTable(c);
            bool successLec = c.InsertToLecTable(c);
            if (successLab == true || successLec == true)
            {
                MessageBox.Show("Statistics Updated Successfully..");
            }
            else
            {
                MessageBox.Show("Failed To Update..");
            }

            //for the chart
            int lab = c.LabForChart();
            int lec = c.LecHallForChart();
            int rows = c.GetNoOfRows();         

            if (rows >= 1)
            {                
                chartStat.Series["Lecture Hall"].Points.AddXY("Location",lec);

                chartStat.Series["Laboratory"].Points.AddXY("Location", lab);
            }
            else
            {
                MessageBox.Show("Empty");
            }

            //for registered rooms
            richTextBoxStat_rRooms.Text = Convert.ToString(rows);

            //for latest lecturer
            textBoxLecturerBoxStat.Text = Convert.ToString(c.LatestLecturer());

            //for the latest group
            textBoxLatestGroupBoxStat.Text = Convert.ToString(c.LatestGroup());

            //for latest subject
            textBoxSubjectBoxStat.Text = Convert.ToString(c.LatestSubject());

            //for the number of Subjects
            richTextBoxStat_rSubjects.Text = Convert.ToString(c.NumOfSubjects());

            //for the number of Subjects
            richTextBoxStat_rLecturers.Text = Convert.ToString(c.NumOfLecturers());

            //for the number of student groups
            richTextBoxStat_rStudents.Text = Convert.ToString(c.NumOfStudentGroups());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxStat_rRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxStat_rSubjects_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
