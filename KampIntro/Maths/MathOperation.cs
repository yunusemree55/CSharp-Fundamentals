using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class MathOperation
    {

        public void Sum(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine($"Toplam sonucu: {result} ");
        }

        public void Sum(int number1,int number2,int number3)
        {
            int result = number1 + number2 + number3;
            Console.WriteLine($"Toplam sonucu: {result} ");
        }




    }
}
