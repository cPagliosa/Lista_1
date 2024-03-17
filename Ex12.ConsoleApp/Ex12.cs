namespace Ex12.ConsoleApp
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Padaria Hotpao(Lista Ex_13)***\n");

                Console.WriteLine("Informe a quantidade vendia de pao: ");
                double pao = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a quantidade vendia de broa: ");
                double broa = Convert.ToDouble(Console.ReadLine());

                double arrecada = (pao * 0.12) + (broa * 1.50); 
                double res = 0.1 * arrecada;

                Console.WriteLine("\nO total arrecadado e de: " + res+"R$.");

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
