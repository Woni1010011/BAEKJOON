using System;

namespace BAEKJOON
{
    class BAEK2562
    {
        public static string MaxNumber(string[] str)
        {
            int compareInt = int.Parse(str[0]);
            int[] ints = new int[str.Length];
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                ints[i] = int.Parse(str[i]);
            }

            foreach (var t in ints)
            {
                compareInt = compareInt < t ? t : compareInt;
            }

            Console.WriteLine(compareInt);


            return compareInt.ToString();
        }

        static void Main(string[] args)
        {
            string[] strings = new string[9];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Console.ReadLine();
            }
            string maxString = MaxNumber(strings);

            foreach (var t in strings)
            {
                if (t == maxString)
                {
                    Console.WriteLine(t);
                    Console.Write(t.Length);
                }
            }
        }
    }
}