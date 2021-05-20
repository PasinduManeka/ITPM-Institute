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

        private void Form5_Load(object sender, EventArgs e)
        {
            //DataTable dt = c.Select();
            //dataGridView1.DataSource = dt;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
