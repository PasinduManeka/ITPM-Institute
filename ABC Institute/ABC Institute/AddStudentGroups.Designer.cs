
namespace ABC_Institute
{
    partial class AddStudentGroups
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
            this.buttonGID = new System.Windows.Forms.Button();
            this.textGID = new System.Windows.Forms.TextBox();
            this.numericBatchNumber = new System.Windows.Forms.NumericUpDown();
            this.comboYearSemester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProgramme = new System.Windows.Forms.ComboBox();
            this.numericGroupNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSGID = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericBatchNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGroupNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGID
            // 
            this.buttonGID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGID.Location = new System.Drawing.Point(842, 239);
            this.buttonGID.Name = "buttonGID";
            this.buttonGID.Size = new System.Drawing.Size(140, 65);
            this.buttonGID.TabIndex = 0;
            this.buttonGID.Text = "Generate IDs";
            this.buttonGID.UseVisualStyleBackColor = false;
            this.buttonGID.Click += new System.EventHandler(this.buttonGID_Click);
            // 
            // textGID
            // 
            this.textGID.Location = new System.Drawing.Point(210, 249);
            this.textGID.Name = "textGID";
            this.textGID.ReadOnly = true;
            this.textGID.Size = new System.Drawing.Size(182, 22);
            this.textGID.TabIndex = 1;
            this.textGID.TextChanged += new System.EventHandler(this.textGID_TextChanged);
            // 
            // numericBatchNumber
            // 
            this.numericBatchNumber.Location = new System.Drawing.Point(740, 129);
            this.numericBatchNumber.Name = "numericBatchNumber";
            this.numericBatchNumber.Size = new System.Drawing.Size(182, 22);
            this.numericBatchNumber.TabIndex = 2;
            this.numericBatchNumber.ValueChanged += new System.EventHandler(this.numericBatchNumber_ValueChanged);
            // 
            // comboYearSemester
            // 
            this.comboYearSemester.FormattingEnabled = true;
            this.comboYearSemester.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.comboYearSemester.Location = new System.Drawing.Point(308, 127);
            this.comboYearSemester.Name = "comboYearSemester";
            this.comboYearSemester.Size = new System.Drawing.Size(182, 24);
            this.comboYearSemester.TabIndex = 3;
            this.comboYearSemester.SelectedIndexChanged += new System.EventHandler(this.comboYearSemester_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Student Groups";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year and  Semster";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboProgramme
            // 
            this.comboProgramme.FormattingEnabled = true;
            this.comboProgramme.Items.AddRange(new object[] {
            "IT(WD)",
            "IT(WE)",
            "SE(WD)",
            "SE(WE)",
            "DS(WD)",
            "DS(WD)"});
            this.comboProgramme.Location = new System.Drawing.Point(308, 184);
            this.comboProgramme.Name = "comboProgramme";
            this.comboProgramme.Size = new System.Drawing.Size(182, 24);
            this.comboProgramme.TabIndex = 6;
            this.comboProgramme.SelectedIndexChanged += new System.EventHandler(this.comboProgramme_SelectedIndexChanged);
            // 
            // numericGroupNumber
            // 
            this.numericGroupNumber.Location = new System.Drawing.Point(740, 184);
            this.numericGroupNumber.Name = "numericGroupNumber";
            this.numericGroupNumber.Size = new System.Drawing.Size(182, 22);
            this.numericGroupNumber.TabIndex = 7;
            this.numericGroupNumber.ValueChanged += new System.EventHandler(this.numericGroupNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Programme";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(566, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Batch Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Group ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sub Group ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textSGID
            // 
            this.textSGID.Location = new System.Drawing.Point(614, 249);
            this.textSGID.Name = "textSGID";
            this.textSGID.ReadOnly = true;
            this.textSGID.Size = new System.Drawing.Size(182, 22);
            this.textSGID.TabIndex = 12;
            this.textSGID.TextChanged += new System.EventHandler(this.textSGID_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear.Location = new System.Drawing.Point(266, 337);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(144, 65);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(580, 337);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(144, 65);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddStudentGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 430);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSGID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericGroupNumber);
            this.Controls.Add(this.comboProgramme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYearSemester);
            this.Controls.Add(this.numericBatchNumber);
            this.Controls.Add(this.textGID);
            this.Controls.Add(this.buttonGID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Groups";
            this.Load += new System.EventHandler(this.AddStudentGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBatchNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGroupNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGID;
        private System.Windows.Forms.TextBox textGID;
        private System.Windows.Forms.NumericUpDown numericBatchNumber;
        private System.Windows.Forms.ComboBox comboYearSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProgramme;
        private System.Windows.Forms.NumericUpDown numericGroupNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSGID;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}

