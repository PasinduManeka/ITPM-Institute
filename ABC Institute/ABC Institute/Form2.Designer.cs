
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.numericUpGNumber2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboYearSemester2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textGID2 = new System.Windows.Forms.TextBox();
            this.comboProgrammer2 = new System.Windows.Forms.ComboBox();
            this.numericSGNumber2 = new System.Windows.Forms.NumericUpDown();
            this.textSGID2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGenerate2 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.buttonUpdate2 = new System.Windows.Forms.Button();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpGNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSGNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Student Groups";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(434, 64);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(184, 22);
            this.textSearch.TabIndex = 1;
            // 
            // numericUpGNumber2
            // 
            this.numericUpGNumber2.Location = new System.Drawing.Point(786, 110);
            this.numericUpGNumber2.Name = "numericUpGNumber2";
            this.numericUpGNumber2.Size = new System.Drawing.Size(184, 22);
            this.numericUpGNumber2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(649, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboYearSemester2.Location = new System.Drawing.Point(324, 153);
            this.comboYearSemester2.Name = "comboYearSemester2";
            this.comboYearSemester2.Size = new System.Drawing.Size(184, 24);
            this.comboYearSemester2.TabIndex = 4;
            this.comboYearSemester2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year and Semester";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textGID2
            // 
            this.textGID2.Location = new System.Drawing.Point(255, 256);
            this.textGID2.Name = "textGID2";
            this.textGID2.ReadOnly = true;
            this.textGID2.Size = new System.Drawing.Size(184, 22);
            this.textGID2.TabIndex = 6;
            this.textGID2.TextChanged += new System.EventHandler(this.textGID2_TextChanged);
            // 
            // comboProgrammer2
            // 
            this.comboProgrammer2.FormattingEnabled = true;
            this.comboProgrammer2.Items.AddRange(new object[] {
            "IT(WD)",
            "IT(WE)",
            "SE(WD)",
            "SE(WE)",
            "DS(WD)",
            "DS(WE)"});
            this.comboProgrammer2.Location = new System.Drawing.Point(324, 201);
            this.comboProgrammer2.Name = "comboProgrammer2";
            this.comboProgrammer2.Size = new System.Drawing.Size(184, 24);
            this.comboProgrammer2.TabIndex = 7;
            // 
            // numericSGNumber2
            // 
            this.numericSGNumber2.Location = new System.Drawing.Point(786, 158);
            this.numericSGNumber2.Name = "numericSGNumber2";
            this.numericSGNumber2.Size = new System.Drawing.Size(184, 22);
            this.numericSGNumber2.TabIndex = 8;
            // 
            // textSGID2
            // 
            this.textSGID2.Location = new System.Drawing.Point(697, 256);
            this.textSGID2.Name = "textSGID2";
            this.textSGID2.ReadOnly = true;
            this.textSGID2.Size = new System.Drawing.Size(184, 22);
            this.textSGID2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Group Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sub Group Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Programmer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Group ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sub Group ID";
            // 
            // buttonGenerate2
            // 
            this.buttonGenerate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGenerate2.Location = new System.Drawing.Point(950, 246);
            this.buttonGenerate2.Name = "buttonGenerate2";
            this.buttonGenerate2.Size = new System.Drawing.Size(108, 39);
            this.buttonGenerate2.TabIndex = 15;
            this.buttonGenerate2.Text = "Geneate IDs";
            this.buttonGenerate2.UseVisualStyleBackColor = false;
            this.buttonGenerate2.Click += new System.EventHandler(this.buttonGenerate2_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear2.Location = new System.Drawing.Point(167, 299);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(138, 39);
            this.buttonClear2.TabIndex = 16;
            this.buttonClear2.Text = "Clear ";
            this.buttonClear2.UseVisualStyleBackColor = false;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
            // 
            // buttonUpdate2
            // 
            this.buttonUpdate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUpdate2.Location = new System.Drawing.Point(542, 299);
            this.buttonUpdate2.Name = "buttonUpdate2";
            this.buttonUpdate2.Size = new System.Drawing.Size(138, 39);
            this.buttonUpdate2.TabIndex = 17;
            this.buttonUpdate2.Text = "Update";
            this.buttonUpdate2.UseVisualStyleBackColor = false;
            this.buttonUpdate2.Click += new System.EventHandler(this.buttonUpdate2_Click);
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.BackColor = System.Drawing.Color.Red;
            this.buttonDelete2.Location = new System.Drawing.Point(871, 299);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(138, 39);
            this.buttonDelete2.TabIndex = 18;
            this.buttonDelete2.Text = "Delete";
            this.buttonDelete2.UseVisualStyleBackColor = false;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(49, 344);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(1049, 269);
            this.dataGridViewGroups.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(324, 109);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(184, 22);
            this.textID.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 625);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewGroups);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.buttonUpdate2);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.buttonGenerate2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSGID2);
            this.Controls.Add(this.numericSGNumber2);
            this.Controls.Add(this.comboProgrammer2);
            this.Controls.Add(this.textGID2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboYearSemester2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpGNumber2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Student Groups";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpGNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSGNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.NumericUpDown numericUpGNumber2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboYearSemester2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGID2;
        private System.Windows.Forms.ComboBox comboProgrammer2;
        private System.Windows.Forms.NumericUpDown numericSGNumber2;
        private System.Windows.Forms.TextBox textSGID2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGenerate2;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Button buttonUpdate2;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textID;
    }
}