namespace SanLingMC
{
    partial class TestForm
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.textBoxLen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtIP.Location = new System.Drawing.Point(46, 11);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(141, 27);
            this.txtIP.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtPort.Location = new System.Drawing.Point(259, 9);
            this.txtPort.MaxLength = 6;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(103, 27);
            this.txtPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label2.Location = new System.Drawing.Point(198, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnCon.Location = new System.Drawing.Point(388, 6);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(116, 46);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "连接";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnSend.Location = new System.Drawing.Point(232, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(616, 51);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "写入(输入起始位置+值)";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label3.Location = new System.Drawing.Point(1, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "D起始位置";
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtPoint.Location = new System.Drawing.Point(112, 62);
            this.txtPoint.MaxLength = 5;
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(141, 27);
            this.txtPoint.TabIndex = 2;
            this.txtPoint.Text = "1";
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnRead.Location = new System.Drawing.Point(547, 57);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(301, 53);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "读取(输入起始位置+读取长度)";
            this.btnRead.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBoxLen
            // 
            this.textBoxLen.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.textBoxLen.Location = new System.Drawing.Point(400, 58);
            this.textBoxLen.MaxLength = 5;
            this.textBoxLen.Name = "textBoxLen";
            this.textBoxLen.Size = new System.Drawing.Size(141, 27);
            this.textBoxLen.TabIndex = 3;
            this.textBoxLen.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label4.Location = new System.Drawing.Point(289, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "读取长度";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.textBoxValue.Location = new System.Drawing.Point(232, 145);
            this.textBoxValue.MaxLength = 0;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(616, 27);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "值(写入时候用逗号分隔)";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxLen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC通信测试";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox textBoxLen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label5;
    }
}
