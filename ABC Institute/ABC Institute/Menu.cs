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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void addGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentGroups ad = new AddStudentGroups();
            ad.Show();
        }

        private void mAnageGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentGroups ms = new ManageStudentGroups();
            ms.Show();
        }

        private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLecturers al = new AddLecturers();
            al.Show();
        }

        private void manageLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLecturers ml = new ManageLecturers();
            ml.Show();
        }

        private void addSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjects ad = new AddSubjects();
            ad.Show();
        }

        private void manageSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSubjects ms = new ManageSubjects();
            ms.Show();
        }

        private void addTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTags at = new AddTags();
            at.Show();
        }

        private void manageTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTags mt = new ManageTags();
            mt.Show();
        }

        private void roomTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MR_Tag mt = new MR_Tag();
            mt.Show();
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation al = new AddLocation();
            al.Show();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocations ml = new ManageLocations();
            ml.Show();
        }

        private void addSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSession ad = new AddSession();
            ad.Show();
        }

        private void manageSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSession ma = new ManageSession();
            ma.Show();
        }

        private void advancedSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SANA sa = new SANA();
            sa.Show();
        }

        private void addWorkingDayAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
