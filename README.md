# Gestión de Usuarios con .NET Core y React

Este proyecto es una aplicación full-stack que permite gestionar una lista de usuarios, utilizando un backend desarrollado con .NET Core siguiendo Clean Architecture y un frontend creado en React. La base de datos utilizada es MySQL.

## Tabla de Contenidos
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Requisitos](#requisitos)
- [Configuración del Backend (.NET Core)](#configuración-del-backend-net-core)
- [Configuración del Frontend (React)](#configuración-del-frontend-react)
- [Configuración de la Base de Datos (MySQL)](#configuración-de-la-base-de-datos-mysql)
- [Endpoints de la API](#endpoints-de-la-api)
- [Tecnologías Utilizadas](#tecnologías-utilizadas)

## Estructura del Proyecto

El proyecto está estructurado de la siguiente manera:

- **Backend (.NET Core)**:
  - Implementado con **.NET Core 8** siguiendo Clean Architecture.
  - Exposición de API REST para las operaciones CRUD.
  - Conexión con MySQL para la persistencia de datos.
  
- **Frontend (React)**:
  - Interfaz de usuario desarrollada con **React**.
  - Uso de **Axios** para comunicarse con la API.
  - Soporte para las operaciones CRUD (Crear, Leer, Actualizar, Eliminar).

## Requisitos

- **Backend**:
  - .NET Core 8.0 SDK
  - Entity Framework Core (con el paquete para MySQL)

- **Frontend**:
  - Node.js (versión 14 o superior)
  - npm (administrador de paquetes de Node.js)

- **Base de Datos**:
  - MySQL

## Configuración del Backend (.NET Core)

### 1. Clonar el repositorio
    ```bash
     git clone https://github.com/Jrace94/gestion-usuarios-net-react.git
     cd gestion-usuarios-net-react/GestionUsuarios

### 2. Configura la cadena de conexión en el archivo ApplicationDbContext.cs
Abre Infrastructure/Data/ApplicationDbContext.cs y edita la cadena de conexión para MySQL:
   ```bash
    optionsBuilder.UseMySql("Server=localhost;Database=usuariosdb;User=root;Password=yourpassword;",
                        new MySqlServerVersion(new Version(8, 0, 21)));

### 3. Aplica las migraciones para crear la base de datos y las tablas necesarias
   ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update

### 4. Ejecuta el backend
   ```bash
    dotnet run