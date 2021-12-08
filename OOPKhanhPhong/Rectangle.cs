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
        public int GetArea()
        {
            return Width * Height;
        }

        public string GetColor()
        {
            daddy();
            return Color;
        }
    }
}