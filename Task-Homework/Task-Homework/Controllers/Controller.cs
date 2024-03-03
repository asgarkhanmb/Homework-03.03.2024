using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Homework.Services;

namespace Task_Homework.Controllers
{
    internal class Controller
    {

        CalculatorService _calculatorService;
        public Controller()
        {
            _calculatorService = new CalculatorService();
        }
        public void Calculator()
        {
            Console.WriteLine("Add first number");
            double a =double.Parse(Console.ReadLine());
            Console.WriteLine("Add second number");
            double b=double.Parse(Console.ReadLine());
            Console.WriteLine("Operation select");
            char c=char.Parse (Console.ReadLine());

            
            Console.WriteLine(_calculatorService.Calculator(a,b,c));
        }

    }
}
