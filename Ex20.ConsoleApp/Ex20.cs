namespace Ex20.ConsoleApp
{
    internal class Ex20
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular Fatorial(Lista Ex_25)***\n");

                Console.WriteLine("Informe o numero: ");
                int x = Convert.ToInt32(Console.ReadLine());

                int res = 1;
                for (int i = x; i >= 1; i--) {
                    res = res * i;
                }

                Console.WriteLine("\nA resposta e de: " + res);

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
