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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSendPost = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.comSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.chkBox.Size = new System.Drawing.Size(1043, 516);
            this.chkBox.TabIndex = 3;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(88, 611);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(48, 16);
            this.chkAll.TabIndex = 4;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 606);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // btnSendPost
            // 
            this.btnSendPost.Location = new System.Drawing.Point(705, 603);
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
            // AutoPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 742);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSource);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnSendPost);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSendPost;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.ComboBox comSource;
        private System.Windows.Forms.Label label2;
    }
}