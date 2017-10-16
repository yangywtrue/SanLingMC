using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Server
{
    public class SanLingController
    {
        private SanLingDTO sanLing;

        public SanLingController(SanLingDTO dto)
        {
            this.sanLing = dto;
        }

        public void Receive(Socket conn, List<string> data)
        {
            if (data[0] == "01" && data[1] == "ff")
            {
                if (data[4] == "00")
                {
                    conn.Send(GetReadValue(sanLing.Data0));
                }
                if (data[4] == "01")
                {
                    conn.Send(GetReadValue(sanLing.Data1));
                }
            }

            if (data[0] == "03" && data[1] == "ff")
            {
                int startIndex = Convert.ToInt16(data[5] + data[4]);
                for (int i = 12; i < data.Count; i = i + 2)
                {
                    string value = Convert.ToInt32(data[i + 1] + data[i]).ToString();

                    SetWriteValue(startIndex, value);
                    startIndex++;
                }
            }
        }

        private byte[] GetReadValue(string data)
        {
            Byte[] readBuffer = new byte[4];

            readBuffer[0] = 0x81;
            readBuffer[1] = 0x00;

            //-----------------------------------------
            string hexStartPostion = data.PadLeft(4, '0');
            readBuffer[2] = (byte)Hex2Int(hexStartPostion.Substring(2, 2));
            readBuffer[3] = (byte)Hex2Int(hexStartPostion.Substring(0, 2));
            return readBuffer;
        }

        private void SetWriteValue(int index, string data)
        {
            this.sanLing.Data0 = data;
        }

        private int Hex2Int(string value)
        {
            return Convert.ToInt32(value, 16);
        }
    }
}
