/*┌─────────────────────────────────────────────────────────────────────────────────────┐
  │                                   Jorge J. Pereda                                   │
  │                                Azure Cloud Developer                                │
  │                                    Jensen - 2023                                    │
  └─────────────────────────────────────────────────────────────────────────────────────┘*/

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

namespace Gruppuppgift
{
    public class Logger
    {

        /*┌─────────────────────────────────┐
          │    List to store log entries    │
          └─────────────────────────────────┘*/
        private List<LogEntry> logEntries;

        /*┌───────────────────────────────────────────┐
          │    Event to notify when a log is added    │
          └───────────────────────────────────────────┘*/
        public event EventHandler<LogAddedEventArgs> LogAdded;

        /*┌───────────────────┐
          │    Constructor    │
          └───────────────────┘*/
        public Logger()
        {

            /*┌──────────────────────────────────────┐
              │    Initialize the logEntries list    │
              └──────────────────────────────────────┘*/
            logEntries = new List<LogEntry>();

        }

        /*┌─────────────────┐
          │    Variables    │
          └─────────────────┘*/
        public class LogEntry
        {

            public DateTime Timestamp { get; set; }
            public string Message { get; set; }

        }

        /*┌────────────────────────────────────┐
          │    Argument when a log is added    │
          └────────────────────────────────────┘*/
        public class LogAddedEventArgs : EventArgs
        {

            public string LogMessage { get; set; }

        }

        /*┌────────────────────────────┐
          │    Method - add logEntry   │
          └────────────────────────────┘*/
        public void AddLogEntry(string message)
        {
            logEntries.Add(new LogEntry
            {

                Timestamp = DateTime.Now,
                Message = message

            });

            /*┌─────────────────────────┐
              │    Trigger the event    │
              └─────────────────────────┘*/
            LogAdded?.Invoke(this, new LogAddedEventArgs { LogMessage = message });

        }

        /*┌────────────────────────────┐
          │    Method - save to .txt   │
          └────────────────────────────┘*/
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

        /*┌──────────────────────┐
          │    Method - getAll   │
          └──────────────────────┘*/
        public List<LogEntry> GetLogEntries()
        {
            return logEntries;
        }


        
    }
}