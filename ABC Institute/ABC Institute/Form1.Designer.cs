
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddingID = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.comboBoxNumberWorking = new System.Windows.Forms.ComboBox();
            this.comboBoxhrs = new System.Windows.Forms.ComboBox();
            this.comboBoxminutes = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding Working Days and Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Working Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number Of Working Days";
            // 
            // textBoxAddingID
            // 
            this.textBoxAddingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddingID.Location = new System.Drawing.Point(47, 86);
            this.textBoxAddingID.Name = "textBoxAddingID";
            this.textBoxAddingID.ReadOnly = true;
            this.textBoxAddingID.Size = new System.Drawing.Size(100, 30);
            this.textBoxAddingID.TabIndex = 6;
            // 
            // textBoxDays
            // 
            this.textBoxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDays.Location = new System.Drawing.Point(270, 203);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(442, 30);
            this.textBoxDays.TabIndex = 8;
            // 
            // comboBoxNumberWorking
            // 
            this.comboBoxNumberWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumberWorking.FormattingEnabled = true;
            this.comboBoxNumberWorking.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days",
            "4 Days",
            "5 Days",
            "6 Days",
            "7 Days"});
            this.comboBoxNumberWorking.Location = new System.Drawing.Point(270, 142);
            this.comboBoxNumberWorking.Name = "comboBoxNumberWorking";
            this.comboBoxNumberWorking.Size = new System.Drawing.Size(442, 33);
            this.comboBoxNumberWorking.TabIndex = 9;
            // 
            // comboBoxhrs
            // 
            this.comboBoxhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxhrs.FormattingEnabled = true;
            this.comboBoxhrs.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "4 Hours",
            "5 Hours",
            "6 Hours",
            "7 Hours",
            "8 Hours",
            "9 Hours"});
            this.comboBoxhrs.Location = new System.Drawing.Point(270, 256);
            this.comboBoxhrs.Name = "comboBoxhrs";
            this.comboBoxhrs.Size = new System.Drawing.Size(442, 33);
            this.comboBoxhrs.TabIndex = 10;
            // 
            // comboBoxminutes
            // 
            this.comboBoxminutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxminutes.FormattingEnabled = true;
            this.comboBoxminutes.Items.AddRange(new object[] {
            "00",
            "15 Minutes",
            "30 Minutes",
            "45 Minutes"});
            this.comboBoxminutes.Location = new System.Drawing.Point(270, 317);
            this.comboBoxminutes.Name = "comboBoxminutes";
            this.comboBoxminutes.Size = new System.Drawing.Size(442, 33);
            this.comboBoxminutes.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 265);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonInsert.Location = new System.Drawing.Point(133, 388);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(91, 47);
            this.buttonInsert.TabIndex = 13;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Azure;
            this.buttonUpdate.Location = new System.Drawing.Point(294, 388);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 47);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.DeepPink;
            this.buttondelete.Location = new System.Drawing.Point(448, 388);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(91, 47);
            this.buttondelete.TabIndex = 15;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.Azure;
            this.buttonclear.Location = new System.Drawing.Point(621, 388);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(91, 47);
            this.buttonclear.TabIndex = 16;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(812, 733);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxminutes);
            this.Controls.Add(this.comboBoxhrs);
            this.Controls.Add(this.comboBoxNumberWorking);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.textBoxAddingID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddingID;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.ComboBox comboBoxNumberWorking;
        private System.Windows.Forms.ComboBox comboBoxhrs;
        private System.Windows.Forms.ComboBox comboBoxminutes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonclear;
    }
}

