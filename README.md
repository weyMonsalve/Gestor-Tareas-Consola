# Aplicación de Consola - Gestor de Tareas (To-Do List)


Este proyecto es una aplicación de consola hecha en C# con .NET Framework 4.8. Fue realizada como parte de una prueba técnica para aprendiz o practicante. El objetivo principal es llevar un registro simple de tareas pendientes desde la terminal.

## ¿Qué hace esta app?

Permite lo siguiente:

- Agregar nuevas tareas (con o sin fecha)
- Ver la lista completa de tareas
- Marcar tareas como realizadas
- Eliminar tareas que ya no se necesitan
- Salir del programa de forma controlada

Todo se maneja a través de un menú que aparece en la consola y que es fácil de usar.

## ¿Qué funcionalidades incluye?

### Agregar tarea
- Puedes escribir qué tarea necesitas hacer.
- Si quieres, puedes ponerle una fecha límite (opcional).

### Ver tareas
- Muestra todas las tareas que has anotado.
- Se indica si ya están hechas o si aún están pendientes.

### Marcar como hecha
- Puedes seleccionar una tarea de la lista y marcarla como completada.

### Eliminar tarea
- También puedes borrar cualquier tarea que ya no necesites.

## Aspectos técnicos

- Se creó una clase `Tarea` que tiene lo básico: descripción, fecha límite (opcional) y si ya está hecha o no.
- Se utiliza una lista (`List<Tarea>`) para guardar las tareas.
- El programa usa `Console.ReadLine()` y `Console.WriteLine()` para interactuar con el usuario.
- Se añadieron validaciones para que el programa no se cierre si el usuario se equivoca al ingresar un número o una fecha (uso de `try-catch`).

## ¿Cómo ejecutar este proyecto?

### Requisitos

- Tener Visual Studio instalado (con soporte para .NET Framework 4.8)

### Pasos para correrlo

1. Abre Visual Studio.
2. Elige la opción **"Abrir un proyecto o solución"**.
3. Busca el archivo `GestorTareasConsola.sln` y ábrelo.
4. Una vez cargado, presiona `Ctrl + F5` para ejecutarlo (sin depurar).
   - También puedes hacer clic en el botón de **Iniciar**.

## Notas sobre el código

- El proyecto está separado por clases. La lógica principal está en `Program.cs` y la definición de cada tarea está en `Tarea.cs`.
- Los comentarios están escritos en un lenguaje claro para que se entienda qué hace cada parte.
- Se usaron nombres sencillos y en español tanto para métodos como para variables.

## Entrega

- El proyecto completo está subido en este repositorio.
- Incluye este archivo `README.md` con las instrucciones necesarias para compilar y ejecutar.

---

**Autor del proyecto:**  
Javier Wbeimar Monsalve Rojas
