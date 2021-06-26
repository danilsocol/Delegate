using System;

namespace Делегаты
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> f = (x, y) => x + y;
            Console.WriteLine(f(1, 2));

            Action<int> g = (x) => Console.WriteLine(x);
            g(3);
        }
    }
}
