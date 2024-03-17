using System;

namespace Ex9.ConsoleApp
{
    internal class Ex9
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular a média harmônica***\n");

                Console.WriteLine("Informe a quantidade de notas: ");
                double n = Convert.ToDouble(Console.ReadLine());

                List<double> lista = new List<double>();
                double soma = 0;

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Informe a notas "+i+": ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    lista.Add(x);
                }

                foreach (double num in lista)
                {
                    soma += 1 / num;
                }

                double res = n / soma;

                Console.WriteLine("\nA media e de: " + res);

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
