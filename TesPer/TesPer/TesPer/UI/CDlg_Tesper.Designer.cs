using System;

namespace TesPer
{
    partial class CDlg_Tesper
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_LeftCount = new System.Windows.Forms.Label();
            this.rbtn_IndexRandom = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Hint = new System.Windows.Forms.Label();
            this.btn_HintShow = new System.Windows.Forms.Button();
            this.btn_Pass = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_LogUpdate = new System.Windows.Forms.Button();
            this.tmr_currentTime = new System.Windows.Forms.Timer(this.components);
            this.edit_currentTime = new System.Windows.Forms.TextBox();
            this.btn_LogShow = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_file = new System.Windows.Forms.Label();
            this.lb_OkCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_NonRandom = new System.Windows.Forms.RadioButton();
            this.rbtn_random = new System.Windows.Forms.RadioButton();
            this.btn_disappear = new System.Windows.Forms.Button();
            this.ck_TypingPractice = new System.Windows.Forms.CheckBox();
            this.lb_NGCnt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.btn_KorShow = new System.Windows.Forms.Button();
            this.btn_OpenCurrentlyDirectory = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtn_LComprehension = new System.Windows.Forms.RadioButton();
            this.rbtn_RComprehension = new System.Windows.Forms.RadioButton();
            this.btn_TestDataModify = new System.Windows.Forms.Button();
            this.ch_HintShow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateContent = new System.Windows.Forms.Button();
            this.cmb_SectionName = new System.Windows.Forms.ComboBox();
            this.btn_DataSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ch_ShowKorean = new System.Windows.Forms.CheckBox();
            this.ch_ShowEnglish = new System.Windows.Forms.CheckBox();
            this.ch_ShowReference = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_CurrentCpm = new System.Windows.Forms.Label();
            this.ch_SentenceRepeat = new System.Windows.Forms.CheckBox();
            this.edit_CurrentKeyIdx = new TesPer.CSubText();
            this.edit_SectionCnt = new TesPer.CSubText();
            this.edit_KorText = new TesPer.CSubText();
            this.edit_English = new TesPer.CSubText();
            this.edit_RecodeTime = new TesPer.CSubText();
            this.edit_Log = new TesPer.CSubText();
            this.edit_Hint = new TesPer.CSubText();
            this.edit_Reference = new TesPer.CSubText();
            this.redit_Text = new TesPer.CSubRichText();
            this.edit_randomCnt = new TesPer.CSubText();
            this.edit_KeyCnt = new TesPer.CSubText();
            this.btn_ShowEnglish = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Left Count";
            // 
            // lb_LeftCount
            // 
            this.lb_LeftCount.AutoSize = true;
            this.lb_LeftCount.Location = new System.Drawing.Point(518, 90);
            this.lb_LeftCount.Name = "lb_LeftCount";
            this.lb_LeftCount.Size = new System.Drawing.Size(11, 12);
            this.lb_LeftCount.TabIndex = 3;
            this.lb_LeftCount.Text = "0";
            // 
            // rbtn_IndexRandom
            // 
            this.rbtn_IndexRandom.AutoSize = true;
            this.rbtn_IndexRandom.Location = new System.Drawing.Point(519, 161);
            this.rbtn_IndexRandom.Name = "rbtn_IndexRandom";
            this.rbtn_IndexRandom.Size = new System.Drawing.Size(106, 16);
            this.rbtn_IndexRandom.TabIndex = 5;
            this.rbtn_IndexRandom.Text = "Index Random";
            this.rbtn_IndexRandom.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Reference";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Section Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Key count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Problem count";
            // 
            // lb_Hint
            // 
            this.lb_Hint.AutoSize = true;
            this.lb_Hint.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Hint.Location = new System.Drawing.Point(862, 260);
            this.lb_Hint.Name = "lb_Hint";
            this.lb_Hint.Size = new System.Drawing.Size(38, 19);
            this.lb_Hint.TabIndex = 17;
            this.lb_Hint.Text = "Hint";
            // 
            // btn_HintShow
            // 
            this.btn_HintShow.Location = new System.Drawing.Point(902, 258);
            this.btn_HintShow.Name = "btn_HintShow";
            this.btn_HintShow.Size = new System.Drawing.Size(93, 23);
            this.btn_HintShow.TabIndex = 18;
            this.btn_HintShow.Text = "Hint show(H)";
            this.btn_HintShow.UseVisualStyleBackColor = true;
            // 
            // btn_Pass
            // 
            this.btn_Pass.Location = new System.Drawing.Point(1039, 502);
            this.btn_Pass.Name = "btn_Pass";
            this.btn_Pass.Size = new System.Drawing.Size(75, 23);
            this.btn_Pass.TabIndex = 20;
            this.btn_Pass.Text = "Pass(p)";
            this.btn_Pass.UseVisualStyleBackColor = true;
            this.btn_Pass.Click += new System.EventHandler(this.btn_Pass_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 22;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(18, 313);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 27;
            this.btn_Apply.Text = "Apply(A)";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(18, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Hint";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(35, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 38;
            this.label11.Text = "&Log";
            // 
            // btn_LogUpdate
            // 
            this.btn_LogUpdate.Location = new System.Drawing.Point(20, 529);
            this.btn_LogUpdate.Name = "btn_LogUpdate";
            this.btn_LogUpdate.Size = new System.Drawing.Size(75, 33);
            this.btn_LogUpdate.TabIndex = 39;
            this.btn_LogUpdate.Text = "Log Update(L)";
            this.btn_LogUpdate.UseVisualStyleBackColor = true;
            // 
            // tmr_currentTime
            // 
            this.tmr_currentTime.Enabled = true;
            this.tmr_currentTime.Interval = 400;
            // 
            // edit_currentTime
            // 
            this.edit_currentTime.Location = new System.Drawing.Point(831, 53);
            this.edit_currentTime.Name = "edit_currentTime";
            this.edit_currentTime.Size = new System.Drawing.Size(141, 21);
            this.edit_currentTime.TabIndex = 41;
            // 
            // btn_LogShow
            // 
            this.btn_LogShow.Location = new System.Drawing.Point(20, 568);
            this.btn_LogShow.Name = "btn_LogShow";
            this.btn_LogShow.Size = new System.Drawing.Size(75, 33);
            this.btn_LogShow.TabIndex = 42;
            this.btn_LogShow.Text = "Log Show(S)";
            this.btn_LogShow.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "Load filename";
            // 
            // lb_file
            // 
            this.lb_file.AutoSize = true;
            this.lb_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_file.Location = new System.Drawing.Point(107, 15);
            this.lb_file.Name = "lb_file";
            this.lb_file.Size = new System.Drawing.Size(87, 14);
            this.lb_file.TabIndex = 46;
            this.lb_file.Text = "Load filename";
            // 
            // lb_OkCount
            // 
            this.lb_OkCount.AutoSize = true;
            this.lb_OkCount.Location = new System.Drawing.Point(518, 112);
            this.lb_OkCount.Name = "lb_OkCount";
            this.lb_OkCount.Size = new System.Drawing.Size(11, 12);
            this.lb_OkCount.TabIndex = 48;
            this.lb_OkCount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(418, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 12);
            this.label14.TabIndex = 47;
            this.label14.Text = "Ok Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_NonRandom);
            this.groupBox2.Controls.Add(this.rbtn_random);
            this.groupBox2.Location = new System.Drawing.Point(519, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 41);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Set";
            // 
            // rbtn_NonRandom
            // 
            this.rbtn_NonRandom.AutoSize = true;
            this.rbtn_NonRandom.Checked = true;
            this.rbtn_NonRandom.Location = new System.Drawing.Point(112, 19);
            this.rbtn_NonRandom.Name = "rbtn_NonRandom";
            this.rbtn_NonRandom.Size = new System.Drawing.Size(93, 16);
            this.rbtn_NonRandom.TabIndex = 1;
            this.rbtn_NonRandom.TabStop = true;
            this.rbtn_NonRandom.Tag = "1";
            this.rbtn_NonRandom.Text = "NonRandom";
            this.rbtn_NonRandom.UseVisualStyleBackColor = true;
            // 
            // rbtn_random
            // 
            this.rbtn_random.AutoSize = true;
            this.rbtn_random.Location = new System.Drawing.Point(14, 19);
            this.rbtn_random.Name = "rbtn_random";
            this.rbtn_random.Size = new System.Drawing.Size(70, 16);
            this.rbtn_random.TabIndex = 0;
            this.rbtn_random.Tag = "0";
            this.rbtn_random.Text = "Random";
            this.rbtn_random.UseVisualStyleBackColor = true;
            // 
            // btn_disappear
            // 
            this.btn_disappear.Location = new System.Drawing.Point(20, 607);
            this.btn_disappear.Name = "btn_disappear";
            this.btn_disappear.Size = new System.Drawing.Size(75, 38);
            this.btn_disappear.TabIndex = 51;
            this.btn_disappear.Text = "Log Hiding(D)";
            this.btn_disappear.UseVisualStyleBackColor = true;
            // 
            // ck_TypingPractice
            // 
            this.ck_TypingPractice.AutoSize = true;
            this.ck_TypingPractice.Checked = true;
            this.ck_TypingPractice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_TypingPractice.Location = new System.Drawing.Point(1113, 262);
            this.ck_TypingPractice.Name = "ck_TypingPractice";
            this.ck_TypingPractice.Size = new System.Drawing.Size(76, 16);
            this.ck_TypingPractice.TabIndex = 52;
            this.ck_TypingPractice.Text = "타자 연습";
            this.ck_TypingPractice.UseVisualStyleBackColor = true;
            // 
            // lb_NGCnt
            // 
            this.lb_NGCnt.AutoSize = true;
            this.lb_NGCnt.Location = new System.Drawing.Point(518, 133);
            this.lb_NGCnt.Name = "lb_NGCnt";
            this.lb_NGCnt.Size = new System.Drawing.Size(11, 12);
            this.lb_NGCnt.TabIndex = 54;
            this.lb_NGCnt.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(418, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 12);
            this.label15.TabIndex = 53;
            this.label15.Text = "NG Count";
            // 
            // btn_Compare
            // 
            this.btn_Compare.Location = new System.Drawing.Point(18, 455);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(75, 28);
            this.btn_Compare.TabIndex = 58;
            this.btn_Compare.Text = "Compare";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // btn_KorShow
            // 
            this.btn_KorShow.Location = new System.Drawing.Point(16, 339);
            this.btn_KorShow.Name = "btn_KorShow";
            this.btn_KorShow.Size = new System.Drawing.Size(75, 28);
            this.btn_KorShow.TabIndex = 59;
            this.btn_KorShow.Text = "Korean(K)";
            this.btn_KorShow.UseVisualStyleBackColor = true;
            this.btn_KorShow.Click += new System.EventHandler(this.btn_KorShow_Click);
            // 
            // btn_OpenCurrentlyDirectory
            // 
            this.btn_OpenCurrentlyDirectory.Location = new System.Drawing.Point(551, 10);
            this.btn_OpenCurrentlyDirectory.Name = "btn_OpenCurrentlyDirectory";
            this.btn_OpenCurrentlyDirectory.Size = new System.Drawing.Size(123, 23);
            this.btn_OpenCurrentlyDirectory.TabIndex = 60;
            this.btn_OpenCurrentlyDirectory.Text = "현재 폴더 열기";
            this.btn_OpenCurrentlyDirectory.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtn_LComprehension);
            this.groupBox4.Controls.Add(this.rbtn_RComprehension);
            this.groupBox4.Location = new System.Drawing.Point(20, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 41);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test Mode";
            // 
            // rbtn_LComprehension
            // 
            this.rbtn_LComprehension.AutoSize = true;
            this.rbtn_LComprehension.Location = new System.Drawing.Point(112, 19);
            this.rbtn_LComprehension.Name = "rbtn_LComprehension";
            this.rbtn_LComprehension.Size = new System.Drawing.Size(39, 16);
            this.rbtn_LComprehension.TabIndex = 1;
            this.rbtn_LComprehension.Tag = "1";
            this.rbtn_LComprehension.Text = "LC";
            this.rbtn_LComprehension.UseVisualStyleBackColor = true;
            // 
            // rbtn_RComprehension
            // 
            this.rbtn_RComprehension.AutoSize = true;
            this.rbtn_RComprehension.Checked = true;
            this.rbtn_RComprehension.Location = new System.Drawing.Point(14, 19);
            this.rbtn_RComprehension.Name = "rbtn_RComprehension";
            this.rbtn_RComprehension.Size = new System.Drawing.Size(40, 16);
            this.rbtn_RComprehension.TabIndex = 0;
            this.rbtn_RComprehension.TabStop = true;
            this.rbtn_RComprehension.Tag = "0";
            this.rbtn_RComprehension.Text = "RC";
            this.rbtn_RComprehension.UseVisualStyleBackColor = true;
            // 
            // btn_TestDataModify
            // 
            this.btn_TestDataModify.Location = new System.Drawing.Point(1120, 502);
            this.btn_TestDataModify.Name = "btn_TestDataModify";
            this.btn_TestDataModify.Size = new System.Drawing.Size(75, 23);
            this.btn_TestDataModify.TabIndex = 64;
            this.btn_TestDataModify.Text = "Modify";
            this.btn_TestDataModify.UseVisualStyleBackColor = true;
            this.btn_TestDataModify.Click += new System.EventHandler(this.btn_EngModify_Click);
            // 
            // ch_HintShow
            // 
            this.ch_HintShow.AutoSize = true;
            this.ch_HintShow.Checked = true;
            this.ch_HintShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_HintShow.Location = new System.Drawing.Point(1035, 39);
            this.ch_HintShow.Name = "ch_HintShow";
            this.ch_HintShow.Size = new System.Drawing.Size(79, 16);
            this.ch_HintShow.TabIndex = 65;
            this.ch_HintShow.Text = "show hint";
            this.ch_HintShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 66;
            this.label1.Text = "Section count";
            // 
            // btn_CreateContent
            // 
            this.btn_CreateContent.Location = new System.Drawing.Point(680, 10);
            this.btn_CreateContent.Name = "btn_CreateContent";
            this.btn_CreateContent.Size = new System.Drawing.Size(123, 23);
            this.btn_CreateContent.TabIndex = 68;
            this.btn_CreateContent.Text = "생성";
            this.btn_CreateContent.UseVisualStyleBackColor = true;
            this.btn_CreateContent.Click += new System.EventHandler(this.btn_CreateContent_Click);
            // 
            // cmb_SectionName
            // 
            this.cmb_SectionName.FormattingEnabled = true;
            this.cmb_SectionName.Location = new System.Drawing.Point(121, 90);
            this.cmb_SectionName.Name = "cmb_SectionName";
            this.cmb_SectionName.Size = new System.Drawing.Size(258, 20);
            this.cmb_SectionName.TabIndex = 69;
            this.cmb_SectionName.SelectedIndexChanged += new System.EventHandler(this.cmb_SectionName_SelectedIndexChanged);
            // 
            // btn_DataSave
            // 
            this.btn_DataSave.Location = new System.Drawing.Point(831, 10);
            this.btn_DataSave.Name = "btn_DataSave";
            this.btn_DataSave.Size = new System.Drawing.Size(123, 23);
            this.btn_DataSave.TabIndex = 70;
            this.btn_DataSave.Text = "Data 저장";
            this.btn_DataSave.UseVisualStyleBackColor = true;
            this.btn_DataSave.Click += new System.EventHandler(this.btn_DataSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "파일 불러오기(O)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_FileOpen_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 12);
            this.label13.TabIndex = 75;
            this.label13.Text = "Current Key Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "Current Key Index";
            // 
            // ch_ShowKorean
            // 
            this.ch_ShowKorean.AutoSize = true;
            this.ch_ShowKorean.Checked = true;
            this.ch_ShowKorean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ShowKorean.Location = new System.Drawing.Point(1035, 82);
            this.ch_ShowKorean.Name = "ch_ShowKorean";
            this.ch_ShowKorean.Size = new System.Drawing.Size(99, 16);
            this.ch_ShowKorean.TabIndex = 78;
            this.ch_ShowKorean.Text = "show Korean";
            this.ch_ShowKorean.UseVisualStyleBackColor = true;
            // 
            // ch_ShowEnglish
            // 
            this.ch_ShowEnglish.AutoSize = true;
            this.ch_ShowEnglish.Checked = true;
            this.ch_ShowEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ShowEnglish.Location = new System.Drawing.Point(1035, 104);
            this.ch_ShowEnglish.Name = "ch_ShowEnglish";
            this.ch_ShowEnglish.Size = new System.Drawing.Size(102, 16);
            this.ch_ShowEnglish.TabIndex = 79;
            this.ch_ShowEnglish.Text = "Show English";
            this.ch_ShowEnglish.UseVisualStyleBackColor = true;
            // 
            // ch_ShowReference
            // 
            this.ch_ShowReference.AutoSize = true;
            this.ch_ShowReference.Checked = true;
            this.ch_ShowReference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ShowReference.Location = new System.Drawing.Point(1035, 60);
            this.ch_ShowReference.Name = "ch_ShowReference";
            this.ch_ShowReference.Size = new System.Drawing.Size(117, 16);
            this.ch_ShowReference.TabIndex = 80;
            this.ch_ShowReference.Text = "Show Reference";
            this.ch_ShowReference.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 81;
            this.label16.Text = "Current CpM";
            // 
            // lb_CurrentCpm
            // 
            this.lb_CurrentCpm.AutoSize = true;
            this.lb_CurrentCpm.Location = new System.Drawing.Point(119, 236);
            this.lb_CurrentCpm.Name = "lb_CurrentCpm";
            this.lb_CurrentCpm.Size = new System.Drawing.Size(87, 12);
            this.lb_CurrentCpm.TabIndex = 82;
            this.lb_CurrentCpm.Text = "Problem count";
            // 
            // ch_SentenceRepeat
            // 
            this.ch_SentenceRepeat.AutoSize = true;
            this.ch_SentenceRepeat.Location = new System.Drawing.Point(1035, 126);
            this.ch_SentenceRepeat.Name = "ch_SentenceRepeat";
            this.ch_SentenceRepeat.Size = new System.Drawing.Size(116, 16);
            this.ch_SentenceRepeat.TabIndex = 83;
            this.ch_SentenceRepeat.Text = "Sentence repeat";
            this.ch_SentenceRepeat.UseVisualStyleBackColor = true;
            // 
            // edit_CurrentKeyIdx
            // 
            this.edit_CurrentKeyIdx.Location = new System.Drawing.Point(979, 502);
            this.edit_CurrentKeyIdx.Name = "edit_CurrentKeyIdx";
            this.edit_CurrentKeyIdx.Size = new System.Drawing.Size(49, 21);
            this.edit_CurrentKeyIdx.TabIndex = 76;
            this.edit_CurrentKeyIdx.Text = "10";
            // 
            // edit_SectionCnt
            // 
            this.edit_SectionCnt.Location = new System.Drawing.Point(121, 117);
            this.edit_SectionCnt.Name = "edit_SectionCnt";
            this.edit_SectionCnt.Size = new System.Drawing.Size(49, 21);
            this.edit_SectionCnt.TabIndex = 67;
            this.edit_SectionCnt.Text = "1";
            // 
            // edit_KorText
            // 
            this.edit_KorText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.edit_KorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit_KorText.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.edit_KorText.Location = new System.Drawing.Point(104, 345);
            this.edit_KorText.Multiline = true;
            this.edit_KorText.Name = "edit_KorText";
            this.edit_KorText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edit_KorText.Size = new System.Drawing.Size(1091, 46);
            this.edit_KorText.TabIndex = 63;
            // 
            // edit_English
            // 
            this.edit_English.BackColor = System.Drawing.SystemColors.Control;
            this.edit_English.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit_English.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_English.ForeColor = System.Drawing.Color.Blue;
            this.edit_English.Location = new System.Drawing.Point(104, 391);
            this.edit_English.Multiline = true;
            this.edit_English.Name = "edit_English";
            this.edit_English.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edit_English.Size = new System.Drawing.Size(1091, 46);
            this.edit_English.TabIndex = 61;
            this.edit_English.Text = "Correct answer\r\nCorrect answer\r\n";
            this.edit_English.TextChanged += new System.EventHandler(this.edit_CorrectAnswer_TextChanged);
            // 
            // edit_RecodeTime
            // 
            this.edit_RecodeTime.AcceptsReturn = true;
            this.edit_RecodeTime.Location = new System.Drawing.Point(831, 104);
            this.edit_RecodeTime.Multiline = true;
            this.edit_RecodeTime.Name = "edit_RecodeTime";
            this.edit_RecodeTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edit_RecodeTime.Size = new System.Drawing.Size(169, 79);
            this.edit_RecodeTime.TabIndex = 50;
            // 
            // edit_Log
            // 
            this.edit_Log.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_Log.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edit_Log.Location = new System.Drawing.Point(104, 531);
            this.edit_Log.Multiline = true;
            this.edit_Log.Name = "edit_Log";
            this.edit_Log.Size = new System.Drawing.Size(1097, 117);
            this.edit_Log.TabIndex = 34;
            this.edit_Log.TabStop = false;
            this.edit_Log.Text = "Correct";
            // 
            // edit_Hint
            // 
            this.edit_Hint.Location = new System.Drawing.Point(67, 260);
            this.edit_Hint.Name = "edit_Hint";
            this.edit_Hint.Size = new System.Drawing.Size(789, 21);
            this.edit_Hint.TabIndex = 28;
            // 
            // edit_Reference
            // 
            this.edit_Reference.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_Reference.Location = new System.Drawing.Point(104, 283);
            this.edit_Reference.Multiline = true;
            this.edit_Reference.Name = "edit_Reference";
            this.edit_Reference.Size = new System.Drawing.Size(1091, 58);
            this.edit_Reference.TabIndex = 26;
            this.edit_Reference.Text = "Reference";
            // 
            // redit_Text
            // 
            this.redit_Text.AcceptsTab = true;
            this.redit_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redit_Text.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redit_Text.Location = new System.Drawing.Point(107, 443);
            this.redit_Text.Name = "redit_Text";
            this.redit_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.redit_Text.Size = new System.Drawing.Size(1070, 46);
            this.redit_Text.TabIndex = 19;
            this.redit_Text.Text = "Correct\nCorrect";
            // 
            // edit_randomCnt
            // 
            this.edit_randomCnt.Location = new System.Drawing.Point(121, 203);
            this.edit_randomCnt.Name = "edit_randomCnt";
            this.edit_randomCnt.Size = new System.Drawing.Size(49, 21);
            this.edit_randomCnt.TabIndex = 15;
            this.edit_randomCnt.Text = "10";
            // 
            // edit_KeyCnt
            // 
            this.edit_KeyCnt.Location = new System.Drawing.Point(121, 144);
            this.edit_KeyCnt.Name = "edit_KeyCnt";
            this.edit_KeyCnt.ReadOnly = true;
            this.edit_KeyCnt.Size = new System.Drawing.Size(49, 21);
            this.edit_KeyCnt.TabIndex = 13;
            this.edit_KeyCnt.Text = "4";
            // 
            // btn_ShowEnglish
            // 
            this.btn_ShowEnglish.Location = new System.Drawing.Point(16, 390);
            this.btn_ShowEnglish.Name = "btn_ShowEnglish";
            this.btn_ShowEnglish.Size = new System.Drawing.Size(75, 28);
            this.btn_ShowEnglish.TabIndex = 24;
            this.btn_ShowEnglish.Text = "English(E)";
            this.btn_ShowEnglish.UseVisualStyleBackColor = true;
            this.btn_ShowEnglish.Click += new System.EventHandler(this.btn_ShowEnglish_Click);
            // 
            // CDlg_Tesper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 658);
            this.Controls.Add(this.ch_SentenceRepeat);
            this.Controls.Add(this.lb_CurrentCpm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ch_ShowReference);
            this.Controls.Add(this.ch_ShowEnglish);
            this.Controls.Add(this.ch_ShowKorean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit_CurrentKeyIdx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DataSave);
            this.Controls.Add(this.btn_Pass);
            this.Controls.Add(this.cmb_SectionName);
            this.Controls.Add(this.btn_CreateContent);
            this.Controls.Add(this.edit_SectionCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_HintShow);
            this.Controls.Add(this.btn_TestDataModify);
            this.Controls.Add(this.edit_KorText);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.edit_English);
            this.Controls.Add(this.btn_OpenCurrentlyDirectory);
            this.Controls.Add(this.btn_KorShow);
            this.Controls.Add(this.btn_Compare);
            this.Controls.Add(this.lb_NGCnt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ck_TypingPractice);
            this.Controls.Add(this.btn_disappear);
            this.Controls.Add(this.edit_RecodeTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_OkCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_file);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_LogShow);
            this.Controls.Add(this.edit_currentTime);
            this.Controls.Add(this.btn_LogUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.edit_Log);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edit_Hint);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.edit_Reference);
            this.Controls.Add(this.btn_ShowEnglish);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.redit_Text);
            this.Controls.Add(this.btn_HintShow);
            this.Controls.Add(this.lb_Hint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edit_randomCnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edit_KeyCnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtn_IndexRandom);
            this.Controls.Add(this.lb_LeftCount);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "CDlg_Tesper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " TesPer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CDlg_Tesper_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_LeftCount;
        private System.Windows.Forms.CheckBox rbtn_IndexRandom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CSubText edit_KeyCnt;
        private System.Windows.Forms.Label label8;
        private CSubText edit_randomCnt;
        private System.Windows.Forms.Label lb_Hint;
        private System.Windows.Forms.Button btn_HintShow;
        private CSubRichText redit_Text;
        private System.Windows.Forms.Button btn_Pass;
        private System.Windows.Forms.Label label9;
        private CSubText edit_Reference;
        private System.Windows.Forms.Button btn_Apply;
        private CSubText edit_Hint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_LogUpdate;
        private CSubText edit_Log;
        private System.Windows.Forms.Timer tmr_currentTime;
        private System.Windows.Forms.TextBox edit_currentTime;
        private System.Windows.Forms.Button btn_LogShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_file;
        private System.Windows.Forms.Label lb_OkCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_NonRandom;
        private System.Windows.Forms.RadioButton rbtn_random;
        private CSubText edit_RecodeTime;
        private System.Windows.Forms.Button btn_disappear;
        private System.Windows.Forms.CheckBox ck_TypingPractice;
        private System.Windows.Forms.Label lb_NGCnt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.Button btn_KorShow;
        private System.Windows.Forms.Button btn_OpenCurrentlyDirectory;
        private CSubText edit_English;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtn_LComprehension;
        private System.Windows.Forms.RadioButton rbtn_RComprehension;
        private CSubText edit_KorText;
        private System.Windows.Forms.Button btn_TestDataModify;
        private System.Windows.Forms.CheckBox ch_HintShow;
        private CSubText edit_SectionCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateContent;
        private System.Windows.Forms.ComboBox cmb_SectionName;
        private System.Windows.Forms.Button btn_DataSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private CSubText edit_CurrentKeyIdx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ch_ShowKorean;
        private System.Windows.Forms.CheckBox ch_ShowEnglish;
        private System.Windows.Forms.CheckBox ch_ShowReference;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_CurrentCpm;
        private System.Windows.Forms.CheckBox ch_SentenceRepeat;
        private System.Windows.Forms.Button btn_ShowEnglish;
    }
}

