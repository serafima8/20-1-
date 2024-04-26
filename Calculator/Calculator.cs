using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2_
{
    class Calculator 
    {
        public dynamic A { get; set; }
        public dynamic B { get; set; }
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Substract(dynamic a, dynamic b)
        {
            return a - b;
        }
        public dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Division(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                return "Ошибка. На ноль делить нельзя";
            }
            else
            {
                return a / b;
            }
        }
    }
}
