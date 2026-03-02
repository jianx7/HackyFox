# 🦊 HackyFox
Aplicación educativa de ciberseguridad infantil

---

## 📌 Descripción del proyecto

**HackyFox** es una aplicación educativa de escritorio desarrollada en C# con Windows Forms, diseñada para enseñar conceptos básicos de ciberseguridad a niños de entre 7 y 12 años mediante lecciones interactivas, retos y dinámicas gamificadas.

El sistema promueve hábitos digitales seguros a través de contenido adaptado a la edad del usuario y un sistema de progreso que se actualiza automáticamente conforme el niño completa actividades correctamente.

---

## 🎯 Objetivo

Desarrollar una aplicación interactiva que:

- Enseñe principios básicos de ciberseguridad infantil.
- Refuerce el aprendizaje mediante retos y dinámicas.
- Registre automáticamente el progreso del usuario.
- Mantenga una experiencia amigable y visualmente atractiva.

---

## 🧠 Público objetivo

Niños de 7 a 12 años que comienzan a utilizar dispositivos digitales e internet.

---

## ⚙️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** Windows Forms (.NET)
- **Base de datos:** MySQL
---

## 🏗️ Estructura del sistema

### 🔐 Registro e inicio de sesión
- Registro con alias y fecha de nacimiento.
- Validación de datos.
- Inicio de sesión personalizado.

### 📚 Módulo de Lecciones
- `MenuLecciones`: muestra número, nombre, título y dinámica asociada.
- `Leccion`: muestra contenido educativo con texto e imagen (almacenada como BLOB).

### ⚡ Reto Relámpago
- Presenta una pregunta con tres opciones.
- Validación de respuesta correcta desde la base de datos.
- Registro del componente "reto" en la tabla `detalle_progreso`.
- Pantalla de felicitación antes de pasar a la dinámica.

### 🎮 Dinámicas
- 6 formularios distintos.
- Se desbloquean tras completar correctamente el reto.
- Actualizan el progreso global del usuario.

### 🐾 Mascota virtual
- Muestra imagen, nombre y consejos.
- Refuerza la experiencia gamificada.

---

## 🔄 Flujo general del usuario

1. Registro / Inicio de sesión  
2. Acceso al menú principal  
3. Selección de lección  
4. Visualización del contenido  
5. Resolución del reto  
6. Dinámica interactiva  
7. Actualización automática del progreso  
8. Desbloqueo de la siguiente lección  

---

## 🌍 Impacto social

HackyFox contribuye a:

- Educación digital responsable.
- Prevención de riesgos en línea.
- Formación temprana en seguridad informática.

Alineado con:
- ODS 4: Educación de calidad
- ODS 16: Paz, justicia e instituciones sólidas

---

## 👩‍💻👩‍💻👨‍💻
Proyecto desarrollado como parte de la formación en Ingeniería en Tecnologías de la Información e Innovación Digital.
