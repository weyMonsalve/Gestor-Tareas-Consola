using System;

namespace GestorTareasConsola.Clases
{
    public class Tarea
    {
        // Atributos o propiedades de una tarea
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }  // Puede ser nula (opcional)
        public bool Completada { get; set; }

        // Constructor que nos ayuda a crear una nueva tarea
        public Tarea(string descripcion, DateTime? fechaLimite = null)
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            Completada = false; // Por defecto, la tarea no está completada
        }

        // Método que muestra la información de la tarea como texto
        public override string ToString()
        {
            string estado = Completada ? "Completada" : "Pendiente";
            string fechaTexto = FechaLimite.HasValue ? FechaLimite.Value.ToShortDateString() : "Sin fecha límite";
            return $"{Descripcion} | {fechaTexto} | {estado}";
        }
    }
}
