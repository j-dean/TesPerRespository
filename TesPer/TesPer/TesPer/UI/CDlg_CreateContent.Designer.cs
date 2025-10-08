namespace TesPer
{
    partial class CDlg_CreateContent
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
            if ( disposing && (components != null) )
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_Hint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Key = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_KeyDataAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_Korean = new TesPer.CSubText();
            this.edit_Reference = new TesPer.CSubText();
            this.edit_English = new TesPer.CSubText();
            this.edit_Section = new System.Windows.Forms.TextBox();
            this.btn_KeyDelete = new System.Windows.Forms.Button();
            this.btn_KeyModify = new System.Windows.Forms.Button();
            this.btn_excelOpen = new System.Windows.Forms.Button();
            this.edit_Hint = new TesPer.CSubText();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(782, 561);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(123, 23);
            this.btn_OK.TabIndex = 69;
            this.btn_OK.Text = "Save";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(911, 561);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 23);
            this.btn_Cancel.TabIndex = 70;
            this.btn_Cancel.Text = "cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lb_Hint
            // 
            this.lb_Hint.AutoSize = true;
            this.lb_Hint.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Hint.Location = new System.Drawing.Point(8, 17);
            this.lb_Hint.Name = "lb_Hint";
            this.lb_Hint.Size = new System.Drawing.Size(67, 19);
            this.lb_Hint.TabIndex = 72;
            this.lb_Hint.Text = "Korean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "English";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(-10, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "&Reference";
            // 
            // cmb_Key
            // 
            this.cmb_Key.FormattingEnabled = true;
            this.cmb_Key.Location = new System.Drawing.Point(83, 149);
            this.cmb_Key.Name = "cmb_Key";
            this.cmb_Key.Size = new System.Drawing.Size(157, 20);
            this.cmb_Key.TabIndex = 80;
            this.cmb_Key.SelectedIndexChanged += new System.EventHandler(this.cmb_Key_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Key Idx";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(13, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 83;
            this.label10.Text = "&Hint";
            // 
            // btn_KeyDataAdd
            // 
            this.btn_KeyDataAdd.Location = new System.Drawing.Point(647, 412);
            this.btn_KeyDataAdd.Name = "btn_KeyDataAdd";
            this.btn_KeyDataAdd.Size = new System.Drawing.Size(123, 23);
            this.btn_KeyDataAdd.TabIndex = 85;
            this.btn_KeyDataAdd.Text = "Add";
            this.btn_KeyDataAdd.UseVisualStyleBackColor = true;
            this.btn_KeyDataAdd.Click += new System.EventHandler(this.btn_TestDataAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 89;
            this.label3.Text = "Section Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Hint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edit_Korean);
            this.groupBox1.Controls.Add(this.edit_Reference);
            this.groupBox1.Controls.Add(this.edit_English);
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 222);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Data";
            // 
            // edit_Korean
            // 
            this.edit_Korean.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_Korean.Location = new System.Drawing.Point(12, 43);
            this.edit_Korean.Multiline = true;
            this.edit_Korean.Name = "edit_Korean";
            this.edit_Korean.Size = new System.Drawing.Size(1010, 45);
            this.edit_Korean.TabIndex = 87;
            this.edit_Korean.Text = "저는 다른 선택을 할게요.";
            // 
            // edit_Reference
            // 
            this.edit_Reference.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_Reference.Location = new System.Drawing.Point(12, 113);
            this.edit_Reference.Name = "edit_Reference";
            this.edit_Reference.Size = new System.Drawing.Size(1010, 30);
            this.edit_Reference.TabIndex = 79;
            this.edit_Reference.Text = "ReferDefalt";
            // 
            // edit_English
            // 
            this.edit_English.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.edit_English.Location = new System.Drawing.Point(12, 168);
            this.edit_English.Multiline = true;
            this.edit_English.Name = "edit_English";
            this.edit_English.Size = new System.Drawing.Size(1010, 45);
            this.edit_English.TabIndex = 86;
            this.edit_English.Text = "I\'m gonna make another choice.";
            // 
            // edit_Section
            // 
            this.edit_Section.Location = new System.Drawing.Point(140, 28);
            this.edit_Section.Name = "edit_Section";
            this.edit_Section.Size = new System.Drawing.Size(732, 21);
            this.edit_Section.TabIndex = 91;
            this.edit_Section.Text = "Cresh Course";
            // 
            // btn_KeyDelete
            // 
            this.btn_KeyDelete.Location = new System.Drawing.Point(911, 412);
            this.btn_KeyDelete.Name = "btn_KeyDelete";
            this.btn_KeyDelete.Size = new System.Drawing.Size(123, 23);
            this.btn_KeyDelete.TabIndex = 92;
            this.btn_KeyDelete.Text = "Delete";
            this.btn_KeyDelete.UseVisualStyleBackColor = true;
            // 
            // btn_KeyModify
            // 
            this.btn_KeyModify.Location = new System.Drawing.Point(782, 412);
            this.btn_KeyModify.Name = "btn_KeyModify";
            this.btn_KeyModify.Size = new System.Drawing.Size(123, 23);
            this.btn_KeyModify.TabIndex = 93;
            this.btn_KeyModify.Text = "Modify";
            this.btn_KeyModify.UseVisualStyleBackColor = true;
            // 
            // btn_excelOpen
            // 
            this.btn_excelOpen.Location = new System.Drawing.Point(896, 28);
            this.btn_excelOpen.Name = "btn_excelOpen";
            this.btn_excelOpen.Size = new System.Drawing.Size(103, 23);
            this.btn_excelOpen.TabIndex = 94;
            this.btn_excelOpen.Text = "excel Open";
            this.btn_excelOpen.UseVisualStyleBackColor = true;
            this.btn_excelOpen.Click += new System.EventHandler(this.btn_excelOpen_Click);
            // 
            // edit_Hint
            // 
            this.edit_Hint.Location = new System.Drawing.Point(83, 61);
            this.edit_Hint.Name = "edit_Hint";
            this.edit_Hint.Size = new System.Drawing.Size(789, 21);
            this.edit_Hint.TabIndex = 82;
            this.edit_Hint.Text = "Defalt";
            // 
            // CDlg_CreateContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 774);
            this.Controls.Add(this.btn_excelOpen);
            this.Controls.Add(this.btn_KeyModify);
            this.Controls.Add(this.btn_KeyDelete);
            this.Controls.Add(this.edit_Section);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_KeyDataAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edit_Hint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Key);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "CDlg_CreateContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CDlg_CreateContent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_Hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private CSubText edit_Reference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private CSubText edit_Hint;
        private System.Windows.Forms.Button btn_KeyDataAdd;
        private CSubText edit_English;
        private CSubText edit_Korean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edit_Section;
        private System.Windows.Forms.Button btn_KeyDelete;
        private System.Windows.Forms.Button btn_KeyModify;
        private System.Windows.Forms.Button btn_excelOpen;
    }
}