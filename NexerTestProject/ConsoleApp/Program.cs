using System;

namespace ConsoleApp
{
    class Program
    {
        static int calc(int n)
        {
            int calcResult;
            calcResult = 1;
            for (int i = 1; i <= n; i++)
                calcResult = calcResult * i;
            return calcResult;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation factorial.");
            Console.Write("Enter a value - ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", value, calc(value));
        }
    }
}
