namespace Ex2.ConsoleApp
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Conversor de Fahrenheit para graus Celsius***\n");

                Console.WriteLine("Informe a Temperatura(F): ");
                double fah = Convert.ToDouble(Console.ReadLine());

                double cel = (fah - 32) * 5/9;

                Console.WriteLine("\n" + cel + "ºC");

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
