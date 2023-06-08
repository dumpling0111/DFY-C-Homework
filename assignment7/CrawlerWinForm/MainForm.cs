using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = URLInput.Text;
            successURLMessage.Text = "";
            failedURLMessage.Text = "";
            startUrl = startUrl.Replace(" ", "");
            if (startUrl == "")
            {
                //默认地址
                startUrl = "http://www.cnblogs.com/dstang2000/";
                URLInput.Text = startUrl;
            }
            //链接无效
            if (!myCrawler.verifyStartURL(startUrl))
            {
                failedURLMessage.Text = "您输入的链接无效！请检查是否拼写错误或者类型错误。\n 本程序只接受htm/html/aspx/php/jsp网页。";
                return;
            }
            //if (args.Length >= 1) startUrl = args[0];
            //myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void failedLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
