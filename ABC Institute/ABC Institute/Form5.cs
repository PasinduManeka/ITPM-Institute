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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        GroupClass c = new GroupClass();
        Session s = new Session();
       

        private void Form5_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);


            DataTable dt = s.select();
            dataGridView1.DataSource = dt;
        }

        //header check
        CheckBox HeaderCheckBox = new CheckBox();
        bool IsHeaderCheckBox = false;

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox.Size = new Size(15, 15);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }
        
        //header check click event
        private void HeaderCheckBoxClick(CheckBox HcheckBox)
        {
            IsHeaderCheckBox = true;
            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HcheckBox.Checked;
            }
            dataGridView1.RefreshEdit();
            IsHeaderCheckBox = false;
        }

        //mouseclick event 
        private void HeaderCheckBox_MouseClick(Object sender , MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveConsecutive_Click(object sender, EventArgs e)
        {
            //details get from selected check boxes.



        }
    }
}
