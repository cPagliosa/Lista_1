namespace Ex15.ConsoleApp
{
    internal class Ex15
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular se a + b < c(Lista Ex_17)***\n");

                Console.WriteLine("Informe o A: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o B: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o C: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double res = a + b;

                if(res < c)
                {
                    Console.WriteLine("\nO C é maior que A + B");
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
