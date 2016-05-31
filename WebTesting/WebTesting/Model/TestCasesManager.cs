using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace WebTesting.Model
{
    class TestCases
    {
        static string url = "http://10.0.1.228/intern_web_testing/Attendance.mvc/WorkTimePerDay";
        public static IWebDriver driver;

        public void OpenChrome()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            People p = new People();
            p.SetListOfIDs();
            p.SetListofWorkers();
            //WorkTimeControl();
            //SetAbsence();
            //BreakeControl();
            //SetBreak();
        }

        public void WorkTimeControl()
        {
            driver.FindElement(By.PartialLinkText("add")).Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("10:00");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("12:00");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            string worktime = driver.FindElement(By.XPath("//*/div[1]/table/tbody/tr[2]/td[7]")).Text;
            if (worktime == "2:00")
            {
                Console.WriteLine("WorkTime Control was set on 2:00");
            }
            else { Console.WriteLine(""); }
        }

        public void SetAbsence()
        {
            driver.FindElement(By.PartialLinkText("absence")).Click();

            var element = driver.FindElement(By.Name("absence_kind"));
            var selectelement = new SelectElement(element);
            selectelement.SelectByText("Illness");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            string notice = driver.FindElement(By.XPath("//*/div[1]/table/tbody/tr[2]/td[8]/span")).Text;
            if (notice == "Illness")
            {
                Console.WriteLine("Absence was set on Illness.");
            }
        }

        public void BreakeControl()
        {
            driver.FindElement(By.PartialLinkText("add")).Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("10:00");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("16:29");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            string breaktime = driver.FindElement(By.XPath("//*/div[1]/table/tbody/tr[2]/td[5]")).Text;
            if(breaktime == "0:29")
            {
                Console.WriteLine("Break was set on 0:29.");
            }
        }

        public void SetBreak()
        {
            driver.FindElement(By.PartialLinkText("add")).Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("10:00");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("12:00");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();

            driver.FindElement(By.PartialLinkText("add")).Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("12:30");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("16:00");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();

            string worktime = driver.FindElement(By.XPath("//*/div[1]/table/tbody/tr[2]/td[7]")).Text;
            if (worktime == "5:30")
            {
                Console.WriteLine("WorkTime was set on 5:30");
            }
        }
    }
}
