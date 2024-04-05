using System;
using System.Collections.Generic;

class Program
{
    static List<string> tareas = new List<string>();

    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Lista\n1. Agregar tarea\n2. Mostrar tareas\n3. Eliminar tarea\n4. Salir");
            char opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcion)
            {
                case '1':
                    Console.Write("Ingrese la tarea: ");
                    string nuevaTarea = Console.ReadLine();
                    tareas.Add(nuevaTarea);
                    Console.WriteLine("Tarea agregada correctamente.");
                    break;
                case '2':
                    if (tareas.Count == 0)
                        Console.WriteLine("Estás libre por el momento.");
                    else
                    {
                        Console.WriteLine("Pendiente");
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                    }
                    break;
                case '3':
                    if (tareas.Count == 0)
                        Console.WriteLine("No hay tareas para eliminar.");
                    else
                    {
                        Console.WriteLine("Pendiente");
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                        Console.Write("Ingrese el número de la tarea a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tareas.Count)
                        {
                            tareas.RemoveAt(indice - 1);
                            Console.WriteLine("Tarea eliminada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Número de tarea no válido.");
                        }
                    }
                    break;
                case '4':
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción del menú.");
                    break;
            }
        }
    }
}