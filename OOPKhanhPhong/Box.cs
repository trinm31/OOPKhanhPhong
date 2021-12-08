using System;

namespace OOPKhanhPhong
{
    internal class Box
    {
        //fields
        // access modifier - quyền access - (public internal private protected)
        private double _length;
        private double _breadth;
        private double _height;
        
        // Properties
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value != 0)
                {
                    _length = value;
                }
                else
                {
                    _length = double.NaN;
                }
            }
        }

        public double Breadth
        {
           
            get
            {
                return _breadth;
            }
            set
            {
                if (value != 0)
                {
                    _breadth = value;
                }
                else
                {
                    _breadth = double.NaN;
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value != 0)
                {
                    _height = value;
                }
                else
                {
                    _height = double.NaN;
                }
            }
        }
        
        //default constructor
        public Box(){}
        
        //constructor with parameters
        public Box(double length, double breadth, double height)
        {
            this.Length = length;
            this.Breadth = breadth;
            this.Height = height;
        }
        
        // method
        public void Print()
        {
            Console.WriteLine("Test method");
        }
        
        //destructor
        ~Box()
        {
            
        }
    }
}