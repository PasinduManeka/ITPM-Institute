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
    public partial class SANA : Form
    {
        public SANA()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void SANA_Load(object sender, EventArgs e)
        {
            //cmbConsectuiveBox1.SelectedText = "null";

            //set default values in combo voxes Consecutive 
            cmbConsectuiveBox1.SelectedText = " -- Select -- ";
            cmbConsectuiveBox2.SelectedText = " -- Select -- ";

            //set default values in combo voxes non overlapping
            cmbOverlappingDay.SelectedText = " -- Select -- ";
            cmbOverlappingDuration.SelectedText = "-- Select --";
            cmbOverlappingDay.SelectedText = "-- Select --";
            cmbOverlappingStartDate.SelectedText = "-- Select --";
            cmbOverlappingEndTime.SelectedText = "-- Select --";

            //set default values in combo voxes parallel
            cmbParallelSession1.SelectedText = "-- Select --";
            cmbParallelSession2.SelectedText = "-- Select --";
            cmbParallelDuration.SelectedText = "-- Select --";
            cmbParallelDay.SelectedText = "-- Select --";
            cmbParallelStartTime.SelectedText = "-- Select --";
            cmbParallelEndTime.SelectedText = "-- Select --";

        }
    }
}
