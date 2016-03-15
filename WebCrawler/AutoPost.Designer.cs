namespace WebCrawler
{
    partial class AutoPost
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.chkBox = new System.Windows.Forms.CheckedListBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnSendPost = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.comSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContentMark = new System.Windows.Forms.TextBox();
            this.targetSiteList = new System.Windows.Forms.ListBox();
            this.txtReplaceForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReplaceTo = new System.Windows.Forms.TextBox();
            this.btnRunAll = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接：";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(88, 49);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(490, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(605, 46);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "获取子连接";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // chkBox
            // 
            this.chkBox.FormattingEnabled = true;
            this.chkBox.HorizontalExtent = 5;
            this.chkBox.HorizontalScrollbar = true;
            this.chkBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkBox.Location = new System.Drawing.Point(88, 76);
            this.chkBox.Name = "chkBox";
            this.chkBox.ScrollAlwaysVisible = true;
            this.chkBox.Size = new System.Drawing.Size(1043, 356);
            this.chkBox.TabIndex = 3;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(88, 445);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(48, 16);
            this.chkAll.TabIndex = 4;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnSendPost
            // 
            this.btnSendPost.Location = new System.Drawing.Point(1000, 437);
            this.btnSendPost.Name = "btnSendPost";
            this.btnSendPost.Size = new System.Drawing.Size(131, 23);
            this.btnSendPost.TabIndex = 6;
            this.btnSendPost.Text = "自动发布到草搞箱";
            this.btnSendPost.UseVisualStyleBackColor = true;
            this.btnSendPost.Click += new System.EventHandler(this.btnSendPost_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(88, 13);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // comSource
            // 
            this.comSource.FormattingEnabled = true;
            this.comSource.Location = new System.Drawing.Point(338, 16);
            this.comSource.Name = "comSource";
            this.comSource.Size = new System.Drawing.Size(188, 20);
            this.comSource.TabIndex = 8;
            this.comSource.SelectedIndexChanged += new System.EventHandler(this.comSource_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "加载配置：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "提取标志：";
            // 
            // txtContentMark
            // 
            this.txtContentMark.Location = new System.Drawing.Point(223, 443);
            this.txtContentMark.Name = "txtContentMark";
            this.txtContentMark.ReadOnly = true;
            this.txtContentMark.Size = new System.Drawing.Size(229, 21);
            this.txtContentMark.TabIndex = 11;
            // 
            // targetSiteList
            // 
            this.targetSiteList.FormattingEnabled = true;
            this.targetSiteList.ItemHeight = 12;
            this.targetSiteList.Location = new System.Drawing.Point(496, 438);
            this.targetSiteList.Name = "targetSiteList";
            this.targetSiteList.Size = new System.Drawing.Size(468, 64);
            this.targetSiteList.TabIndex = 12;
            // 
            // txtReplaceForm
            // 
            this.txtReplaceForm.Location = new System.Drawing.Point(163, 470);
            this.txtReplaceForm.Name = "txtReplaceForm";
            this.txtReplaceForm.ReadOnly = true;
            this.txtReplaceForm.Size = new System.Drawing.Size(110, 21);
            this.txtReplaceForm.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "=>";
            // 
            // txtReplaceTo
            // 
            this.txtReplaceTo.Location = new System.Drawing.Point(302, 468);
            this.txtReplaceTo.Name = "txtReplaceTo";
            this.txtReplaceTo.ReadOnly = true;
            this.txtReplaceTo.Size = new System.Drawing.Size(150, 21);
            this.txtReplaceTo.TabIndex = 15;
            // 
            // btnRunAll
            // 
            this.btnRunAll.Location = new System.Drawing.Point(1000, 468);
            this.btnRunAll.Name = "btnRunAll";
            this.btnRunAll.Size = new System.Drawing.Size(131, 23);
            this.btnRunAll.TabIndex = 16;
            this.btnRunAll.Text = "自动运行全部配置";
            this.btnRunAll.UseVisualStyleBackColor = true;
            this.btnRunAll.Click += new System.EventHandler(this.btnRunAll_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1000, 500);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(131, 23);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = " 测试标签对应的值";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // AutoPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 535);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnRunAll);
            this.Controls.Add(this.txtReplaceTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReplaceForm);
            this.Controls.Add(this.targetSiteList);
            this.Controls.Add(this.txtContentMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSource);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnSendPost);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "AutoPost";
            this.Text = "AutoPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.CheckedListBox chkBox;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnSendPost;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.ComboBox comSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContentMark;
        private System.Windows.Forms.ListBox targetSiteList;
        private System.Windows.Forms.TextBox txtReplaceForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReplaceTo;
        private System.Windows.Forms.Button btnRunAll;
        private System.Windows.Forms.Button btnTest;
    }
}