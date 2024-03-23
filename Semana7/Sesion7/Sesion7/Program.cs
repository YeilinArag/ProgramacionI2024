using System.Collections;

namespace Sesion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Puedo directamente asignar los valores
            int[] arreglo = { 1, 2, 3 };

            //Puedo crearlo directamente indicando el tamaño
            int[] arreglo2 = new int[10]; 

            //Indicamos el tamaño y los elementos
            int[] arreglo3 = new int[4] {1, 2, 4, 3};

            //Guardar valores en arreglo
            
               // arreglo2[0] = 1;
                //Console.WriteLine(arreglo2[0]);
               // arreglo2[1] = 2;
              
            for (int i = 0; i < arreglo.Length; i++)
            { 
                arreglo2[i] = i + 1; 
            }
            //Recorremos e imprimimos sus valores
            for (int i = 0;i < arreglo2.Length; i++)
            {
                Console.WriteLine(arreglo2[i]);
            }
            int contador = 0;
            while (contador < arreglo2.Length)
            {
                Console.WriteLine(arreglo2[contador]);
                contador++;
            }
           
           
        }
        

        public static void PruebaArrayLists()
        {
            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add(2);
            lista.Add("Hola");
            lista.Add("mundo");

            for (int i = 0;i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
