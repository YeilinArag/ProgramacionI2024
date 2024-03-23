using System;
namespace Desafio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] compras =
            {
                {50, 75, 120, 80, 90 },
                {200, 300, 150, 250, 180 },
                {1200,800, 600, 400, 1000 },
                {80, 60, 70, 90, 50 },
                {1500, 2000, 1800, 1200, 1000 }
            };

            CalcularDescuentos(compras);
            Console.ReadLine();
        }
        static void CalcularDescuentos(int[,] compras)
        {
            int numClientes=compras.GetLength(0); 
            int numCompras=compras.GetLength(1);

            for (int i=0; i < numClientes; i++)
            {
                int totalCompras = 0;
                for (int j=0; j < numCompras; j++)
                {
                    totalCompras += compras[i,j];
                }

                double descuento = CalcularDescuento(totalCompras);
                double montoConDescuento = totalCompras - (totalCompras * descuento);

                Console.WriteLine($"Cliente {i + 1}: Total de compras = ${totalCompras}, Descuento={descuento * 100}%, Monto con descuento=${montoConDescuento}");

            }
        }
        static double CalcularDescuento(int totalCompras)
        {
            if (totalCompras < 100)
                return 0;
            else if (totalCompras >= 100 && totalCompras <= 1000)
                return 0.1;
            else
                return 0.2;
        }
    }
}
