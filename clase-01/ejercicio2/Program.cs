namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Armar otra aplicacion de consola que reciba dos numeros, devuelva la suma, resta, multiplicacion, division entre ambos.

            // si escribo Read solo (sin el Line) me leerá solo el primer carácter que ingrese. 
            try
            {
                Console.Write("Ingrese el primer número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine()); // metodo para convertir la devolucion del string a entero

                Console.Write("Ingrese el segundo número: ");
                int numero2 = int.Parse(Console.ReadLine()); // lectura de dos numeros de forma distinta    

                // Console.WriteLine("La suma es: " + numero1 + numero2); esto me va a devolver una concatenacion y no una suma

                int suma = numero1 + numero2;
                Console.WriteLine("La suma es: " + (numero1 + numero2));

                int resta = numero1 - numero2;
                Console.WriteLine("La resta es: " + (numero1 - numero2));

                int multiplicacion = numero1 * numero2;
                Console.WriteLine("La multiplicacion es: " + (numero1 * numero2));

                if (numero2 != 0)
                {
                    double division = Math.Round((double)numero1 / numero2, 2);
                    Console.WriteLine("La division es: " + (numero1 / numero2));
                }
                else
                {
                    Console.WriteLine("El resultado es basura");
                }

            }
            catch
            {
                Console.Write("El valor ingresado no es numérico.");
            }


            /* anotaciones:
             * 
             * Errores en tiempo de ejecución -> excepciones

            Si yo divido dos enteros, el resultado sera entero, para que pase lo contrario tengo que convertir alguno de los numeros a float

            Un float se puede almacenar adentro de un double ya que el float es mas chico que el double.

            Comunmente en la división si se le pasa 0 daria un error, pero este es un caso extraño que no devuelve una excepcion

            */
        }
    }
}