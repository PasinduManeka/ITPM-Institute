
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
            this.btnViewConsecutive = new System.Windows.Forms.Button();
            this.btnSaveConsecutive = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnViewParallel = new System.Windows.Forms.Button();
            this.btnSaveParallel = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnViewOverlapping = new System.Windows.Forms.Button();
            this.btnSaveOverlapping = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1368, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnViewConsecutive);
            this.tabPage1.Controls.Add(this.btnSaveConsecutive);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1360, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consecutive";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnViewConsecutive
            // 
            this.btnViewConsecutive.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewConsecutive.Location = new System.Drawing.Point(643, 371);
            this.btnViewConsecutive.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewConsecutive.Name = "btnViewConsecutive";
            this.btnViewConsecutive.Size = new System.Drawing.Size(180, 54);
            this.btnViewConsecutive.TabIndex = 2;
            this.btnViewConsecutive.Text = "View";
            this.btnViewConsecutive.UseVisualStyleBackColor = false;
            // 
            // btnSaveConsecutive
            // 
            this.btnSaveConsecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveConsecutive.Location = new System.Drawing.Point(323, 371);
            this.btnSaveConsecutive.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveConsecutive.Name = "btnSaveConsecutive";
            this.btnSaveConsecutive.Size = new System.Drawing.Size(180, 54);
            this.btnSaveConsecutive.TabIndex = 1;
            this.btnSaveConsecutive.Text = "Save";
            this.btnSaveConsecutive.UseVisualStyleBackColor = false;
            this.btnSaveConsecutive.Click += new System.EventHandler(this.btnSaveConsecutive_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(36, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 289);
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
            this.tabPage2.Controls.Add(this.btnViewParallel);
            this.tabPage2.Controls.Add(this.btnSaveParallel);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1360, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnViewParallel
            // 
            this.btnViewParallel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewParallel.Location = new System.Drawing.Point(656, 351);
            this.btnViewParallel.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewParallel.Name = "btnViewParallel";
            this.btnViewParallel.Size = new System.Drawing.Size(180, 54);
            this.btnViewParallel.TabIndex = 4;
            this.btnViewParallel.Text = "View";
            this.btnViewParallel.UseVisualStyleBackColor = false;
            // 
            // btnSaveParallel
            // 
            this.btnSaveParallel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveParallel.Location = new System.Drawing.Point(336, 351);
            this.btnSaveParallel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveParallel.Name = "btnSaveParallel";
            this.btnSaveParallel.Size = new System.Drawing.Size(180, 54);
            this.btnSaveParallel.TabIndex = 3;
            this.btnSaveParallel.Text = "Save";
            this.btnSaveParallel.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1163, 289);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnViewOverlapping);
            this.tabPage3.Controls.Add(this.btnSaveOverlapping);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1360, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Overlapping";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnViewOverlapping
            // 
            this.btnViewOverlapping.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewOverlapping.Location = new System.Drawing.Point(675, 348);
            this.btnViewOverlapping.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewOverlapping.Name = "btnViewOverlapping";
            this.btnViewOverlapping.Size = new System.Drawing.Size(180, 54);
            this.btnViewOverlapping.TabIndex = 6;
            this.btnViewOverlapping.Text = "View";
            this.btnViewOverlapping.UseVisualStyleBackColor = false;
            // 
            // btnSaveOverlapping
            // 
            this.btnSaveOverlapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveOverlapping.Location = new System.Drawing.Point(355, 348);
            this.btnSaveOverlapping.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveOverlapping.Name = "btnSaveOverlapping";
            this.btnSaveOverlapping.Size = new System.Drawing.Size(180, 54);
            this.btnSaveOverlapping.TabIndex = 5;
            this.btnSaveOverlapping.Text = "Save";
            this.btnSaveOverlapping.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(38, 15);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1163, 289);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1360, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Non Available Times";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 498);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Sessions and Not Available Time Allocations ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnViewConsecutive;
        private System.Windows.Forms.Button btnSaveConsecutive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnViewParallel;
        private System.Windows.Forms.Button btnSaveParallel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnViewOverlapping;
        private System.Windows.Forms.Button btnSaveOverlapping;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}