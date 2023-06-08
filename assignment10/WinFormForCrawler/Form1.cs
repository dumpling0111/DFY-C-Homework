using SimpleCrawler;
using System.Security.Policy;

namespace WinFormForCrawler
{
    public partial class Form1 : Form
    {
        SimpleCrawler.SimpleCrawler crawler;
        public Form1()
        {
            InitializeComponent();
            crawler = new SimpleCrawler.SimpleCrawler();
            dgvInfo.DataSource = uRLInfoBindingSource;
            crawler.DispURLEvent += Crawler_DispURLEvent;
        }

        //�¼�������
        private void Crawler_DispURLEvent(URLInfo u)
        {
            Action action = () => { uRLInfoBindingSource.Add(u); };
            if (this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SimpleCrawler.SimpleCrawler.cnt = 1;
            uRLInfoBindingSource.Clear();   //���Ӵ˾䣬�������ϴ���ȡ����Ϣ��
            if (txtURL.Text == "")
                MessageBox.Show("������URL��");
            else
                crawler.Start(txtURL.Text);
        }
    }
}