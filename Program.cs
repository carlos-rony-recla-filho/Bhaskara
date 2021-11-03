using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, delta, x1, x2;
            
            Console.WriteLine("-- Equação do segundo grau --\n");

            
            Console.Write("(a): ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("(b): ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("(c): ");
            c = Convert.ToDouble(Console.ReadLine());
            
            if (a == 0)
            {
                Console.WriteLine("Não éuma equação de segundo grau!");
            } 
            else
            {
                delta = b * b - 4 * a * c;
            
                if (delta < 0)
                {
                    Console.WriteLine($"Como delta = {delta:N2}, a equacação não possui raizes reais!");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");
                }    
            }
        }
    }
}
