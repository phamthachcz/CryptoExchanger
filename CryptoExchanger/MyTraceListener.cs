using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchanger
{
    class MyTraceListener : TraceListener
    {
        public override void Write(string message)
        {
            using(FileStream fs = new FileStream("mylog.txt", FileMode.Append, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(DateTime.Now.ToString());
                    sw.Write(message);
                }
            }
        }

        public override void WriteLine(string message)
        {
            using (FileStream fs = new FileStream("mylog.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(message);
                }
            }
        }
    }
}
