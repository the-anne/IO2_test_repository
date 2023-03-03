using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWMiNI.TddWorkshop.CalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        { 
            if(string.IsNullOrEmpty(numbers))
            { return 0; }

            string[] res = numbers.Split(',', '\n');
            int sum = 0;

            foreach(string s in res)
            {
                sum += Int32.Parse(s);
            }

            return sum;
        }
    }
}
