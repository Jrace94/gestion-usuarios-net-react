using Infrastructure.Data; // Importar tu DbContext
using Microsoft.EntityFrameworkCore; // Para usar el DbContext con MySQL

var builder = WebApplication.CreateBuilder(args);

// 1. Agregar los servicios necesarios al contenedor (Inyección de dependencias)

// Configurar Entity Framework con MySQL:
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 23)))); // Versión de MySQL

// Agregar controladores para poder usar endpoints de la API:
builder.Services.AddControllers();

// Configurar CORS si React se encuentra en un dominio diferente al del backend:
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// 2. Configurar el pipeline de la aplicación

// Redirección automática a HTTPS
app.UseHttpsRedirection();

// Usar autorizaciones si las has configurado (en este caso no se requiere)
app.UseAuthorization();

// Habilitar CORS para la política definida
app.UseCors("AllowAll");

// Mapear los controladores (endpoints de la API)
app.MapControllers();

// Iniciar la aplicación
app.Run();
