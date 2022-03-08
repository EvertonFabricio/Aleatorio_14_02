using System;

namespace Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int []n = new int[20];
            int troca;

            for (int i = 0; i < 20; i++)
            {
                n[i] = aleatorio.Next(1,99);
            }
            for (int i = 0;i < 20;i++)
            {
                for (int j = i; j < 20; j++)
                {
                    if (n[i] > n[j])
                    {
                        troca = n[i];
                        n[i] = n[j];
                        n[j] = troca;
                    }
                }
                Console.Write($"{n[i]},");                
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
