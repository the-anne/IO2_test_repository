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
                int x = Int32.Parse(s);
                if(x<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                sum += x;
            }

            return sum;
        }
    }
}
