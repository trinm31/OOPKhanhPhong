using System;

namespace OOPKhanhPhong
{
    public class Voi:IMammal
    {
        public void Veu()
        {
            Console.WriteLine("Nhieu hon 2 cai");
        }

        public void Run()
        {
            Console.WriteLine("Chay cham");
        }

        public void Eat()
        {
            Console.WriteLine("an co");
        }

        public void Sleep()
        {
            Console.WriteLine("ngu du 8 tieng");
        }

        public void NumberOfLeg()
        {
            Console.WriteLine(4);
        }
    }
}