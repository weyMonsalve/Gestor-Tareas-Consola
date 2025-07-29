using System;
using System.Collections.Generic;
using GestorTareasConsola.Clases;

namespace GestorTareasConsola
{
    class Program
    {
        //Lista vacia para guardar tareas en memoria que el usuario agregue
        static List<Tarea> listaTareas = new List<Tarea>();

        static void Main(string[] args)
        {
            bool salir = false;  // variable que controla si el programa se sigue ejecutando o no

            //Mientras salir sea falso, el programa seguira mostarndo el menu
            while (!salir)
            {
                Console.Clear();  //Limpiamos pantalla
                Console.WriteLine("=======MENÚ PRINCIPAL=======");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opción: ");

                //Leemos lo que el usuario escriba como opción
                string opcion = Console.ReadLine();

                // Según lo que elija el usuario, se ejecuta una acción diferente
                switch (opcion)
                {
                    case "1":
                        AgregarTarea();         //Función para agreagar una tarea
                        break;
                    case "2":
                        ListarTareas();         //Función para ver las tareas
                        break;
                    case "3":
                        MarcarComoCompletada();  //Función para marcar la tarea como completada
                        break;
                    case "4":
                        EliminarTarea();         //Función para eliminar una tarea
                        break;
                    case "5":
                        salir = true;  // para salir del programa se cambia true
                        break;
                    default:
                        Console.WriteLine("Opción no valida.");  //Cuando se escrib algo que no esta en el menú
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");  //se espera que usuario presione una tecla para volver al menu
                Console.ReadKey();
            }
        }

        //Metodo para agregar una nueva tarea
        static void AgregarTarea()
        {
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();   //aqui leemos la descripción

            Console.Write("¿Desea establecer una fecha limite? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();  // Convertimos a minuscula por mejor opcion

            DateTime? fechaLimite = null;        //Por defecto, no tiene fecha

            if (respuesta == "s")
            {
                Console.WriteLine("Ingrese la fecha limite: ");
                string fechaTexto = Console.ReadLine();

                //Se intenta convertir el texto a una fecha valida
                if (DateTime.TryParse(fechaTexto, out DateTime fecha))
                {
                    fechaLimite = fecha;
                }
                else
                {
                    Console.WriteLine("Fecha no valida. se agregara sin fecha limite.");
                }
            }

            //Creamos una nueva tarea con los datos ingresados por el usuario
            Tarea nueva = new Tarea(descripcion, fechaLimite);
            listaTareas.Add(nueva);       //Aqui se agrega a la lista

            Console.WriteLine("Tarea agregada con exito.");
        }

        //Metodo para ver todas las tareas guardadas
        static void ListarTareas()
        {
            if (listaTareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registardas.");
            }
            else
            {
                Console.WriteLine("==== TAREAS ====");
                for (int i = 0; i < listaTareas.Count; i++)
                {
                    //Se muestra cada tarea con sunúmero correspondiente
                    Console.WriteLine($"{i + 1}. {listaTareas[i]}");
                }
            }
        }

        //Metodo para marcar tarea como completada
        static void MarcarComoCompletada()
        {
            ListarTareas();     //Se muestran las tareas para que el usuarui elija

            Console.Write("Ingrese el numero de la taraea a completar: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero) && numero >= 1 && numero <= listaTareas.Count)
            {
                listaTareas[numero - 1].Completada = true;  //Se marca la tarea completada
                Console.WriteLine("Tarea marcada como completada");
            }
            else
            {
                Console.WriteLine("Número invalido.");
            }
        }

        //Metodo para eliminar una tarea
        static void EliminarTarea()
        {
            ListarTareas();       //Se listan las tareas para elegir cuál borrar

            Console.Write("Ingrese el número de la tarea a eliminar: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero) && numero >= 1 && numero <= listaTareas.Count)
            {
                listaTareas.RemoveAt(numero - 1); // Quitamos la tarea de la lista
                Console.WriteLine("Tarea eliminada.");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }
}