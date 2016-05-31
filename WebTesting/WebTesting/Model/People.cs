using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebTesting.Model
{
    class People
    {
        IList<IWebElement> IDs;
        public List<Worker> Workers;

        public void SetListOfIDs()
        {
            IDs = TestCases.driver.FindElements(By.XPath("//tr/td[1]/a"));
            
            foreach (IWebElement element in IDs)
            {
                
                //Console.WriteLine(element.Text);
            }
        }

        public void SetListofWorkers()
        {
            for(int i = 0; i < IDs.Count; i++)
            {
                //Console.WriteLine(TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'"+ IDs[i].Text +"')]/../..")).Text);
                Workers[i].ID = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + IDs[i].Text + "')]/../../td[1]")).Text;
                Workers[i].Breaks = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + IDs[i].Text + "')]/../../td[5]")).Text;
                Workers[i].Notice = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + IDs[i].Text + "')]/../../td[8]")).Text;
                Workers[i].WorkTime = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + IDs[i].Text + "')]/../../td[7]")).Text;
                Workers[i].Add = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + IDs[i].Text + "')]/../../td/a[contains(text(),'add')]"));
                Workers[i].Absent = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + IDs[i].Text + "')]/../../td/a[contains(text(),'absence')]"));
            }
           
        }
    }
}
