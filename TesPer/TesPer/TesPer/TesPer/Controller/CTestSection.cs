//using GKSound;
using GKFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static TesPer.CTestSection;

namespace TesPer
{
	public class CTestSection
	{
	
		/* ----------------------------------------------------------------------------- */
		// App 
		/* ----------------------------------------------------------------------------- */
		//public delegate void Delegate_VerifyAnswer(bool bReuslt, int nCnt);
		public delegate void Delegate_NotPassed(string strEnglish);
		
	
		/* ----------------------------------------------------------------------------- */
		// Definitions 
		/* ----------------------------------------------------------------------------- */
		

		/* ----------------------------------------------------------------------------- */
		// Enum 
		/* ----------------------------------------------------------------------------- */


		/* ----------------------------------------------------------------------------- */
		// Struct 
		/* ----------------------------------------------------------------------------- */
		


		/* ----------------------------------------------------------------------------- */
		// Class 
		/* ----------------------------------------------------------------------------- */
	


		/* ----------------------------------------------------------------------------- */
		// Variable
		/* ----------------------------------------------------------------------------- */
	
        private CEduSectionData			m_clsEduSectionData		= new CEduSectionData();
       

		//private int						m_nCurrentRandomIdx		= 0;
		private int						m_nOkCnt                = 0;
		private int						m_nNgCnt                = 0;
		//private bool					m_bRandomChecked		= true;
		private bool					m_bIsCopare				= false;
		private bool					m_bExamSuccess			= true;
		private bool					m_bTypingPractice		= false;
		private bool					m_bShownEnglish			= false;
		private string					m_strCurrentlyPath		= string.Empty;

		//private Delegate_VerifyAnswer	m_hVerifyAnswerEvent = null;
		private Delegate_NotPassed		m_hNotPassedEvent = null;
	

		/* ----------------------------------------------------------------------------- */
		// Properties Function
		/* ----------------------------------------------------------------------------- */

		//public bool RandomChecked
		//{
		//	get
		//	{
		//		return m_bRandomChecked;
		//	}
		//	set
		//	{
		//		m_bRandomChecked = value;
		//	}
		//}


		public bool TypingTest
		{
			set
			{
				m_bTypingPractice = value;
			}
		}

		public string CurrentPath
		{
			get
			{
				return m_strCurrentlyPath;
			}
		}
		
	

		public CEduSectionData Data
		{
			get
			{
				return m_clsEduSectionData;
            }
		}

        /* ----------------------------------------------------------------------------- */
        // Singleton
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Constructor
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // InitInstance
        /* ----------------------------------------------------------------------------- */
        public void Close()
		{
			//m_clsEducationData.Close();
		}
		


		/* ----------------------------------------------------------------------------- */
		// Event
		/* ----------------------------------------------------------------------------- */
		

		public event Delegate_NotPassed NotPassed
		{
			add
			{
				m_hNotPassedEvent += value;
			}

			remove
			{
				m_hNotPassedEvent -= value;
			}
		}



	
		
	


		/* ----------------------------------------------------------------------------- */
		// Private Function
		/* ----------------------------------------------------------------------------- */

	

	
     

        /* ----------------------------------------------------------------------------- */
        // Protected Function
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Public Function
        /* ----------------------------------------------------------------------------- */
      

		public void InitialData(CEduSectionData clsEducationData)
		{
            m_clsEduSectionData = clsEducationData;
            //m_listRandomIdxArray = RandomExtractorVer(m_clsEduSectionData.m_list_clsTestData.Count);

            int nRandomVal = 0;

            //ReturnIdx(m_nCurrentRandomIdx , ref nRandomVal);
	
        }


        public void NextQuestion()
		{
			if (m_bExamSuccess)
			{
				m_nOkCnt++;
	
			}
			else
			{
				m_nNgCnt++;
			
			}

			m_bExamSuccess = true;
		}


		public void TextCompare(string strSetText, int nRandomVal  ,ref bool bResult)
		{
			int nCurrentSection = 0;
			//int nRandomVal      = 0;
			string strCulcomEng = string.Empty;
			string strEngTrim   = string.Empty;
            string strTextLower = string.Empty;

            m_bIsCopare = true;
			//ReturnIdx(m_nCurrentRandomIdx, ref nRandomVal);

            strCulcomEng = m_clsEduSectionData.m_list_clsTestData[nRandomVal].m_strEnglish;

            strTextLower	= strSetText.ToLower();
			strTextLower	= strTextLower.Trim();
			strEngTrim		= strCulcomEng.ToLower();

			if (strEngTrim.Equals(strTextLower))
			{
				bResult = true;

				NextQuestion();
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

	
		public void ModifyData(CTestData clsTestData, int nRandomVal)
        {
			m_clsEduSectionData.m_list_clsTestData[nRandomVal] = clsTestData;
        }

        public void ModifyReference(string strPath, int nRandomVal , string strReference)
        {
            m_clsEduSectionData.m_list_clsTestData[nRandomVal].m_strReference = strReference;

			CGKIni clsIniFile = new CGKIni();
           

            if (clsIniFile.Open(strPath))
            {
                clsIniFile.WriteString(m_clsEduSectionData.m_strName , _eKeyType.Ref.ToString() + nRandomVal.ToString() , strReference);
            }
        }

		public void GetOriginData(_eKeyType eKeyType ,int nCurrentIdx, ref string strValue)
        {
            if (eKeyType == _eKeyType.Eng)
            {
                strValue = m_clsEduSectionData.m_list_clsTestData[nCurrentIdx].m_strEnglish;
            }
            else if (eKeyType == _eKeyType.Kor)
            {
                strValue = m_clsEduSectionData.m_list_clsTestData[nCurrentIdx].m_strKorean;
            }
            else if (eKeyType == _eKeyType.Ref)
            {
                strValue = m_clsEduSectionData.m_list_clsTestData[nCurrentIdx].m_strReference;
            }
            else if (eKeyType == _eKeyType.Hint)
            {
                strValue = m_clsEduSectionData.m_strHint;
            }
        }
        /* ----------------------------------------------------------------------------- */
        // Thread Function
        /* ----------------------------------------------------------------------------- */



    }
}
