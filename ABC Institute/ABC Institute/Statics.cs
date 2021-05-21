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
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }
        SQL c = new SQL();
        private void Statics_Load(object sender, EventArgs e)
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
                chartStat.Series["Lecture Hall"].Points.AddXY("Location", lec);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
