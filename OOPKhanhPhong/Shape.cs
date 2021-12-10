namespace OOPKhanhPhong
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape()
        {
            
        }

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public string daddy()
        {
            return "hello";
        }

        public virtual string Helloworld()
        {
            return "Hello world";
        }
    }
}