namespace SanLingPLC
{
    partial class Server
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.richTextMsg = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD0 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.btnCon.Location = new System.Drawing.Point(437, 9);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(116, 33);
            this.btnCon.TabIndex = 7;
            this.btnCon.Text = "开始监听";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtPort.Location = new System.Drawing.Point(301, 12);
            this.txtPort.MaxLength = 6;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(103, 27);
            this.txtPort.TabIndex = 6;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtIP.Location = new System.Drawing.Point(88, 14);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(141, 27);
            this.txtIP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label2.Location = new System.Drawing.Point(240, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbMessage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 381);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gbMessage
            // 
            this.gbMessage.BackColor = System.Drawing.Color.Transparent;
            this.gbMessage.Controls.Add(this.richTextMsg);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessage.ForeColor = System.Drawing.Color.Blue;
            this.gbMessage.Location = new System.Drawing.Point(3, 117);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.gbMessage.Size = new System.Drawing.Size(606, 261);
            this.gbMessage.TabIndex = 10;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "信息日志";
            // 
            // richTextMsg
            // 
            this.richTextMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextMsg.Location = new System.Drawing.Point(5, 17);
            this.richTextMsg.Name = "richTextMsg";
            this.richTextMsg.Size = new System.Drawing.Size(596, 239);
            this.richTextMsg.TabIndex = 1;
            this.richTextMsg.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtD1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtD0);
            this.panel1.Controls.Add(this.btnCon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 108);
            this.panel1.TabIndex = 11;
            // 
            // txtD1
            // 
            this.txtD1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtD1.Location = new System.Drawing.Point(301, 56);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(126, 27);
            this.txtD1.TabIndex = 11;
            this.txtD1.TextChanged += new System.EventHandler(this.txtD1_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label3.Location = new System.Drawing.Point(43, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "D0:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.label4.Location = new System.Drawing.Point(240, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "D1:";
            // 
            // txtD0
            // 
            this.txtD0.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.txtD0.Location = new System.Drawing.Point(88, 56);
            this.txtD0.Name = "txtD0";
            this.txtD0.Size = new System.Drawing.Size(141, 27);
            this.txtD0.TabIndex = 10;
            this.txtD0.TextChanged += new System.EventHandler(this.txtD0_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbMessage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox richTextMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD0;
    }
}

