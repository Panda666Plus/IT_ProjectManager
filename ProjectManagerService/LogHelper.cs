using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectManagerService
{
   static  class LogHelper
    {
       public static void  writerlog(string message,int eventID=0 )
       {
           try
           {
               if (!EventLog.SourceExists("ProjectManagerService"))
                   EventLog.CreateEventSource("ProjectManagerService", "RunEvent");
               EventLog log = new EventLog();
               log.Source = "ProjectManagerService";
               log.WriteEntry(message , EventLogEntryType.Information,eventID );
           }
          catch ( Exception er)
           {
           }
       }
    }
}
