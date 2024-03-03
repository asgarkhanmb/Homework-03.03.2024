using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_Homework.Helpers.Extensions
{
    internal static class TextExtensions
    {
     public static bool CheckForText(this string text,char message)
        {
            return text.Contains(message);
        }

     public static bool CheckForLength(this string password)
        {
            return password.Length > 8;
        }

     public static int Divison(this int[] arr)
        {
            int result=1;
          foreach(int item in arr)
            {
                result*=item;
            }
          return result;
        }
    }
}
