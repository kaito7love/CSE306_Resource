namespace Assignment1_Compress_Images
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompress = new System.Windows.Forms.Button();
            this.cmbRatio = new System.Windows.Forms.ComboBox();
            this.lbImageList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Folder/ Images";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(316, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(347, 23);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(90, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(457, 23);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFiles.TabIndex = 3;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Images List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Compression Ratio %";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(231, 271);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtPrefix.TabIndex = 9;
            this.txtPrefix.Text = "Compressed_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prefix";
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(408, 261);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 30);
            this.btnCompress.TabIndex = 10;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // cmbRatio
            // 
            this.cmbRatio.FormattingEnabled = true;
            this.cmbRatio.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80"});
            this.cmbRatio.Location = new System.Drawing.Point(16, 271);
            this.cmbRatio.Name = "cmbRatio";
            this.cmbRatio.Size = new System.Drawing.Size(36, 21);
            this.cmbRatio.TabIndex = 11;
            this.cmbRatio.Text = "50";
            // 
            // lbImageList
            // 
            this.lbImageList.FormattingEnabled = true;
            this.lbImageList.Location = new System.Drawing.Point(15, 80);
            this.lbImageList.Name = "lbImageList";
            this.lbImageList.Size = new System.Drawing.Size(517, 160);
            this.lbImageList.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 304);
            this.Controls.Add(this.lbImageList);
            this.Controls.Add(this.cmbRatio);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Image Compression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.ComboBox cmbRatio;
        private System.Windows.Forms.ListBox lbImageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

