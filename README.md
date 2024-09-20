# Proyecto Gestión de Usuarios con .NET Core y React

Este proyecto es una aplicación full-stack que permite gestionar una lista de usuarios. Utiliza .NET Core como backend (siguiendo el patrón Clean Architecture) y React como frontend, comunicándose mediante una API REST. La base de datos es MySQL.

## Requisitos

- .NET Core SDK 8.0
- Node.js (versión 14 o superior)
- MySQL (versión 8.0 o superior)

## Estructura del Proyecto

- **Backend**: .NET Core con Clean Architecture, exponiendo una API REST para gestionar los usuarios.
- **Frontend**: React para la interfaz de usuario.
- **Base de Datos**: MySQL.

## Instrucciones de Configuración

### Backend (.NET Core)

1. **Clona el repositorio** y navega al directorio del backend

   ```bash
   git clone https://github.com/Jrace94/gestion-usuarios-net-react.git
   cd gestion-usuarios-net-react/GestionUsuarios

2. **Clonfigura la cadena de conexión** en el archivo ApplicationDbContext.cs

   ```bash
   optionsBuilder.UseMySql("Server=localhost;Database=usuarios;User=root;Password=jose0123;",
                    new MySqlServerVersion(new Version(8, 0, 21)));
   
3. **Aplica las migraciones** para crear la base de datos y las tablas necesarias

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update

4. **Ejecuta el backends**

   ```bash
   dotnet run

### Frontend (React)

1. **Navega al directorio del frontend**

   ```bash
   cd ../frontend

2. **Instala las dependencias de React**

   ```bash
   npm install
   
3. **Ejecuta la aplicación React**

   ```bash
   npm start

### Base de Datos (MySQL)

**Crea la base de datos**
    
    ```bash
    CREATE DATABASE IF NOT EXISTS usuarios;

### Endpoints de la API

| Método | Endpoint              | Descripción                       |
|--------|-----------------------|-----------------------------------|
| GET    | `/api/usuarios`        | Obtiene la lista de todos los usuarios. |
| GET    | `/api/usuarios/{id}`   | Obtiene un usuario por su ID.     |
| POST   | `/api/usuarios`        | Crea un nuevo usuario.            |
| PUT    | `/api/usuarios/{id}`   | Actualiza un usuario existente.   |
| DELETE | `/api/usuarios/{id}`   | Elimina un usuario por su ID.     |

### Tecnologías Utilizadas

## Backend

- .NET Core 8.0
- Entity Framework Core
- MySQL

## Frontend

- React
- Axios

### Autor
Proyecto desarrollado por [José Rojas] - 2024.