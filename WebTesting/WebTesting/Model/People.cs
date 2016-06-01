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
        public List<string> IDs;
        public Worker wor;
        

        public void SetListOfIDs()
        {
            IDs = TestCases.driver.FindElements(By.XPath("//tr/td[1]/a")).Select(x=>x.Text).ToList();
        }

        public void SetListofWorkers(string ID)
        {
                //Console.WriteLine(TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'"+ IDs[i].Text +"')]/../..")).Text);
                wor = new Worker();
                wor.ID = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + ID + "')]/../../td[1]")).Text;
                wor.Breaks = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + ID + "')]/../../td[5]")).Text;
                wor.Notice = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + ID + "')]/../../td[8]")).Text;
                wor.WorkTime = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + ID + "')]/../../td[7]")).Text;
                wor.Add = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + ID + "')]/../../td/a[contains(text(),'add')]"));
                wor.Absence = TestCases.driver.FindElement(By.XPath("//tr/td/a[contains(text(),'" + ID + "')]/../../td/a[contains(text(),'absence')]"));

            //foreach(Worker wor in Workers)
            //{
            //    Console.WriteLine(wor.ID + " " + wor.WorkTime + " " + wor.Breaks + " " + wor.Notice);
            //}
           
        }
    }
}
