using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание__20_1__
{
    //Обобщенный класс Point.
    class Point <T>
    {
        /// <summary>
        /// Создание поля x
        /// </summary>
        private T x;
        /// <summary>
        /// Создание поля У
        /// </summary>
        private T y;
        /// <summary>
        /// Свойство Х
        /// </summary>
        public T X { get; set; }
        /// <summary>
        /// Свойство У
        /// </summary>
        public T Y { get; set; }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        /// <summary>
        ///  метод, выводящий значения внутренних полей класса.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Координатная точка x: {X}\nКоординатная точка у: {Y}");
        }
    }
}
