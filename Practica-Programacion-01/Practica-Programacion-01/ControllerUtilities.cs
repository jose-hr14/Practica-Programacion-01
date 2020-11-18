using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class ControllerUtilities
    {
        public static int ReadMenuOptionValue(int MinOptionValue, int MaxOptionValue)
        {
            while (true)
            {
                try
                {
                    while (true)
                    {                        
                        int Option = Convert.ToInt32(Console.ReadLine());
                        if (Option >= MinOptionValue && Option <= MaxOptionValue)
                            return Option;
                        Console.WriteLine("Introduce un número entre " + MinOptionValue + " y " + MaxOptionValue);
                    }
                }
                catch (System.FormatException ErrorFormato)
                {
                    Console.WriteLine("Por favor, introduce un número entero entre " + MinOptionValue + " y " + MaxOptionValue);
                }
            }
            

            
        }
    }
}
