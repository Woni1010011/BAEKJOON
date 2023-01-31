namespace BAEKJOON;
class program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        char[] chars = Console.ReadLine().ToCharArray();
        int result = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            result += int.Parse(chars[i].ToString());
        }

        Console.WriteLine(result);
    }
}