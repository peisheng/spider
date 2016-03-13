namespace WebCrawler
{
    partial class Setting
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
            this.ListSource = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSourceName = new System.Windows.Forms.TextBox();
            this.txtSourceUrl = new System.Windows.Forms.TextBox();
            this.txtContentSelectMark = new System.Windows.Forms.TextBox();
            this.txtReplaceFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReplaceTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listTargetSiteUrl = new System.Windows.Forms.ListBox();
            this.comSiteList = new System.Windows.Forms.ComboBox();
            this.btnAddTarget = new System.Windows.Forms.Button();
            this.btnDeleteSiteUrl = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWebSiteBaseUrl = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.comSite = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelSite = new System.Windows.Forms.Button();
            this.btnDelSource = new System.Windows.Forms.Button();
            this.btnSaveSource = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListSource
            // 
            this.ListSource.FormattingEnabled = true;
            this.ListSource.ItemHeight = 12;
            this.ListSource.Location = new System.Drawing.Point(14, 58);
            this.ListSource.Name = "ListSource";
            this.ListSource.ScrollAlwaysVisible = true;
            this.ListSource.Size = new System.Drawing.Size(120, 436);
            this.ListSource.TabIndex = 0;
            this.ListSource.SelectedIndexChanged += new System.EventHandler(this.ListSource_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择源：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSiteUrl);
            this.groupBox1.Controls.Add(this.btnAddTarget);
            this.groupBox1.Controls.Add(this.comSiteList);
            this.groupBox1.Controls.Add(this.listTargetSiteUrl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtReplaceTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtReplaceFrom);
            this.groupBox1.Controls.Add(this.txtContentSelectMark);
            this.groupBox1.Controls.Add(this.txtSourceUrl);
            this.groupBox1.Controls.Add(this.txtSourceName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(168, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 439);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "源名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "源地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "内容选择标志：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "替换的文字：";
            // 
            // txtSourceName
            // 
            this.txtSourceName.Location = new System.Drawing.Point(66, 23);
            this.txtSourceName.Name = "txtSourceName";
            this.txtSourceName.Size = new System.Drawing.Size(424, 21);
            this.txtSourceName.TabIndex = 4;
            // 
            // txtSourceUrl
            // 
            this.txtSourceUrl.Location = new System.Drawing.Point(67, 59);
            this.txtSourceUrl.Name = "txtSourceUrl";
            this.txtSourceUrl.Size = new System.Drawing.Size(424, 21);
            this.txtSourceUrl.TabIndex = 5;
            // 
            // txtContentSelectMark
            // 
            this.txtContentSelectMark.Location = new System.Drawing.Point(92, 93);
            this.txtContentSelectMark.Name = "txtContentSelectMark";
            this.txtContentSelectMark.Size = new System.Drawing.Size(399, 21);
            this.txtContentSelectMark.TabIndex = 6;
            // 
            // txtReplaceFrom
            // 
            this.txtReplaceFrom.Location = new System.Drawing.Point(85, 129);
            this.txtReplaceFrom.Name = "txtReplaceFrom";
            this.txtReplaceFrom.Size = new System.Drawing.Size(139, 21);
            this.txtReplaceFrom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "=>";
            // 
            // txtReplaceTo
            // 
            this.txtReplaceTo.Location = new System.Drawing.Point(289, 129);
            this.txtReplaceTo.Name = "txtReplaceTo";
            this.txtReplaceTo.Size = new System.Drawing.Size(201, 21);
            this.txtReplaceTo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "目标网站：";
            // 
            // listTargetSiteUrl
            // 
            this.listTargetSiteUrl.FormattingEnabled = true;
            this.listTargetSiteUrl.ItemHeight = 12;
            this.listTargetSiteUrl.Location = new System.Drawing.Point(33, 190);
            this.listTargetSiteUrl.Name = "listTargetSiteUrl";
            this.listTargetSiteUrl.Size = new System.Drawing.Size(351, 244);
            this.listTargetSiteUrl.TabIndex = 11;
            // 
            // comSiteList
            // 
            this.comSiteList.FormattingEnabled = true;
            this.comSiteList.Location = new System.Drawing.Point(81, 164);
            this.comSiteList.Name = "comSiteList";
            this.comSiteList.Size = new System.Drawing.Size(303, 20);
            this.comSiteList.TabIndex = 12;
            this.comSiteList.SelectedIndexChanged += new System.EventHandler(this.comSiteList_SelectedIndexChanged);
            // 
            // btnAddTarget
            // 
            this.btnAddTarget.Location = new System.Drawing.Point(390, 162);
            this.btnAddTarget.Name = "btnAddTarget";
            this.btnAddTarget.Size = new System.Drawing.Size(101, 23);
            this.btnAddTarget.TabIndex = 13;
            this.btnAddTarget.Text = "添加目标网站";
            this.btnAddTarget.UseVisualStyleBackColor = true;
            this.btnAddTarget.Click += new System.EventHandler(this.btnAddTarget_Click);
            // 
            // btnDeleteSiteUrl
            // 
            this.btnDeleteSiteUrl.Location = new System.Drawing.Point(390, 225);
            this.btnDeleteSiteUrl.Name = "btnDeleteSiteUrl";
            this.btnDeleteSiteUrl.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteSiteUrl.TabIndex = 14;
            this.btnDeleteSiteUrl.Text = "删除选中地址";
            this.btnDeleteSiteUrl.UseVisualStyleBackColor = true;
            this.btnDeleteSiteUrl.Click += new System.EventHandler(this.btnDeleteSiteUrl_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(561, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(166, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "新建配置";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelSite);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.comSite);
            this.groupBox2.Controls.Add(this.txtSiteName);
            this.groupBox2.Controls.Add(this.txtWebSiteBaseUrl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAddSite);
            this.groupBox2.Location = new System.Drawing.Point(743, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 177);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网站配置";
            // 
            // btnAddSite
            // 
            this.btnAddSite.Location = new System.Drawing.Point(161, 14);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(75, 23);
            this.btnAddSite.TabIndex = 1;
            this.btnAddSite.Text = "新加网站";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "网址：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "网站名称：";
            // 
            // txtWebSiteBaseUrl
            // 
            this.txtWebSiteBaseUrl.Location = new System.Drawing.Point(55, 57);
            this.txtWebSiteBaseUrl.Name = "txtWebSiteBaseUrl";
            this.txtWebSiteBaseUrl.Size = new System.Drawing.Size(181, 21);
            this.txtWebSiteBaseUrl.TabIndex = 4;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(55, 85);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(181, 21);
            this.txtSiteName.TabIndex = 5;
            // 
            // comSite
            // 
            this.comSite.FormattingEnabled = true;
            this.comSite.Location = new System.Drawing.Point(9, 16);
            this.comSite.Name = "comSite";
            this.comSite.Size = new System.Drawing.Size(136, 20);
            this.comSite.TabIndex = 6;
            this.comSite.SelectedIndexChanged += new System.EventHandler(this.comSite_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelSite
            // 
            this.btnDelSite.Location = new System.Drawing.Point(71, 131);
            this.btnDelSite.Name = "btnDelSite";
            this.btnDelSite.Size = new System.Drawing.Size(75, 23);
            this.btnDelSite.TabIndex = 8;
            this.btnDelSite.Text = "删除";
            this.btnDelSite.UseVisualStyleBackColor = true;
            this.btnDelSite.Click += new System.EventHandler(this.btnDelSite_Click);
            // 
            // btnDelSource
            // 
            this.btnDelSource.Location = new System.Drawing.Point(743, 317);
            this.btnDelSource.Name = "btnDelSource";
            this.btnDelSource.Size = new System.Drawing.Size(209, 23);
            this.btnDelSource.TabIndex = 5;
            this.btnDelSource.Text = "删除选中的源配置";
            this.btnDelSource.UseVisualStyleBackColor = true;
            this.btnDelSource.Click += new System.EventHandler(this.btnDelSource_Click);
            // 
            // btnSaveSource
            // 
            this.btnSaveSource.Location = new System.Drawing.Point(743, 384);
            this.btnSaveSource.Name = "btnSaveSource";
            this.btnSaveSource.Size = new System.Drawing.Size(209, 23);
            this.btnSaveSource.TabIndex = 6;
            this.btnSaveSource.Text = "保存源配置";
            this.btnSaveSource.UseVisualStyleBackColor = true;
            this.btnSaveSource.Click += new System.EventHandler(this.btnSaveSource_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 509);
            this.Controls.Add(this.btnSaveSource);
            this.Controls.Add(this.btnDelSource);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListSource);
            this.Name = "Setting";
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReplaceFrom;
        private System.Windows.Forms.TextBox txtContentSelectMark;
        private System.Windows.Forms.TextBox txtSourceUrl;
        private System.Windows.Forms.TextBox txtSourceName;
        private System.Windows.Forms.TextBox txtReplaceTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listTargetSiteUrl;
        private System.Windows.Forms.Button btnAddTarget;
        private System.Windows.Forms.ComboBox comSiteList;
        private System.Windows.Forms.Button btnDeleteSiteUrl;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.TextBox txtWebSiteBaseUrl;
        private System.Windows.Forms.ComboBox comSite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelSite;
        private System.Windows.Forms.Button btnDelSource;
        private System.Windows.Forms.Button btnSaveSource;
    }
}