
namespace ABC_Institute
{
    partial class AddTags
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRTag = new System.Windows.Forms.ComboBox();
            this.textSubjectName = new System.Windows.Forms.TextBox();
            this.textTagCode = new System.Windows.Forms.TextBox();
            this.textSubjectCode = new System.Windows.Forms.TextBox();
            this.buttonClear3 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(555, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Subject Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Related Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tag Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Subject Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Tags";
            // 
            // comboRTag
            // 
            this.comboRTag.FormattingEnabled = true;
            this.comboRTag.Items.AddRange(new object[] {
            "Lecture",
            "Lab",
            "Tutorial"});
            this.comboRTag.Location = new System.Drawing.Point(700, 224);
            this.comboRTag.Name = "comboRTag";
            this.comboRTag.Size = new System.Drawing.Size(196, 24);
            this.comboRTag.TabIndex = 15;
            // 
            // textSubjectName
            // 
            this.textSubjectName.Location = new System.Drawing.Point(251, 139);
            this.textSubjectName.Name = "textSubjectName";
            this.textSubjectName.Size = new System.Drawing.Size(196, 22);
            this.textSubjectName.TabIndex = 20;
            // 
            // textTagCode
            // 
            this.textTagCode.Location = new System.Drawing.Point(251, 222);
            this.textTagCode.Name = "textTagCode";
            this.textTagCode.Size = new System.Drawing.Size(196, 22);
            this.textTagCode.TabIndex = 21;
            // 
            // textSubjectCode
            // 
            this.textSubjectCode.Location = new System.Drawing.Point(700, 139);
            this.textSubjectCode.Name = "textSubjectCode";
            this.textSubjectCode.Size = new System.Drawing.Size(196, 22);
            this.textSubjectCode.TabIndex = 22;
            this.textSubjectCode.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonClear3
            // 
            this.buttonClear3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear3.Location = new System.Drawing.Point(210, 333);
            this.buttonClear3.Name = "buttonClear3";
            this.buttonClear3.Size = new System.Drawing.Size(212, 50);
            this.buttonClear3.TabIndex = 23;
            this.buttonClear3.Text = "Clear";
            this.buttonClear3.UseVisualStyleBackColor = false;
            this.buttonClear3.Click += new System.EventHandler(this.buttonClear3_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(593, 333);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(212, 50);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 476);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear3);
            this.Controls.Add(this.textSubjectCode);
            this.Controls.Add(this.textTagCode);
            this.Controls.Add(this.textSubjectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboRTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTags";
            this.Text = "Tags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRTag;
        private System.Windows.Forms.TextBox textSubjectName;
        private System.Windows.Forms.TextBox textTagCode;
        private System.Windows.Forms.TextBox textSubjectCode;
        private System.Windows.Forms.Button buttonClear3;
        private System.Windows.Forms.Button buttonSave;
    }
}