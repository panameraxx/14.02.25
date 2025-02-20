using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle
    {
        private double length;
        private double width;


        public Rectangle() { }
        public Rectangle(double length,double width)
        {
            this.Length = length;
            this.Width = width;

        }


        public double Length
        {
            get => length; set
            {
                if (value < 0) throw new ArgumentException("error"); length = value;
            }
        }
        public double Width { get => width; set
            {
                if (value < 0) throw new ArgumentException("error"); width = value;
            }
        }
        public double Square()
        {
            return (length*width);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Первое число: {length}\t второе число: {width}\t Результат{Square():f2}");
        }

        public string Tostring()
        {
            return $"Первое число: {length}\t второе число: {width}\t Результат{Square():f2}";
        }
    }
}
