namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reciba tres numeros enteros (hora, minutos, segundos) e indique si es un numero valido.

            Console.Write("Hora: ");
            int hora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            if (hora >= 0 && hora <= 23 &&
                minutos >= 0 && minutos <= 59 &&
                segundos >= 0 && segundos <= 59)
            {
                Console.WriteLine("Hora valida");
                Console.WriteLine($"{hora}:{minutos}:{segundos}");
            }
        }
    }
}