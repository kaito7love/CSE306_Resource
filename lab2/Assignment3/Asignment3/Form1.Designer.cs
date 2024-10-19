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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectAvatar = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReadAndDeserialize = new System.Windows.Forms.Button();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnSaveAndSeialize = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(16, 31);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(265, 22);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fullname";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(16, 92);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(265, 22);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Text = "abc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of birth";
            // 
            // txtDoB
            // 
            this.txtDoB.Location = new System.Drawing.Point(16, 158);
            this.txtDoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(265, 22);
            this.txtDoB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 218);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 112);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Text = "asd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avatar";
            // 
            // btnSelectAvatar
            // 
            this.btnSelectAvatar.Location = new System.Drawing.Point(320, 37);
            this.btnSelectAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectAvatar.Name = "btnSelectAvatar";
            this.btnSelectAvatar.Size = new System.Drawing.Size(117, 28);
            this.btnSelectAvatar.TabIndex = 9;
            this.btnSelectAvatar.Text = "Select/Change";
            this.btnSelectAvatar.UseVisualStyleBackColor = true;
            this.btnSelectAvatar.Click += new System.EventHandler(this.btnSelectAvatar_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(16, 343);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(136, 28);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read from a file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 379);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReadAndDeserialize
            // 
            this.btnReadAndDeserialize.Location = new System.Drawing.Point(217, 343);
            this.btnReadAndDeserialize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadAndDeserialize.Name = "btnReadAndDeserialize";
            this.btnReadAndDeserialize.Size = new System.Drawing.Size(236, 28);
            this.btnReadAndDeserialize.TabIndex = 12;
            this.btnReadAndDeserialize.Text = "Read from a file and Deserialize";
            this.btnReadAndDeserialize.UseVisualStyleBackColor = true;
            this.btnReadAndDeserialize.Click += new System.EventHandler(this.btnReadAndDeserialize_Click);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(320, 73);
            this.pictureBoxAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(133, 62);
            this.pictureBoxAvatar.TabIndex = 13;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // btnSaveAndSeialize
            // 
            this.btnSaveAndSeialize.Location = new System.Drawing.Point(217, 379);
            this.btnSaveAndSeialize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAndSeialize.Name = "btnSaveAndSeialize";
            this.btnSaveAndSeialize.Size = new System.Drawing.Size(236, 28);
            this.btnSaveAndSeialize.TabIndex = 14;
            this.btnSaveAndSeialize.Text = "Serialize and Save to a file";
            this.btnSaveAndSeialize.UseVisualStyleBackColor = true;
            this.btnSaveAndSeialize.Click += new System.EventHandler(this.btnSaveAndSeialize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.btnSaveAndSeialize);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.btnReadAndDeserialize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSelectAvatar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectAvatar;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReadAndDeserialize;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button btnSaveAndSeialize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

