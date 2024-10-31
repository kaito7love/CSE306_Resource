namespace TCP_Client
{
    partial class s
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
            this.btnChooseAndSend = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnChooseAndSend
            // 
            this.btnChooseAndSend.Location = new System.Drawing.Point(441, 28);
            this.btnChooseAndSend.Name = "btnChooseAndSend";
            this.btnChooseAndSend.Size = new System.Drawing.Size(137, 23);
            this.btnChooseAndSend.TabIndex = 5;
            this.btnChooseAndSend.Text = "Choose and Send file";
            this.btnChooseAndSend.UseVisualStyleBackColor = true;
            this.btnChooseAndSend.Click += new System.EventHandler(this.btnChooseAndSend_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(15, 28);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(407, 22);
            this.txtFilePath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 69);
            this.Controls.Add(this.btnChooseAndSend);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Name = "s";
            this.Text = "TCP - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseAndSend;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

