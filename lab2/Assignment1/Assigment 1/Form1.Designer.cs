namespace ChatApp
{
    partial class MainForm
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
            this.txtTextContent = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // txtTextContent
            // 
            this.txtTextContent.Location = new System.Drawing.Point(16, 41);
            this.txtTextContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextContent.Name = "txtTextContent";
            this.txtTextContent.Size = new System.Drawing.Size(315, 22);
            this.txtTextContent.TabIndex = 2;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(359, 41);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(100, 28);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "Browse";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read From File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRead_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save To File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSave_click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(19, 117);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(336, 127);
            this.textBoxContent.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Content";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.txtTextContent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Steam Reader and Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextContent;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label label2;
    }
}

