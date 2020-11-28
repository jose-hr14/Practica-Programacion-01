using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Programacion_01
{
    class ControllerUtilities
    {        
        /// <summary>
        /// Esta función, toma como parámetro un string que se usará
        /// para indicar al usuario que debe pulsar una tecla para
        /// que el programa siga ejecutando instrucciones.
        /// </summary>
        /// <param name="TextAskingForInput">
        /// El texto con el que se informará al usuario de que debe
        /// pulsar una tecla para que el programa continúe ejecutando
        /// instrucciones.
        /// </param>
        public static void WaitForInputToContinue(string TextAskingForInput)
        {
            Console.WriteLine("\n" + TextAskingForInput);
            Console.ReadLine();
        }

        /// <summary>
        /// Esta función tomará como parámetros el valor mínimo y máximo 
        /// de una función para devolver un entero, el cual se empleará
        /// como opción para navegar por el menú de usuario. Cualquier opción 
        /// que se de ese rango, hará que la función solicite entrada del
        /// usuario nuevamente.
        /// </summary>
        /// <param name="MinOptionValue">
        /// El valor mínimo que aceptará la función para devolver la opción escogida.
        /// </param>
        /// <param name="MaxOptionValue">
        /// El valor máximo que aceptará la función para devolver la opción escogida.
        /// </param>
        /// <returns>
        /// Devuelve un entero, que se empleará como opción para navegar por el menú
        /// de usuario.
        /// </returns>
        public static int ReadMenuOption(int MinOptionValue, int MaxOptionValue)
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

        /// <summary>
        /// Esta función leerá un número entero, y si detecta
        /// valor no válido, captará el error y volverá a solicitar
        /// input al usuario para evitar excepciones en el programa.
        /// </summary>
        /// <returns>
        /// Devuelve un número entero.
        /// </returns>
        public static int ReadIntValue()
        {
            int IntValue;            
            while (true)
            {
                try
                {
                    return IntValue = Convert.ToInt32(Console.ReadLine());
                }

                catch (System.FormatException ErrorFormato) 
                {
                    Console.Write("Por favor, introduce un número entero: ");
                }                
            }            
        }

        /// <summary>
        /// Esta función leerá un número entero, y si detecta 
        /// un valor no válido, captará el error y volverá a solicitar
        /// input al usuario para evitar excepciones en el programa.
        /// Empleará como parámetro un string para indicar al usuario
        /// que se está esperando la entrada de un número entero.
        /// </summary>
        /// <param name="TextAskingForInput">
        /// El string que se imprimirá por pantalla para solicitar
        /// la entrada de un número entero al usuario.
        /// </param>
        /// <returns>
        /// Devuelve un número entero.
        /// </returns>
        public static int ReadIntValue(string TextAskingForInput)
        {
            Console.Write(TextAskingForInput);
            return ReadIntValue();
        }

    }
}
