using System;

namespace _03ErmeHamisitas
{
    internal class FakeCoin : Coin
    {
        public FakeCoin()
        {
            Console.WriteLine("FakeCoin konstruktor");
        }   

        public override int Collect()
        {
            Console.Write("FakeCoin.Collect()");
            return 0;
        }
    }
}