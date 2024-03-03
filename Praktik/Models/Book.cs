using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Models
{
    internal class Book
    {
        public const int num = 5;
        public int result = 0;
        static Book()
        {
            Console.WriteLine(num);
        }
    }
}
