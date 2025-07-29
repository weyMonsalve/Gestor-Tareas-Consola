//Se importa lo necesario para trabajar con  listas y mis clases
using System;
using System.Collections.Generic;
using GestorTareasConsola.Clases;

namespace GestorTareasConsola
{
    class Program
    {
        //Aqui van todas la cosas que debo realizar
        static List<Tarea> misPendientes = new List<Tarea>();     //esta es una variable tipo local

        static void Main(string[] args)
        {
            bool quieroSalir = false;  // variable que controla si el programa para sabe si se sigue ejecutando

            //Mientras salir sea falso, seguira mostarndo el menu
            while (!quieroSalir)
            {
                Console.Clear();  //Limpia la pantalla
                Console.WriteLine("=======MENÚ PRINCIPAL=======");
                Console.WriteLine("1. Anotar nueva tarea");
                Console.WriteLine("2. Ver tareas pendientes");
                Console.WriteLine("3. Marcar tarea como realizada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opcion del 1 al 5: ");

                // Según lo que el usuario elija, se llama a la función correspondiente
                string loElegido = Console.ReadLine();

                switch (loElegido)
                {
                    case "1":
                        ApuntarPendiente();
                        break;
                    case "2":
                        VerTodo();
                        break;
                    case "3":
                        MarcarComoRealizado();
                        break;
                    case "4":
                        BorrarPendiente();
                        break;
                    case "5":
                        quieroSalir = true; //Se pone asi para que termine el programa
                        Console.WriteLine("Cerrando el programa");
                        break;
                    default:
                        Console.WriteLine("Opción no valida. Intenta de nuevo");
                        Console.ReadKey();
                        break;


                }
            }
        }
        // Función para anotar una nueva tarea
        static void ApuntarPendiente()  //Usamos static void  para que se ejecute sin necesidad de crear un objeto de la clase
        {
            Console.Clear();
            Console.WriteLine("===== NUEVA COSA A REALIZAR =====");
            Console.Write("¿Que vas a realizar?: ");
            string cosa = Console.ReadLine();    // Nombramos de la tarea

            Console.Write("¿quieres agregarle una fecha limite? (s/n): ");
            string agregarFecha = Console.ReadLine().ToLower();

            DateTime? fecha = null;   // Fecha es opcional

            if (agregarFecha == "s")
            {
                Console.Write("Escribe la fecha (formato: yyyy-mm-dd): ");
                string textoFecha = Console.ReadLine();

                try
                {
                    fecha = DateTime.Parse(textoFecha);
                }
                catch
                {
                    Console.WriteLine("Se guradara sin fecha limite");
                }
            }

            // Creamos un nuevo objeto Tarea con lo que el usuario escriba
            Tarea nueva = new Tarea(cosa, fecha);
            misPendientes.Add(nueva);   // Se agrega a la lista

            Console.WriteLine("Se anoto. Pulsa una tecla para continuar.");
            Console.ReadKey();
        }

        // Función para mostrar todas las tareas guardadas
        static void VerTodo()
        {
            Console.Clear();
            Console.WriteLine("==== ESTO ES LO PENDIENTE ====");

            if (misPendientes.Count == 0)
            {
                Console.WriteLine("No tienes nada pendiente.");
            }
            else
            {
                for (int i = 0; i < misPendientes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {misPendientes[i]}");
                }
            }

            Console.WriteLine("Pulsa una tecla para volver a menú.");
            Console.ReadKey();
        }

        // Función que permite marcar una tarea completada
        static void MarcarComoRealizado()
        {
            Console.Clear();
            Console.WriteLine("==== MARCAR COMO REALIZADO ====");
            VerTodo();    //  Se muestra la lista para que el usuario vea qué número elegira

            Console.Write("escribe el número de la tarea ya realizada:");
            string entrada = Console.ReadLine();

            try
            {
                int indice = int.Parse(entrada) - 1;

                if (indice >= 0 && indice < misPendientes.Count)
                {
                    misPendientes[indice].Realizada = true;
                    Console.WriteLine("Tarea marcada como completada.");
                }
                else
                {
                    Console.WriteLine("Numero no existente en tú lista.");
                }
            }
            catch
            {
                Console.WriteLine("No es un número valido");
            }

            Console.WriteLine("Presiona una tecla para continuar.");
            Console.ReadKey();
        }

        //Función que permite eliminar una tarea
        static void BorrarPendiente()
        {
            Console.Clear();
            Console.WriteLine("=== ELIMINAR ALGO ===");
            VerTodo();

            Console.WriteLine("¿Cual deseas eliminar?. Escribe el numero: ");
            string entrada = Console.ReadLine();

            try
            {
                int indice = int.Parse(entrada) - 1;

                if (indice >= 0 && indice < misPendientes.Count)
                {
                    misPendientes.RemoveAt(indice);
                    Console.WriteLine("Eliminado de la lista.");
                }
                else
                {
                    Console.WriteLine("Ese número no existe.");
                }
            }
            catch
            {
                Console.WriteLine("No es un número valido.");
            }

            Console.WriteLine("Presiona una tecla para continuar.");
            Console.ReadKey();
        }
    }
}
