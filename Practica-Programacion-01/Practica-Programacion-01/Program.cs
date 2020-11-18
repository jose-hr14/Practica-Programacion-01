using System;

namespace Practica_Programacion_01
{
    class Program
    {
        public static void LaunchMainMenu()
        {
            UserInterface.PrintMainMenu();
            switch (ControllerUtilities.ReadMenuOptionValue(0, 5))
            {
                case 0:
                    break;
                case 1:                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            
        }
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //System.Console.WriteLine("Probando los colores", Console.ForegroundColor = ConsoleColor.Red);
            //Console.WriteLine("Texto en color normal", Console.ForegroundColor = ConsoleColor.White);
            //Console.WriteLine(MathsModel.Power(2, 4));
            /*
            while (true)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                MathsModel.FibonacciFunction(value);
            }
            */
            LaunchMainMenu();


        }
    }
}
