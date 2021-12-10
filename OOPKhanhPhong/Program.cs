using System;

namespace OOPKhanhPhong
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            
            Rectangle rectangle1 = new Rectangle(5,7);
            Rectangle rectangle2 = new Rectangle(6,9);
            // rectangle.Width = 5;
            // rectangle.Height = 7;
            
            // in ra area

            // Shape hinh = new Shape();
            // Shape hinh2 = new Shape(2, 3);

            //rectangle.Resize(1.0,2.0);
            

            //Console.WriteLine($"Total Area: {rectangle.GetArea()} and color: {rectangle.Color}");
            
            // use operator + 
            // Rectangle rectangle3 = rectangle1 + rectangle2;
            // Rectangle rectangle4 = rectangle1 - rectangle2;
            // Console.WriteLine($"{rectangle3.Width}-{rectangle3.Height}");
            // Console.WriteLine($"{rectangle4.Width}-{rectangle4.Height}");

            Shape shape = new Shape();
            Console.WriteLine(shape.Helloworld());
            Console.WriteLine(rectangle1.Helloworld());
            
            
        }
    }
}