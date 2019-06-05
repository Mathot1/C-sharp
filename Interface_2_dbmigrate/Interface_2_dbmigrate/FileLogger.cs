using System.IO;

namespace Interface_2_dbmigrate
{
    public class FileLogger : Ilogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error: ");
        }
        public void LogInfo(string message)
        {
            Log(message, "Info: ");
        }
        private void Log(string message, string messageType)
        {
            var streamWriter = new StreamWriter(_path, true);
            streamWriter.WriteLine(messageType + message);
        }
    }
}
