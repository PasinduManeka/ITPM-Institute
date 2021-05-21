
namespace ABC_Institute
{
    partial class ManageLocations
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
            this.components = new System.ComponentModel.Container();
            this.labelManageLocations = new System.Windows.Forms.Label();
            this.labelBuildingNameManageLocations = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBoxBuildingNameML = new System.Windows.Forms.TextBox();
            this.textBoxCapacityML = new System.Windows.Forms.TextBox();
            this.textBoxRoomNameML = new System.Windows.Forms.TextBox();
            this.buttonMLupdate = new System.Windows.Forms.Button();
            this.buttonMLdelete = new System.Windows.Forms.Button();
            this.buttonMLclear = new System.Windows.Forms.Button();
            this.ML_RoomType_LecHall = new System.Windows.Forms.RadioButton();
            this.ML_RoomType_lab = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxID_ML = new System.Windows.Forms.TextBox();
            this.searchML = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageLocations
            // 
            this.labelManageLocations.AutoSize = true;
            this.labelManageLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelManageLocations.Location = new System.Drawing.Point(371, 20);
            this.labelManageLocations.Name = "labelManageLocations";
            this.labelManageLocations.Size = new System.Drawing.Size(299, 38);
            this.labelManageLocations.TabIndex = 0;
            this.labelManageLocations.Text = "Manage Locations";
            // 
            // labelBuildingNameManageLocations
            // 
            this.labelBuildingNameManageLocations.AutoSize = true;
            this.labelBuildingNameManageLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBuildingNameManageLocations.Location = new System.Drawing.Point(102, 453);
            this.labelBuildingNameManageLocations.Name = "labelBuildingNameManageLocations";
            this.labelBuildingNameManageLocations.Size = new System.Drawing.Size(138, 25);
            this.labelBuildingNameManageLocations.TabIndex = 1;
            this.labelBuildingNameManageLocations.Text = "Building Name";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCapacity.Location = new System.Drawing.Point(102, 644);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(89, 25);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRoomType.Location = new System.Drawing.Point(102, 583);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(113, 25);
            this.labelRoomType.TabIndex = 7;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRoomName.Location = new System.Drawing.Point(102, 518);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(120, 25);
            this.labelRoomName.TabIndex = 8;
            this.labelRoomName.Text = "Room Name";
            this.labelRoomName.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxBuildingNameML
            // 
            this.textBoxBuildingNameML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuildingNameML.Location = new System.Drawing.Point(329, 447);
            this.textBoxBuildingNameML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuildingNameML.Multiline = true;
            this.textBoxBuildingNameML.Name = "textBoxBuildingNameML";
            this.textBoxBuildingNameML.Size = new System.Drawing.Size(598, 30);
            this.textBoxBuildingNameML.TabIndex = 9;
            this.textBoxBuildingNameML.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCapacityML
            // 
            this.textBoxCapacityML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCapacityML.Location = new System.Drawing.Point(329, 638);
            this.textBoxCapacityML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCapacityML.Multiline = true;
            this.textBoxCapacityML.Name = "textBoxCapacityML";
            this.textBoxCapacityML.Size = new System.Drawing.Size(598, 30);
            this.textBoxCapacityML.TabIndex = 10;
            // 
            // textBoxRoomNameML
            // 
            this.textBoxRoomNameML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRoomNameML.Location = new System.Drawing.Point(329, 512);
            this.textBoxRoomNameML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRoomNameML.Multiline = true;
            this.textBoxRoomNameML.Name = "textBoxRoomNameML";
            this.textBoxRoomNameML.Size = new System.Drawing.Size(598, 30);
            this.textBoxRoomNameML.TabIndex = 12;
            // 
            // buttonMLupdate
            // 
            this.buttonMLupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMLupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMLupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonMLupdate.ForeColor = System.Drawing.Color.White;
            this.buttonMLupdate.Location = new System.Drawing.Point(836, 135);
            this.buttonMLupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMLupdate.Name = "buttonMLupdate";
            this.buttonMLupdate.Size = new System.Drawing.Size(210, 55);
            this.buttonMLupdate.TabIndex = 13;
            this.buttonMLupdate.Text = "Update";
            this.buttonMLupdate.UseVisualStyleBackColor = false;
            this.buttonMLupdate.Click += new System.EventHandler(this.buttonMLupdate_Click);
            // 
            // buttonMLdelete
            // 
            this.buttonMLdelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonMLdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMLdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonMLdelete.ForeColor = System.Drawing.Color.White;
            this.buttonMLdelete.Location = new System.Drawing.Point(836, 242);
            this.buttonMLdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMLdelete.Name = "buttonMLdelete";
            this.buttonMLdelete.Size = new System.Drawing.Size(210, 55);
            this.buttonMLdelete.TabIndex = 14;
            this.buttonMLdelete.Text = "Delete";
            this.buttonMLdelete.UseVisualStyleBackColor = false;
            this.buttonMLdelete.Click += new System.EventHandler(this.buttonMLdelete_Click);
            // 
            // buttonMLclear
            // 
            this.buttonMLclear.BackColor = System.Drawing.Color.Transparent;
            this.buttonMLclear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonMLclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMLclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonMLclear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonMLclear.Location = new System.Drawing.Point(836, 347);
            this.buttonMLclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMLclear.Name = "buttonMLclear";
            this.buttonMLclear.Size = new System.Drawing.Size(210, 55);
            this.buttonMLclear.TabIndex = 15;
            this.buttonMLclear.Text = "Clear";
            this.buttonMLclear.UseVisualStyleBackColor = false;
            this.buttonMLclear.Click += new System.EventHandler(this.buttonMLclear_Click);
            // 
            // ML_RoomType_LecHall
            // 
            this.ML_RoomType_LecHall.AutoSize = true;
            this.ML_RoomType_LecHall.Location = new System.Drawing.Point(329, 585);
            this.ML_RoomType_LecHall.Name = "ML_RoomType_LecHall";
            this.ML_RoomType_LecHall.Size = new System.Drawing.Size(105, 21);
            this.ML_RoomType_LecHall.TabIndex = 17;
            this.ML_RoomType_LecHall.TabStop = true;
            this.ML_RoomType_LecHall.Text = "Lecture Hall";
            this.ML_RoomType_LecHall.UseVisualStyleBackColor = true;
            this.ML_RoomType_LecHall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ML_RoomType_lab
            // 
            this.ML_RoomType_lab.AutoSize = true;
            this.ML_RoomType_lab.Location = new System.Drawing.Point(643, 585);
            this.ML_RoomType_lab.Name = "ML_RoomType_lab";
            this.ML_RoomType_lab.Size = new System.Drawing.Size(98, 21);
            this.ML_RoomType_lab.TabIndex = 18;
            this.ML_RoomType_lab.TabStop = true;
            this.ML_RoomType_lab.Text = "Laboratory";
            this.ML_RoomType_lab.UseVisualStyleBackColor = true;
            this.ML_RoomType_lab.CheckedChanged += new System.EventHandler(this.ML_RoomType_lab_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 267);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textBoxID_ML
            // 
            this.textBoxID_ML.Location = new System.Drawing.Point(957, 518);
            this.textBoxID_ML.Name = "textBoxID_ML";
            this.textBoxID_ML.ReadOnly = true;
            this.textBoxID_ML.Size = new System.Drawing.Size(100, 22);
            this.textBoxID_ML.TabIndex = 20;
            this.textBoxID_ML.Visible = false;
            this.textBoxID_ML.TextChanged += new System.EventHandler(this.textBoxID_ML_TextChanged);
            // 
            // searchML
            // 
            this.searchML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchML.ForeColor = System.Drawing.Color.DarkGray;
            this.searchML.Location = new System.Drawing.Point(515, 89);
            this.searchML.Multiline = true;
            this.searchML.Name = "searchML";
            this.searchML.Size = new System.Drawing.Size(292, 27);
            this.searchML.TabIndex = 21;
            this.searchML.Text = "Search using Room Name";
            this.searchML.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchML_MouseClick_1);
            this.searchML.TextChanged += new System.EventHandler(this.searchML_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search with Room Name";
            // 
            // ManageLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchML);
            this.Controls.Add(this.textBoxID_ML);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ML_RoomType_lab);
            this.Controls.Add(this.ML_RoomType_LecHall);
            this.Controls.Add(this.buttonMLclear);
            this.Controls.Add(this.buttonMLdelete);
            this.Controls.Add(this.buttonMLupdate);
            this.Controls.Add(this.textBoxRoomNameML);
            this.Controls.Add(this.textBoxCapacityML);
            this.Controls.Add(this.textBoxBuildingNameML);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelBuildingNameManageLocations);
            this.Controls.Add(this.labelManageLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageLocations";
            this.Load += new System.EventHandler(this.ManageLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageLocations;
        private System.Windows.Forms.Label labelBuildingNameManageLocations;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBoxBuildingNameML;
        private System.Windows.Forms.TextBox textBoxCapacityML;
        private System.Windows.Forms.TextBox textBoxRoomNameML;
        private System.Windows.Forms.Button buttonMLupdate;
        private System.Windows.Forms.Button buttonMLdelete;
        private System.Windows.Forms.Button buttonMLclear;
        private System.Windows.Forms.RadioButton ML_RoomType_LecHall;
        private System.Windows.Forms.RadioButton ML_RoomType_lab;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxID_ML;
        public System.Windows.Forms.TextBox searchML;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}