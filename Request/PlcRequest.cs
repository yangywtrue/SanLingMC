using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using Common;

namespace Request
{
    public class PlcRequest
    {
        //测试用的PLC是 FX3U-32M，带FX3u-ENET-ADP网络模块，MC协议通信
        //注意：本例子PLC上要设置成ASCII方式通信，二进制格式高低位相反

        //01 ff 000a 4420 0000 0000 05 00 
        //01：副标题(批量【读取】的意思)，
        //FF：PC号，
        //000a：监视定时器，
        //4420：44是十六进制的D，20是空白占位符，中间的0000 0000是起始点位号：0，要转换成8位16进制，所以 4420 0000 0000 意思就是从:D0开始
        //05：意思是连续取5个点位，后面的00不用管
        //总体的意思就是从D0～D4成批读出5个(1E结构)

        //03 FF 000A 4420 0000 0000 05 00 1122 3344 5566 7788 99AA 
        //03：副标题(批量【写入】的意思)
        //4420 0000 0000：从D0开始，05 00：写入5个值，分别是：1122 3344 5566 7788 99AA
        //D0～D4成批写入要求(1E结构)

        //本演示例子，每次只写入、读取一个点位

        private TcpClient conn;
        
        public PlcRequest(TcpClient conn)
        {
            this.conn = conn;
        }

        public string Read(int startIndex, int length)
        {
            Byte[] InBuffer = new byte[2 + length * 2];
            Byte[] Buffer = GetReadCMD(startIndex, length);

            conn.GetStream().Write(Buffer, 0, Buffer.Length);

            if (WaitDataAvailable() == false)
            {
                return string.Empty;
            }

            if (conn.GetStream().DataAvailable)
            {
                conn.GetStream().Read(InBuffer, 0, InBuffer.Length);

                if (InBuffer[0] == 0x81 && InBuffer[1] == 0x00)
                {
                    return GetReadValue(InBuffer);
                }
            }

            return string.Empty;
        }

        public bool Write(int startIndex, params string[] setValue)
        {
            Byte[] InBuffer = new byte[12];
            Byte[] Buffer = GetWriteCMD(startIndex, setValue);

            conn.GetStream().Write(Buffer, 0, Buffer.Length);

            if (WaitDataAvailable() == false)
            {
                return false;
            }

            if (conn.GetStream().DataAvailable)
            {
                conn.GetStream().Read(InBuffer, 0, InBuffer.Length);

                if (InBuffer[0] == 0x83 && InBuffer[1] == 0x00)
                {
                    return true;
                }
            }

            return false;
        }

        private Byte[] GetReadCMD(int startIndex, int length)
        {
            //Buffer = new Byte[12] { 0x01, 0xff, 0x0a, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x44, 0x05, 0x00 };
            Byte[] readBuffer = new byte[12];

            readBuffer[0] = 0x01;
            readBuffer[1] = 0xff;

            readBuffer[2] = 0x0a;
            readBuffer[3] = 0x00;
            //-----------------------------------------
            string hexStartPostion = Int2Hex(startIndex).PadLeft(4, '0');
            readBuffer[4] = (byte)Hex2Int(hexStartPostion.Substring(2, 2));
            readBuffer[5] = (byte)Hex2Int(hexStartPostion.Substring(0, 2));

            readBuffer[6] = 0x00;
            readBuffer[7] = 0x00;
            //-----------------------------------------
            readBuffer[8] = 0x20;
            readBuffer[9] = 0x44;

            readBuffer[10] = (byte)length;
            readBuffer[11] = 0x00;
            return readBuffer;
        }

        private Byte[] GetWriteCMD(int startIndex, string[] setValue)
        {
            string[] arrValue = setValue;
            Byte[] writeBuffer = new byte[12 + arrValue.Length * 2];
            writeBuffer[0] = 0x03;
            writeBuffer[1] = 0xff;

            writeBuffer[2] = 0x0a;
            writeBuffer[3] = 0x00;
            //-----------------------------------------
            string hexStartPostion = Int2Hex(startIndex).PadLeft(4, '0');
            writeBuffer[4] = (byte)Hex2Int(hexStartPostion.Substring(2, 2));
            writeBuffer[5] = (byte)Hex2Int(hexStartPostion.Substring(0, 2));

            writeBuffer[6] = 0x00;
            writeBuffer[7] = 0x00;
            //-----------------------------------------
            writeBuffer[8] = 0x20;
            writeBuffer[9] = 0x44;

            writeBuffer[10] = (byte)arrValue.Length;
            writeBuffer[11] = 0x00;
            for (int i = 0; i < arrValue.Length; i++)
            {
                string hexValue = Int2Hex(Convert.ToInt32(arrValue[i])).PadLeft(4, '0');
                writeBuffer[12 + 2 * i] = (byte)Hex2Int(hexValue.Substring(2, 2));
                writeBuffer[12 + 2 * i + 1] = (byte)Hex2Int(hexValue.Substring(0, 2));
            }
            return writeBuffer;
        }

        private string GetReadValue(Byte[] inBuffer)
        {
            string result = String.Empty;
            for (int i = 1; i < inBuffer.Length / 2; i++)
            {
                result = result + Hex2Int(Int2Hex(inBuffer[2 + 2 * (i - 1) + 1]).PadLeft(2, '0') + Int2Hex(inBuffer[2 + 2 * (i - 1)]).PadLeft(2, '0')).ToString() + ",";
            }
            return result.TrimEnd(',');
        }

        private bool WaitDataAvailable()
        {
            return CallWithTimeOut.Invoke(() =>
              {
                  while (!conn.GetStream().DataAvailable)
                  {
                      Thread.Sleep(100);
                  }
              }, 5000);
        }

        private string Int2Hex(int value)
        {
            return Convert.ToString(value, 16);
        }

        private int Hex2Int(string value)
        {
            return Convert.ToInt32(value, 16);
        }
    }
}
