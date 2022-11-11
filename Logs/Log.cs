using SDETAPI_CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDETAPI_CSharp.Enums.EventTypes;

namespace SDETAPI_CSharp.Logs
{
    /// <summary>
    /// Write a log file
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Add an event to log file
        /// </summary>
        /// <param name="msj">Message to add</param>
        /// <param name="eventToLog">Event occurred</param>
        public static void AddEvent(string msg,LogType eventToLog)
        {
            DateTime time = DateTime.Now;
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\LogEvents.log",true);
            sw.WriteLine(time.Hour.ToString("D2")+":"+ time.Minute.ToString("D2")+ ":" + time.Second.ToString("D2") + ":" + time.Millisecond.ToString("D3") + "  "+  eventToLog.ToString().PadRight(7,' ')+ msg);
            sw.Close();
        }
    }
}
