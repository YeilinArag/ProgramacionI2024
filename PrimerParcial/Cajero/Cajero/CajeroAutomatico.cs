using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public class CajeroAutomatico
    {
        private decimal saldo;
        public CajeroAutomatico(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }
        public void VerificarSaldo()
        {
            Console.WriteLine("Su saldo es: " + saldo);
        }
        public void Depositar(decimal monto)
        {
            saldo += monto;
            Console.WriteLine("Depósito exitoso. Su nuevo saldo es: " + saldo);
        }
        public void Retirar(decimal monto)
        {
            if (monto <= saldo) 
            {
                saldo-= monto;
                Console.WriteLine("Retiro exitoso. Su nuevo saldo es: " +saldo);
            }
            else
            {
                Console.WriteLine("No tienes fondos suficientes para retirar la cantidad que deseas.");
            }
        }
    }
}
