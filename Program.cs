using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


namespace web_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                int counter = 1;
                driver.Navigate().GoToUrl("http://10.0.1.228/intern_web_testing/Attendance.mvc/WorkTimePerDay");
                IList<IWebElement> rows = driver.FindElements(By.CssSelector("tr"));
                     
                foreach (IWebElement row in rows.Skip(1))
                {
                    
                    IList<IWebElement> cells = row.FindElements(By.CssSelector("td"));
                   
                    Console.WriteLine(cells[0]);
                    counter += 1;
                    row.Click();
                }

                    Console.ReadKey();

            }

        }

    }
}
