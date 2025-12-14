using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2.Exercise_4
{
    public class ArrayAnalyzer
    {
        public void AnalyzeArray(int[]? numbers, ref int max, out double average)
        {
            if (numbers.Length == 0 || numbers == null)
            {
                max = 0;
                average = 0;
            }
            else
            {
                max = numbers.Max();
                average = numbers.Average();
            }
        }
    }
}
