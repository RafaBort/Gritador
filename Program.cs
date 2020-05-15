using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algo!");

            string texto;
            texto = Console.ReadLine();

            Console.WriteLine(texto.ToUpper());
        }
    }
}
