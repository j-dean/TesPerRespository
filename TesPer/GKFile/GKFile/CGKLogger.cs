using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKForm
{
    public enum _eLogType
    {
        Debug,
        Info,
        Error
    }

    public class CGKLogger
    {
        private class LogMessage
        {
            public _eLogType    m_elogtype  = _eLogType.Debug;
            public string       m_strLogmsg = string.Empty;

            public LogMessage(_eLogType eLogType, string strmsg)
            {
                m_elogtype = eLogType;
                m_strLogmsg = strmsg;
            }
        }

        Queue<LogMessage> m_logQueue = new Queue<LogMessage>();
        private object m_writeLock = new object();
        private string m_strFileName = string.Empty;

        public CGKLogger(string strFileName)
        {
            m_strFileName = strFileName;
        }

        public void WriteLog(_eLogType eLogtype, string str, bool bWritenow = false)
        {
            Debug.WriteLine(str);
            m_logQueue.Enqueue(new LogMessage(eLogtype, str));

            if (bWritenow)
            {
                lock(m_writeLock)
                {
                    using (StreamWriter fw = new StreamWriter(m_strFileName, true))
                    {
                        while (m_logQueue.Count > 0)
                        {
                            LogMessage log = m_logQueue.Dequeue();
                            fw.WriteLine(log.m_strLogmsg);
                        }
                    }
                }
            }
        }
    }
}
