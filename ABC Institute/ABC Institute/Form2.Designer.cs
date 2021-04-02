
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboYearSemester2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericGNum2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboProgramme2 = new System.Windows.Forms.ComboBox();
            this.numericSGNum2 = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSGID = new System.Windows.Forms.TextBox();
            this.textGID2 = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericGNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSGNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Group Number";
            // 
            // comboYearSemester2
            // 
            this.comboYearSemester2.FormattingEnabled = true;
            this.comboYearSemester2.Items.AddRange(new object[] {
            "Y1 S1",
            "Y1 S2",
            "Y2 S1",
            "Y2 S2",
            "Y3 S1",
            "Y3 S2",
            "Y4 S1",
            "Y4 S2"});
            this.comboYearSemester2.Location = new System.Drawing.Point(302, 129);
            this.comboYearSemester2.Name = "comboYearSemester2";
            this.comboYearSemester2.Size = new System.Drawing.Size(165, 24);
            this.comboYearSemester2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Year and Semester";
            // 
            // numericGNum2
            // 
            this.numericGNum2.Location = new System.Drawing.Point(889, 129);
            this.numericGNum2.Name = "numericGNum2";
            this.numericGNum2.Size = new System.Drawing.Size(165, 22);
            this.numericGNum2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Update Student Groups";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sub Group Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Programme";
            // 
            // comboProgramme2
            // 
            this.comboProgramme2.FormattingEnabled = true;
            this.comboProgramme2.Items.AddRange(new object[] {
            "IT (WD)",
            "IT (WE)",
            "SE (WD)",
            "SE (WE)",
            "CS (WD)",
            "CS (WE)",
            "DS (WD)",
            "DS (WE)",
            "IM (WD)",
            "IM (WE)"});
            this.comboProgramme2.Location = new System.Drawing.Point(302, 186);
            this.comboProgramme2.Name = "comboProgramme2";
            this.comboProgramme2.Size = new System.Drawing.Size(165, 24);
            this.comboProgramme2.TabIndex = 16;
            // 
            // numericSGNum2
            // 
            this.numericSGNum2.Location = new System.Drawing.Point(889, 186);
            this.numericSGNum2.Name = "numericSGNum2";
            this.numericSGNum2.Size = new System.Drawing.Size(165, 22);
            this.numericSGNum2.TabIndex = 15;
            // 
            // buttonGenerate2
            // 
            this.buttonGenerate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGenerate2.Location = new System.Drawing.Point(936, 253);
            this.buttonGenerate2.Name = "buttonGenerate2";
            this.buttonGenerate2.Size = new System.Drawing.Size(141, 34);
            this.buttonGenerate2.TabIndex = 23;
            this.buttonGenerate2.Text = "Generate IDs";
            this.buttonGenerate2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Group ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sub Group ID";
            // 
            // textSGID
            // 
            this.textSGID.Location = new System.Drawing.Point(696, 259);
            this.textSGID.Name = "textSGID";
            this.textSGID.Size = new System.Drawing.Size(165, 22);
            this.textSGID.TabIndex = 20;
            // 
            // textGID2
            // 
            this.textGID2.Location = new System.Drawing.Point(280, 259);
            this.textGID2.Name = "textGID2";
            this.textGID2.Size = new System.Drawing.Size(165, 22);
            this.textGID2.TabIndex = 19;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(398, 70);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(189, 22);
            this.textSearch.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(597, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonSave2
            // 
            this.buttonSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave2.Location = new System.Drawing.Point(518, 326);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(179, 43);
            this.buttonSave2.TabIndex = 27;
            this.buttonSave2.Text = "Save";
            this.buttonSave2.UseVisualStyleBackColor = false;
            // 
            // buttonClear2
            // 
            this.buttonClear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear2.Location = new System.Drawing.Point(167, 326);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(165, 43);
            this.buttonClear2.TabIndex = 26;
            this.buttonClear2.Text = "Clear";
            this.buttonClear2.UseVisualStyleBackColor = false;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Red;
            this.buttonDel.Location = new System.Drawing.Point(851, 326);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(179, 43);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 197);
            this.dataGridView1.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonGenerate2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSGID);
            this.Controls.Add(this.textGID2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboProgramme2);
            this.Controls.Add(this.numericSGNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboYearSemester2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericGNum2);
            this.Name = "Form2";
            this.Text = "Student Groups";
            ((System.ComponentModel.ISupportInitialize)(this.numericGNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSGNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboYearSemester2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericGNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboProgramme2;
        private System.Windows.Forms.NumericUpDown numericSGNum2;
        private System.Windows.Forms.Button buttonGenerate2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSGID;
        private System.Windows.Forms.TextBox textGID2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}