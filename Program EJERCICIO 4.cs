//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace array
{
    class programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 4");

            Console.WriteLine("");

            Console.WriteLine("=================================");
            Console.WriteLine("ALUMNO JOSE SAUL SIBRIAN SERRNO");
            Console.WriteLine("=================================");

            Console.WriteLine("");

            Console.WriteLine("Funcion BinarySearch");

            Console.WriteLine("");

            string[] a = {"Sol", "Dedo", "Casa"};

            System.Array.Sort(a, 0, a.Length);
            foreach (var j in a)
                Console.WriteLine(j);

            Console.WriteLine("");

            int index1 = Array.BinarySearch(a, "Sol");
            int index2 = Array.BinarySearch(a, "Dedo");
            int index3 = Array.BinarySearch(a, "Casa");

            Console.WriteLine(index1);
            Console.WriteLine(index2);
            Console.WriteLine(index3);
        }
    }
}

