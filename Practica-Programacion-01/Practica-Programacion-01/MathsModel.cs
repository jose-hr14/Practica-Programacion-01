using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class MathsModel
    {
        public static int Power(int number, int power)
        {
            int result = 0;
            for (int i = 0; i <= power; i++)
            {
                if (i == 0)
                    result = 1;
                result *= number;
            }
            return result;
        }
    }
}
