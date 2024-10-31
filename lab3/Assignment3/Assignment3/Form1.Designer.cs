namespace Assignment3
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
            this.btnGet_Click = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtURL.Size = new System.Drawing.Size(443, 22);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://eiu.edu.vn/";
            // 
            // btnGet_Click
            // 
            this.btnGet_Click.Location = new System.Drawing.Point(464, 28);
            this.btnGet_Click.Name = "btnGet_Click";
            this.btnGet_Click.Size = new System.Drawing.Size(75, 23);
            this.btnGet_Click.TabIndex = 2;
            this.btnGet_Click.Text = "Get";
            this.btnGet_Click.UseVisualStyleBackColor = true;
            this.btnGet_Click.Click += new System.EventHandler(this.btnGet_Click_ClickAsync);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(15, 88);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(524, 227);
            this.txtContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Content";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnGet_Click);
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
        private System.Windows.Forms.Button btnGet_Click;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
    }
}

