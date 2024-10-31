namespace Assignment4
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(15, 28);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(379, 22);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://139.180.213.49/getdata.php";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(15, 72);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 22);
            this.txtPara.TabIndex = 3;
            this.txtPara.Text = "type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parameter";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(230, 72);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 5;
            this.txtValue.Text = "all";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 100);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(382, 23);
            this.btnGet.TabIndex = 6;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 145);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(379, 159);
            this.txtContent.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 320);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContent;
    }
}

