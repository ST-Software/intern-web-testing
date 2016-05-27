using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTesting.Model
{
    class WorkTimeControl
    {
        string url = "http://10.0.1.228/intern_web_testing/Attendance.mvc/WorkTimePerDay";
        IWebDriver driver;
        public void OpenChrome()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath("//div[1]/table/tbody/tr[2]/td[15]/a")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
