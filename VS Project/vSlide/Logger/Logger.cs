using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace vSlide
{
    public static class Logger
    {
        private static readonly string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly StringBuilder sb = new StringBuilder();
        private static uint flushBufferSize = 400;
        public static uint FlushBufferSize
        {
            get { return flushBufferSize; }
            set
            {
                flushBufferSize = value;
            }
        }

        public static void Log(string msg)
        {
            sb.Append(msg);
            if (sb.Length >= flushBufferSize) Flush();
        }

        public static void LogLine(string msg)
        {
            Log(msg + '\n');
        }
        
        public static void LogException(Exception e)
        {
            LogLine(e.ToString());
        }

        public static void Flush()
        {
            try
            {
                var msg = sb.ToString();
                sb.Clear();
                Console.WriteLine(msg);
                File.AppendAllText(exePath + "\\" + "log.txt", msg);
            }
            catch (Exception ex)
            {
                throw new LoggingException("", ex);
            }
        }
    }
}
