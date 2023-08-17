//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("EJERCICIO 1");
        Console.WriteLine("");
        Console.WriteLine("=================================");
        Console.WriteLine("ALUMNO JOSE SAUL SIBRIAN SERRNO");
        Console.WriteLine("=================================");
        Console.WriteLine("");

        int[] arreglo;
        Console.Write("Ingrese el tamaño del arreglo (mínimo 5): ");
        int tamaño = Convert.ToInt32(Console.ReadLine());

        if (tamaño < 5)
        {
            Console.WriteLine("El tamaño debe ser al menos 5.");
            return;
        }
        arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("");

        Console.WriteLine("Valores del arreglo:");
        for (int i = 0; i < tamaño; i++)
        {
            Console.WriteLine($"Valor {i + 1}: {arreglo[i]}");
        }
    }
}