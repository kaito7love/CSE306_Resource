namespace Asignment2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rbtn_UTF8 = new System.Windows.Forms.RadioButton();
            this.rbtn_Unicode = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected an Encoding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(37, 137);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(263, 22);
            this.txtFilePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(37, 226);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(371, 134);
            this.txtContent.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 169);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Read from a file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReadFromFile);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 369);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save content to file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnWriteToFile);
            // 
            // rbtn_UTF8
            // 
            this.rbtn_UTF8.AutoSize = true;
            this.rbtn_UTF8.Checked = true;
            this.rbtn_UTF8.Location = new System.Drawing.Point(37, 57);
            this.rbtn_UTF8.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_UTF8.Name = "rbtn_UTF8";
            this.rbtn_UTF8.Size = new System.Drawing.Size(62, 20);
            this.rbtn_UTF8.TabIndex = 11;
            this.rbtn_UTF8.TabStop = true;
            this.rbtn_UTF8.Text = "UTF8";
            this.rbtn_UTF8.UseVisualStyleBackColor = true;
            // 
            // rbtn_Unicode
            // 
            this.rbtn_Unicode.AutoSize = true;
            this.rbtn_Unicode.Location = new System.Drawing.Point(37, 85);
            this.rbtn_Unicode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_Unicode.Name = "rbtn_Unicode";
            this.rbtn_Unicode.Size = new System.Drawing.Size(79, 20);
            this.rbtn_Unicode.TabIndex = 12;
            this.rbtn_Unicode.Text = "Unicode";
            this.rbtn_Unicode.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 441);
            this.Controls.Add(this.rbtn_Unicode);
            this.Controls.Add(this.rbtn_UTF8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbtn_UTF8;
        private System.Windows.Forms.RadioButton rbtn_Unicode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

