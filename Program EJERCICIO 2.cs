//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EJERCICIO 2");
        Console.WriteLine("");
        Console.WriteLine("=================================");
        Console.WriteLine("ALUMNO JOSE SAUL SIBRIAN SERRNO");
        Console.WriteLine("=================================");

        Console.WriteLine("");

        string nombre = "SAUL SIBRIAN";
        int longitud = nombre.Length;

        char[] arregloNombre = new char [longitud];

        for (int i = 0; i < longitud; i++)
        {
            arregloNombre[i] = nombre[i];
            Console.WriteLine("Valor en posición " + i + ": " + arregloNombre[i]);
        }

        Console.WriteLine("");

        Console.WriteLine("Tamaño del arreglo: " + longitud);
    }
}


