using GKFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesPer
{
    public partial class CDlg_CreateContent : Form
    {
        private CEduContent             clsEducationContent     = new CEduContent();
        private CEduSectionData         m_clsEducationData      = new CEduSectionData();
        private int                     nTestDataCnt = 0;

        public CDlg_CreateContent()
        {
            InitializeComponent();
        }

        public void GetData(ref CEduSectionData clsEducationData)
        {
            clsEducationData = m_clsEducationData;
        }


        private void btn_TestDataAdd_Click(object sender , EventArgs e)
        {
            CTestData clsTestData = new CTestData();

            clsTestData.m_strKorean     = edit_Korean.Text;
            clsTestData.m_strReference  = edit_Hint.Text;
            clsTestData.m_strEnglish    = edit_English.Text;

            m_clsEducationData.m_list_clsTestData.Add(clsTestData);

            nTestDataCnt = m_clsEducationData.m_list_clsTestData.Count;
            cmb_Key.Items.Add(nTestDataCnt.ToString());
        }

        private void btn_OK_Click(object sender , EventArgs e)
        {
            m_clsEducationData.m_strName        = edit_Section.Text;
            m_clsEducationData.m_strHint        = edit_Hint.Text;

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            this.DialogResult = DialogResult.OK;
            //clsEducationContent.SaveData(saveFileDialog.FileName , m_clsEducationData);

            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    clsEducationContent.SaveData(saveFileDialog.FileName,m_clsEducationData);
            //}
        }

        private void btn_SectionAdd_Click(object sender , EventArgs e)
        {

        }

        private void btn_excelOpen_Click(object sender , EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DataTable dataTable = new DataTable();
            CPnExcel clsPnExcel = new CPnExcel();

            //CPnExcel.XlsxRead(strPath , ref dataTable);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strPath = openFileDialog.FileName;
                clsPnExcel.XlsxRead(strPath ,1, ref dataTable);

                //CTestData clsTestData = new CTestData();
                if (dataTable.Rows.Count > 0 && dataTable.Columns.Count > 0)
                {
                    int ColumnCount = dataTable.Columns.Count;

                    int _iRow = 0;

                    foreach (DataRow _Row in dataTable.Rows)
                    {
                        if (_iRow == 0)
                        {
                            _iRow++;
                            continue;
                        }
                        CTestData clsTestData = new CTestData();

                        string strData = string.Empty;

                        clsTestData.m_strEnglish = _Row[1].ToString();
                        clsTestData.m_strKorean = _Row[2].ToString();

                        m_clsEducationData.m_list_clsTestData.Add(clsTestData);
                        cmb_Key.Items.Add(_iRow);
                        _iRow++;
                    }
                    MessageBox.Show("Finished");
                }
            }

        }

        private void cmb_Key_SelectedIndexChanged(object sender , EventArgs e)
        {
            edit_Korean.Text        = m_clsEducationData.m_list_clsTestData[cmb_Key.SelectedIndex].m_strKorean;
            edit_Reference.Text     = m_clsEducationData.m_list_clsTestData[cmb_Key.SelectedIndex].m_strReference;
            edit_English.Text       = m_clsEducationData.m_list_clsTestData[cmb_Key.SelectedIndex].m_strEnglish;

            // cmb_Key.Text;
        }
    }
}
