using System;

namespace BAEKJOON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sum = new List<int>();

            while (true)
            {
                string[] strings = Console.ReadLine().Split(" ");
                int a = int.Parse(strings[0]);
                int b = int.Parse(strings[1]);

                sum.Add(a + b);

                if (a == 0 && b == 0)
                {
                    break;
                }
            }

            for (int i = 0; i < sum.Count-1; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}