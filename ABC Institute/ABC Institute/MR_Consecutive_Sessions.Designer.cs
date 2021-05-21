
namespace ABC_Institute
{
    partial class MR_Consecutive_Sessions
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
            this.dataGridView1CS = new System.Windows.Forms.DataGridView();
            this.buttonAdd_Room = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHidden_CS = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sessions = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsecutivePage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1Con = new System.Windows.Forms.DataGridView();
            this.button1RefreshCon = new System.Windows.Forms.Button();
            this.textBoxHiddenCon = new System.Windows.Forms.TextBox();
            this.button3AddRoomCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1CS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Sessions.SuspendLayout();
            this.ConsecutivePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Con)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1CS
            // 
            this.dataGridView1CS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1CS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1CS.Location = new System.Drawing.Point(31, 131);
            this.dataGridView1CS.Name = "dataGridView1CS";
            this.dataGridView1CS.RowHeadersWidth = 51;
            this.dataGridView1CS.RowTemplate.Height = 24;
            this.dataGridView1CS.Size = new System.Drawing.Size(993, 252);
            this.dataGridView1CS.TabIndex = 0;
            this.dataGridView1CS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1CS_CellContentClick);
            this.dataGridView1CS.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1CS_RowHeaderMouseClick);
            // 
            // buttonAdd_Room
            // 
            this.buttonAdd_Room.BackColor = System.Drawing.Color.Green;
            this.buttonAdd_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_Room.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.buttonAdd_Room.ForeColor = System.Drawing.Color.White;
            this.buttonAdd_Room.Location = new System.Drawing.Point(213, 577);
            this.buttonAdd_Room.Name = "buttonAdd_Room";
            this.buttonAdd_Room.Size = new System.Drawing.Size(200, 60);
            this.buttonAdd_Room.TabIndex = 1;
            this.buttonAdd_Room.Text = "Add Room";
            this.buttonAdd_Room.UseVisualStyleBackColor = false;
            this.buttonAdd_Room.Click += new System.EventHandler(this.buttonAdd_Room_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(609, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxHidden_CS
            // 
            this.textBoxHidden_CS.Enabled = false;
            this.textBoxHidden_CS.Location = new System.Drawing.Point(31, 441);
            this.textBoxHidden_CS.Multiline = true;
            this.textBoxHidden_CS.Name = "textBoxHidden_CS";
            this.textBoxHidden_CS.Size = new System.Drawing.Size(993, 114);
            this.textBoxHidden_CS.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sessions);
            this.tabControl1.Controls.Add(this.ConsecutivePage);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 715);
            this.tabControl1.TabIndex = 4;
            // 
            // Sessions
            // 
            this.Sessions.Controls.Add(this.label6);
            this.Sessions.Controls.Add(this.label5);
            this.Sessions.Controls.Add(this.label4);
            this.Sessions.Controls.Add(this.dataGridView1CS);
            this.Sessions.Controls.Add(this.button2);
            this.Sessions.Controls.Add(this.textBoxHidden_CS);
            this.Sessions.Controls.Add(this.buttonAdd_Room);
            this.Sessions.Location = new System.Drawing.Point(4, 31);
            this.Sessions.Name = "Sessions";
            this.Sessions.Padding = new System.Windows.Forms.Padding(3);
            this.Sessions.Size = new System.Drawing.Size(1054, 680);
            this.Sessions.TabIndex = 0;
            this.Sessions.Text = "Sessions";
            this.Sessions.UseVisualStyleBackColor = true;
            this.Sessions.Click += new System.EventHandler(this.Sessions_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(580, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tag and Subject code of the selected row will appear below";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(799, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select a session from the table (click the arrow head) to add a room to that sess" +
    "ion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sessions";
            // 
            // ConsecutivePage
            // 
            this.ConsecutivePage.Controls.Add(this.button1);
            this.ConsecutivePage.Controls.Add(this.label2);
            this.ConsecutivePage.Controls.Add(this.label1);
            this.ConsecutivePage.Controls.Add(this.dataGridView1Con);
            this.ConsecutivePage.Controls.Add(this.button1RefreshCon);
            this.ConsecutivePage.Controls.Add(this.textBoxHiddenCon);
            this.ConsecutivePage.Controls.Add(this.button3AddRoomCon);
            this.ConsecutivePage.Location = new System.Drawing.Point(4, 31);
            this.ConsecutivePage.Name = "ConsecutivePage";
            this.ConsecutivePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsecutivePage.Size = new System.Drawing.Size(1054, 680);
            this.ConsecutivePage.TabIndex = 1;
            this.ConsecutivePage.Text = "Consecutive";
            this.ConsecutivePage.UseVisualStyleBackColor = true;
            this.ConsecutivePage.Click += new System.EventHandler(this.ConsecutivePage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(381, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show selected sessions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(860, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select sessions from the table (use checkboxes to choose multiple) to add a room " +
    "to that\r\nconsecutive session";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consecutive Sessions";
            // 
            // dataGridView1Con
            // 
            this.dataGridView1Con.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1Con.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Con.Location = new System.Drawing.Point(31, 131);
            this.dataGridView1Con.Name = "dataGridView1Con";
            this.dataGridView1Con.RowHeadersWidth = 51;
            this.dataGridView1Con.RowTemplate.Height = 24;
            this.dataGridView1Con.Size = new System.Drawing.Size(993, 252);
            this.dataGridView1Con.TabIndex = 4;
            this.dataGridView1Con.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Con_CellContentClick);
            this.dataGridView1Con.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1Con_RowHeaderMouseClick);
            // 
            // button1RefreshCon
            // 
            this.button1RefreshCon.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1RefreshCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1RefreshCon.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.button1RefreshCon.ForeColor = System.Drawing.Color.White;
            this.button1RefreshCon.Location = new System.Drawing.Point(613, 562);
            this.button1RefreshCon.Name = "button1RefreshCon";
            this.button1RefreshCon.Size = new System.Drawing.Size(200, 60);
            this.button1RefreshCon.TabIndex = 6;
            this.button1RefreshCon.Text = "Refresh";
            this.button1RefreshCon.UseVisualStyleBackColor = false;
            this.button1RefreshCon.Click += new System.EventHandler(this.button1RefreshCon_Click);
            // 
            // textBoxHiddenCon
            // 
            this.textBoxHiddenCon.Enabled = false;
            this.textBoxHiddenCon.Location = new System.Drawing.Point(31, 430);
            this.textBoxHiddenCon.Multiline = true;
            this.textBoxHiddenCon.Name = "textBoxHiddenCon";
            this.textBoxHiddenCon.Size = new System.Drawing.Size(993, 116);
            this.textBoxHiddenCon.TabIndex = 7;
            // 
            // button3AddRoomCon
            // 
            this.button3AddRoomCon.BackColor = System.Drawing.Color.Green;
            this.button3AddRoomCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3AddRoomCon.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.button3AddRoomCon.ForeColor = System.Drawing.Color.White;
            this.button3AddRoomCon.Location = new System.Drawing.Point(207, 562);
            this.button3AddRoomCon.Name = "button3AddRoomCon";
            this.button3AddRoomCon.Size = new System.Drawing.Size(200, 60);
            this.button3AddRoomCon.TabIndex = 5;
            this.button3AddRoomCon.Text = "Add Room";
            this.button3AddRoomCon.UseVisualStyleBackColor = false;
            this.button3AddRoomCon.Click += new System.EventHandler(this.button3AddRoomCon_Click);
            // 
            // MR_Consecutive_Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.tabControl1);
            this.Name = "MR_Consecutive_Sessions";
            this.Text = "Consecutive Sessions";
            this.Load += new System.EventHandler(this.MR_Consecutive_Sessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1CS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Sessions.ResumeLayout(false);
            this.Sessions.PerformLayout();
            this.ConsecutivePage.ResumeLayout(false);
            this.ConsecutivePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Con)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1CS;
        private System.Windows.Forms.Button buttonAdd_Room;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBoxHidden_CS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sessions;
        private System.Windows.Forms.TabPage ConsecutivePage;
        private System.Windows.Forms.DataGridView dataGridView1Con;
        private System.Windows.Forms.Button button1RefreshCon;
        public System.Windows.Forms.TextBox textBoxHiddenCon;
        private System.Windows.Forms.Button button3AddRoomCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}