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
        public string TickIn { get; set; }
        public string TickOut { get; set; }
        public string Breaks { get; set; }
        public string WorkTime { get; set; }
        public string Notice { get; set; }
    }
}
