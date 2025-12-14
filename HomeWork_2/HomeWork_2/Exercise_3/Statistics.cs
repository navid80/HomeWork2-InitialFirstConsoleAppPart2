using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2.Exercise_3
{
    public class Statistics
    {
        public void AnalyzeNumbers(int firstNumber, ref int secondNumber, out int ThirdNumber)
        {
            ThirdNumber = firstNumber + secondNumber;
            secondNumber = secondNumber * secondNumber;
            Console.WriteLine($"First Number : {firstNumber}");
        }
    }
}
