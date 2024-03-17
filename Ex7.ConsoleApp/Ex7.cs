namespace Ex7.ConsoleApp
{
    internal class Ex7
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular o salário total de um vendedor***\n");

                Console.WriteLine("Informe o Salario base: ");
                double sal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o Total de vendas: ");
                double venda = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a comicao: ");
                double comi = Convert.ToDouble(Console.ReadLine());

                double res = sal + (venda * (comi/100));

                Console.WriteLine("\nTotal: " + res);

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
