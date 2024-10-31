namespace Assignment5
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
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnConnect_Client = new System.Windows.Forms.Button();
            this.btnSend_CLient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(12, 28);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(200, 22);
            this.txtServerIP.TabIndex = 1;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(284, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "30000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text";
            // 
            // txtTextSend
            // 
            this.txtTextSend.Location = new System.Drawing.Point(12, 99);
            this.txtTextSend.Multiline = true;
            this.txtTextSend.Name = "txtTextSend";
            this.txtTextSend.Size = new System.Drawing.Size(446, 88);
            this.txtTextSend.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 244);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(446, 175);
            this.txtContent.TabIndex = 7;
            // 
            // btnConnect_Client
            // 
            this.btnConnect_Client.Location = new System.Drawing.Point(479, 28);
            this.btnConnect_Client.Name = "btnConnect_Client";
            this.btnConnect_Client.Size = new System.Drawing.Size(75, 23);
            this.btnConnect_Client.TabIndex = 9;
            this.btnConnect_Client.Text = "Connect";
            this.btnConnect_Client.UseVisualStyleBackColor = true;
            this.btnConnect_Client.Click += new System.EventHandler(this.btnConnect_Client_Click);
            // 
            // btnSend_CLient
            // 
            this.btnSend_CLient.Location = new System.Drawing.Point(479, 99);
            this.btnSend_CLient.Name = "btnSend_CLient";
            this.btnSend_CLient.Size = new System.Drawing.Size(75, 23);
            this.btnSend_CLient.TabIndex = 10;
            this.btnSend_CLient.Text = "Send";
            this.btnSend_CLient.UseVisualStyleBackColor = true;
            this.btnSend_CLient.Click += new System.EventHandler(this.btnSend_CLient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnSend_CLient);
            this.Controls.Add(this.btnConnect_Client);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTextSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP-Client Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnConnect_Client;
        private System.Windows.Forms.Button btnSend_CLient;
    }
}

