namespace Assignment2
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
            this.txtDomanName = new System.Windows.Forms.TextBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDomanName
            // 
            this.txtDomanName.Location = new System.Drawing.Point(12, 28);
            this.txtDomanName.Name = "txtDomanName";
            this.txtDomanName.Size = new System.Drawing.Size(383, 22);
            this.txtDomanName.TabIndex = 1;
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(426, 28);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 2;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbIP
            // 
            this.lbIP.FormattingEnabled = true;
            this.lbIP.ItemHeight = 16;
            this.lbIP.Location = new System.Drawing.Point(12, 72);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(489, 212);
            this.lbIP.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 305);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.txtDomanName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDomanName;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.ListBox lbIP;
    }
}

