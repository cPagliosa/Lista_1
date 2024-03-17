namespace Ex11.ConsoleApp
{
    internal class Ex11
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular a area do terreno***\n");

                Console.WriteLine("Informe o comprimento: ");
                double com = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a largura: ");
                double lar = Convert.ToDouble(Console.ReadLine());

                double res = com * lar;

                Console.WriteLine("\nA area total e de: " + res);

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
