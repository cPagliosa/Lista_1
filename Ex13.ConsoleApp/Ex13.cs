namespace Ex13.ConsoleApp
{
    internal class Ex13
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Calcular quantos dias de vida viveu(Lista Ex_14)***\n");

                Console.WriteLine("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe a idade: ");
                double idade = Convert.ToDouble(Console.ReadLine());

                double res = idade * 365;

                Console.WriteLine("\n" + nome + ", voce ja viveu " + res + " dias.");

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
