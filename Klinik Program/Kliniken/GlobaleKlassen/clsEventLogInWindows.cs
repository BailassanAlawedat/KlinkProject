using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kliniken
{
   public class clsEventLogInWindows
    {
        private static readonly string Sourcename = "KlinkProgram";

        public enum enEventLogInformation { information = 1, Warning = 2, Fehler = 3}

        public static void LogEvent(enEventLogInformation LogType, string message)
        {
            if(!EventLog.Exists(Sourcename))
            {
                EventLog.CreateEventSource(Sourcename, message);
            }

            switch(LogType)
            {
                case enEventLogInformation.information:
                    EventLog.WriteEntry(Sourcename, message, EventLogEntryType.Information);
                    break;

                case enEventLogInformation.Warning:
                    EventLog.WriteEntry(Sourcename, message, EventLogEntryType.Warning);
                    break;

                case enEventLogInformation.Fehler:
                    EventLog.WriteEntry(Sourcename, message, EventLogEntryType.Error);
                    break;
            }
                
        }
    }
}
