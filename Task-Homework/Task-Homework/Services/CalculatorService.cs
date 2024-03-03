using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Homework.Services
{
    internal class CalculatorService
    {
       public double Calculator(double a,double b,char calculator)
        {
          switch (calculator)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case  '/':
                    return  a / b;
            }
            return 0;
        }

    }
}
