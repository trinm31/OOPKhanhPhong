namespace OOPKhanhPhong
{
    public class Rectangle: Shape
    {
        public string Color { get; set; }
        public Rectangle()
        {
            
        }

        public Rectangle(int width, int height,string color):base(width,height)
        {
            this.Color = color;
        }
        
        public Rectangle(int width, int height):base(width,height)
        {
        }
        
        // overload method
        public void Resize(double sameSize)
        {
            Width = (int)sameSize;
            Height = (int)sameSize;
        }

        public void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public void Resize(double width, double height)
        {
            Width = (int)width;
            Height = (int)height;
        }
        // overload operator
        public static Rectangle operator +(Rectangle a, Rectangle b)
        {
            var width = a.Width + b.Width;
            var height = a.Height + b.Height;
            return new Rectangle(width, height);
        }
        
        public static Rectangle operator -(Rectangle a, Rectangle b)
        {
            var width = a.Width - b.Width;
            var height = a.Height - b.Height;
            return new Rectangle(width, height);
        }
        public int GetArea()
        {
            return Width * Height;
        }

        public string GetColor()
        {
            daddy();
            return Color;
        }

        public override string Helloworld()
        {
            return base.Helloworld() + " this is from rectangle";
        }
    }
}