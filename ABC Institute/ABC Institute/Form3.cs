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

        Tags tg = new Tags();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            tg.subjectName = textSubjectName.Text;
            tg.subjectCode = textSubjectCode.Text;
            tg.tagCode = textTagCode.Text;
            tg.rTag = comboRTag.Text;

            bool success = tg.Insert(tg);

            if (success == true)
            {
                if(MessageBox.Show("Do You want to move \'Manage Tags\'?", "Tag is ceated...", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                else
                {

                }
                //MessageBox.Show("Tag is created.....");
            }
            else
            {
                MessageBox.Show("Tag has not created. Try again..........");
            }
        }

        private void buttonClear3_Click(object sender, EventArgs e)
        {
            textSubjectName.Text = string.Empty;
            textSubjectCode.Text = string.Empty;
            textTagCode.Text = string.Empty;
            comboRTag.Text = string.Empty;
        }
    }
}
