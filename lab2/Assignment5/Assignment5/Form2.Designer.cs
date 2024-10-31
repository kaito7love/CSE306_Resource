namespace Assignment5
{
    partial class Form2
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
            this.btnSend_Server = new System.Windows.Forms.Button();
            this.btnListen_Server = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend_Server
            // 
            this.btnSend_Server.Location = new System.Drawing.Point(479, 99);
            this.btnSend_Server.Name = "btnSend_Server";
            this.btnSend_Server.Size = new System.Drawing.Size(75, 23);
            this.btnSend_Server.TabIndex = 20;
            this.btnSend_Server.Text = "Send";
            this.btnSend_Server.UseVisualStyleBackColor = true;
            this.btnSend_Server.Click += new System.EventHandler(this.btnSend_Server_Click);
            // 
            // btnListen_Server
            // 
            this.btnListen_Server.Location = new System.Drawing.Point(479, 28);
            this.btnListen_Server.Name = "btnListen_Server";
            this.btnListen_Server.Size = new System.Drawing.Size(75, 23);
            this.btnListen_Server.TabIndex = 19;
            this.btnListen_Server.Text = "Listen";
            this.btnListen_Server.UseVisualStyleBackColor = true;
            this.btnListen_Server.Click += new System.EventHandler(this.btnListen_Server_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 244);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(446, 175);
            this.txtContent.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Content";
            // 
            // txtTextSend
            // 
            this.txtTextSend.Location = new System.Drawing.Point(12, 99);
            this.txtTextSend.Multiline = true;
            this.txtTextSend.Name = "txtTextSend";
            this.txtTextSend.Size = new System.Drawing.Size(446, 88);
            this.txtTextSend.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Text";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(284, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 14;
            this.txtPort.Text = "30000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Server Port";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(12, 28);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(200, 22);
            this.txtServerIP.TabIndex = 12;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server IP";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btnSend_Server);
            this.Controls.Add(this.btnListen_Server);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTextSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "TCP-Server Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend_Server;
        private System.Windows.Forms.Button btnListen_Server;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label1;
    }
}