using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

namespace Gruppuppgift
{
    public class Logger
    {
        private Dictionary<string, string> errorMessages = new Dictionary<string, string>
        {

            { "error_001", "Error: You need to use 'a', 'b', 'c' and not '#' or '$" },
            { "error_002", "" },
            { "error_003", "" },
            { "error_004", "" },
            { "error_005", "" },
            { "error_006", "" },
            { "error_007", "" },
            { "error_008", "" },
            { "error_009", "" },
            { "error_010", "" }
            /*┌───────────────────────────────────────────────────┐
              │    Add more error codes and messages as needed    │
              └───────────────────────────────────────────────────┘*/

        };

            private Dictionary<string, string> successMessages = new Dictionary<string, string>
        {

            { "success_001", "Receptet har uppdaterats!" },
            { "success_002", "Ett nytt recept har lagts till!" },
            /*┌─────────────────────────────────────────────────────┐
              │    Add more success codes and messages as needed    │
              └─────────────────────────────────────────────────────┘*/

        };

        public string GetErrorMessage(string errorCode)
        {

            if (errorMessages.TryGetValue(errorCode, out string errorMessage))
            {

                return errorMessage;

            }

            return null; // Handle the case where the error code is not found

        }

        public string GetSuccessMessage(string successCode)
        {

            if (successMessages.TryGetValue(successCode, out string successMessage))
            {

                return successMessage;

            }

            return null; // Handle the case where the success code is not found

        }


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