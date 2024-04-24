using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание__20_1__
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первый объект с целыми параметрами 
            Point<int> point = new Point<int>(3,6);
            point.Show();
            //Второй объект с вещественными параметрами 
            Point<double> point1 = new Point<double>(5.5, 6.7);
            point1.Show();

            Console.ReadKey();
        }
    }
}
