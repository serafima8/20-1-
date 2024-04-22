using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_
{
    class Book <T>
    {
        /// <summary>
        /// Поле названия книги
        /// </summary>
        private string  name;
        /// <summary>
        /// Поле цены книги
        /// </summary>
        private T price;
        /// <summary>
        /// Свойства Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойства Цена
        /// </summary>
        public T Price { get; set; }
        /// <summary>
        /// Метод который задает название книги
        /// </summary>
        /// <param name="name"></param>
        public void Swap(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Метод с универсальным параметром, который задает цену книги
        /// </summary>
        /// <param name="price"></param>
        public void SwapPrice(T price)
        {
            Price = price;
        }
        /// <summary>
        /// Метод для вывода информации о книге
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Название: {Name}\nЦена: {Price}";
        }
    }
}
