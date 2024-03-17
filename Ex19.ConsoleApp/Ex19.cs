namespace Ex19.ConsoleApp
{
    internal class Ex19
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular a Tabuada(Lista Ex_24)***\n");

                Console.WriteLine("Informe a tabuada: ");
                int tabu = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 10; i++) {
                    Console.WriteLine(tabu +" X "+ i + " = " + tabu * i);
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
