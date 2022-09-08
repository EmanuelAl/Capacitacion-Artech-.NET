namespace ejercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 1
             * Reciba su nombre, sexo e idioma y devuelva un mensaje de bienvenida (ej: Leandro, M, ES => "¡Bienvenido Leandro!")
            */

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su sexo: ");
            string sexo = Console.ReadLine();

            Console.Write("Ingrese su idioma: ");
            string idioma = Console.ReadLine();
            /*
            Console.WriteLine("Bienvenido " + nombre + "!");// concatenacion comun
            Console.WriteLine($"Bienvenido {nombre} !");// concatenacion por template
            */
            // trabajo con condicionales:

            if (idioma.ToUpper() == "ES")
            {
                if (sexo == "M" || sexo == "m") // operador or (||) operador and (&&)
                {
                    Console.WriteLine($"¡Bienvenido {nombre}!");
                }

                else if (sexo == "F" || sexo == "f")
                {
                    Console.WriteLine($"¡Bienvenido {nombre}!");
                }

                else
                {
                    Console.WriteLine($"¡Bienvenidx {nombre}!");
                }
            }
            else if (idioma.ToUpper() == "EN")
            {
                Console.WriteLine($"Welcome {nombre}!");
            }

            else
            {
                Console.WriteLine("Idioma incorrecto");
            }
            // Lo mismo que lo anterior pero con switch
            /*
            switch (sexo)
            {
                case "M":
                case "m":
                    Console.WriteLine($"¡Bienvenido {nombre}!");
                    break;

                case "F":
                case "f":
                    Console.WriteLine($"¡Bienvenida {nombre}!");
                    break;

                default:
                    Console.WriteLine($"¡Bienvenidx {nombre}!");
                    break;
            }
            */
        }
    }
}