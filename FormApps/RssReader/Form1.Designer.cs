
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsinfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWorld = new System.Windows.Forms.RadioButton();
            this.tbIt = new System.Windows.Forms.RadioButton();
            this.rbDomestic = new System.Windows.Forms.RadioButton();
            this.rbScience = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(399, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGet.Location = new System.Drawing.Point(417, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(50, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRssTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(514, 12);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(512, 268);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrowser.Location = new System.Drawing.Point(26, 309);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1000, 388);
            this.wbBrowser.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsinfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsinfo
            // 
            this.tsinfo.Name = "tsinfo";
            this.tsinfo.Size = new System.Drawing.Size(51, 17);
            this.tsinfo.Text = "ステータス";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWorld);
            this.groupBox1.Controls.Add(this.tbIt);
            this.groupBox1.Controls.Add(this.rbDomestic);
            this.groupBox1.Controls.Add(this.rbScience);
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbWorld
            // 
            this.rbWorld.AutoSize = true;
            this.rbWorld.Location = new System.Drawing.Point(7, 83);
            this.rbWorld.Name = "rbWorld";
            this.rbWorld.Size = new System.Drawing.Size(47, 16);
            this.rbWorld.TabIndex = 3;
            this.rbWorld.TabStop = true;
            this.rbWorld.Text = "国際";
            this.rbWorld.UseVisualStyleBackColor = true;
            this.rbWorld.CheckedChanged += new System.EventHandler(this.rbWorld_CheckedChanged);
            // 
            // tbIt
            // 
            this.tbIt.AutoSize = true;
            this.tbIt.Location = new System.Drawing.Point(7, 41);
            this.tbIt.Name = "tbIt";
            this.tbIt.Size = new System.Drawing.Size(33, 16);
            this.tbIt.TabIndex = 2;
            this.tbIt.TabStop = true;
            this.tbIt.Text = "IT";
            this.tbIt.UseVisualStyleBackColor = true;
            this.tbIt.CheckedChanged += new System.EventHandler(this.tbIt_CheckedChanged);
            // 
            // rbDomestic
            // 
            this.rbDomestic.AutoSize = true;
            this.rbDomestic.Location = new System.Drawing.Point(7, 61);
            this.rbDomestic.Name = "rbDomestic";
            this.rbDomestic.Size = new System.Drawing.Size(47, 16);
            this.rbDomestic.TabIndex = 1;
            this.rbDomestic.TabStop = true;
            this.rbDomestic.Text = "国内";
            this.rbDomestic.UseVisualStyleBackColor = true;
            this.rbDomestic.CheckedChanged += new System.EventHandler(this.rbDomestic_CheckedChanged);
            // 
            // rbScience
            // 
            this.rbScience.AutoSize = true;
            this.rbScience.Location = new System.Drawing.Point(7, 19);
            this.rbScience.Name = "rbScience";
            this.rbScience.Size = new System.Drawing.Size(47, 16);
            this.rbScience.TabIndex = 0;
            this.rbScience.TabStop = true;
            this.rbScience.Text = "科学";
            this.rbScience.UseVisualStyleBackColor = true;
            this.rbScience.CheckedChanged += new System.EventHandler(this.rbScience_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 35);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 35);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 738);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWorld;
        private System.Windows.Forms.RadioButton tbIt;
        private System.Windows.Forms.RadioButton rbDomestic;
        private System.Windows.Forms.RadioButton rbScience;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

