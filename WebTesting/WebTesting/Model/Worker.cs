using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTesting.Model
{
    class Worker
    {
        public string ID { get; set; }
        public string Breaks { get; set; }
        public string WorkTime { get; set; }
        public string Notice { get; set; }
        public IWebElement Add { get; set; }
        public IWebElement Absent { get; set; }
    }
}
