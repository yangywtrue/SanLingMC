using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Request
{
    public class SanLingPlcRequest
    {
        private PlcRequest conn;

        public SanLingPlcRequest(TcpClient conn)
        {
            this.conn = new PlcRequest(conn);
        }

        public string ReadD0()
        {
            return conn.Read(0, 1);
        }

        public string ReadD1()
        {
            return conn.Read(1, 1);
        }

        public bool WriteD0(string value)
        {
            return conn.Write(0, value) ;
        }
    }
}
