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
    public partial class CDlg_SentenceHelper : Form
    {
        /* ----------------------------------------------------------------------------- */
        // App 
        /* ----------------------------------------------------------------------------- */
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
        private bool m_bEnglishShown = false;
        private bool m_bKoreanShown = false;
        private CTesPerSystem m_clsTesPer = null;
        IntPtr m_pContext = IntPtr.Zero;
        private int m_nCurrentIdx = 0;
        /* ----------------------------------------------------------------------------- */
        // Properties 
        /* ----------------------------------------------------------------------------- */


        /* ----------------------------------------------------------------------------- */
        // Constructor
        /* ----------------------------------------------------------------------------- */

        public CDlg_SentenceHelper(CTesPerSystem clsTesPer, IntPtr pContext, int nCurrentIdx)
        {
            m_pContext = pContext;
            m_clsTesPer = clsTesPer;
            m_nCurrentIdx = nCurrentIdx;
            InitializeComponent();
            m_clsTesPer.CompareEvent += M_clsTesPer_ComparedEvent;

            UINextQuestionShowSetting();
        }
        /* ----------------------------------------------------------------------------- */
        // Event
        /* ----------------------------------------------------------------------------- */
        private void M_clsTesPer_ComparedEvent(bool bOK , int nKeyIdx , string strCurrentCpm , List<string> strWpm)
        {
            if (bOK)
            {
                string strHint = string.Empty;
                string strReference = string.Empty;

                //edit_CurrentKeyIdx.Text = nCurrentIdx.ToString();
                lb_CurrentCpm.Text = strCurrentCpm;
            }
            else
            {

                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Eng , ref strEnglish);

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
        private void UINextQuestionShowSetting()
        {

            edit_English.ForeColor = Color.Blue;
            //btn_HintShow.BackColor = SystemColors.Control;
            //btn_Apply.BackColor = SystemColors.Control;
            //btn_TestDataModify.BackColor = SystemColors.Control;

            //lb_Hint.Text = "Hint";
            edit_Log.Text = string.Empty;
            redit_Text.Text = string.Empty;

            m_bEnglishShown = ch_ShowEnglish.Checked;
            m_bKoreanShown = ch_ShowKorean.Checked;

            if (ch_HintShow.Checked)
            {
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(_eKeyType.Hint , ref strEnglish);
                edit_Hint.Text = strEnglish;
            }
            else
            {
                edit_Hint.Text = string.Empty;
            }


            if (ch_ShowReference.Checked)
            {
                string strEnglish = string.Empty;
                //m_clsTesPer.
                m_clsTesPer.GetData(m_nCurrentIdx, _eKeyType.Ref , ref strEnglish);
                edit_Reference.Text = strEnglish;
            }
            else
            {
                edit_Reference.Text = "Correct answer";
            }

            if (ch_ShowKorean.Checked)
            {
                string strKorea = string.Empty;
                m_clsTesPer.GetData(m_nCurrentIdx , _eKeyType.Kor , ref strKorea);
                edit_KorText.Text = strKorea;
            }
            else
            {
                edit_KorText.Text = "Correct answer";
            }

            if (ch_ShowEnglish.Checked)
            {
                string strEnglish = string.Empty;
                m_clsTesPer.GetData(m_nCurrentIdx , _eKeyType.Eng , ref strEnglish);
                edit_English.Text = strEnglish;
            }
            else
            {
                edit_English.Text = "Correct answer";
            }
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
                m_clsTesPer.GetData(m_nCurrentIdx , _eKeyType.Eng , ref strEnglish);
                edit_English.Text = strEnglish;
            }

            m_bEnglishShown = !m_bEnglishShown;
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
                m_clsTesPer.GetData(m_nCurrentIdx , _eKeyType.Kor , ref strEnglish);
                edit_KorText.Text = strEnglish;

            }

            m_bKoreanShown = !m_bKoreanShown;
        }

        private void CDlg_SentenceHelper_KeyDown(object sender , KeyEventArgs e)
        {
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
                ImmSetConversionStatus(m_pContext , IME_CMODE_ALPHANUMERIC , 0);

                edit_English.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.K)
            {
                ImmSetConversionStatus(m_pContext , IME_CMODE_NATIVE , 0);

                edit_KorText.Focus();
            }
            else if (e.Alt && e.KeyCode == Keys.C)
            {
                ImmSetConversionStatus(m_pContext , IME_CMODE_ALPHANUMERIC , 0);

                redit_Text.Focus();
            }
        }
        /* ----------------------------------------------------------------------------- */
        // Controller Event
        /* ----------------------------------------------------------------------------- */
        private void btn_Compare_Click(object sender , EventArgs e)
        {
            m_clsTesPer.TextCoompare(redit_Text.Text , true);
        }

        private void CDlg_SentenceHelper_FormClosing(object sender , FormClosingEventArgs e)
        {
            m_clsTesPer.CompareEvent -= M_clsTesPer_ComparedEvent;
        }

        private void btn_Modify_Click(object sender , EventArgs e)
        {
            CTestData clsTestData = new CTestData();
            clsTestData.m_strKorean = edit_KorText.Text;
            clsTestData.m_strReference = edit_Reference.Text;
            clsTestData.m_strEnglish = edit_English.Text;

            m_clsTesPer.Modify(m_nCurrentIdx , clsTestData);
        }
    }
}
