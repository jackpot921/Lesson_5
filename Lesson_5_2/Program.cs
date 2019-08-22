using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    class Program
    {
        private static char[] GetRandomArray(int count)
        {
            Random rnd = new Random();
            char[] chars = new char[count];
            for (int i = 0; i < count; i++)
            {
                chars[i] = (char)rnd.Next('A', 'Z' + 1);
            }
            return chars;
        }
        private static char[] BubbleSortCharsArray(char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i+1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        char temp = chars[i];
                        chars[i] = chars[j];
                        chars[j] = temp;
                    }
                }
            }
            return chars;
        }
        private static char[] InsertionSort (char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                char current = chars[i];
                char temp = 
            }
        }
        static void Main(string[] args)
        {
            char[] chars = GetRandomArray(20);
            foreach (var item in chars)
            {
                Console.Write($"{item}; ");
            }
            Console.WriteLine();
            char[] sortedChars = BubbleSortCharsArray(chars);
            
            foreach (var item in sortedChars)
            {
                Console.Write($"{item}; ");
            }
        }
    }
}
