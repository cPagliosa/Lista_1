namespace Ex17.ConsoleApp
{
    internal class Ex17
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular se multiplica ou soma?(Lista Ex_21)***\n");

                Console.WriteLine("Informe o x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double res = 0;
                if (x == y) {
                    res = x + y;
                }else res = x * y;

                Console.WriteLine("\nO resutado é: " + res);

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
