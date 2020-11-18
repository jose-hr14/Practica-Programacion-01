using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class ControllerUtilities
    {
        public static int ReadMenuOptionValue(int MinOptionValue, int MaxOptionValue)
        {
            Console.Write("\n" + "Introduce un valor entre " + MinOptionValue + " y " + MaxOptionValue + " para seleccionar una opción: ");
            while (true)
            {                
                try
                {                    
                    while (true)
                    {                        
                        int Option = Convert.ToInt32(Console.ReadLine());
                        if (Option >= MinOptionValue && Option <= MaxOptionValue)
                            return Option;
                        Console.Write("Por favor, introduce un número entero entre " + MinOptionValue + " y " + MaxOptionValue + ": ");
                    }
                }
                catch (System.FormatException ErrorFormato)
                {
                    Console.Write("Por favor, introduce un número entero entre " + MinOptionValue + " y " + MaxOptionValue + ": ");
                }
            }                        
        }

        public static int ReadIntValue()
        {
            int IntValue;            
            while (true)
            {
                try
                {
                    return IntValue = Convert.ToInt32(Console.ReadLine());
                }

                catch (System.FormatException ErrorFormato) { }                
            }            
        }

        public static int ReadIntValue(string TextAskingForInput)
        {
            int IntValue;
            Console.Write(TextAskingForInput);
            while (true)
            {
                try
                {
                    return IntValue = Convert.ToInt32(Console.ReadLine());
                }

                catch (System.FormatException ErrorFormato)
                {
                    Console.Write(TextAskingForInput);
                }
            }
        }

    }
}
