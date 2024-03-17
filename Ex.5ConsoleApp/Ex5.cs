namespace Ex5.ConsoleApp
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular o Volume de uma Esfera***\n");


                Console.WriteLine("Informe o Raio: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                double res = (raio * Math.Sqrt(raio) * Math.PI * 4 / 3);

                Console.WriteLine("\nO Volume e de: " + res);

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
