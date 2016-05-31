using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTesting.Model;


namespace WebTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCases work = new TestCases();
            work.OpenChrome();
            Console.ReadKey();
        }
    }
}
