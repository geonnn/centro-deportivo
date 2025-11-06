# Sistema de gestión del Centro Deportivo Universitario

> Proyecto desarrollado para el Seminario de Lenguajes opción .NET – 1º Semestre 2025

---

## 🧩 Novedad de esta versión

En esta versión, el sistema deja de operar exclusivamente por **consola** y se implementa una **interfaz gráfica de usuario (UI)** desarrollada en C#.  
La nueva interfaz permite **una experiencia más intuitiva y visual**, manteniendo la misma lógica de negocio y arquitectura por capas que la versión anterior.

Los casos de uso, repositorios y validaciones funcionan ahora detrás de la UI, que permite al usuario:
- Gestionar personas, eventos y reservas de forma visual  
- Navegar entre pantallas y formularios específicos  
- Visualizar mensajes de error o éxito mediante ventanas modales  
- Mantener la persistencia de datos en archivos de texto como en la versión original  

---

## ⚙️ Cómo ejecutar el proyecto

1. Abrir la solución en **Visual Studio 2022 o superior**
2. Seleccionar el proyecto de interfaz gráfica como **Startup Project**
3. Ejecutar el programa (`F5`) para iniciar la aplicación con la UI

---

## 🧠 Estructura general

El sistema mantiene una arquitectura modular basada en **capas y casos de uso**:

- **CentroEventos.Aplicacion.Entidades** → Clases de dominio (`Persona`, `EventoDeportivo`, `Reserva`, etc.)
- **CentroEventos.Aplicacion.Validadores** → Validaciones de reglas de negocio
- **CentroEventos.Aplicacion.UseCases** → Casos de uso que encapsulan la lógica de aplicación
- **CentroEventos.Repositorios** → Manejo de archivos de texto e IDs autogenerados
- **CentroEventos.UI** → Nueva capa de interfaz gráfica (formularios, controladores, vistas)

---

## 💾 Repositorios

Los datos ahora se almacenan en una **base de datos SQLite**, lo que permite un manejo más robusto y eficiente de la persistencia.
Cada entidad (Persona, EventoDeportivo, Reserva, etc.) tiene su propia tabla, y las relaciones se mantienen mediante claves foráneas e IDs autoincrementales.

La base de datos se crea automáticamente en tiempo de ejecución si no existe.
Ruta por defecto del archivo de base de datos:
CentroEventos.Repositorios/CentroEventos.sqlite

Esta implementación mejora:

- La **integridad de datos**

- El **rendimiento en consultas**

- Y la posibilidad de **ampliar** el sistema sin modificar el almacenamiento físico.

---

## 💡 Migración desde la versión de consola

La nueva versión mantiene la compatibilidad con el modelo anterior:
- Los **casos de uso** siguen disponibles y pueden ejecutarse sin la interfaz (por ejemplo, para testing o integración).  
- Se eliminaron los ejemplos de ejecución directa desde `Program.cs`, ya que la inicialización y orquestación de las entidades ahora la realiza la UI.  
- Se modularizó el acceso a cada entidad (Personas, Eventos, Reservas) mediante formularios dedicados.

---

## 👥 Autores

`👨‍💻 Gil, Gonzalo` **-** `👨‍💻 Hassan, Ignacio` **-** `👨‍💻 Lara, Gabriel`

---