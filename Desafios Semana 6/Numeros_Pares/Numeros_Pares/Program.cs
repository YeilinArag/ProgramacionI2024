using System;
namespace Numeros_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;

            do
            {
                Console.WriteLine("Ingrese un número entero positivo: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

            for (int i = 1; i < numero; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}