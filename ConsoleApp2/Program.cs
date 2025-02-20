using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5,76);
            rectangle.ShowInfo();
            
            double adin = double.Parse(Console.ReadLine());
            double dwa = double.Parse(Console.ReadLine());
            Rectangle rectangle2 = new Rectangle(adin, dwa);
            Console.WriteLine($"{rectangle2.Tostring()}");
            Console.ReadKey();
        }
    }
}
