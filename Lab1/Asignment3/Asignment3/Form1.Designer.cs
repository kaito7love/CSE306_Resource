namespace Asignment3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectAvatar = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReadAndDeserialize = new System.Windows.Forms.Button();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnSaveAndSeialize = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fullname";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 177);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 92);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avatar";
            // 
            // btnSelectAvatar
            // 
            this.btnSelectAvatar.Location = new System.Drawing.Point(240, 30);
            this.btnSelectAvatar.Name = "btnSelectAvatar";
            this.btnSelectAvatar.Size = new System.Drawing.Size(88, 23);
            this.btnSelectAvatar.TabIndex = 9;
            this.btnSelectAvatar.Text = "Select/Change";
            this.btnSelectAvatar.UseVisualStyleBackColor = true;
            this.btnSelectAvatar.Click += new System.EventHandler(this.btnSelectAvatar_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 279);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(102, 23);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read from a file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReadAndDeserialize
            // 
            this.btnReadAndDeserialize.Location = new System.Drawing.Point(163, 279);
            this.btnReadAndDeserialize.Name = "btnReadAndDeserialize";
            this.btnReadAndDeserialize.Size = new System.Drawing.Size(177, 23);
            this.btnReadAndDeserialize.TabIndex = 12;
            this.btnReadAndDeserialize.Text = "Read from a file and Deserialize";
            this.btnReadAndDeserialize.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(240, 59);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAvatar.TabIndex = 13;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // btnSaveAndSeialize
            // 
            this.btnSaveAndSeialize.Location = new System.Drawing.Point(163, 308);
            this.btnSaveAndSeialize.Name = "btnSaveAndSeialize";
            this.btnSaveAndSeialize.Size = new System.Drawing.Size(177, 23);
            this.btnSaveAndSeialize.TabIndex = 14;
            this.btnSaveAndSeialize.Text = "Serialize and Save to a file";
            this.btnSaveAndSeialize.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 352);
            this.Controls.Add(this.btnSaveAndSeialize);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.btnReadAndDeserialize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSelectAvatar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectAvatar;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReadAndDeserialize;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button btnSaveAndSeialize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

