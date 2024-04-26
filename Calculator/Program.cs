using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"Сложение: {calculator.Add(5,4)}");
            Console.WriteLine($"Вычитание: {calculator.Substract(6,5.5)}");
            Console.WriteLine($"Умножение: {calculator.Multiply(2,9)}");
            Console.WriteLine($"Деление: {calculator.Division(18,0)}");
            Console.ReadKey();
        }
    }
}
