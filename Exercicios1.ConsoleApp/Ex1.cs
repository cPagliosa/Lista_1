using System.Linq.Expressions;

namespace Exercicios1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("***Calcular o Volume De Uma Caixa Retangular***\n");
                Console.WriteLine("Informe o comprimento: ");
                double cpm = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a largura: ");
                double lar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a altura: ");
                double h = Convert.ToDouble(Console.ReadLine());

                double res = cpm * lar * h;
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
