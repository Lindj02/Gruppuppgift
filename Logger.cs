///////////////////////////////////////////////////////////////////////////////
//////////////////////////// Jorge Jonathan Pereda ////////////////////////////
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

namespace Gruppuppgift
{
    public class Logger
    {
        private List<LogEntry> logEntries;

        public event EventHandler<LogAddedEventArgs> LogAdded;

        public Logger()
        {
            logEntries = new List<LogEntry>();
        }

        public class LogEntry
        {

            public DateTime Timestamp { get; set; }
            public string Message { get; set; }

        }

        public class LogAddedEventArgs : EventArgs
        {

            public string LogMessage { get; set; }

        }


        public void AddLogEntry(string message)
        {
            logEntries.Add(new LogEntry
            {

                Timestamp = DateTime.Now,
                Message = message

            });

            // Trigger the event
            LogAdded?.Invoke(this, new LogAddedEventArgs { LogMessage = message });

        }

        public void SaveLogsToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var entry in logEntries)
                    {
                        string formattedTimestamp = entry.Timestamp.ToString("yyyy-MM-dd HH:mm");
                        writer.WriteLine($"{{ \"timestamp\": \"{formattedTimestamp}\", \"message\": \"{entry.Message}\" }}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing log file: {ex.Message}");
            }
        }

        public List<LogEntry> GetLogEntries()
        {
            return logEntries;
        }


        
    }
}