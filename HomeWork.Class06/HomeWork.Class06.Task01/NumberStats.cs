using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Class06.Task01
{
    public class NumberStats
    {
        public double Number { get; set; }

        public bool isEven { get; set; }
        public bool isNegative { get; set; }
        public bool isDecimal { get; set; }

        public void PrintInfo()
        {
            string str = string.Format(@"Stats for number: {0} {1} {2}",
                Number,
                isNegative ? "Negarive" : "Positive",
                isDecimal ? "Decimal" : "Intager",
                isEven ? "Even" : "Odd"
                );
            Console.WriteLine(str);
        }


    }
}
