namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ejercicio 4: hacer la sumatoria hasta el numero ingresado

            int numero = Convert.ToInt32(Console.ReadLine());

            int sumatoria = 0;

            for (int i = 0; i <= numero; i++)
            {
                sumatoria += i;
            }

            Console.WriteLine($" La sumatoria de 1 a {numero} es : {sumatoria}");
        }
    }
}