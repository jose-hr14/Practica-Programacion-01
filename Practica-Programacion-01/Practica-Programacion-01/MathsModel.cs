﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class MathsModel
    {
        public static int PowerFunction(int value, int power)
        {
            int result = 0;
            for (int i = 0; i < power; i++)
            {
                if (i == 0)
                    result = 1;
                result *= value;
            }
            return result;
        }

        public static int SummationFunction(int value)
        {
            int result = 0;
            for (int i = 0; i <= value; i++)
            {
                result += i;
            }
            return result;
        }

        public static int FactorialFunction(int value)
        {
            int result = 1;
            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }

        public static bool IsPrimeFunction(int value)
        {
            if (value == 0 || value == 1)
                return false;
            for (int i = 1; i < value; i++)
            {                                    
                if (value % i == 0 && i != 1)
                    return false;                
            }
            return true;            
        }

        public static void FibonacciFunction(int value)
        {
            //0, 1, 1, 2, 3, 5, 8,13, 21
            int Fibo1 = 0;
            int Fibo2 = 1;
            int Fibo3 = Fibo1 + Fibo2;
            Console.Write(Fibo1 + ", " + Fibo2 + ", " + Fibo3 + ", ");

            for (int i = 0; i < value; i++)
            {
                Fibo1 = Fibo2;
                Fibo2 = Fibo3;
                Fibo3 = Fibo1 + Fibo2;
                if (i != (value - 1))
                    System.Console.Write(Fibo3 + ", ");
                else
                    System.Console.Write(Fibo3 + "...");
            }

        }
    }
}
