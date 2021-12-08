using System;

namespace OOPKhanhPhong
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            
            Rectangle rectangle = new Rectangle(5,7, "Red");

            // rectangle.Width = 5;
             //rectangle.Height = 7;
            
            // in ra area

            Console.WriteLine($"Total Area: {rectangle.GetArea()} and color: {rectangle.Color}");
        }
    }
}