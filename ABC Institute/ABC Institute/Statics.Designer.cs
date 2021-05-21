
namespace ABC_Institute
{
    partial class Statics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.richTextBoxStat_rLecturers = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStat_rStudents = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStat_rSubjects = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStat_rRooms = new System.Windows.Forms.RichTextBox();
            this.chartStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxLecturerBoxStat = new System.Windows.Forms.TextBox();
            this.textBoxLatestGroupBoxStat = new System.Windows.Forms.TextBox();
            this.textBoxSubjectBoxStat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxStat_rLecturers
            // 
            this.richTextBoxStat_rLecturers.BackColor = System.Drawing.Color.White;
            this.richTextBoxStat_rLecturers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStat_rLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.richTextBoxStat_rLecturers.Location = new System.Drawing.Point(110, 124);
            this.richTextBoxStat_rLecturers.Name = "richTextBoxStat_rLecturers";
            this.richTextBoxStat_rLecturers.ReadOnly = true;
            this.richTextBoxStat_rLecturers.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rLecturers.TabIndex = 0;
            this.richTextBoxStat_rLecturers.Text = "";
            // 
            // richTextBoxStat_rStudents
            // 
            this.richTextBoxStat_rStudents.BackColor = System.Drawing.Color.White;
            this.richTextBoxStat_rStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStat_rStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.richTextBoxStat_rStudents.Location = new System.Drawing.Point(413, 124);
            this.richTextBoxStat_rStudents.Name = "richTextBoxStat_rStudents";
            this.richTextBoxStat_rStudents.ReadOnly = true;
            this.richTextBoxStat_rStudents.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rStudents.TabIndex = 1;
            this.richTextBoxStat_rStudents.Text = "";
            // 
            // richTextBoxStat_rSubjects
            // 
            this.richTextBoxStat_rSubjects.BackColor = System.Drawing.Color.White;
            this.richTextBoxStat_rSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStat_rSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.richTextBoxStat_rSubjects.Location = new System.Drawing.Point(681, 124);
            this.richTextBoxStat_rSubjects.Name = "richTextBoxStat_rSubjects";
            this.richTextBoxStat_rSubjects.ReadOnly = true;
            this.richTextBoxStat_rSubjects.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rSubjects.TabIndex = 2;
            this.richTextBoxStat_rSubjects.Text = "";
            // 
            // richTextBoxStat_rRooms
            // 
            this.richTextBoxStat_rRooms.BackColor = System.Drawing.Color.White;
            this.richTextBoxStat_rRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStat_rRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStat_rRooms.Location = new System.Drawing.Point(934, 124);
            this.richTextBoxStat_rRooms.Name = "richTextBoxStat_rRooms";
            this.richTextBoxStat_rRooms.ReadOnly = true;
            this.richTextBoxStat_rRooms.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rRooms.TabIndex = 3;
            this.richTextBoxStat_rRooms.Text = "";
            // 
            // chartStat
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStat.Legends.Add(legend1);
            this.chartStat.Location = new System.Drawing.Point(12, 303);
            this.chartStat.Name = "chartStat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Lecture Hall";
            series1.XValueMember = "Labs";
            series1.YValueMembers = "LecHalls";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Laboratory";
            this.chartStat.Series.Add(series1);
            this.chartStat.Series.Add(series2);
            this.chartStat.Size = new System.Drawing.Size(536, 406);
            this.chartStat.TabIndex = 4;
            this.chartStat.Text = "chart1";
            // 
            // textBoxLecturerBoxStat
            // 
            this.textBoxLecturerBoxStat.Location = new System.Drawing.Point(183, 102);
            this.textBoxLecturerBoxStat.Name = "textBoxLecturerBoxStat";
            this.textBoxLecturerBoxStat.ReadOnly = true;
            this.textBoxLecturerBoxStat.Size = new System.Drawing.Size(309, 22);
            this.textBoxLecturerBoxStat.TabIndex = 5;
            // 
            // textBoxLatestGroupBoxStat
            // 
            this.textBoxLatestGroupBoxStat.Location = new System.Drawing.Point(183, 196);
            this.textBoxLatestGroupBoxStat.Name = "textBoxLatestGroupBoxStat";
            this.textBoxLatestGroupBoxStat.ReadOnly = true;
            this.textBoxLatestGroupBoxStat.Size = new System.Drawing.Size(309, 22);
            this.textBoxLatestGroupBoxStat.TabIndex = 6;
            // 
            // textBoxSubjectBoxStat
            // 
            this.textBoxSubjectBoxStat.Location = new System.Drawing.Point(183, 299);
            this.textBoxSubjectBoxStat.Name = "textBoxSubjectBoxStat";
            this.textBoxSubjectBoxStat.ReadOnly = true;
            this.textBoxSubjectBoxStat.Size = new System.Drawing.Size(309, 22);
            this.textBoxSubjectBoxStat.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxLecturerBoxStat);
            this.groupBox1.Controls.Add(this.textBoxSubjectBoxStat);
            this.groupBox1.Controls.Add(this.textBoxLatestGroupBoxStat);
            this.groupBox1.Location = new System.Drawing.Point(554, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 406);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What\'s New";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Latest Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Latest Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Latest Lecturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Registered Lecturers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registered Student Group";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Registered Subjects";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(880, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registered Rooms";
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartStat);
            this.Controls.Add(this.richTextBoxStat_rRooms);
            this.Controls.Add(this.richTextBoxStat_rSubjects);
            this.Controls.Add(this.richTextBoxStat_rStudents);
            this.Controls.Add(this.richTextBoxStat_rLecturers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statics";
            this.Load += new System.EventHandler(this.Statics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStat_rLecturers;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rStudents;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rSubjects;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rRooms;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStat;
        private System.Windows.Forms.TextBox textBoxLecturerBoxStat;
        private System.Windows.Forms.TextBox textBoxLatestGroupBoxStat;
        private System.Windows.Forms.TextBox textBoxSubjectBoxStat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}