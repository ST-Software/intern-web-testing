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
                IList<IWebElement> even = driver.FindElements(By.ClassName("even"));
                IList<IWebElement> odd = driver.FindElements(By.ClassName("odd"));
                //foreach(var item in even)
                //{
                //    item.FindElements(By.LinkText()
                //}
                foreach (IWebElement option in even)
                {
                    Console.WriteLine(counter.ToString() +") " + option.Text);
                    counter += 1;
                    option.Click();
                }
                Console.ReadKey();


            }
        }
    }
}
