namespace ej_bucle_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine + "EJERCICIO C"); //TRIANGULO DECRECIENTE ESPEJADO

            int numero = Convert.ToInt32(Console.ReadLine());
            /*
            for (int i = numero; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("1 ");
                }
                Console.Write(Environment.NewLine);
            }
            */
            for (int i = 0; i <= numero; i++)
            {
                for (int j = numero; j >= numero -  i; j--)
                {
                    Console.Write("1 ");
                }
                Console.Write(Environment.NewLine);
            }

            // revisar no hace lo que se pide
        }
    }
}