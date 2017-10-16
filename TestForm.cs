using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using Common;
using System.Threading.Tasks;
using Request;

namespace SanLingMC
{
    public partial class TestForm : System.Windows.Forms.Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.txtIP.Text = Constants.DefaultIP;
            this.txtPort.Text = Constants.DefaultPort;
        }

        TcpClient Client = null;

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (btnCon.Text == "断开")
            {
                Client.Close();
                Client = null;
                btnCon.Text = "连接";
                btnCon.ForeColor = Color.Black;
                btnSend.Enabled = false;
                btnRead.Enabled = false;
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
                    btnSend.Enabled = true;
                    btnRead.Enabled = true;

                    MessageBox.Show("连接成功！");
                }
                catch (Exception _e)
                {
                    MessageBox.Show("连接失败！\r\n" + _e.Message);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Client.Connected)
                {
                    MessageBox.Show("连接已断开！");
                    btnCon_Click(null, null);
                    return;
                }

                Task.Factory.StartNew(() =>
                {
                    bool isRead = ((Button)sender).Name == "btnRead";

                    PlcRequest plc = new PlcRequest(Client);

                    if (isRead)
                    {
                        textBoxValue.Text = plc.Read(Convert.ToInt32(txtPoint.Text.Trim()), Convert.ToInt32(textBoxLen.Text.Trim()));
                    }
                    else
                    {
                        if (plc.Write(Convert.ToInt32(txtPoint.Text.Trim()), textBoxValue.Text.Trim().Split(',')))
                        {
                            MessageBox.Show("Write successfully.");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("[{0}]\n[{1}]", ex.Message, ex.StackTrace));
            }
        }
    }
}
