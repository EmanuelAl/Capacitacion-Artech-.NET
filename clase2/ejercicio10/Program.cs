﻿using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] listaPalabras = new string[5];

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("ingrese una palabra: ");
                
                listaPalabras[i] = Console.ReadLine();
            }

            Array.Sort(listaPalabras);//ordena alfabeticamente
            Array.Reverse(listaPalabras);//ordena al reves

            foreach(string element in listaPalabras) {
                Console.WriteLine(element);
            }


        }
    }
}
