namespace Ex4.ConsoleApp
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***calcular o consumo de combustível por Km***\n");

                Console.WriteLine("Informe o quilometro Inicial: ");
                double kmInicio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o quilometro Final: ");
                double kmFinal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o Consumo: ");
                double cons = Convert.ToDouble(Console.ReadLine());

                double res = (kmFinal-kmInicio)/cons;

                Console.WriteLine("\nO consumo foi de: " + res + "Km por Litro");

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
