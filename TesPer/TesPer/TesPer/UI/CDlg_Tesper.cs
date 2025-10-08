using GKFile;
using GKForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TesPer
{

    public partial class CDlg_Tesper : Form
    {
        /* ----------------------------------------------------------------------------- */
        // App 
        /* ----------------------------------------------------------------------------- */
        [DllImport("imm32.dll")]
        public static extern IntPtr ImmGetContext(IntPtr hWnd);

        [DllImport("imm32.dll")]
        public static extern bool ImmGetConversionStatus(IntPtr hIMC , ref int lpdw , ref int lpdw2);

        [DllImport("imm32.dll")]
        public static extern Boolean ImmSetConversionStatus(IntPtr hIMC , Int32 fdwConversion , Int32 fdwSentence);



        /* ----------------------------------------------------------------------------- */
        // Definitions 
        /* ----------------------------------------------------------------------------- */
        private const int IME_CMODE_ALPHANUMERIC    = 0x0;
        private const int IME_CMODE_NATIVE          = 0x1;
        private const int IME_SMODE_NONE            = 0x0;


        /* ----------------------------------------------------------------------------- */
        // Enum 
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Struct 
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Field
        /* ----------------------------------------------------------------------------- */
        private CTesPer     m_clsTesPer         = new CTesPer();
        private CGKLogger   m_clsLogger         = null;
        private bool        m_bEnglishShown     = false;
        private bool        m_bKoreanShown           = false;
        /* ----------------------------------------------------------------------------- */
        // Properties 
        /* ----------------------------------------------------------------------------- */


        /* ----------------------------------------------------------------------------- */
        // Constructor
        /* ----------------------------------------------------------------------------- */

        public CDlg_Tesper()
        {
            m_clsLogger = new CGKLogger("./Losg.log");
            InitializeComponent();

            m_clsTesPer.CompareEvent += M_clsTesPer_ComparedEvent;
            m_clsTesPer.SequenceFinishedEvent += M_clsTesPer_SequenceFinishedEvent;
            //m_clsTesPer.ShowEnglishEvent += TesPer_ShowEnglishEvent;
        }


        /* ----------------------------------------------------------------------------- */
        // Event
        /* ----------------------------------------------------------------------------- */
        private void M_clsTesPer_SequenceFinishedEvent()
        {
            tmr_currentTime.Stop();

            edit_KorText.Text = "Finish";
            lb_LeftCount.Text = "Finish";
            edit_English.Text = "Finish";
            edit_Reference.Text = string.Empty;
            redit_Text.Text = string.Empty;
        }

        private void M_clsTesPer_ComparedEvent(bool bOK, int nCurrentIdx,string strCurrentCpm, List<string> strLogs)
        {
            if (bOK)
            {
                string strHint = string.Empty;
                string strReference = string.Empty;
                
                edit_CurrentKeyIdx.Text = nCurrentIdx.ToString();
                lb_CurrentCpm.Text = strCurrentCpm;


                UINextQuestionShowSetting();
                SetLog(strLogs);

                //m_clsLogger.WriteLog(_eLogType.Info , strWpm, true);
            }
            else
            {
                btn_HintShow.BackColor = Color.Red;
       
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Eng , ref strEnglish);

                ShowEnglish(true);

                string[] words = strEnglish.Split(' ');

                foreach (string word in words)
                {
                    redit_Text.Find(word , RichTextBoxFinds.WholeWord);

                    redit_Text.SelectionBackColor = Color.FromArgb(0 , 255 , 0);
                }

                redit_Text.SelectionStart = redit_Text.Text.Length;
                redit_Text.ScrollToCaret();
            }

            redit_Text.Focus();
        }


        /* ----------------------------------------------------------------------------- */
        // Private Method
        /* ----------------------------------------------------------------------------- */
        private void TextCompare()
        {
            bool bResult = false;
            string strEnglish = string.Empty;


            m_clsTesPer.TextCoompare(redit_Text.Text, ch_SentenceRepeat.Checked);
        }

        private void ShowEnglish(bool bForce = false)
        {
            string strEnglish = string.Empty;

            if (bForce)
            {
                m_bEnglishShown = false;
            }
           

            if (m_bEnglishShown)
            {
                edit_English.Text = string.Empty;
            }
            else
            {
                m_clsTesPer.GetData(_eKeyType.Eng , ref strEnglish);
                edit_English.Text = strEnglish;
            }
            m_bEnglishShown = !m_bEnglishShown;
            ch_ShowEnglish.Checked = m_bEnglishShown;
        }

     

        private void ShowKorean(bool bForce = false)
        {
            string strEnglish = string.Empty;

            if (bForce)
            {
                m_bKoreanShown = false;
            }

            if (m_bKoreanShown)
            {
                edit_KorText.Text = string.Empty;
            }
            else
            {
                m_clsTesPer.GetData(_eKeyType.Kor , ref strEnglish);
                edit_KorText.Text = strEnglish;

            }

            m_bKoreanShown = !m_bKoreanShown;
        }

        private void TestDataModify()
        {
            bool bModify = true;

            if (!m_bEnglishShown || !m_bKoreanShown)
            {
                if(MessageBox.Show("","alarm",MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    bModify = false;
                }
            }
            
            if (bModify)
            {
                CTestData clsTestData = new CTestData();
                clsTestData.m_strKorean = edit_KorText.Text;
                clsTestData.m_strReference = edit_Reference.Text;
                clsTestData.m_strEnglish = edit_English.Text;

                m_clsTesPer.Modify(clsTestData);

                btn_TestDataModify.BackColor = Color.Red;
            }

        }

        private void Pass(int nPassedIdx)
        {
      

            m_clsTesPer.Pass(nPassedIdx);
        }

        private void SetLog(List<string> strLog)
        {
            edit_Log.Clear();

            if (strLog != null)
            {
                for (int nCnt = 0 ; nCnt < strLog.Count ; nCnt++)
                {
                    edit_Log.Text += strLog[nCnt];
                    edit_Log.Text += "\r\n";
                }
            }
        }
        /* ----------------------------------------------------------------------------- */
        // Protected Method
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Public Method
        /* ----------------------------------------------------------------------------- */



        /* ----------------------------------------------------------------------------- */
        // Controller Event
        /* ----------------------------------------------------------------------------- */
     
   
        private void UINextQuestionShowSetting()
        {

            edit_English.ForeColor          = Color.Blue;
            btn_HintShow.BackColor          = SystemColors.Control;
            btn_Apply.BackColor             = SystemColors.Control;
            btn_TestDataModify.BackColor    = SystemColors.Control;

            lb_Hint.Text                    = "Hint";
            edit_Log.Text                   = string.Empty;
            redit_Text.Text                 = string.Empty;

            m_bEnglishShown = ch_ShowEnglish.Checked;
            m_bKoreanShown  = ch_ShowKorean.Checked;

            if (ch_HintShow.Checked)
            {
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Hint , ref strEnglish);
                edit_Hint.Text = strEnglish;
                //ShowEnglish();
            }
            else
            {
                edit_Hint.Text = string.Empty;
            }
           

            if (ch_ShowReference.Checked)
            {
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Ref , ref strEnglish);
                edit_Reference.Text = strEnglish;
            }
            else
            {
                edit_Reference.Text = "Correct answer";
            }

            if (ch_ShowKorean.Checked)
            {
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Kor , ref strEnglish);

                edit_KorText.Text = strEnglish;
                //ShowEnglish();
            }
            else
            {
                edit_KorText.Text = "Correct answer";
            }

            if (ch_ShowEnglish.Checked)
            {
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Eng , ref strEnglish);
                edit_English.Text = strEnglish;
                //ShowEnglish();
            }
            else
            {
                edit_English.Text = "Correct answer";
            }
        }

        private void Form1_Load(object sender , EventArgs e)
        {

        }

        private void btn_CreateContent_Click(object sender , EventArgs e)
        {
            CDlg_CreateContent dlg_CreateContent = new CDlg_CreateContent();

            if (dlg_CreateContent.ShowDialog() == DialogResult.OK)
            {
                CEduSectionData clsEducationData = new CEduSectionData();
                dlg_CreateContent.GetData(ref clsEducationData);
                m_clsTesPer.SetData(clsEducationData);

                cmb_SectionName.Items.Add(clsEducationData.m_strName);
            }
        }

        private void btn_FileOpen_Click(object sender , EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            int nKeyCount = 0;
            int nCurrentKeyIdx = 0;
            string strPath = "D:\\Dean\\Project\\Project\\private\\TesPer\\CrashCourse_3.ini";
            string strSafeFileName = "CrashCourse_3.ini";
            string strKorean = string.Empty;
            string strHint = string.Empty;
            string strReference = string.Empty;
            string strTimelist = string.Empty;
            string strDataCnt = string.Empty;
            string[] strSectionNames = null;
            List<string> strLog = new List<string>();
            openFileDialog.InitialDirectory = Application.StartupPath + "\\Data";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strPath = openFileDialog.FileName;
                strSafeFileName = openFileDialog.SafeFileName;
                string strPathSafeFileName = "DATA1_0.ini";
                //openFileDialog.AddExtension
                if (m_clsTesPer.FileOpen
               (
                   strPath ,
                   strSafeFileName ,
                   rbtn_random.Checked ,
                   0,
                   0 ,
                   int.Parse(edit_SectionCnt.Text) ,
                   ref nKeyCount ,
                   ref nCurrentKeyIdx ,
                   ref strDataCnt ,
                   ref strKorean ,
                   ref strHint ,
                   ref strReference ,
                   ref strTimelist ,
                   ref strSectionNames,
                   ref strLog
               ))
                {
                    lb_LeftCount.Text = strDataCnt;
                    edit_KeyCnt.Text = nKeyCount.ToString();
                    edit_RecodeTime.Text = strTimelist;
                    cmb_SectionName.Items.Clear();
                    edit_CurrentKeyIdx.Text = nCurrentKeyIdx.ToString();

                    for (int nCnt = 0 ; nCnt < strSectionNames.Length ; nCnt++)
                    {
                        cmb_SectionName.Items.Add(strSectionNames[nCnt]);
                    }

                    UINextQuestionShowSetting();
                    SetLog(strLog);

                    tmr_currentTime.Start();


                    redit_Text.Focus();
                }
                else
                {
                    MessageBox.Show("OpenError");
                }
            }
        }
    
        private void Form1_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextCompare();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                ShowEnglish();
            }
            else if (e.Control && e.KeyCode == Keys.M)
            {
                TestDataModify();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                int nPassedIdx = int.Parse(edit_CurrentKeyIdx.Text);
                nPassedIdx++;
                Pass(nPassedIdx);
            }
            else if (e.Control && e.KeyCode == Keys.K)
            {
                ShowKorean();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                ch_SentenceRepeat.Checked = !ch_SentenceRepeat.Checked;
            }

            if (e.Alt && e.KeyCode == Keys.H)
            {
                edit_Hint.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.R)
            {
                edit_Reference.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.E)
            {
                IntPtr context = ImmGetContext(this.Handle);
                Int32 dwConversion = IME_CMODE_ALPHANUMERIC;

                ImmSetConversionStatus(context , dwConversion , 0);

                edit_English.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.K)
            {
                bool bChecked = false;
                int dwConversion = 0;
                int dwSentence = 0;
                IntPtr context = ImmGetContext(this.Handle);

                dwConversion = IME_CMODE_NATIVE;
                ImmSetConversionStatus(context , dwConversion , 0);
        
                edit_KorText.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.C)
            {
                IntPtr context = ImmGetContext(this.Handle);
                Int32 dwConversion = IME_CMODE_ALPHANUMERIC;

                ImmSetConversionStatus(context , dwConversion , 0);

                redit_Text.Focus();
            }
        }
        private void btn_Apply_Click(object sender , EventArgs e)
        {

            m_clsTesPer.ModifyReference(edit_Reference.Text);
        }

        private void btn_KorShow_Click(object sender , EventArgs e)
        {
            ShowKorean();
        }

        private void btn_ShowEnglish_Click(object sender , EventArgs e)
        {
            ShowEnglish();
        }


        private void cmb_SectionName_SelectedIndexChanged(object sender , EventArgs e)
        {
            int nIdx  = cmb_SectionName.SelectedIndex;
      
            string strHint = string.Empty;
            string strReference = string.Empty;
       
            m_clsTesPer.InitializeSection(nIdx, rbtn_random.Checked, 0);
            UINextQuestionShowSetting();
        }

        private void btn_DataSave_Click(object sender , EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //this.DialogResult = DialogResult.OK;

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                m_clsTesPer.Data.SaveData(saveFileDialog.FileName);
            }

       
        }

        private void edit_CorrectAnswer_TextChanged(object sender , EventArgs e)
        {

        }

        private void btn_EngModify_Click(object sender , EventArgs e)
        {
            TestDataModify();
        }

        private void btn_Compare_Click(object sender , EventArgs e)
        {
            TextCompare();
        }

        private void btn_Pass_Click(object sender , EventArgs e)
        {
            int nPassedIdx = int.Parse(edit_CurrentKeyIdx.Text);

            Pass(nPassedIdx);
        }

        private void CDlg_Tesper_FormClosing(object sender , FormClosingEventArgs e)
        {
            m_clsTesPer.Close();
        }

     
    }
}
