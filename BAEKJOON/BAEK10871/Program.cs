using System;

namespace BAEKJOON
{
    class BAEKJOON
    {
        static void Main(string[] args)
        {
            string[] strings = new string[2];

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string[] X = strings[0].Split(' ');
            string[] N = strings[1].Split(' ');

            foreach (var t in N)
            {
                if (int.Parse(X[1]) > int.Parse(t))
                {
                    Console.Write(t + ' ');
                }
            }
        }
    }
}