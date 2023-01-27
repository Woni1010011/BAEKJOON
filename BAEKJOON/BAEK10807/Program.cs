using System;

namespace BAEKJOON
{
    class BAEK10807
    {
        static void Main(string[] args)
        {
            string[] strings = new string[3];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string[] input = strings[1].Split(' ');

            foreach (var t in input)
            {
                count = t == strings[2] ? count + 1 : count;
            }

            Console.Write(count);
        }
    }
}