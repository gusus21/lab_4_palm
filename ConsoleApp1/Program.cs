using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            if ((x >= 1 || y >= 1 || x <= -1 || y <= -1) && x * x + y * y <= 4)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
