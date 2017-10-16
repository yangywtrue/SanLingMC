using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Common;

namespace Server
{
    public class ServerSocket
    {
        private Socket server;
        private IPAddress address;
        private SanLingController processor;
        private static Object _LockObj = new Object();
        private Action<string> onLog;

        public ServerSocket(SanLingController processor)
        {
            this.processor = processor;
            this.onLog = (str) => { };
        }

        public void SetLogEvent(Action<string> func)
        {
            this.onLog = func;
        }

        public void Listen(string ip, int port)
        {
            address = IPAddress.Parse(ip);

            IPEndPoint endPointIPV4 = new IPEndPoint(IPAddress.Any, port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(endPointIPV4);
            server.Listen(0);
            //创建一个线程监客户端连接请求
            Thread listenThreadIPV4 = new Thread(ListenConnect);
            listenThreadIPV4.IsBackground = true;
            listenThreadIPV4.Start();
        }

        private void ListenConnect()
        {
            try
            {
                while (true)
                {
                    Socket client = server.Accept();
                    Thread thread = new Thread(ClientService);
                    thread.IsBackground = true;
                    thread.Start(client);
                }
            }
            catch (Exception ex)
            {
                lock (_LockObj)
                {

                    if (server != null)
                    {
                        server.Close();
                        server.Dispose();
                        server = null;
                    }
                }
            }
        }

        public void ClientService(object client)
        {
            Socket connection = (Socket)client;

            //connection.ReceiveTimeout = 5000;
            //connection.SendTimeout = 5000;
            //接收来自客户端的消息，Receive不断等待

            try
            {
                while (true)
                {
                    if (connection == null || connection.Connected == false)
                    {
                        break;
                    }

                    List<string> cmd = ReadOneCmd(connection);
                    Log(cmd);
                    processor.Receive(connection, cmd);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //关闭套接字
                connection.Close();
                connection.Dispose();
            }
        }

        private List<string> ReadOneCmd(Socket connection)
        {
            byte[] array = new byte[128];
            int length = connection.Receive(array, SocketFlags.None);
            return array.Take(length).Select(i =>
            {
                int num = (int)i;
                return Convert.ToString(num, 16).PadLeft(2, '0');
            }).ToList<string>();
        }

        private void Log(List<string> data)
        {
            string message = string.Join(" ", data);
            string format = "Receive {0} : {1}";
            onLog(string.Format(format, DateTime.Now.ToString("HH:mm:ss"), message));
        }
    }
}
