
namespace ABC_Institute
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Consective = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.comboBoxYS = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSubgroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSesID = new System.Windows.Forms.ComboBox();
            this.comboBoxdates = new System.Windows.Forms.ComboBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonLAdd = new System.Windows.Forms.Button();
            this.buttonLupdate = new System.Windows.Forms.Button();
            this.buttonLDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewL = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Consective);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(18, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // Consective
            // 
            this.Consective.Location = new System.Drawing.Point(4, 25);
            this.Consective.Name = "Consective";
            this.Consective.Padding = new System.Windows.Forms.Padding(3);
            this.Consective.Size = new System.Drawing.Size(1268, 582);
            this.Consective.TabIndex = 0;
            this.Consective.Text = "Consective";
            this.Consective.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1268, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1268, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Non Overlapping";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.dataGridViewL);
            this.tabPage4.Controls.Add(this.buttonClear);
            this.tabPage4.Controls.Add(this.buttonLDelete);
            this.tabPage4.Controls.Add(this.buttonLupdate);
            this.tabPage4.Controls.Add(this.buttonLAdd);
            this.tabPage4.Controls.Add(this.textBoxTime);
            this.tabPage4.Controls.Add(this.comboBoxdates);
            this.tabPage4.Controls.Add(this.comboBoxSesID);
            this.tabPage4.Controls.Add(this.comboBoxSubgroup);
            this.tabPage4.Controls.Add(this.comboBoxGroup);
            this.tabPage4.Controls.Add(this.comboBoxYS);
            this.tabPage4.Controls.Add(this.comboBoxLecturer);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBoxLID);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1268, 582);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Not Available Time";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Lecturer";
            // 
            // textBoxLID
            // 
            this.textBoxLID.Location = new System.Drawing.Point(81, 35);
            this.textBoxLID.Name = "textBoxLID";
            this.textBoxLID.ReadOnly = true;
            this.textBoxLID.Size = new System.Drawing.Size(64, 22);
            this.textBoxLID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Sub-Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Session ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Select Year and Sem";
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Items.AddRange(new object[] {
            "Herath P.M",
            "Udagedara P.Y",
            "Deshan B.G.S",
            "Nonis S.L.M",
            "Jayashanki T.R.C",
            "Kumari T.N",
            "Jayasooriya S.H.A"});
            this.comboBoxLecturer.Location = new System.Drawing.Point(257, 76);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(201, 28);
            this.comboBoxLecturer.TabIndex = 9;
            // 
            // comboBoxYS
            // 
            this.comboBoxYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYS.FormattingEnabled = true;
            this.comboBoxYS.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.comboBoxYS.Location = new System.Drawing.Point(257, 134);
            this.comboBoxYS.Name = "comboBoxYS";
            this.comboBoxYS.Size = new System.Drawing.Size(201, 28);
            this.comboBoxYS.TabIndex = 10;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxGroup.Location = new System.Drawing.Point(257, 190);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(201, 28);
            this.comboBoxGroup.TabIndex = 11;
            // 
            // comboBoxSubgroup
            // 
            this.comboBoxSubgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubgroup.FormattingEnabled = true;
            this.comboBoxSubgroup.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "2.1",
            "2.2",
            "3.1",
            "3.2",
            "4.1",
            "4.2",
            "5.1",
            "5.2"});
            this.comboBoxSubgroup.Location = new System.Drawing.Point(257, 242);
            this.comboBoxSubgroup.Name = "comboBoxSubgroup";
            this.comboBoxSubgroup.Size = new System.Drawing.Size(201, 28);
            this.comboBoxSubgroup.TabIndex = 12;
            // 
            // comboBoxSesID
            // 
            this.comboBoxSesID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSesID.FormattingEnabled = true;
            this.comboBoxSesID.Items.AddRange(new object[] {
            "S01",
            "S02",
            "S03",
            "S04",
            "S05",
            "S06",
            "S06"});
            this.comboBoxSesID.Location = new System.Drawing.Point(257, 292);
            this.comboBoxSesID.Name = "comboBoxSesID";
            this.comboBoxSesID.Size = new System.Drawing.Size(201, 28);
            this.comboBoxSesID.TabIndex = 13;
            // 
            // comboBoxdates
            // 
            this.comboBoxdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxdates.FormattingEnabled = true;
            this.comboBoxdates.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxdates.Location = new System.Drawing.Point(257, 391);
            this.comboBoxdates.Name = "comboBoxdates";
            this.comboBoxdates.Size = new System.Drawing.Size(201, 28);
            this.comboBoxdates.TabIndex = 14;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(257, 344);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(201, 26);
            this.textBoxTime.TabIndex = 15;
            // 
            // buttonLAdd
            // 
            this.buttonLAdd.BackColor = System.Drawing.Color.Red;
            this.buttonLAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLAdd.Location = new System.Drawing.Point(41, 485);
            this.buttonLAdd.Name = "buttonLAdd";
            this.buttonLAdd.Size = new System.Drawing.Size(83, 47);
            this.buttonLAdd.TabIndex = 16;
            this.buttonLAdd.Text = "Add";
            this.buttonLAdd.UseVisualStyleBackColor = false;
            this.buttonLAdd.Click += new System.EventHandler(this.buttonLAdd_Click);
            // 
            // buttonLupdate
            // 
            this.buttonLupdate.Location = new System.Drawing.Point(208, 485);
            this.buttonLupdate.Name = "buttonLupdate";
            this.buttonLupdate.Size = new System.Drawing.Size(83, 47);
            this.buttonLupdate.TabIndex = 17;
            this.buttonLupdate.Text = "Update";
            this.buttonLupdate.UseVisualStyleBackColor = true;
            this.buttonLupdate.Click += new System.EventHandler(this.buttonLupdate_Click);
            // 
            // buttonLDelete
            // 
            this.buttonLDelete.BackColor = System.Drawing.Color.Red;
            this.buttonLDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLDelete.Location = new System.Drawing.Point(375, 485);
            this.buttonLDelete.Name = "buttonLDelete";
            this.buttonLDelete.Size = new System.Drawing.Size(83, 47);
            this.buttonLDelete.TabIndex = 18;
            this.buttonLDelete.Text = "Delete";
            this.buttonLDelete.UseVisualStyleBackColor = false;
            this.buttonLDelete.Click += new System.EventHandler(this.buttonLDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(542, 485);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 47);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewL
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewL.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewL.Location = new System.Drawing.Point(665, 76);
            this.dataGridViewL.Name = "dataGridViewL";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewL.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewL.RowHeadersWidth = 51;
            this.dataGridViewL.RowTemplate.Height = 24;
            this.dataGridViewL.Size = new System.Drawing.Size(586, 456);
            this.dataGridViewL.TabIndex = 20;
            this.dataGridViewL.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewL_RowHeaderMouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 637);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Consective;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewL;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLDelete;
        private System.Windows.Forms.Button buttonLupdate;
        private System.Windows.Forms.Button buttonLAdd;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.ComboBox comboBoxdates;
        private System.Windows.Forms.ComboBox comboBoxSesID;
        private System.Windows.Forms.ComboBox comboBoxSubgroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxYS;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}