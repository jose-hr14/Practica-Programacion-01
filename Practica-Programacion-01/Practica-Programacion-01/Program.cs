using System;

namespace Practica_Programacion_01
{
    class Program
    {
        public static void LaunchMainMenu()
        {
            UserInterface.PrintMainMenu();
            
        }
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //System.Console.WriteLine("Probando los colores", Console.ForegroundColor = ConsoleColor.Red);
            //Console.WriteLine("Texto en color normal", Console.ForegroundColor = ConsoleColor.White);
            //Console.WriteLine(MathsModel.Power(2, 4));
            Console.WriteLine(MathsModel.IsPrimeFunction(4));
        }
    }
}
