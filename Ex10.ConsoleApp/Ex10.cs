namespace Ex10.ConsoleApp
{
    internal class Ex10
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular a média ponderada de duas provas***\n");

                Console.WriteLine("Informe a primeira nota: ");
                double nt1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o peso da primeira nota: ");
                double pe1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a segunda nota: ");
                double nt2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o peso da segunda nota: ");
                double pe2 = Convert.ToDouble(Console.ReadLine());


                double res = ((pe1*nt1)+(pe2*nt2))/(pe1+pe2);

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
