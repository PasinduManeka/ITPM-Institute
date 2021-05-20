
namespace ABC_Institute
{
    partial class Form5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMsgDidaplay = new System.Windows.Forms.Label();
            this.btnViewConsecutive = new System.Windows.Forms.Button();
            this.btnSaveConsecutive = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveParallel = new System.Windows.Forms.Button();
            this.btnSaveParalle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chk1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblDisplayMSG2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblMsgDidaplay);
            this.tabPage1.Controls.Add(this.btnViewConsecutive);
            this.tabPage1.Controls.Add(this.btnSaveConsecutive);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consecutive";
            // 
            // lblMsgDidaplay
            // 
            this.lblMsgDidaplay.AutoSize = true;
            this.lblMsgDidaplay.Location = new System.Drawing.Point(352, 455);
            this.lblMsgDidaplay.Name = "lblMsgDidaplay";
            this.lblMsgDidaplay.Size = new System.Drawing.Size(0, 17);
            this.lblMsgDidaplay.TabIndex = 3;
            // 
            // btnViewConsecutive
            // 
            this.btnViewConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewConsecutive.Location = new System.Drawing.Point(631, 353);
            this.btnViewConsecutive.Name = "btnViewConsecutive";
            this.btnViewConsecutive.Size = new System.Drawing.Size(136, 65);
            this.btnViewConsecutive.TabIndex = 2;
            this.btnViewConsecutive.Text = "View";
            this.btnViewConsecutive.UseVisualStyleBackColor = false;
            // 
            // btnSaveConsecutive
            // 
            this.btnSaveConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveConsecutive.Location = new System.Drawing.Point(263, 353);
            this.btnSaveConsecutive.Name = "btnSaveConsecutive";
            this.btnSaveConsecutive.Size = new System.Drawing.Size(136, 65);
            this.btnSaveConsecutive.TabIndex = 1;
            this.btnSaveConsecutive.Text = "Add Session";
            this.btnSaveConsecutive.UseVisualStyleBackColor = false;
            this.btnSaveConsecutive.Click += new System.EventHandler(this.btnSaveConsecutive_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(39, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(973, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 6;
            this.chk.Name = "chk";
            this.chk.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDisplayMSG2);
            this.tabPage2.Controls.Add(this.btnSaveParallel);
            this.tabPage2.Controls.Add(this.btnSaveParalle);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveParallel
            // 
            this.btnSaveParallel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveParallel.Location = new System.Drawing.Point(632, 349);
            this.btnSaveParallel.Name = "btnSaveParallel";
            this.btnSaveParallel.Size = new System.Drawing.Size(136, 65);
            this.btnSaveParallel.TabIndex = 5;
            this.btnSaveParallel.Text = "View";
            this.btnSaveParallel.UseVisualStyleBackColor = false;
            // 
            // btnSaveParalle
            // 
            this.btnSaveParalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveParalle.Location = new System.Drawing.Point(264, 349);
            this.btnSaveParalle.Name = "btnSaveParalle";
            this.btnSaveParalle.Size = new System.Drawing.Size(136, 65);
            this.btnSaveParalle.TabIndex = 4;
            this.btnSaveParalle.Text = "Add Session";
            this.btnSaveParalle.UseVisualStyleBackColor = false;
            this.btnSaveParalle.Click += new System.EventHandler(this.btnSaveParalle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk1});
            this.dataGridView2.Location = new System.Drawing.Point(39, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(973, 262);
            this.dataGridView2.TabIndex = 3;
            // 
            // chk1
            // 
            this.chk1.HeaderText = "";
            this.chk1.MinimumWidth = 6;
            this.chk1.Name = "chk1";
            this.chk1.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1054, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Non Overlapping";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1054, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Not Available Times";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblDisplayMSG2
            // 
            this.lblDisplayMSG2.AutoSize = true;
            this.lblDisplayMSG2.Location = new System.Drawing.Point(239, 458);
            this.lblDisplayMSG2.Name = "lblDisplayMSG2";
            this.lblDisplayMSG2.Size = new System.Drawing.Size(0, 17);
            this.lblDisplayMSG2.TabIndex = 6;
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblMsgDidaplay;
        private System.Windows.Forms.Button btnViewConsecutive;
        private System.Windows.Forms.Button btnSaveConsecutive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.Button btnSaveParallel;
        private System.Windows.Forms.Button btnSaveParalle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk1;
        private System.Windows.Forms.Label lblDisplayMSG2;
    }
}