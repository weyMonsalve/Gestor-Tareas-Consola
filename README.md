# Aplicación de Consola: Gestor de Tareas (To-Do List)

Este proyecto es una aplicación de consola desarrollada en **C#** utilizando **.NET Framework 4.8**,  
como parte de una **prueba técnica para desarrollador practicante**.  
La aplicación permite gestionar una pequeña lista de tareas de forma sencilla a través de un menú interactivo en consola.

---

## Descripción del proyecto

Esta aplicación de consola permite:

- Agregar tareas (con descripción y fecha límite opcional)
- Listar todas las tareas registradas
- Marcar tareas como completadas
- Eliminar tareas

---

## Requerimientos funcionales implementados

1. **Agregar tareas:**
   - Permite ingresar una descripción de la tarea
   - También permite ingresar una fecha límite (opcional)

2. **Listar tareas:**
   - Muestra todas las tareas, indicando si están completadas o no

3. **Marcar tareas como completadas:**
   - El usuario puede seleccionar una tarea y marcarla como realizada

4. **Eliminar tareas:**
   - El usuario puede eliminar cualquier tarea de la lista

---

## Requerimientos técnicos cumplidos

1. **Uso de clases y objetos:**
   - Se creó una clase `Tarea` con propiedades (`Descripcion`, `FechaLimite`, `Completada`) y un método `ToString`
   - Se aplicó encapsulamiento usando modificadores de acceso como `public` y `private`

2. **Manejo de colecciones:**
   - Se utilizó una lista genérica `List<Tarea>` para almacenar las tareas

3. **Interacción con el usuario:**
   - Se implementó un menú interactivo en consola para que el usuario pueda elegir si desea agregar, listar, completar o eliminar tareas

4. **Manejo de errores:**
   - Se utilizaron bloques `try-catch` para manejar excepciones y evitar errores por entradas inválidas (por ejemplo, si se escriben letras en lugar de números)

---

## Instrucciones para compilar y ejecutar

### Requisitos

- Tener instalado **Visual Studio** con soporte para **.NET Framework 4.8**

### Pasos para ejecutar el proyecto

1. Abre Visual Studio
2. Haz clic en **"Abrir un proyecto o solución"**
3. Selecciona el archivo `GestorTareasConsola.sln`
4. Una vez cargado el proyecto, presiona `Ctrl + F5` para ejecutar sin depurar  
   (también puedes usar el botón **"Iniciar"**)

---

## Documentación del código

- El código está comentado de manera clara para facilitar su comprensión.
- Se explican las partes importantes: cómo se agregan tareas, cómo se recorre la lista, cómo se muestran mensajes, y cómo se validan las entradas del usuario.

---

## Entregable

- Este repositorio contiene todo el código fuente de la aplicación.
- Incluye este archivo `README.md` con las instrucciones para compilar y ejecutar.
- El proyecto ha sido subido a GitHub en un repositorio público como se solicitó.

---

## Autor

Javier Wbeimar Monsalve Rojas
