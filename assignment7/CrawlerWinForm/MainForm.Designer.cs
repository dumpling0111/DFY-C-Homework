namespace CrawlerWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.URLInput = new System.Windows.Forms.TextBox();
            this.URLInputLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.successURLMessage = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.successLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.failedURLMessage = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.failedLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.successDataLabel = new System.Windows.Forms.Label();
            this.remindLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.remindLabel);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.URLInput);
            this.panel1.Controls.Add(this.URLInputLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(643, 20);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(95, 31);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "启动爬虫";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // URLInput
            // 
            this.URLInput.Location = new System.Drawing.Point(153, 23);
            this.URLInput.Name = "URLInput";
            this.URLInput.Size = new System.Drawing.Size(441, 25);
            this.URLInput.TabIndex = 1;
            // 
            // URLInputLabel
            // 
            this.URLInputLabel.AutoSize = true;
            this.URLInputLabel.Location = new System.Drawing.Point(20, 28);
            this.URLInputLabel.Name = "URLInputLabel";
            this.URLInputLabel.Size = new System.Drawing.Size(127, 15);
            this.URLInputLabel.TabIndex = 0;
            this.URLInputLabel.Text = "请输入初始地址：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 349);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 143);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 206);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.successURLMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 46);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(399, 160);
            this.panel5.TabIndex = 3;
            // 
            // successURLMessage
            // 
            this.successURLMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.successURLMessage.Location = new System.Drawing.Point(20, 20);
            this.successURLMessage.Multiline = true;
            this.successURLMessage.Name = "successURLMessage";
            this.successURLMessage.ReadOnly = true;
            this.successURLMessage.Size = new System.Drawing.Size(359, 120);
            this.successURLMessage.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.successLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 46);
            this.panel3.TabIndex = 2;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(16, 18);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(121, 15);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "成功爬取的URL：";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.failedURLMessage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 46);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(20);
            this.panel6.Size = new System.Drawing.Size(397, 160);
            this.panel6.TabIndex = 3;
            // 
            // failedURLMessage
            // 
            this.failedURLMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.failedURLMessage.Location = new System.Drawing.Point(20, 20);
            this.failedURLMessage.Multiline = true;
            this.failedURLMessage.Name = "failedURLMessage";
            this.failedURLMessage.ReadOnly = true;
            this.failedURLMessage.Size = new System.Drawing.Size(357, 120);
            this.failedURLMessage.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.failedLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 46);
            this.panel4.TabIndex = 2;
            // 
            // failedLabel
            // 
            this.failedLabel.AutoSize = true;
            this.failedLabel.Location = new System.Drawing.Point(18, 18);
            this.failedLabel.Name = "failedLabel";
            this.failedLabel.Size = new System.Drawing.Size(82, 15);
            this.failedLabel.TabIndex = 1;
            this.failedLabel.Text = "失败信息：";
            this.failedLabel.Click += new System.EventHandler(this.failedLabel_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.splitContainer2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(800, 143);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.successDataLabel);
            this.panel8.Location = new System.Drawing.Point(308, 17);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 37);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Location = new System.Drawing.Point(29, 17);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(20);
            this.panel9.Size = new System.Drawing.Size(273, 46);
            this.panel9.TabIndex = 1;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // successDataLabel
            // 
            this.successDataLabel.AutoSize = true;
            this.successDataLabel.Location = new System.Drawing.Point(27, 12);
            this.successDataLabel.Name = "successDataLabel";
            this.successDataLabel.Size = new System.Drawing.Size(82, 15);
            this.successDataLabel.TabIndex = 0;
            this.successDataLabel.Text = "爬虫数据：";
            // 
            // remindLabel
            // 
            this.remindLabel.AutoSize = true;
            this.remindLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.remindLabel.Location = new System.Drawing.Point(22, 68);
            this.remindLabel.Name = "remindLabel";
            this.remindLabel.Size = new System.Drawing.Size(619, 15);
            this.remindLabel.TabIndex = 3;
            this.remindLabel.Text = "注意！本程序只有当爬取的是htm/html/aspx/php/jsp等网页时，才解析并爬取下一级URL。";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(233, 6);
            this.textBox1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(262, 6);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel9);
            this.splitContainer2.Panel1.Controls.Add(this.panel8);
            this.splitContainer2.Size = new System.Drawing.Size(502, 131);
            this.splitContainer2.SplitterDistance = 65;
            this.splitContainer2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "爬虫";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox URLInput;
        private System.Windows.Forms.Label URLInputLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox successURLMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label failedLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox failedURLMessage;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label remindLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label successDataLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

