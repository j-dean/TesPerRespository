using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GKFile
{
	public class CGKXml
	{
		private string m_strPath = string.Empty;
		private bool m_bInitialized = false;

		XmlDocument xdoc = new XmlDocument();

		public bool Open(string strPath)
		{
			string strDirectoryPath = string.Empty;
			DirectoryInfo directory = null;

			m_strPath = strPath;
			m_bInitialized = false;

			try
			{
				if (directory.Exists == false)
				{
					directory.Create();
				}

				if (!File.Exists(strPath))
				{
					File.Create(strPath);
				}

				if (File.Exists(strPath))
				{
					m_bInitialized = true;

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

		public void Set()
		{
			XmlNode root = xdoc.CreateElement("CoffeeType");
			xdoc.AppendChild(root);


			//자식 노드 1. 아메리카노 , 가격은 4000원 
			XmlNode coff1 = xdoc.CreateElement("Coffee");

			XmlNode type1 = xdoc.CreateElement("Type");
			type1.InnerText = "Americano";
			coff1.AppendChild(type1);
			XmlNode price1 = xdoc.CreateElement("Price");
			price1.InnerText = "4000";
			coff1.AppendChild(price1);


			//자식 노드 2. 라떼 , 가격은 5000원 
			XmlNode coff2 = xdoc.CreateElement("Coffee");

			XmlNode type2 = xdoc.CreateElement("Type");
			type2.InnerText = "Latte";
			coff2.AppendChild(type2);
			XmlNode price2 = xdoc.CreateElement("Price");
			price2.InnerText = "5000";
			coff2.AppendChild(price2);


			//부모 노드에 자식 노드 추가 
			root.AppendChild(coff1);
			root.AppendChild(coff2);




			xdoc.Save(@"C:\Temp\xmltest.xml");
		}


       
    }
}
