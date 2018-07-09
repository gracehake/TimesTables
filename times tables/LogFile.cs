using System.IO;

namespace times_tables
{
    public class LogFile
    {
        private readonly string _logFile;

        public LogFile(string logFile)
        {
            _logFile = logFile;
        }
        public void WriteLog(string msg)
        {
            if (!string.IsNullOrEmpty(_logFile))
            {
                using (var file = new StreamWriter(_logFile,true))
                {
                    try
                    {
                        file.WriteLine(msg);
                    }
                    catch
                    {
                        // suppress errors
                    }
                }
            }
        }
    }
}