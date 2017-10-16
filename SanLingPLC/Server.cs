using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using Server;

namespace SanLingPLC
{
    public partial class Server : Form
    {
        private SanLingDTO sanLing = new SanLingDTO();

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            this.txtIP.Text = Constants.DefaultIP;
            this.txtPort.Text = Constants.DefaultPort;

            this.txtD0.Text = sanLing.Data0;
            this.txtD1.Text = sanLing.Data1;

            //this.txtD0.DataBindings.Add("Text", sanLing, "Data0", false, DataSourceUpdateMode.OnPropertyChanged);
            //this.txtD1.DataBindings.Add("Text", sanLing, "Data1", false, DataSourceUpdateMode.OnPropertyChanged);
            sanLing.SetData0Changed(OnData0Changed);
            sanLing.SetData1Changed(OnData1Changed);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            SanLingController processor = new SanLingController(sanLing);
            ServerSocket server = new ServerSocket(processor);
            server.SetLogEvent(LogWrite);
            server.Listen(this.txtIP.Text, Convert.ToInt16(this.txtPort.Text));

            btnCon.Text = "监听中";
            btnCon.ForeColor = Color.Red;
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

        private void OnData0Changed(string before, string after)
        {
            string format = "Data0 changed from [{0}] to [{1}]";
            LogWrite(string.Format(format, before, after));
            this.txtD0.Invoke(new Action(() =>
            {
                this.txtD0.TextChanged -= txtD0_TextChanged;
                this.txtD0.Text = after;
                this.txtD0.TextChanged += txtD0_TextChanged;
            }));
        }

        private void OnData1Changed(string before, string after)
        {
            string format = "Data1 changed from [{0}] to [{1}]";
            LogWrite(string.Format(format, before, after));
            this.txtD1.Invoke(new Action(() =>
            {
                this.txtD1.TextChanged -= txtD1_TextChanged;
                this.txtD1.Text = after;
                this.txtD1.TextChanged += txtD1_TextChanged;
            }));
        }

        private void txtD0_TextChanged(object sender, EventArgs e)
        {
            this.sanLing.Data0 = this.txtD0.Text.Trim();
        }

        private void txtD1_TextChanged(object sender, EventArgs e)
        {
            this.sanLing.Data1 = this.txtD1.Text.Trim();
        }
    }
}
