//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("EJERCICIO 3");

Console.WriteLine("");

Console.WriteLine("=================================");
Console.WriteLine("ALUMNO JOSE SAUL SIBRIAN SERRNO");
Console.WriteLine("=================================");

Console.WriteLine("");

string[] a = { "Perro", "Casa", "Cebra", "Tortuga",
"Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"};

Console.WriteLine("");

Console.WriteLine("Funcion Sort");

Console.WriteLine("");

foreach (var i in a)
    Console.WriteLine(i);

Console.WriteLine("");

System.Array.Sort(a, 0, a.Length);
foreach (var j in a)
    Console.WriteLine(j);

Console.WriteLine("");

