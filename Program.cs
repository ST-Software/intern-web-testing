using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace web_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://10.0.1.228/intern_web_testing/Attendance.mvc/WorkTimePerDay");
                IList<IWebElement> even = driver.FindElements(By.ClassName("even"));
                IList<IWebElement> odd = driver.FindElements(By.ClassName("odd"));
                

            }
        }
    }
}
