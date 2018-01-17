using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAop
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogAttribute : Attribute
    {
        /// <summary>
        /// 日志特性标识
        /// </summary>
        /// <param name="startLog">进方法体打印的字符串</param>
        /// <param name="endLog">出方法体打印的字符串</param>
        public LogAttribute(string startLog, string endLog)
        {
            StartLog = startLog;
            EndLog = endLog;
        }

        public string StartLog;

        public string EndLog;
    }
}
