using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesPer
{
    public class CTestData
    {
        public string       m_strKorean = string.Empty;
        public string       m_strEnglish = string.Empty;
        public string       m_strReference = string.Empty;
        public List<string> _Log            = new List<string>();
    }

    public class CEduSectionData
    {
        public const string     DEF_STRING_VALUE = "default";
        public string           m_strName           = string.Empty;
        public string           m_strHint           = string.Empty;
        public int              m_lastIdx           = 0;
        public List<CTestData>  m_list_clsTestData  = new List<CTestData>();

 

        public CEduSectionData()
        {

        }

    }
}
