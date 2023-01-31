using System;

namespace BAEKJOON
{
    class program
    {
        public static int Solution(char alphabet)
        {
            return (int)alphabet;
        }

        static void Main(string[] strings)
        {
            char input = char.Parse(Console.ReadLine());

            Console.WriteLine(Solution(input));
        }
    }
}