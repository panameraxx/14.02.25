using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calc.Number1 = 10;
            calc.Number2 = 2;
            calc.ShowInfo();
            Calculate calc2 = new Calculate(15, 2);
            Console.WriteLine($"{calc2.Tostring()}");
            Console.WriteLine("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());
            Calculate calc3 = new Calculate(num1, num2);
            Console.WriteLine($"{calc3.Tostring()}");
           

            Console.ReadKey();
        }
    }
}
