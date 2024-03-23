using System;
using System.Collections.Generic;
namespace Desafio_3
{
    internal class Program
    {
        static List<string> tareas = new List<string>();
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                MostrarMenu();
                opcion = ObtenerOpcionUsuario();

                switch (opcion)
                {
                    case 1:
                        MostrarTareas();
                        break;
                    case 2:
                        AgregarTarea();
                        break;

                    case 3:
                        EliminarTarea();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
            }while (opcion !=4);
            }
        static void MostrarMenu()
        {
            Console.WriteLine("Lista de Tareas");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Mostrar Tareas");
            Console.WriteLine("2. Agregar Tarea");
            Console.WriteLine("3. Eliminar Tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }
        static int ObtenerOpcionUsuario()
        {
            int opcion;
            while(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion>4)
            {
                Console.Write("Opcion invalida. Intente de nuevo: ");
            }
            return opcion;
        }
        static void MostrarTareas() 
        {
            Console.WriteLine("\nLista de Tareas:");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas en la lista. ");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {tareas[i]}");
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("\nIngrese la nueva tarea: ");
            string nuevaTarea= Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada correctamente");
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            if (tareas.Count > 0)
            {
                Console.Write("\nIngrese el número de la tarea a eliminar: ");
                int indice = ObtenerOpcionUsuario() - 1;

                if (indice >= 0 && indice < tareas.Count)
                {
                    tareas.RemoveAt(indice);
                    Console.WriteLine("Tarea eliminada correctamente. ");
                }
                else
                {
                    Console.WriteLine("Indice invalido. No se pudo eliminar la tarea. ");
                }
            }
        }
        
        
           
        }
    }

