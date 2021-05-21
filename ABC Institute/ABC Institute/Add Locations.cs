using ABC_Institute.Classes;
using System;
using System.Windows.Forms;

namespace ABC_Institute
{
    public partial class AddLocation : Form
    { 
        string RoomType;

        public AddLocation()
        {
            InitializeComponent();
        }

        SQL c = new SQL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Lecture Hall";
        }

        private void radioButtonLabRoomType_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Laboratory";
        }

        private void textBoxRoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.BName = textBoxBuildingName.Text;
            c.RName = textBoxRoomName.Text;
            c.RType = RoomType;
            c.Capacity = textBoxCapacity.Text;
           

            //inserting data into db using SQL class file
            bool success = c.Insert(c);
            if(success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Location Added.");

                //clear if success
                Clear();

            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add new Location. Try Again");
            }      

        }

        private void AddLocation_Load(object sender, EventArgs e)
        {
            //make the panel2(manage rooms submenu)hidden
            panel2.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //to clear fields
        public void Clear()
        {
            textBoxBuildingName.Text = "";
            textBoxRoomName.Text = "";
            radioButtonLecRoomType.Checked = false;
            radioButtonLabRoomType.Checked = false;
            textBoxCapacity.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statics s = new Statics();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageLocations ml = new ManageLocations();
            ml.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button4SubMR_Click(object sender, EventArgs e)
        {
            MR_Subject sub = new MR_Subject();
            sub.Show();
        }

        private void button5TagMR_Click(object sender, EventArgs e)
        {
            MR_Tag tag = new MR_Tag();
            tag.Show();
        }

        private void button6LecMR_Click(object sender, EventArgs e)
        {
            MR_Lecturer lec = new MR_Lecturer();
            lec.Show();
        }

        private void button7grpMR_Click(object sender, EventArgs e)
        {
            MR_Group grp = new MR_Group();
            grp.Show();
        }

        private void button8sessMR_Click(object sender, EventArgs e)
        {
            MR_Consecutive_Sessions cs = new MR_Consecutive_Sessions();
            cs.Show();
        }

        private void button9TnSubMR_Click(object sender, EventArgs e)
        {
            T_and_Sub ts = new T_and_Sub();
            ts.Show();
        }
    }
}
