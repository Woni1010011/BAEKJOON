using System;

namespace BAEKJOON1110
{
    class MainApp
    {
        public static string ConvertInput(string a)
        {
            string str;

            str = int.Parse(a) < 10 ? "0" + a : a.ToString();

            return str;
        }



        public static string SumString(string str)
        {
            char char1 = str[0];
            char char2 = str[1];
            
            int a = int.Parse(char1.ToString());
            int b = int.Parse(char2.ToString());

            string sumInt = ConvertInput((a+b).ToString());
            char char3 = sumInt[1];

            string strings = char2.ToString() + char3;
            return strings;
        }



        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            int count = 0;

            List<string> sum = new List<string>();
            sum.Add(ConvertInput(strings));

            while (true)
            {
                sum.Add(SumString(sum[count]));
                count++;
                if (sum[0] == sum[sum.Count-1]) break;
            }

            Console.WriteLine(sum.Count-1);

        }
    }
}