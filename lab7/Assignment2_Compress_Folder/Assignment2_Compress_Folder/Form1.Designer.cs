namespace Assignment2_Compress_Folder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnSelectFolderCom = new System.Windows.Forms.Button();
            this.txtPathCom = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathExtract = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnSelectFolderExtract = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 104);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnZip);
            this.tabPage1.Controls.Add(this.btnSelectFolderCom);
            this.tabPage1.Controls.Add(this.txtPathCom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compression";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder Path";
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(168, 45);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 5;
            this.btnZip.Text = "Compression";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnSelectFolderCom
            // 
            this.btnSelectFolderCom.Location = new System.Drawing.Point(319, 17);
            this.btnSelectFolderCom.Name = "btnSelectFolderCom";
            this.btnSelectFolderCom.Size = new System.Drawing.Size(83, 23);
            this.btnSelectFolderCom.TabIndex = 4;
            this.btnSelectFolderCom.Text = "Select Folder";
            this.btnSelectFolderCom.UseVisualStyleBackColor = true;
            this.btnSelectFolderCom.Click += new System.EventHandler(this.btnSelectFolderCom_Click);
            // 
            // txtPathCom
            // 
            this.txtPathCom.Location = new System.Drawing.Point(6, 19);
            this.txtPathCom.Name = "txtPathCom";
            this.txtPathCom.Size = new System.Drawing.Size(296, 20);
            this.txtPathCom.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtPathExtract);
            this.tabPage2.Controls.Add(this.btnExtract);
            this.tabPage2.Controls.Add(this.btnSelectFolderExtract);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Folder Path";
            // 
            // txtPathExtract
            // 
            this.txtPathExtract.Location = new System.Drawing.Point(6, 19);
            this.txtPathExtract.Name = "txtPathExtract";
            this.txtPathExtract.Size = new System.Drawing.Size(296, 20);
            this.txtPathExtract.TabIndex = 7;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(168, 45);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 9;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnSelectFolderExtract
            // 
            this.btnSelectFolderExtract.Location = new System.Drawing.Point(319, 17);
            this.btnSelectFolderExtract.Name = "btnSelectFolderExtract";
            this.btnSelectFolderExtract.Size = new System.Drawing.Size(82, 23);
            this.btnSelectFolderExtract.TabIndex = 8;
            this.btnSelectFolderExtract.Text = "Select Folder";
            this.btnSelectFolderExtract.UseVisualStyleBackColor = true;
            this.btnSelectFolderExtract.Click += new System.EventHandler(this.btnSelectFolderExtract_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 127);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnSelectFolderCom;
        private System.Windows.Forms.TextBox txtPathCom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnSelectFolderExtract;
        private System.Windows.Forms.TextBox txtPathExtract;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

