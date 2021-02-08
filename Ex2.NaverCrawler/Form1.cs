using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;


namespace NaverGoogle_AutoCrawler
{
    public partial class Form1 : Form
    {
        string result1, result2, result3, result4, result5, result6, result7, result8;

        
        public Form1()
        {
            InitializeComponent();
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            //크롬 드라이버 인스턴스 생성
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(service);
            driver.Url = "https://www.naver.com";
            driver.FindElement(By.Name("query")).SendKeys(textBox1.Text);
            driver.FindElement(By.Id("search_btn")).Click();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            try
            {
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[2]/div[1]/a")).Text);
                result1 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[1]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[2]/div[1]/a")).Text);
                result2 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[2]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[3]/div[1]/a")).Text);
                result3 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[3]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[4]/div[1]/a")).Text);
                result4 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[4]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[5]/div[1]/a")).Text);
                result1 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[5]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[6]/div[1]/a")).Text);
                result2 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[6]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[7]/div[1]/a")).Text);
                result3 = driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[7]/a")).GetAttribute("href");
            }
            catch (Exception e1)
            {
               
                listBox1.Items.Add("View가 없습니다.");
            }
            try
            {
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a/text")).Text);
                result5 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all2\"]/div[1]/div/a/text")).Text);
                result6 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all2\"]/div[2]/div/a/text")).Text);
                result7 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all2\"]/div[3]/div/a/text")).Text);
                result8 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
            }
            catch { listBox2.Items.Add("News가 없습니다."); }
            if (driver.Manage().Window == null) driver.Close();


        }
        private void SearchResult_btn_Click(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(service);
            //driver.Manage().Window.Maximize();
            if (listBox1.SelectedItem != null && listBox2.SelectedItem == null)
            {
                if (listBox1.SelectedIndex.Equals(0)) driver.Url = "http://" + result1;
                else if (listBox1.SelectedIndex.Equals(1)) driver.Url = "http://" + result2;
                else if (listBox1.SelectedIndex.Equals(2)) driver.Url = "http://" + result3;
                else if (listBox1.SelectedIndex.Equals(3)) driver.Url = "http://" + result4;
            }

            else if (listBox2.SelectedItem != null && listBox1.SelectedItem == null)
            {
                if (listBox2.SelectedIndex.Equals(0)) driver.Url = result5;
                else if (listBox2.SelectedIndex.Equals(1)) driver.Url = result6;
                else if (listBox2.SelectedIndex.Equals(2)) driver.Url = result7;
                else if (listBox2.SelectedIndex.Equals(3)) driver.Url = result8;
            }

            if (driver.Manage().Window == null) driver.Close();        // 이렇게 하면 창은 남기고 드라이버만 닫을 수 있다.
        }

        private void BackGroundSearch_btn_Click(object sender, EventArgs e)
        {

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            IWebDriver driver = new ChromeDriver(service, options);
            driver.Url = "https://www.naver.com";
            driver.FindElement(By.Name("query")).SendKeys(textBox1.Text);
            driver.FindElement(By.Id("search_btn")).Click();
            Thread.Sleep(2000);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            try
            {
                listBox1.Items.Add(driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[1]/a/text()")).Text);
                result1 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[1]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[2]/div[1]/a/text()")).Text);
                result2 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[2]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[3]/div[1]/a/text()")).Text);
                result3 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[3]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[4]/div[1]/a/text()")).Text);
                result4 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[4]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[5]/div[1]/a/text()")).Text);
                result1 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[5]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath("//*[@id=\"main_pack\"]/section[2]/div/div[2]/panel-list/div/ul/li[6]/div[1]/a/text()")).Text);
                result2 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[6]/a")).GetAttribute("href");
                listBox1.Items.Add(driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[7]/div[1]/a/text()")).Text);
                result3 = driver.FindElement(By.XPath(@"//*[@id=""main_pack""]/section[2]/div/div[2]/panel-list/div/ul/li[1]/div[7]/a")).GetAttribute("href");
            }
            catch { listBox1.Items.Add("View가 없습니다."); }
            try
            {
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a/text()")).Text);
                result5 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all2\"]/div[1]/div/a/text()")).Text);
                result6 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all2\"]/div[2]/div/a/text()")).Text);
                result7 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");
                listBox2.Items.Add(driver.FindElement(By.XPath("//*[@id=\"sp_nws_all2\"]/div[3]/div/a/text()")).Text);
                result8 = driver.FindElement(By.XPath("//*[@id=\"sp_nws_all1\"]/div/div/a")).GetAttribute("href");

            }
            catch { listBox2.Items.Add("News가 없습니다."); }
            if (driver.Manage().Window == null) driver.Close();
        }
        //
        private void WindowClose_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] process = new Process[100];
                process = Process.GetProcessesByName("chrome");
                foreach (Process x in process) x.Kill();
                process = Process.GetProcessesByName("chromedriver");
                foreach (Process x in process) x.Kill();
                process = Process.GetProcessesByName("conhost");
                foreach (Process x in process) x.Kill();
            }
            catch { }
        }
        private void ListBoxReset_btn_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            listBox2.SelectedItem = null;
        }
    }
}
