using System;

namespace ej_bucles_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine + "EJERCICIO B"); //TRIANGULO DECRECIENTE

            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("1 ");
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}