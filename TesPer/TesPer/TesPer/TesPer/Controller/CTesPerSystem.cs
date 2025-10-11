using GKFile;
using GKForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static TesPer.CTestSection;

namespace TesPer
{
    public class CTesPerSystem
    {
        public delegate void Delegate_Compared(bool bReuslt , int nCnt);
        public delegate void Delegate_Compare(bool bOK, int nKeyIdx, string strCurrentCpm, List<string> strWpm);
        public delegate void Delegate_SequnceFinish();

        /* ----------------------------------------------------------------------------- */
        // Variable
        /* ----------------------------------------------------------------------------- */
        private CTestSection            m_Testion               = new CTestSection();
        private CEduContent			    m_clsEduContent			= new CEduContent();
        private List<int>               m_listRandomIdxArray    = new List<int>();
        private Stopwatch               m_swWpm                 = new Stopwatch();
  


        private int					    m_nCurrentRandomIdx		= 0;
        private int                     m_QuestionCnt            = 0;

		private int					    m_nOkCnt                = 0;
		private int					    m_nNgCnt                = 0;
		private bool				    m_bRandomChecked		= true;
		private bool				    m_bExamSuccess			= true;
		private string				    m_strCurrentlyPath		= string.Empty;
        private string                  m_strSafeFileName       = string.Empty;
        private Delegate_Compare        m_hCompared             = null;
        private Delegate_SequnceFinish  m_hSequnceFinished      = null;

        private int m_nLogCount = 0;
       
        /* ----------------------------------------------------------------------------- */
        // Properties Function
        /* ----------------------------------------------------------------------------- */
        public CEduContent Data
        {
            get
            {
                return m_clsEduContent;
            }
        }

        public int CurrentIndex
        {
            get
            {
                return m_nCurrentRandomIdx;
            }
        }

        public event Delegate_Compare CompareEvent
        {
            add
            {
                m_hCompared += value;
            }

            remove
            {
                m_hCompared -= value;
            }
        }

        public event Delegate_SequnceFinish SequenceFinishedEvent
        {
            add
            {
                m_hSequnceFinished += value;
            }

            remove
            {
                m_hSequnceFinished -= value;
            }
        }

        public CTesPerSystem()
        {
            //m_tWpmChecker = new CGKTask(WphChecker, 0);
        }

        /* ----------------------------------------------------------------------------- */
        // Event
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Private Method
        /* ----------------------------------------------------------------------------- */
        private bool ReturnIdx(int nIdx , ref int nReturnIdx)
        {
            //int nReturn = 0;

            if (m_bRandomChecked)
            {
                if (nReturnIdx < m_listRandomIdxArray.Count)
                {
                    nReturnIdx = m_listRandomIdxArray[nIdx];
                }
                else
                {
                    return false;
                }
            }
            else
            {
        
                nReturnIdx = nIdx;
            }
            return true;
        }

        private List<int> RandomExtractorVer(int nMaxRandomVal)
        {
            Random clsRandom = new Random();
            List<int> listResult = new List<int>();
            bool[] selected = Enumerable.Repeat<bool>(false , nMaxRandomVal).ToArray<bool>();
            int selectedCnt = 0;


            while (selectedCnt < nMaxRandomVal)
            {
                int nRandomValue = clsRandom.Next(0 , nMaxRandomVal); // 1에서 N-1까지

                while (selected[nRandomValue] == true)
                {
                    nRandomValue = (nRandomValue + 1) % nMaxRandomVal;
                }

                selected[nRandomValue] = true;
                selectedCnt++;

                listResult.Add(nRandomValue);
            }

            return listResult;
        }

        private bool PassesNext(ref int nCurrentRandomIdx)
        {
       
            bool    bRepeat = true;


            while (bRepeat)
            {
                int nRandomVal = 0;
                string strRef = string.Empty;

                //GetData(_eKeyType.Ref , ref strRef);
                if (m_Testion.Data.m_list_clsTestData.Count > nCurrentRandomIdx)
                {
                    ReturnIdx(nCurrentRandomIdx , ref nRandomVal);
                    m_Testion.GetOriginData(_eKeyType.Ref , nRandomVal , ref strRef);

                    if (strRef != "pass")
                    {
                        bRepeat = false;
                    }
                    else
                    {
                        nCurrentRandomIdx++;
                    }
                }
                else
                {
                    nCurrentRandomIdx = nCurrentRandomIdx - 1;
                       bRepeat = false;
                    return false;
                }

             
            }

            return true;
        }

        public bool HighPass(int nPassedIdx)
        {
            if (m_listRandomIdxArray.Count <= nPassedIdx + 1)
            {
                return true;
            }
            else
            {
                m_nCurrentRandomIdx = nPassedIdx;

                //PassesNext();

                return false;
            }
        }

        public bool NextSequence()
        {
            if (m_listRandomIdxArray.Count > m_nCurrentRandomIdx + 1)
            {
                m_nCurrentRandomIdx++;

                PassesNext(ref m_nCurrentRandomIdx);
                return true;
            }
            else
            {
                return false;
            }
        }


        private void LogSave(int nIdx, string strWpm)
        {
            CGKIni clsIniFile = new CGKIni();

            string strLogPath = m_strCurrentlyPath + "Log\\" + m_strSafeFileName + "Log.ini";
            //m_strCurrentlyPath

            if (clsIniFile.Open(strLogPath))
            {
                clsIniFile.WriteInt(_eKeyType.Log.ToString() + "_" + nIdx.ToString() , "count", m_nLogCount + 1);
                clsIniFile.WriteString(_eKeyType.Log.ToString() + "_" + nIdx.ToString() , m_nLogCount.ToString() ,strWpm);

            }
        }

      
        private void LogLoad(int nIdx ,ref List<string> strLogs)
        {
            CGKIni clsIniFile = new CGKIni();

            string strLogPath = m_strCurrentlyPath + "Log\\" + m_strSafeFileName + "Log.ini";
            //m_strCurrentlyPath
            m_nLogCount = 0;
            if (clsIniFile.Open(strLogPath))
            {
                clsIniFile.ReadInt(_eKeyType.Log.ToString() + "_" + nIdx.ToString() ,  "count" ,ref m_nLogCount);

                for (int nCnt = 0 ; nCnt < m_nLogCount ;nCnt++)
                {
                    string strLog = string.Empty;
                    clsIniFile.ReadString(_eKeyType.Log.ToString() + "_" + nIdx.ToString() , nCnt.ToString() , ref strLog);
                    strLogs.Add(strLog);
                }
   
            }
        }

        private void IdxSave(int nIdx)
        {
            CGKIni clsIniFile = new CGKIni();

            string strLogPath = m_strCurrentlyPath + m_strSafeFileName + ".ini";

            if (clsIniFile.Open(strLogPath))
            {
                clsIniFile.WriteInt("Config" ,"Current_Index" , nIdx);
                //clsIniFile.WriteString(_eKeyType.Log.ToString() + "_" + nIdx.ToString() , m_nLogCount.ToString() , strWpm);
            }
        }

        private void SaveTestData(CTestData clsTestData,int nRandomVal)
        {
            CGKIni clsIniFile = new CGKIni();

            string strLogPath = m_strCurrentlyPath + m_strSafeFileName + ".ini";

            if (clsIniFile.Open(strLogPath))
            {
                clsIniFile.WriteString( m_clsEduContent.m_listclsCulCom[0].m_strName , _eKeyType.Eng.ToString() + nRandomVal.ToString() , clsTestData.m_strEnglish);
                clsIniFile.WriteString( m_clsEduContent.m_listclsCulCom[0].m_strName , _eKeyType.Kor.ToString() + nRandomVal.ToString() , clsTestData.m_strKorean);
                clsIniFile.WriteString( m_clsEduContent.m_listclsCulCom[0].m_strName , _eKeyType.Ref.ToString() + nRandomVal.ToString() , clsTestData.m_strReference);
                //clsIniFile.WriteString(_eKeyType.Log.ToString() + "_" + nIdx.ToString() , m_nLogCount.ToString() , strWpm);
            }
        }

        private void SaveReferance()
        {

        }

        /* ----------------------------------------------------------------------------- */
        // Public Function
        /* ----------------------------------------------------------------------------- */
        public bool FileOpen
        (
            string strFileFath ,
            string strSafeFileName ,
            bool bRandom,
            int nIdxOffset,
            int nSectionIdx ,
            int nSectionCnt ,
            ref int nKeyCnt ,
            ref int nCurrentKeyIdx ,
            ref string strDataCnt ,
            ref string strKorean ,
            ref string strHint ,
            ref string strReference ,
            ref string strTimelist,
            ref string[] strTitles,
            ref List<string> strLog
        )
        {
            DirectoryInfo clsCurrentDirInfo = new DirectoryInfo(strFileFath);
            string strCopyPath = clsCurrentDirInfo.Parent.FullName + "\\" + Path.GetFileNameWithoutExtension(strSafeFileName) + "copy.ini";
 
            m_QuestionCnt = nIdxOffset;
            m_nOkCnt = 0;
            m_nNgCnt = 0;

            m_strCurrentlyPath = strFileFath.Replace(strSafeFileName , "");
            m_strSafeFileName = Path.GetFileNameWithoutExtension(strSafeFileName);
            
            m_clsEduContent.LoadData(strFileFath , ref nKeyCnt);

            strTitles = new string[m_clsEduContent.m_listclsCulCom.Count];

            for (int nCnt = 0 ; nCnt < m_clsEduContent.m_listclsCulCom.Count ; nCnt++)
            {
                strTitles[nCnt] = m_clsEduContent.m_listclsCulCom[nCnt].m_strName;
            }

            InitializeSection(m_clsEduContent.m_listclsCulCom[0].m_lastIdx , bRandom, nIdxOffset);

            nCurrentKeyIdx = m_clsEduContent.m_listclsCulCom[0].m_lastIdx;
            LogLoad(nCurrentKeyIdx , ref strLog);
            

            m_swWpm.Start();
            return true;
        }

        public void InitializeSection(int nKeyIdx, bool bRandom, int nIdxOffset)
        {
            int nRandomVal = 0;

            m_nCurrentRandomIdx = nKeyIdx;
            m_bRandomChecked    = bRandom;
            m_Testion.InitialData(m_clsEduContent.m_listclsCulCom[0]);
            m_listRandomIdxArray = RandomExtractorVer(m_clsEduContent.m_listclsCulCom[0].m_list_clsTestData.Count);

            HighPass(m_nCurrentRandomIdx);

            ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);

            PassesNext(ref nRandomVal);
        }

        public void GetData(_eKeyType eKeyType , ref string strValue)
        {
            int nRandomVal = 0;
            string strData = string.Empty;
            int nStandardIdx = m_nCurrentRandomIdx;
            strValue = string.Empty;

            if (m_QuestionCnt == 0)
            {
                ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);
                m_Testion.GetOriginData(eKeyType , nRandomVal , ref strData);
                strValue += strData;
            }
            else
            {
                for (int nOffCnt = 0 ; nOffCnt < m_QuestionCnt ; nOffCnt++)
                {
                    nRandomVal = 0;

                    if (PassesNext(ref nStandardIdx))
                    {
                        ReturnIdx(nStandardIdx , ref nRandomVal);
                        m_Testion.GetOriginData(eKeyType , nRandomVal , ref strData);
                        strValue += strData + " ";
                        nStandardIdx++;
                    }
                    else
                    {
                        break;
                    }
                }

                strValue = strValue.Substring(0 , strValue.Length - 1);
            }
        }

        public void GetData(int nIdx, _eKeyType eKeyType , ref string strValue)
        {
            int nRandomVal = 0;
            ReturnIdx(nIdx , ref nRandomVal);
            m_Testion.GetOriginData(eKeyType , nRandomVal , ref strValue);
        }


        public void SetData(CEduSectionData clsEducationData)
        {
            m_clsEduContent.m_listclsCulCom.Add(clsEducationData);
        }

        public void Modify(CTestData clsTestData)
        {
            int nRandomVal = 0;
            ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);
            SaveTestData(clsTestData, nRandomVal);
            m_Testion.ModifyData(clsTestData, nRandomVal);
        }

        public void Modify(int nCurrentIdx, CTestData clsTestData)
        {
            int nRandomVal = 0;
            ReturnIdx(nCurrentIdx , ref nRandomVal);
            SaveTestData(clsTestData , nRandomVal);
            m_Testion.ModifyData(clsTestData , nRandomVal);
        }

        public void ModifyReference(string strReference)
        {
            int nRandomVal = 0;
            ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);
            string strPath = m_strCurrentlyPath + m_strSafeFileName + ".ini";
            m_Testion.ModifyReference(strPath, nRandomVal, strReference);
        }

        public void TextCoompare(string strSetText,bool bRepeat = false)
        {
            bool bRet = false;
            int nRandomVal = 0;
            ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);

            m_Testion.TextCompare(strSetText , nRandomVal, ref bRet);
            int nCurrentIdx = m_nCurrentRandomIdx;
           
            if (bRet)
            {
                if (bRepeat)
                {
                    Compared(bRet , nCurrentIdx , strSetText.Count());
                }
                else
                {
                    if (NextSequence())
                    {
                        Compared(bRet , m_nCurrentRandomIdx , strSetText.Count());
                    }
                    else
                    {
                        m_hSequnceFinished?.Invoke();
                    }
                }
            }
            else
            {
                m_hCompared?.Invoke(bRet , m_nCurrentRandomIdx , string.Empty, null);
            }
        }

        public void LogTextCompare(string strSetText , bool bRepeat = false)
        {
            bool bRet = false;
            int nRandomVal = 0;
            IdxSave(m_nCurrentRandomIdx);
            ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);
            
            LognTextCompare(strSetText , nRandomVal, ref bRet);

  
            int nCurrentIdx = m_nCurrentRandomIdx;

            if (bRet)
            {
                if (bRepeat)
                {
                    Compared(bRet , nCurrentIdx , strSetText.Count());
                }
                else
                {
                    bool bNext = true;

                    for (int nCnt = 0 ;nCnt < m_QuestionCnt ;nCnt++)
                    {
                        if (! NextSequence())
                        {
                            bNext = false;
                            break;
                        }
                    }
                    if (bNext)
                    {

                        Compared(bRet , m_nCurrentRandomIdx , strSetText.Count());
                    }
                    else
                    {
                        IdxSave(0);
                        m_hSequnceFinished?.Invoke();
                    }
                }
            }
            else
            {
                m_hCompared?.Invoke(bRet , m_nCurrentRandomIdx , string.Empty , null);
            }
        }


        public void LognTextCompare(string strSetText , int nRandomVal , ref bool bResult)
        {
            int nCurrentSection = 0;
            //int nRandomVal      = 0;
            string strCulcomEng = string.Empty;
            string strEngTrim = string.Empty;
            string strTextLower = string.Empty;
            string strEnglish = string.Empty;
            //ReturnIdx(m_nCurrentRandomIdx, ref nRandomVal);

            GetData(_eKeyType.Eng , ref strEnglish);

            strCulcomEng = strEnglish;

            strTextLower = strSetText.ToLower();
       
            strEngTrim = strCulcomEng.ToLower();

            if (strEngTrim.Equals(strTextLower))
            {
                bResult = true;
            }
            else
            {
                if (m_bExamSuccess)
                {
                    //m_clsEducationData.SetData(nRandomVal,_eKeyType.Log, strSetText);
                    //CLog.SaveLog(nRandomVal , strSetText , nRandomVal , nCurrentSection.ToString());
                }

                m_bExamSuccess = false;
                bResult = false;
            }
        }

        private void Compared(bool bComparedOk, int nCurrentIdx, double dbSentenceCnt)
        {
            m_swWpm.Stop();
            List<string> strLog = new List<string>();

            double dbSecond = m_swWpm.Elapsed.Seconds;
            double dbMinute = dbSecond / 60;
            dbMinute += m_swWpm.Elapsed.Minutes;

            //double dbSentenceCnt = strSetText.Count();
            string strCpm = "Wpc " + (dbSentenceCnt / dbMinute).ToString();
            
            LogLoad(nCurrentIdx , ref strLog);

            LogSave(nCurrentIdx , strCpm);

          

            m_hCompared?.Invoke(bComparedOk , nCurrentIdx , strCpm , strLog);
            m_swWpm.Start();
        }

        public void Pass(int nIdx)
        {
            if (HighPass(nIdx))
            {
                m_hSequnceFinished?.Invoke();
            }
            else
            {
                m_hCompared?.Invoke(true , m_nCurrentRandomIdx , string.Empty ,null);
            }
        }

        public void Close()
        {
            m_Testion.Close();
            //m_tWpmChecker.Close();
        }

        /* ----------------------------------------------------------------------------- */
        // Thread Function
        /* ----------------------------------------------------------------------------- */

        //private void WphChecker()
        //{
        //    while (m_tWpmChecker.GetWaitOne())
        //    {
                
        //    }
        //}
    }
}
