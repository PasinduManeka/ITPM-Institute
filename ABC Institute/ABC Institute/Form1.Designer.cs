
namespace ABC_Institute
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textGID = new System.Windows.Forms.TextBox();
            this.textSGID = new System.Windows.Forms.TextBox();
            this.numericGNum = new System.Windows.Forms.NumericUpDown();
            this.numericSGNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboYearSemester = new System.Windows.Forms.ComboBox();
            this.comboProgramme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericGNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSGNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student Groups";
            // 
            // textGID
            // 
            this.textGID.Location = new System.Drawing.Point(290, 228);
            this.textGID.Name = "textGID";
            this.textGID.Size = new System.Drawing.Size(165, 22);
            this.textGID.TabIndex = 1;
            // 
            // textSGID
            // 
            this.textSGID.Location = new System.Drawing.Point(706, 228);
            this.textSGID.Name = "textSGID";
            this.textSGID.Size = new System.Drawing.Size(165, 22);
            this.textSGID.TabIndex = 2;
            // 
            // numericGNum
            // 
            this.numericGNum.Location = new System.Drawing.Point(905, 71);
            this.numericGNum.Name = "numericGNum";
            this.numericGNum.Size = new System.Drawing.Size(165, 22);
            this.numericGNum.TabIndex = 3;
            // 
            // numericSGNum
            // 
            this.numericSGNum.Location = new System.Drawing.Point(905, 136);
            this.numericSGNum.Name = "numericSGNum";
            this.numericSGNum.Size = new System.Drawing.Size(165, 22);
            this.numericSGNum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year and Semester";
            // 
            // comboYearSemester
            // 
            this.comboYearSemester.FormattingEnabled = true;
            this.comboYearSemester.Items.AddRange(new object[] {
            "Y1 S1",
            "Y1 S2",
            "Y2 S1",
            "Y2 S2",
            "Y3 S1",
            "Y3 S2",
            "Y4 S1",
            "Y4 S2"});
            this.comboYearSemester.Location = new System.Drawing.Point(318, 71);
            this.comboYearSemester.Name = "comboYearSemester";
            this.comboYearSemester.Size = new System.Drawing.Size(165, 24);
            this.comboYearSemester.TabIndex = 7;
            // 
            // comboProgramme
            // 
            this.comboProgramme.FormattingEnabled = true;
            this.comboProgramme.Items.AddRange(new object[] {
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
            this.comboProgramme.Location = new System.Drawing.Point(318, 136);
            this.comboProgramme.Name = "comboProgramme";
            this.comboProgramme.Size = new System.Drawing.Size(165, 24);
            this.comboProgramme.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Group Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Programme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sub Group Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sub Group ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Group ID";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear.Location = new System.Drawing.Point(284, 317);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(165, 43);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGenerate.Location = new System.Drawing.Point(946, 222);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(141, 34);
            this.buttonGenerate.TabIndex = 17;
            this.buttonGenerate.Text = "Generate IDs";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(635, 317);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(179, 43);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 472);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProgramme);
            this.Controls.Add(this.comboYearSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericSGNum);
            this.Controls.Add(this.numericGNum);
            this.Controls.Add(this.textSGID);
            this.Controls.Add(this.textGID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Groups";
            ((System.ComponentModel.ISupportInitialize)(this.numericGNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSGNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGID;
        private System.Windows.Forms.TextBox textSGID;
        private System.Windows.Forms.NumericUpDown numericGNum;
        private System.Windows.Forms.NumericUpDown numericSGNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboYearSemester;
        private System.Windows.Forms.ComboBox comboProgramme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSave;
    }
}

