namespace SanLingMC
{
    partial class SanLingClient
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
            this.btnCon = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadD0 = new System.Windows.Forms.Button();
            this.btnReadD1 = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.richTextMsg = new System.Windows.Forms.RichTextBox();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnCon.Location = new System.Drawing.Point(419, 20);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(116, 46);
            this.btnCon.TabIndex = 7;
            this.btnCon.Text = "连接";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtPort.Location = new System.Drawing.Point(290, 23);
            this.txtPort.MaxLength = 6;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(103, 27);
            this.txtPort.TabIndex = 6;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtIP.Location = new System.Drawing.Point(77, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(141, 27);
            this.txtIP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label2.Location = new System.Drawing.Point(229, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // btnReadD0
            // 
            this.btnReadD0.Enabled = false;
            this.btnReadD0.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnReadD0.Location = new System.Drawing.Point(77, 74);
            this.btnReadD0.Name = "btnReadD0";
            this.btnReadD0.Size = new System.Drawing.Size(116, 46);
            this.btnReadD0.TabIndex = 8;
            this.btnReadD0.Text = "读取D0";
            this.btnReadD0.Click += new System.EventHandler(this.btnReadD0_Click);
            // 
            // btnReadD1
            // 
            this.btnReadD1.Enabled = false;
            this.btnReadD1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnReadD1.Location = new System.Drawing.Point(290, 74);
            this.btnReadD1.Name = "btnReadD1";
            this.btnReadD1.Size = new System.Drawing.Size(116, 46);
            this.btnReadD1.TabIndex = 9;
            this.btnReadD1.Text = "读取D1";
            this.btnReadD1.Click += new System.EventHandler(this.btnReadD1_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnWrite.Location = new System.Drawing.Point(359, 143);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(116, 46);
            this.btnWrite.TabIndex = 10;
            this.btnWrite.Text = "写入";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "写入D0：";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtValue.Location = new System.Drawing.Point(134, 153);
            this.txtValue.MaxLength = 5;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(206, 27);
            this.txtValue.TabIndex = 12;
            this.txtValue.Text = "1";
            // 
            // gbMessage
            // 
            this.gbMessage.BackColor = System.Drawing.Color.Transparent;
            this.gbMessage.Controls.Add(this.richTextMsg);
            this.gbMessage.ForeColor = System.Drawing.Color.Blue;
            this.gbMessage.Location = new System.Drawing.Point(2, 195);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.gbMessage.Size = new System.Drawing.Size(588, 243);
            this.gbMessage.TabIndex = 13;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "信息日志";
            // 
            // richTextMsg
            // 
            this.richTextMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextMsg.Location = new System.Drawing.Point(5, 17);
            this.richTextMsg.Name = "richTextMsg";
            this.richTextMsg.Size = new System.Drawing.Size(578, 221);
            this.richTextMsg.TabIndex = 1;
            this.richTextMsg.Text = "";
            // 
            // SanLingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 443);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnReadD1);
            this.Controls.Add(this.btnReadD0);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SanLingClient";
            this.Text = "SanLingClient";
            this.Load += new System.EventHandler(this.SanLingClient_Load);
            this.gbMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadD0;
        private System.Windows.Forms.Button btnReadD1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox richTextMsg;
    }
}