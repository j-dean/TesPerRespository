using GKFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesPer
{
    internal class CLog
    {
        static public void SaveLog(string strPath ,  string strValue, int nKeyIdx, string strSection)
        {
            CGKIni clsIniFile = new CGKIni();

            if (clsIniFile.Open(strPath))
            {
                int nLogcount = 0;
                clsIniFile.ReadInt(strSection , _eKeyType.LogCount.ToString() + "_" + nKeyIdx.ToString() ,ref nLogcount);
                clsIniFile.WriteInt(strSection , _eKeyType.LogCount.ToString() + "_" + nKeyIdx.ToString() , nLogcount + 1);

                string strKey = _eKeyType.Log.ToString() + "_" + nKeyIdx.ToString() + "_" + (nLogcount).ToString();
                clsIniFile.WriteString(strSection , strKey , strValue);
            }
        }
    }
}
