using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class MathsModel
    {
        /// <summary>
        /// Esta función toma como parámetro un número entero y 
        /// devuelve su potencia en base 2.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int PowerFunction(int value)
        {            
            return value *= value;
        }

        /// <summary>
        /// Esta función devuelve el sumatorio de un número entero que se
        /// emplee como parámetro, esto es, se sumarán todas las cifras
        /// menores e iguales al número introducido.
        /// </summary>
        /// <param name="value">
        /// El número con el cual se calculará el sumatorio.
        /// </param>
        /// <returns>
        /// La función devuelve un número entero, que representa el resultado
        /// del sumatorio del número introducido como parámetro.
        /// </returns>
        public static int SummationFunction(int value)
        {
            int result = 0;
            for (int i = 0; i <= value; i++)
            {
                result += i;
            }
            return result;
        }

        /// <summary>
        /// A partir de un número entero como parámetro se devuelva su factorial,
        /// esto es, se multiplicarán entre sí todas las cifras, menores e iguales,
        /// del número introducido.
        /// </summary>
        /// <param name="value">
        /// Es el número entero del cual se calculará el factorial.
        /// </param>
        /// <returns>
        /// Devuelve un número entero, el cual representa el resultado del factorial
        /// del número introducido como parámetro.
        /// </returns>
        public static int FactorialFunction(int value)
        {
            if (value == 0)
                return 0;
            int result = 1;
            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Esta función, toma un número entero como parámetro y devuelve si es primo o no.
        /// </summary>
        /// <param name="value">
        /// Este número entero que se usa como parámetro, es el que se comprobará si es primo
        /// o no.
        /// </param>
        /// <returns>
        /// Devuelve un booleano, dado que el fin de la función es indicar si es un número
        /// primo o no, el resultado se limita a un true o un false.
        /// </returns>
        public static bool IsPrimeFunction(int value)
        {
            if (value == 0 || value == 1 || value < 0)
                return false;
            for (int i = 1; i < value; i++)
            {                                    
                if (value % i == 0 && i != 1)
                    return false;                
            }
            return true;            
        }

        /// <summary>
        /// Esta función imprime una cantidad concreta de números de la serie de Fibonacci. 
        /// La cantidad de números de la serie que se imprimen, está determinado por el número 
        /// entero que se emplea como parámetro.
        /// </summary>
        /// <param name="value">
        /// Esta parámetro, es un número entero que determina la cantidad de números de la 
        /// serie de Fibonacci que se van a imprimir.
        /// </param>
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
