using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace WebTesting.Model
{
    class TestCases
    {
        static string url = "http://10.0.1.228/intern_web_testing/Attendance.mvc/WorkTimePerDay";
        public static IWebDriver driver;
        private int WorkerIndex = 7;
        People p = new People();

        public void Manager()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            p.SetListOfIDs();
            p.SetListofWorkers(p.IDs[WorkerIndex]);
            WorkTimeControl();
            SetAbsence();
            BreakeControl();
            SetBreak();
        }

        public void Close()
        {
            driver.Close();
        }

        public void WorkTimeControl()
        {
            p.wor.Add.Click();
                       
            driver.FindElement(By.Name("tick_in_time")).SendKeys("10:00");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("12:00");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            if (p.wor.WorkTime == "2:00")
            {
                Console.WriteLine("WorkTime Control was set on 2:00");
            }
            else { Console.WriteLine(""); }
            p.SetListofWorkers(p.IDs[WorkerIndex]);
        }

        public void SetAbsence()
        {
            p.wor.Absence.Click();
            
            SelectElement selectelement = new SelectElement(driver.FindElement(By.Name("absence_kind")));
            selectelement.SelectByText("Illness");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            if (p.wor.Notice == "Illness")
            {
                Console.WriteLine("Absence was set on Illness.");
            }
            WorkerIndex++;
            p.SetListofWorkers(p.IDs[WorkerIndex]);
        }

        public void BreakeControl()
        {
            p.wor.Add.Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("10:00");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("16:29");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            if(p.wor.Breaks == "0:29")
            {
                Console.WriteLine("Break was set on 0:29.");
            }
            WorkerIndex++;
            p.SetListofWorkers(p.IDs[WorkerIndex]);
        }

        public void SetBreak()
        {
            p.wor.Add.Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("10:00");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("12:00");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            p.SetListofWorkers(p.IDs[WorkerIndex]);

            p.wor.Add.Click();

            driver.FindElement(By.Name("tick_in_time")).SendKeys("12:30");
            driver.FindElement(By.Name("tick_out_time")).SendKeys("16:00");
            driver.FindElement(By.XPath("//*/form/p/input")).Click();
            
            if (p.wor.WorkTime == "5:30")
            {
                Console.WriteLine("WorkTime was set on 5:30");
            }
            p.SetListofWorkers(p.IDs[WorkerIndex]);
        }
    }
}
