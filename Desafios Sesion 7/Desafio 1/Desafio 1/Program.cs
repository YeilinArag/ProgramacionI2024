namespace Desafio_1
{
    internal class Calculadora 
    {
       public string Marca {  get; set; }
        public string Serie { get; set; }

        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2; 
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 != 0) 
            return num1 / num2;
            else 
                return double.NaN;
        }
    }

    class CalculadoraCientifica : Calculadora
    {
        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double Raiz(double num1, double num2)
        {
            return Math.Pow(num1, 1.0 / num2);
        }

        public double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }
        public double QLogaritmo(double num1, double num2)
        {
            return Math.Log(num1, num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Marca = "Casio";
            calculadora.Serie = "FX-991ES";

            double resultado = calculadora.Sumar(5, 3);
            Console.WriteLine($"Suma: 5+3 = {resultado}");

            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Marca = "HP";
            calculadoraCientifica.Serie = "35s";

            resultado = calculadoraCientifica.Potencia(2, 3);
            Console.WriteLine($"Potencia: 2^3 = {resultado}");

            Console.ReadLine();

        }
    }
}
