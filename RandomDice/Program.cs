using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dados quer lancar?");
            int n=Convert.ToInt32(Console.ReadLine());
            int soma1 =0;
            Random r1 = new Random();
            for (int i = 0; i < n; i++)
            {
                int n1= r1.Next(1,7);
                Console.WriteLine(n1);
                soma1=soma1+n1;
            }
            Console.WriteLine("Total da soma dos dados e: " + soma1);

        }
    }
}
