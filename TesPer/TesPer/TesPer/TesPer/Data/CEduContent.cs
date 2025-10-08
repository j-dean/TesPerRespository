using GKFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesPer
{
    public enum _eKeyType
    {
        Kor = 0,
        Eng = 1,
        Hint = 2,
        Ref = 3,
        LogCount = 4,
        Log = 5,
        
        KeyCount = 111,
        Grobal = 11,
        FinishTime = 12,
        FinishCount = 13,
        End
    }


    public class CEduContent
    {
        const string DEF_STRING_VALUE = "default";
        const string DEF_STRING_Info = "Config";

        /* ----------------------------------------------------------------------------- */
        // Enum 
        /* ----------------------------------------------------------------------------- */


        /* ----------------------------------------------------------------------------- */
        // Variable
        /* ----------------------------------------------------------------------------- */
        public List<CEduSectionData> m_listclsCulCom = new List<CEduSectionData>();
        //private string				m_strSoundFileName	= string.Empty;
        //private CSound				m_clsSound			= new CSound();	

        private int nTotalCnt = 0;
        private string m_strFileName = string.Empty;
        //private string m_strSoundPath = string.Empty;
        private string m_strMainIniPath = string.Empty;
        private string m_strChildIniPath = string.Empty;
        private string m_strHintPath = string.Empty;
        private string m_strLogPath = string.Empty;

        /* ----------------------------------------------------------------------------- */
        // Properties Function
        /* ----------------------------------------------------------------------------- */
        public int CulcomDataCount
        {
            get
            {
                return 10;
            }
        }

        public void SaveData(string strPath )
        {
            CGKIni clsIniFile = new CGKIni();
   
            try
            {
                if (clsIniFile.Open(strPath))
                {

                    clsIniFile.WriteInt(DEF_STRING_Info , "SectionCount" , m_listclsCulCom.Count);


                    for (int nCnt = 0 ; nCnt < m_listclsCulCom.Count ; nCnt++)
                    {
                        clsIniFile.WriteString(DEF_STRING_Info , "SectionName" + nCnt.ToString() , m_listclsCulCom[nCnt].m_strName);

                        clsIniFile.WriteInt(m_listclsCulCom[nCnt].m_strName , _eKeyType.KeyCount.ToString() , m_listclsCulCom[nCnt].m_list_clsTestData.Count);
                        clsIniFile.WriteString(m_listclsCulCom[nCnt].m_strName , _eKeyType.Hint.ToString() ,  m_listclsCulCom[nCnt].m_strHint);

                        for (int nValueCnt = 0 ; nValueCnt < m_listclsCulCom[nCnt].m_list_clsTestData.Count ; nValueCnt++)
                        {
                        
                            CTestData clsTestData = m_listclsCulCom[nCnt].m_list_clsTestData[nValueCnt];

                            string strKorea = clsTestData.m_strKorean.Replace("\n" , " ");

                            clsIniFile.WriteString(m_listclsCulCom[nCnt].m_strName , _eKeyType.Eng.ToString() + nValueCnt.ToString() , clsTestData.m_strEnglish);
                            clsIniFile.WriteString(m_listclsCulCom[nCnt].m_strName , _eKeyType.Kor.ToString() + nValueCnt.ToString() , strKorea);
                            clsIniFile.WriteString(m_listclsCulCom[nCnt].m_strName , _eKeyType.Ref.ToString() + nValueCnt.ToString() , clsTestData.m_strReference);
                        }
                    }
                }

                //bReturn = true;
            }
            catch (Exception ex)
            {
                //bReturn = false;
            }
        }

        public bool LoadData(string strPath, ref int nKeyCnt)
        {
            //bool bReturn = false;



            //CGKIni clsIniFile = new CGKIni();
            //int nSectionCnt = 0;
            //int nlastIdx = 0;
            //nTotalCnt = 0;

            //try
            //{
            //    if (clsIniFile.Open(strPath))
            //    {
            //        m_listclsCulCom.Clear();

            //        clsIniFile.ReadInt(DEF_STRING_Info , "SectionCount" , ref nSectionCnt);

            //        for (int nCnt = 0 ; nCnt < nSectionCnt ; nCnt++)
            //        {
            //            CEduSectionData clsEduSectionData = new CEduSectionData();

            //            clsIniFile.ReadString(DEF_STRING_Info , "SectionName" + nCnt.ToString() , ref clsEduSectionData.m_strName);
            //            clsIniFile.ReadInt(DEF_STRING_Info , "Current_Index" , ref nlastIdx);
            //            clsIniFile.ReadInt(clsEduSectionData.m_strName , _eKeyType.KeyCount.ToString() , ref nKeyCnt);
            //            clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Hint.ToString() , ref clsEduSectionData.m_strHint);

            //            for (int nValueCnt = 0 ; nValueCnt < nKeyCnt ; nValueCnt++)
            //            {
            //                CTestData clsTestData = new CTestData();

            //                clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Eng.ToString() + nValueCnt.ToString() , ref clsTestData.m_strEnglish);
            //                clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Ref.ToString() + nValueCnt.ToString() , ref clsTestData.m_strReference);
            //                clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Kor.ToString() + nValueCnt.ToString() , ref clsTestData.m_strKorean);

            //                clsEduSectionData.m_list_clsTestData.Add(clsTestData);

            //                nTotalCnt++;
            //            }

            //            clsEduSectionData.m_lastIdx = nlastIdx;
            //            m_listclsCulCom.Add(clsEduSectionData);
            //        }
            //    }


            //    bReturn = true;
            //}
            //catch (Exception ex)
            //{
            //    bReturn = false;
            //}

            //return bReturn;


            bool bReturn = false;



            //CGKIni clsIniFile = new CGKIni();
            CEduSectionData clsEduSectionData = new CEduSectionData();
            int nSectionCnt = 0;
            int nlastIdx = 0;
            nTotalCnt = 0;

            try
            {
                DataTable dTblInspection = new DataTable();
                DataTable dTblInspection2 = new DataTable();
                CPnExcel.XlsxRead(strPath ,1, ref dTblInspection);
                CPnExcel.XlsxRead(strPath , 2 , ref dTblInspection2);



                //DataRow row2 = dTblInspection2.Rows[0];
                int RowIdx = 0;

                foreach (DataRow row in dTblInspection.Rows)
                {

                    if (RowIdx == 0)
                    {
                        //RowIdx[]
                        //clsEduSectionData.m_strHint = 
                    }    
                    else 
                    {
                        CTestData clsTestData = new CTestData();


                        clsTestData.m_strEnglish = row[0].ToString();


                        clsTestData.m_strKorean = row[1].ToString();
                        clsTestData.m_strReference = row[2].ToString();

                        int nLogCnt = 0;
                        int.TryParse(row[3].ToString() , out nLogCnt);


                        for (int nLogIdx = 0 ; nLogIdx < nLogCnt ; nLogIdx++)
                        {
                            clsTestData._Log.Add(row[nLogIdx +4].ToString());
                        }
                      
                        clsEduSectionData.m_list_clsTestData.Add(clsTestData);
                    }


                    RowIdx++;

                }

                m_listclsCulCom.Add(clsEduSectionData);
                             //if (clsIniFile.Open(strPath))
                             //{
                             //    m_listclsCulCom.Clear();

                             //    clsIniFile.ReadInt(DEF_STRING_Info , "SectionCount" , ref nSectionCnt);

                             //    for (int nCnt = 0 ; nCnt < nSectionCnt ; nCnt++)
                             //    {
                             //        CEduSectionData clsEduSectionData = new CEduSectionData();

                             //        clsIniFile.ReadString(DEF_STRING_Info , "SectionName" + nCnt.ToString() , ref clsEduSectionData.m_strName);
                             //        clsIniFile.ReadInt(DEF_STRING_Info , "Current_Index" , ref nlastIdx);
                             //        clsIniFile.ReadInt(clsEduSectionData.m_strName , _eKeyType.KeyCount.ToString() , ref nKeyCnt);
                             //        clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Hint.ToString() , ref clsEduSectionData.m_strHint);

                             //        for (int nValueCnt = 0 ; nValueCnt < nKeyCnt ; nValueCnt++)
                             //        {
                             //            CTestData clsTestData = new CTestData();

                             //            clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Eng.ToString() + nValueCnt.ToString() , ref clsTestData.m_strEnglish);
                             //            clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Ref.ToString() + nValueCnt.ToString() , ref clsTestData.m_strReference);
                             //            clsIniFile.ReadString(clsEduSectionData.m_strName , _eKeyType.Kor.ToString() + nValueCnt.ToString() , ref clsTestData.m_strKorean);

                             //            clsEduSectionData.m_list_clsTestData.Add(clsTestData);

                             //            nTotalCnt++;
                             //        }

                             //        clsEduSectionData.m_lastIdx = nlastIdx;
                             //        m_listclsCulCom.Add(clsEduSectionData);
                             //    }
                             //}


                             bReturn = true;
            }
            catch (Exception ex)
            {
                bReturn = false;
            }

            return bReturn;

        }
    }
}
