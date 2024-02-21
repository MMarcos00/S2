using System;

namespace MyCompiler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su año de nacimiento:");
            string añoTexto = Console.ReadLine();
            int año = int.Parse(añoTexto);

            switch (año)
            {
                case >= 1928 and <= 1945:
                    Console.WriteLine("Usted pertenece a la generación Silenciosa");
                    break;
                case >= 1946 and <= 1964:
                    Console.WriteLine("Usted pertenece a la generación de los baby boom");
                    break;
                case >= 1965 and <= 1980:
                    Console.WriteLine("Usted pertenece a la generación X");
                    break;
                case >= 1981 and <= 1996:
                    Console.WriteLine("Usted pertenece a la generación millenial");
                    break;
                case >= 1997 and <= 2012:
                    Console.WriteLine("Usted pertenece a la generación Z");
                    break;
                case >= 2013:
                    Console.WriteLine("Usted pertenece a la generación Alfa");
                    break;
                default:
                    Console.WriteLine("Año invalido");
                    break;
            }
        }
    }
}
