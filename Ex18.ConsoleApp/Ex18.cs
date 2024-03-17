using System;

namespace Ex18.ConsoleApp
{
    internal class Ex18
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Numeros Impares de 100 a 200(Lista Ex_22)***\n");

                

                for (int i = 101; i < 200; i = i + 2) {
                    Console.WriteLine(i);
                }

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
