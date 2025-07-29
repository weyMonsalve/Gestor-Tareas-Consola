using System;

namespace GestorTareasConsola.Clases
{
    public class Tarea
    {
        public string Realizar { get; set; }     // Lo que se debe realizar
        public DateTime? ParaQueDia { get; set; }  // Puede ser nula (opcional)
        public bool Realizada { get; set; }    //Dice si ya esta completado

        // Constructor que nos ayuda a crear una nueva tarea
        public Tarea(string realizar, DateTime? paraQueDia = null)
        {
            Realizar = realizar;
            ParaQueDia = paraQueDia;
            Realizada = false; // Por defecto, la tarea se crea como pendiente
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
