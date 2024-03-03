using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Models
{
    internal class Doctor
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        static Doctor()
        {
            Console.WriteLine("static construction");
        }
        public Doctor()
        {
            Console.WriteLine("non-static construction");
        }
    }
}
