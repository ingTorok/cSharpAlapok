using System;

namespace _03ErmeHamisitas
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin coin = new FakeCoin();

            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Collect()},");
            }

            var fakeCoin = new FakeCoin();

            Console.ReadLine();
        }
    }
}
