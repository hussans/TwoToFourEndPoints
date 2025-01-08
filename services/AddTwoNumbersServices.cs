using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFourEndPoints.services
{
    public class AddTwoNumbersServices
    {
        public string GetSum(int num1, int num2)
        {
            int result = num1 + num2;
            return $"{num1} + {num2} = {result}";
        }
    }
}