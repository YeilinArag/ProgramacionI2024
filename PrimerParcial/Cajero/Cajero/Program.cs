namespace Cajero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CajeroAutomatico cajero = new CajeroAutomatico(500);

            int opcion;

            do
            {
                Console.WriteLine("Menú del cajero automático");
                Console.WriteLine("1. Ver saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cajero.VerificarSaldo();
                        break;

                    case 2:
                        Console.Write("Ingrese monto a depositar: ");
                        decimal montoDeposito = decimal.Parse(Console.ReadLine());
                        cajero.Depositar(montoDeposito);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar");
                        decimal montoRetiro = decimal.Parse(Console.ReadLine());
                        cajero.Retirar(montoRetiro);
                        break;
                }
            } while (opcion != 4);

        }
    }

}        




