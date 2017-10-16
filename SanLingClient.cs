using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using System.Net.Sockets;
using System.Net;
using Request;

namespace SanLingMC
{
    public partial class SanLingClient : Form
    {
        public SanLingClient()
        {
            InitializeComponent();
        }

        private void SanLingClient_Load(object sender, EventArgs e)
        {
            this.txtIP.Text = Constants.DefaultIP;
            this.txtPort.Text = Constants.DefaultPort;
        }

        TcpClient Client = null;
        SanLingPlcRequest request = null;

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (btnCon.Text == "断开")
            {
                Client.Close();
                Client = null;
                btnCon.Text = "连接";
                btnCon.ForeColor = Color.Black;
                request = null;
                setButtonEnable(false);
                return;
            }
            else
            {
                Client = new TcpClient();

                string IP = txtIP.Text.Trim();
                int PortNum = int.Parse(txtPort.Text.Trim());

                try
                {
                    Client.Connect(IPAddress.Parse(IP), PortNum);
                    btnCon.Text = "断开";
                    btnCon.ForeColor = Color.Red;
                    request = new SanLingPlcRequest(Client);
                    setButtonEnable(true);
                    MessageBox.Show("连接成功！");
                }
                catch (Exception _e)
                {
                    MessageBox.Show("连接失败！\r\n" + _e.Message);
                }
            }
        }

        private void btnReadD0_Click(object sender, EventArgs e)
        {
            LogWrite(request.ReadD0());
        }

        private void btnReadD1_Click(object sender, EventArgs e)
        {
            LogWrite(request.ReadD1());
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string value = this.txtValue.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return;
            }
            LogWrite(request.WriteD0(value).ToString());
        }

        private void setButtonEnable(bool enabled)
        {
            this.btnReadD0.Enabled = enabled;
            this.btnReadD1.Enabled = enabled;
            this.btnWrite.Enabled = enabled;
        }

        private void LogWrite(string str)
        {
            try
            {
                if (richTextMsg.InvokeRequired)
                {
                    richTextMsg.Invoke(new Action<string>(LogWrite), str);
                }
                else
                {
                    if (richTextMsg.Lines.Length % 10000 == 0)
                    {
                        richTextMsg.Clear();
                    }
                    richTextMsg.AppendText(str + "\n");
                    richTextMsg.SelectionStart = richTextMsg.TextLength;
                    richTextMsg.ScrollToCaret();

                }
            }
            catch
            {
            }
        }
    }
}
