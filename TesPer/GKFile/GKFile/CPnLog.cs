using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKFile
{
	public class CPnLog
	{
		private string		m_strPath = string.Empty;
		private bool		m_bInitialized = false;
		private string		m_strValue = string.Empty;
		private StreamWriter writer;
		private StreamReader SR;
		private bool		m_bWrite = true;


		private bool Open(string strPath)
		{
			string strDirectoryPath = string.Empty;
			DirectoryInfo directory = null;

			m_strPath = strPath;
			m_bInitialized = false;
			strDirectoryPath = Path.GetDirectoryName(strPath);
			directory = new DirectoryInfo(strDirectoryPath);

			if (directory.Exists == false)
			{
				directory.Create();
			}

			return true;
		}

		public bool WriteOpen(string strPath)
		{

			try
			{
				Open(strPath);

				if (!File.Exists(strPath))
				{
					//File.Create(strPath);
					writer = File.CreateText(strPath);
				}
				else
				{
					writer = File.AppendText(strPath);
					//SR = new StreamReader(m_strPath);
				}

				if (File.Exists(strPath))
				{
					m_bInitialized = true;
					m_bWrite = true;
					return true;
				}
			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}

			m_bInitialized = false;

			return false;
		}
		
		public bool ReadOpen(string strPath)
		{
			try
			{
				Open(strPath);

				if (!File.Exists(strPath))
				{
					m_bInitialized = false;

					return false;
				}
				else
				{
					SR = new StreamReader(m_strPath);
					//SR = new StreamReader(m_strPath);
				}

				if (File.Exists(strPath))
				{
					m_bInitialized = true;
					m_bWrite = false;
					return true;
				}
			
			}
			catch (Exception ex)
			{
				Debug.Assert(condition: false, $"Exception: {ex}");
			}

			m_bInitialized = false;

			return false;
		}

		public bool AddItem(string strItem)
		{
			if (m_bInitialized)
			{
				m_strValue += strItem;
				m_strValue += " ,";
				return true;
			}

			return false;
		}

	

		public bool Write()
		{
			if (m_bInitialized)
			{
				m_strValue = m_strValue.Substring(0, m_strValue.Length - 1);

				writer.WriteLine(m_strValue);
			
				return true;
			}

			return false;
		}

		public bool Read(ref string strLog)
		{
			if (m_bInitialized)
			{
				//string line;                                         
				//string result = ""; 
				

				//while ((line = SR.ReadLine())!= null)                
				//{
				//	result += line;                                  
				//	result += "\r\n";                                
				//}

				if ((strLog = SR.ReadLine())!= null)
				{
					return true;
				}
				return false;

			}
			return false;

		}

		public bool Close()
		{
			if (m_bInitialized)
			{
				if (m_bWrite)
				{
					writer.Close();
				}
				else
				{
					SR.Close();
				}

				return true;
			}
			

			return false;
		}
	}
}
