﻿namespace Ex8.ConsoleApp
{
    internal class Ex8
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular o volume de uma lata de óleo***\n");

                Console.WriteLine("Informe o Raio: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a altura: ");
                double h = Convert.ToDouble(Console.ReadLine());

                double res = Math.PI * Math.Sqrt(raio) * h;

                Console.WriteLine("\nO Volume e de: " + res);

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
