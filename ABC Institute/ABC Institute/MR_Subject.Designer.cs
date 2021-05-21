
namespace ABC_Institute
{
    partial class MR_Subject
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
            this.comboBox1Subject = new System.Windows.Forms.ComboBox();
            this.label_Head_MR_Sub = new System.Windows.Forms.Label();
            this.comboBox2Subject = new System.Windows.Forms.ComboBox();
            this.textBox1Subject = new System.Windows.Forms.TextBox();
            this.labelSelectSubject = new System.Windows.Forms.Label();
            this.label3SelectRoomSubject = new System.Windows.Forms.Label();
            this.label4SelectedSubject = new System.Windows.Forms.Label();
            this.button1ClearSubject = new System.Windows.Forms.Button();
            this.button2SubmitSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1Subject
            // 
            this.comboBox1Subject.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.comboBox1Subject.FormattingEnabled = true;
            this.comboBox1Subject.Items.AddRange(new object[] {
            "Select here.."});
            this.comboBox1Subject.Location = new System.Drawing.Point(263, 148);
            this.comboBox1Subject.Name = "comboBox1Subject";
            this.comboBox1Subject.Size = new System.Drawing.Size(235, 24);
            this.comboBox1Subject.TabIndex = 0;
            this.comboBox1Subject.Text = "Select here..";
            this.comboBox1Subject.SelectedIndexChanged += new System.EventHandler(this.comboBox1Subject_SelectedIndexChanged);
            // 
            // label_Head_MR_Sub
            // 
            this.label_Head_MR_Sub.AutoSize = true;
            this.label_Head_MR_Sub.Font = new System.Drawing.Font("Montserrat", 19.8F);
            this.label_Head_MR_Sub.Location = new System.Drawing.Point(332, 43);
            this.label_Head_MR_Sub.Name = "label_Head_MR_Sub";
            this.label_Head_MR_Sub.Size = new System.Drawing.Size(437, 40);
            this.label_Head_MR_Sub.TabIndex = 1;
            this.label_Head_MR_Sub.Text = "Manage Rooms - Subject";
            this.label_Head_MR_Sub.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2Subject
            // 
            this.comboBox2Subject.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.comboBox2Subject.FormattingEnabled = true;
            this.comboBox2Subject.Items.AddRange(new object[] {
            "Select here.."});
            this.comboBox2Subject.Location = new System.Drawing.Point(714, 148);
            this.comboBox2Subject.Name = "comboBox2Subject";
            this.comboBox2Subject.Size = new System.Drawing.Size(235, 24);
            this.comboBox2Subject.TabIndex = 2;
            this.comboBox2Subject.Text = "Select here..";
            this.comboBox2Subject.SelectedIndexChanged += new System.EventHandler(this.comboBox2Subject_SelectedIndexChanged);
            // 
            // textBox1Subject
            // 
            this.textBox1Subject.BackColor = System.Drawing.Color.White;
            this.textBox1Subject.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1Subject.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.textBox1Subject.Location = new System.Drawing.Point(263, 312);
            this.textBox1Subject.Multiline = true;
            this.textBox1Subject.Name = "textBox1Subject";
            this.textBox1Subject.ReadOnly = true;
            this.textBox1Subject.Size = new System.Drawing.Size(686, 169);
            this.textBox1Subject.TabIndex = 3;
            this.textBox1Subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSelectSubject
            // 
            this.labelSelectSubject.AutoSize = true;
            this.labelSelectSubject.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelSelectSubject.Location = new System.Drawing.Point(61, 148);
            this.labelSelectSubject.Name = "labelSelectSubject";
            this.labelSelectSubject.Size = new System.Drawing.Size(153, 24);
            this.labelSelectSubject.TabIndex = 4;
            this.labelSelectSubject.Text = "Select Subject";
            this.labelSelectSubject.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3SelectRoomSubject
            // 
            this.label3SelectRoomSubject.AutoSize = true;
            this.label3SelectRoomSubject.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label3SelectRoomSubject.Location = new System.Drawing.Point(542, 148);
            this.label3SelectRoomSubject.Name = "label3SelectRoomSubject";
            this.label3SelectRoomSubject.Size = new System.Drawing.Size(138, 24);
            this.label3SelectRoomSubject.TabIndex = 5;
            this.label3SelectRoomSubject.Text = "Select Room";
            // 
            // label4SelectedSubject
            // 
            this.label4SelectedSubject.AutoSize = true;
            this.label4SelectedSubject.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4SelectedSubject.Location = new System.Drawing.Point(61, 378);
            this.label4SelectedSubject.Name = "label4SelectedSubject";
            this.label4SelectedSubject.Size = new System.Drawing.Size(178, 24);
            this.label4SelectedSubject.TabIndex = 6;
            this.label4SelectedSubject.Text = "Selected Subject";
            // 
            // button1ClearSubject
            // 
            this.button1ClearSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1ClearSubject.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.button1ClearSubject.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1ClearSubject.Location = new System.Drawing.Point(359, 564);
            this.button1ClearSubject.Name = "button1ClearSubject";
            this.button1ClearSubject.Size = new System.Drawing.Size(163, 38);
            this.button1ClearSubject.TabIndex = 7;
            this.button1ClearSubject.Text = "Clear";
            this.button1ClearSubject.UseVisualStyleBackColor = true;
            this.button1ClearSubject.Click += new System.EventHandler(this.button1ClearSubject_Click);
            // 
            // button2SubmitSubject
            // 
            this.button2SubmitSubject.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2SubmitSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2SubmitSubject.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.button2SubmitSubject.ForeColor = System.Drawing.Color.White;
            this.button2SubmitSubject.Location = new System.Drawing.Point(648, 564);
            this.button2SubmitSubject.Name = "button2SubmitSubject";
            this.button2SubmitSubject.Size = new System.Drawing.Size(163, 38);
            this.button2SubmitSubject.TabIndex = 8;
            this.button2SubmitSubject.Text = "Submit";
            this.button2SubmitSubject.UseVisualStyleBackColor = false;
            this.button2SubmitSubject.Click += new System.EventHandler(this.button2SubmitSubject_Click);
            // 
            // MR_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.button2SubmitSubject);
            this.Controls.Add(this.button1ClearSubject);
            this.Controls.Add(this.label4SelectedSubject);
            this.Controls.Add(this.label3SelectRoomSubject);
            this.Controls.Add(this.labelSelectSubject);
            this.Controls.Add(this.textBox1Subject);
            this.Controls.Add(this.comboBox2Subject);
            this.Controls.Add(this.label_Head_MR_Sub);
            this.Controls.Add(this.comboBox1Subject);
            this.Name = "MR_Subject";
            this.Text = "Manage Rooms - Subject";
            this.Load += new System.EventHandler(this.MR_Subject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Subject;
        private System.Windows.Forms.Label label_Head_MR_Sub;
        private System.Windows.Forms.ComboBox comboBox2Subject;
        private System.Windows.Forms.TextBox textBox1Subject;
        private System.Windows.Forms.Label labelSelectSubject;
        private System.Windows.Forms.Label label3SelectRoomSubject;
        private System.Windows.Forms.Label label4SelectedSubject;
        private System.Windows.Forms.Button button1ClearSubject;
        private System.Windows.Forms.Button button2SubmitSubject;
    }
}