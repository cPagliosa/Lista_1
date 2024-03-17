namespace Ex16.ConsoleApp
{
    internal class Ex16
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Ordernar(Decrecente)(Lista Ex_18)***\n");

                Console.WriteLine("Informe o A: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o B: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o C: ");
                int c = Convert.ToInt32(Console.ReadLine());

                List<int> res = new List<int>();
            
                if(a > b)
                {
                    if(a > c) 
                    {
                        res.Add(a);
                        if(b > c)
                        {
                            res.Add(b);
                            res.Add(c);
                        }
                        else
                        {
                            res.Add(c);
                            res.Add(b);
                        }
                    }else if (a < c)
                    {
                        res.Add(c);
                        res.Add(a);
                        res.Add(b);
                    }
                }else
                {
                    if(b > c)
                    {
                        res.Add(b);
                        if(a > c)
                        {
                            res.Add(a);
                            res.Add(c);
                        }else
                        {
                            res.Add(c);
                            res.Add(a);
                        }
                    }else
                    {
                        res.Add(c);
                        res.Add(b);
                        res.Add(a);
                    }
                }
                
                
                Console.WriteLine("\nA lista ficou assim: " + string.Join(" ",res));

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
