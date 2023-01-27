using System;

namespace BAEKJOON
{
    class BAEKJOON
    {
        public static void MinNumber(int n, string[] input)
        {
            int min = 0;
            int[] ints = new int[input.Length];
            min = min == 0 ? n : min;

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
            }

            foreach (var t in ints)
            {
                min = min < t ? min : t;
            }

            Console.Write($"{min} ");
        }

        public static void MaxNumber(int n, string[] input)
        {
            int min = 0;
            int[] ints = new int[input.Length];
            min = min == 0 ? n : min;

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
            }

            foreach (var t in ints)
            {
                min = min < t ? t : min;
            }

            Console.Write(min);
        }

        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ');

            MinNumber(int.Parse(input[0]), input);
            MaxNumber(int.Parse(input[0]), input);
        }
    }
}