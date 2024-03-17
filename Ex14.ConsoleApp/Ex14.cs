namespace Ex14.ConsoleApp
{
    internal class Ex14
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular o aumento de salario(Lista Ex_16)***\n");

                Console.WriteLine("Informe o salario atual: ");
                double sal = Convert.ToDouble(Console.ReadLine());

                double alt = (sal * 0.15) ;
                double res = alt + sal - (sal*0.08);

                Console.WriteLine("\nO salario era de: "+sal+"\nO novo salario e de: " + res);

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
