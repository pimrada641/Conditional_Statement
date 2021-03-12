using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y,t1 = 0, p1=0,t2=0 ,p2 = 0;
            string programmode = Console.ReadLine();
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                switch (programmode)
                {
                    case "time":
                        t1 = x;
                        p1 = Math.Pow(t1 - 1, 2);
                        Console.WriteLine("{0}, {1}", t1, p1);
                        break;
                    case "price":
                        p2 = y;
                        t2 = Math.Sqrt(p2) + 1;
                        Console.WriteLine("{0}, {1}", t2, p2);
                        break;
                    default:
                        Console.WriteLine("Invalid mode");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid mouse position");
            }
        }
    }
}
