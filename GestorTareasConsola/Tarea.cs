using System;

namespace GestorTareasConsola.Clases
{
    public class Tarea
    {
        public string Realizar { get; set; }     // Atributos o propiedades de una tarea
        public DateTime? ParaQueDia { get; set; }  // Puede ser nula (opcional)
        public bool Realizada { get; set; }

        // Constructor que nos ayuda a crear una nueva tarea
        public Tarea(string descripcion, DateTime? fechaLimite = null)
        {
            Realizar = realizar;
            ParaQueDia = paraQueDia;
            Realizada = false; // Por defecto, la tarea no está completada
        }

        // Método que muestra la información de la tarea como texto
        public override string ToString()
        {
            string estado = Realizada ? "Realizada" : "Pendiente";
            string fechaTexto = ParaQueDia.HasValue ? $"(Para: {ParaQueDia.Value.ToShortTimeString()})" : "";
            return $"{estado} - {Realizar}{fechaTexto}";
        }
    }
}
