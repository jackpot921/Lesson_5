using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_1
{
    class Program
    {
        public static bool IsPolindrome(string value)
        {
            for (int i = 0, j = value.Length - 1; i <= j; i++, j--)
            {
                if (value[i] != value[j])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool b = IsPolindrome("asdffdsdgsdgsa");
            Console.WriteLine(b);
        }
    }
}
