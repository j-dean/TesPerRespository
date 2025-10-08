using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GKFile
{
    public class CGKIni
    {
		//[DllImport("kernel32")]
		//private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32.dll")]
        private static extern bool WritePrivateProfileString(string section , string key , string value , string filePath);

        [DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		const int DEF_INI_False     = -1;
		private string m_strPath    = string.Empty;
		private bool m_bInitialized = false;

		public bool Open(string strPath)
		{
			string strDirectoryPath = string.Empty;
			DirectoryInfo directory = null;

			m_strPath = strPath;
			m_bInitialized = false;
			strDirectoryPath = Path.GetDirectoryName(strPath);
			directory = new DirectoryInfo(strDirectoryPath);

			try
			{
				if (directory.Exists == false)
				{
					directory.Create();
				}

				//if (!File.Exists(strPath))
				//{
				//	File.Create(strPath);
				//}

				if (File.Exists(strPath))
				{
					

					
				}

                m_bInitialized = true;
                return true;
            }
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}

			m_bInitialized = false;

			return false;
		}


		public void WriteInt(string strSection, string strKey, int nDefaltValue)
		{
			if (m_bInitialized)
			{
				//long aa = ;
			
				if (WritePrivateProfileString(strSection , strKey , nDefaltValue.ToString() , m_strPath))
				{

				}
			}
		}

		public void WriteBool(string strSection, string strKey, bool bDefaltValue)
		{
			if (m_bInitialized)
			{
				//if (WritePrivateProfileString(strSection, strKey, bDefaltValue.ToString(), m_strPath) == DEF_INI_False)
				//{

				//}
			}
		}

		public void WriteFloat(string strSection, string strKey, float fDefaltValue)
		{
			if (m_bInitialized)
			{
				//if (WritePrivateProfileString(strSection, strKey, fDefaltValue.ToString(), m_strPath) == DEF_INI_False)
				//{

				//}
			}
		}


		public void WriteDouble(string strSection, string strKey, double dbDefaltValue)
		{
			if (m_bInitialized)
			{
				//if (WritePrivateProfileString(strSection, strKey, dbDefaltValue.ToString(), m_strPath) == DEF_INI_False)
				//{

				//}
			}
		}


		public void WriteString(string strSection, string strKey, string strValue)
		{
			if (m_bInitialized)
			{
                //long nReturn = ;
				
             
			}

            try
            {
                if (WritePrivateProfileString(strSection , strKey , strValue , m_strPath))
                {
                    if (strValue == string.Empty)
                    {
                        strValue = "Default";
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Assert(false , ex.Message);
            }
        }


		public void WriteEnum(string strSection, string strKey, Enum strValue) 
		{
			if (m_bInitialized)
			{
				//strValue
				//if (WritePrivateProfileString(strSection, strKey, strValue.ToString(), m_strPath) == DEF_INI_False)
				//{
				//	if (strValue.ToString() == string.Empty)
				//	{
				//		//strValue
				//	}
				//}
			}
		}


		public bool ReadEnum<TEnum>(string strSection, string strKey, ref TEnum strDefaltValue) where TEnum: struct
		{
			bool			bReturn = false;
			StringBuilder	clsSBvalue = new StringBuilder(1000);
			TEnum eDefaltValue = strDefaltValue;

			if (m_bInitialized)
			{
				if (DEF_INI_False != GetPrivateProfileString(strSection, strKey, strDefaltValue.ToString(), clsSBvalue, 1000, m_strPath))
				{
					//if (clsSBvalue.ToString().Equals("MatcherInspection"))
					//{
					//	string strtemp = "Matcher";
					//	strDefaltValue = (TEnum)Enum.Parse(typeof(TEnum), strtemp.ToString());
					//}
					//else if (clsSBvalue.ToString().Equals("PointInspection"))
					//{
					//	string strtemp = "Point";
					//	strDefaltValue = (TEnum)Enum.Parse(typeof(TEnum), strtemp.ToString());
					//}
					//else
					//{
					//	strDefaltValue = (TEnum)Enum.Parse(typeof(TEnum), clsSBvalue.ToString());
					//}

					//strDefaltValue = (TEnum)Enum.Parse(typeof(TEnum), clsSBvalue.ToString());

					//strDefaltValue = (TEnum)Enum.Parse(typeof(TEnum), clsSBvalue.ToString());

					if (Enum.TryParse(clsSBvalue.ToString(), out strDefaltValue))
					{
						bReturn = true;
						//strDefaltValue = eDefaltValue;
					}
					else
					{
						strDefaltValue = eDefaltValue;
						bReturn = false;
					}
					//bReturn = Enum.TryParse(clsSBvalue.ToString(), out strDefaltValue);

				
				}
			}

			return bReturn;
		}


		public void ReadBool(string strSection, string strKey, ref bool bDefaltValue)
		{
			StringBuilder clsSBvalue = new StringBuilder();

			if (m_bInitialized)
			{
				GetPrivateProfileString(strSection, strKey, bDefaltValue.ToString(), clsSBvalue, 32, m_strPath);
				bDefaltValue = bool.Parse(clsSBvalue.ToString());

			}
		}


		public void ReadInt(string strSection, string strKey, ref int nReturn)
		{
			StringBuilder clsSBvalue = new StringBuilder();
			
			if (m_bInitialized)
			{
				int result = GetPrivateProfileString(strSection, strKey, nReturn.ToString(), clsSBvalue, 32, m_strPath);

				nReturn = int.Parse(clsSBvalue.ToString());
				if (DEF_INI_False != result)
				{

				}
			}

		}


		public void ReadFloat(string strSection, string strKey, ref float dbReturn)
		{
			StringBuilder clsSBvalue = new StringBuilder();

			if (m_bInitialized)
			{
				if (DEF_INI_False != GetPrivateProfileString(strSection, strKey, dbReturn.ToString(), clsSBvalue, 32, m_strPath))
				{
					dbReturn = float.Parse(clsSBvalue.ToString());
				}
			}

		}

		public void ReadDouble(string strSection, string strKey, ref double dbReturn)
		{
			StringBuilder clsSBvalue = new StringBuilder();

			if (m_bInitialized)
			{
				if (DEF_INI_False != GetPrivateProfileString(strSection, strKey, dbReturn.ToString(), clsSBvalue, 32, m_strPath))
				{
					dbReturn = double.Parse(clsSBvalue.ToString());
				}
			}

		}


		public void ReadString(string strSection, string strKey, ref string strDefaltValue)
		{
			StringBuilder clsSBvalue = new StringBuilder(1000);

			if (m_bInitialized)
			{
				if (DEF_INI_False != GetPrivateProfileString(strSection, strKey, strDefaltValue, clsSBvalue, 1000, m_strPath))
				{
					strDefaltValue = clsSBvalue.ToString();

				}
			}
		}

	}
}
