using System;

namespace OOPKhanhPhong
{
    public class HocSinhGioiVan: ISpecialStudent
    {
        public void Study()
        {
            Console.WriteLine("I am Studying in 10 hours");
        }

        public void Gifted()
        {
            Console.WriteLine("I good literature");
        }
    }
}