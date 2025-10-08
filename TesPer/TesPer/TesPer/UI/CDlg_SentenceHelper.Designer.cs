namespace TesPer
{
    partial class CDlg_SentenceHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Compare = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ch_ShowReference = new System.Windows.Forms.CheckBox();
            this.ch_ShowEnglish = new System.Windows.Forms.CheckBox();
            this.ch_ShowKorean = new System.Windows.Forms.CheckBox();
            this.ch_HintShow = new System.Windows.Forms.CheckBox();
            this.lb_CurrentCpm = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.edit_Log = new TesPer.CSubText();
            this.edit_KorText = new TesPer.CSubText();
            this.edit_English = new TesPer.CSubText();
            this.edit_Hint = new TesPer.CSubText();
            this.edit_Reference = new TesPer.CSubText();
            this.redit_Text = new TesPer.CSubRichText();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Compare
            // 
            this.btn_Compare.Location = new System.Drawing.Point(12, 261);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(75, 28);
            this.btn_Compare.TabIndex = 72;
            this.btn_Compare.Text = "Compare";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(29, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "&Log";
            // 
            // ch_ShowReference
            // 
            this.ch_ShowReference.AutoSize = true;
            this.ch_ShowReference.Checked = true;
            this.ch_ShowReference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ShowReference.Location = new System.Drawing.Point(8, 110);
            this.ch_ShowReference.Name = "ch_ShowReference";
            this.ch_ShowReference.Size = new System.Drawing.Size(81, 16);
            this.ch_ShowReference.TabIndex = 84;
            this.ch_ShowReference.Text = "Reference";
            this.ch_ShowReference.UseVisualStyleBackColor = true;
            // 
            // ch_ShowEnglish
            // 
            this.ch_ShowEnglish.AutoSize = true;
            this.ch_ShowEnglish.Checked = true;
            this.ch_ShowEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ShowEnglish.Location = new System.Drawing.Point(8, 215);
            this.ch_ShowEnglish.Name = "ch_ShowEnglish";
            this.ch_ShowEnglish.Size = new System.Drawing.Size(66, 16);
            this.ch_ShowEnglish.TabIndex = 83;
            this.ch_ShowEnglish.Text = "English";
            this.ch_ShowEnglish.UseVisualStyleBackColor = true;
            // 
            // ch_ShowKorean
            // 
            this.ch_ShowKorean.AutoSize = true;
            this.ch_ShowKorean.Checked = true;
            this.ch_ShowKorean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ShowKorean.Location = new System.Drawing.Point(8, 163);
            this.ch_ShowKorean.Name = "ch_ShowKorean";
            this.ch_ShowKorean.Size = new System.Drawing.Size(64, 16);
            this.ch_ShowKorean.TabIndex = 82;
            this.ch_ShowKorean.Text = "Korean";
            this.ch_ShowKorean.UseVisualStyleBackColor = true;
            // 
            // ch_HintShow
            // 
            this.ch_HintShow.AutoSize = true;
            this.ch_HintShow.Checked = true;
            this.ch_HintShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_HintShow.Location = new System.Drawing.Point(8, 76);
            this.ch_HintShow.Name = "ch_HintShow";
            this.ch_HintShow.Size = new System.Drawing.Size(79, 16);
            this.ch_HintShow.TabIndex = 81;
            this.ch_HintShow.Text = "show hint";
            this.ch_HintShow.UseVisualStyleBackColor = true;
            // 
            // lb_CurrentCpm
            // 
            this.lb_CurrentCpm.AutoSize = true;
            this.lb_CurrentCpm.Location = new System.Drawing.Point(96, 42);
            this.lb_CurrentCpm.Name = "lb_CurrentCpm";
            this.lb_CurrentCpm.Size = new System.Drawing.Size(87, 12);
            this.lb_CurrentCpm.TabIndex = 86;
            this.lb_CurrentCpm.Text = "Problem count";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 85;
            this.label16.Text = "Current CpM";
            // 
            // edit_Log
            // 
            this.edit_Log.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_Log.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edit_Log.Location = new System.Drawing.Point(101, 321);
            this.edit_Log.Multiline = true;
            this.edit_Log.Name = "edit_Log";
            this.edit_Log.Size = new System.Drawing.Size(1097, 117);
            this.edit_Log.TabIndex = 76;
            this.edit_Log.TabStop = false;
            this.edit_Log.Text = "Correct";
            // 
            // edit_KorText
            // 
            this.edit_KorText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.edit_KorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit_KorText.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.edit_KorText.Location = new System.Drawing.Point(98, 163);
            this.edit_KorText.Multiline = true;
            this.edit_KorText.Name = "edit_KorText";
            this.edit_KorText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edit_KorText.Size = new System.Drawing.Size(1091, 46);
            this.edit_KorText.TabIndex = 75;
            // 
            // edit_English
            // 
            this.edit_English.BackColor = System.Drawing.SystemColors.Control;
            this.edit_English.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit_English.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_English.ForeColor = System.Drawing.Color.Blue;
            this.edit_English.Location = new System.Drawing.Point(98, 209);
            this.edit_English.Multiline = true;
            this.edit_English.Name = "edit_English";
            this.edit_English.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edit_English.Size = new System.Drawing.Size(1091, 46);
            this.edit_English.TabIndex = 74;
            this.edit_English.Text = "Correct answer\r\nCorrect answer\r\n";
            // 
            // edit_Hint
            // 
            this.edit_Hint.Location = new System.Drawing.Point(98, 74);
            this.edit_Hint.Name = "edit_Hint";
            this.edit_Hint.Size = new System.Drawing.Size(789, 21);
            this.edit_Hint.TabIndex = 69;
            // 
            // edit_Reference
            // 
            this.edit_Reference.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_Reference.Location = new System.Drawing.Point(98, 101);
            this.edit_Reference.Multiline = true;
            this.edit_Reference.Name = "edit_Reference";
            this.edit_Reference.Size = new System.Drawing.Size(1091, 58);
            this.edit_Reference.TabIndex = 67;
            this.edit_Reference.Text = "Reference";
            // 
            // redit_Text
            // 
            this.redit_Text.AcceptsTab = true;
            this.redit_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redit_Text.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redit_Text.Location = new System.Drawing.Point(101, 261);
            this.redit_Text.Name = "redit_Text";
            this.redit_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.redit_Text.Size = new System.Drawing.Size(1070, 46);
            this.redit_Text.TabIndex = 65;
            this.redit_Text.Text = "Correct\nCorrect";
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(12, 410);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 28);
            this.btn_Modify.TabIndex = 87;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // CDlg_SentenceHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 450);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.lb_CurrentCpm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ch_ShowReference);
            this.Controls.Add(this.ch_ShowEnglish);
            this.Controls.Add(this.ch_ShowKorean);
            this.Controls.Add(this.ch_HintShow);
            this.Controls.Add(this.edit_Log);
            this.Controls.Add(this.edit_KorText);
            this.Controls.Add(this.edit_English);
            this.Controls.Add(this.btn_Compare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.edit_Hint);
            this.Controls.Add(this.edit_Reference);
            this.Controls.Add(this.redit_Text);
            this.Name = "CDlg_SentenceHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CDlg_SentenseHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CDlg_SentenceHelper_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CDlg_SentenceHelper_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSubText edit_KorText;
        private CSubText edit_English;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.Label label11;
        private CSubText edit_Hint;
        private CSubText edit_Reference;
        private CSubRichText redit_Text;
        private CSubText edit_Log;
        private System.Windows.Forms.CheckBox ch_ShowReference;
        private System.Windows.Forms.CheckBox ch_ShowEnglish;
        private System.Windows.Forms.CheckBox ch_ShowKorean;
        private System.Windows.Forms.CheckBox ch_HintShow;
        private System.Windows.Forms.Label lb_CurrentCpm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Modify;
    }
}