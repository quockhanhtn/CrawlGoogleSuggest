using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GoogleFakeAPI
{
   public partial class MainForm : Form
   {
      private string getSearchResultScript = @" let result = [];
                                                document.querySelectorAll('div[role=\'option\']').forEach(x => {
                                                     result.push(x.querySelector('span').innerHTML.replaceAll('<b>', '')
                                                                                                  .replaceAll('</b>', '')
                                                                                                  .replaceAll('&nbsp;', '')
                                                                 );
                                                });
                                                return result.join('!@#$%&*()'); ";

      private FirefoxDriver firefoxDriver;
      private FirefoxDriverService firefoxDriverService;
      private FirefoxOptions firefoxOptions;
      private IWebElement searchBar;

      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         firefoxDriverService = FirefoxDriverService.CreateDefaultService();
         firefoxDriverService.HideCommandPromptWindow = true;

         firefoxOptions = new FirefoxOptions();
         firefoxOptions.AddArgument("--window-position=-32000,-32000");

         firefoxDriver = new FirefoxDriver(firefoxDriverService, firefoxOptions);
         firefoxDriver.Manage().Window.Minimize();
         firefoxDriver.Url = "https://google.com";
         firefoxDriver.Navigate();

         Thread.Sleep(200);
         searchBar = firefoxDriver.FindElementByCssSelector("input[type=\'text\']");
         while (searchBar is null)
         {
            searchBar = firefoxDriver.FindElementByCssSelector("input[type=\'text\']");
         }
      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {
         listBox1.DataSource = new List<string>();
         searchBar.Clear();
         searchBar.SendKeys(txtSearch.Text);

         if (string.IsNullOrEmpty(txtSearch.Text)) { return; }

         string result = System.Net.WebUtility.HtmlDecode((string)firefoxDriver.ExecuteScript(getSearchResultScript));
         var list = result.Split(new string[] { "!@#$%&*()" }, StringSplitOptions.None).ToList();
         listBox1.DataSource = list;
      }

      private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         firefoxDriver.Close();
         firefoxDriver.Dispose();
         firefoxDriverService.Dispose();
      }
   }
}