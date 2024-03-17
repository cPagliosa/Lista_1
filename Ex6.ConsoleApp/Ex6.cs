using System;

namespace Ex6.ConsoleApp
{
    internal class Ex6
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***conversor de Celsius para Fahrenheit***\n");


                Console.WriteLine("Informe a Temperatura(C): ");
                double cel = Convert.ToDouble(Console.ReadLine());

                double fah = 32 + cel * 9 / 5;

                Console.WriteLine("\n" + fah + "ºF");
                Console.WriteLine("\nSair : 0");
                Console.WriteLine("Recalcular != 0");
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }

            }
        }
    }
}
