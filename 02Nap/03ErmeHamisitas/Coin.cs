using System;

namespace _03ErmeHamisitas
{
    public class Coin
    {
        Random random = new Random();

        public Coin()
        {
            Console.WriteLine("Coin konstruktor");
        }

        public virtual int Collect()
        {
            Console.Write("Coin.Collect()");
            return random.Next(0, 2);
        }
    }
}