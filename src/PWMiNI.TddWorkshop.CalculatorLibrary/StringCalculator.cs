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

            string[] res = numbers.Split(',');
            int a = Int32.Parse(res[0]);
            int b = res.Length>1 ? Int32.Parse(res[1]) : 0;

            return a + b;
        }
    }
}
