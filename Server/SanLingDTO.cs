using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    public class SanLingDTO
    {
        public List<string> Data;

        private Action<string, string> onData0Changed = (s1, s2) => { };
        private Action<string, string> onData1Changed = (s1, s2) => { };

        public string Data0
        {
            get { return Data[0]; }
            set {
                onData0Changed(Data[0], value);
                Data[0] = value;
            }
        }

        public string Data1
        {
            get { return Data[1]; }
            set
            {
                onData1Changed(Data[1], value);
                Data[1] = value;
            }
        }

        public SanLingDTO()
        {
            Data = new List<string>();
            Data.Add("0");
            Data.Add("0");
        }


        public void SetData0Changed(Action<string, string> func)
        {
            this.onData0Changed = func;
        }

        public void SetData1Changed(Action<string, string> func)
        {
            this.onData1Changed = func;
        }
    }
}
