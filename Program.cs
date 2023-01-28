using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Func(long number, long delenie)
        {
            if (delenie >= number)
            {
                Console.WriteLine("YES");
                return 0;
            }
            if (number % delenie == 0)
            {
                if (delenie != 1)
                {
                    Console.WriteLine("NO");
                    return 0;
                }
            }
            if (true)
            {
                Func(number, delenie + 1);
                return 0;
            }
        }
        static void Main(string[] args)
        {
            long number = Convert.ToInt64(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Func(number, 1);
            }
        }
    }
}
