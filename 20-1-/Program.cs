using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<int> book = new Book<int>();
            book.Swap("Отцы и дети");
            book.SwapPrice((int)250);
            Console.WriteLine(book.ToString());
            Book<string> book1 = new Book<string>();
            book1.Swap("Преступление и наказание");
            book1.SwapPrice((string)"210");
            Console.WriteLine(book1.ToString());

            Console.ReadKey();
        }
    }
}
