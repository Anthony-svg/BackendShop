# BackendShop (.NET + SQL Server) ⚙️

Este repositorio contiene la API REST (Backend) para el proyecto **Shop**, desarrollada con **.NET** (C#) y conectada a una base de datos relacional **SQL Server** utilizando **Entity Framework Core**.

---

## 🛠️ Requisitos Previos

Antes de comenzar, asegúrate de tener instalado en tu sistema:

*   [.NET SDK](https://microsoft.com) (Versión 10.0 o compatible)
*   [SQL Server](https://microsoft.com) (LocalDB o Express)
*   [EF Core CLI](https://microsoft.com) (Instalado globalmente ejecutando `dotnet tool install --global dotnet-ef`)

---

## 🚀 Instalación y Configuración

Sigue estos pasos para levantar el servidor de desarrollo localmente:

### 1. Clonar el repositorio
```bash
git clone https://github.com/Anthony-svg/BackendShop.git
cd BackendShop
```

### 2. Configurar la Base de Datos
Este proyecto utiliza un archivo de configuración local oculto para proteger las credenciales.
Abre `appsettings.json` y edita la cadena de conexión (`DefaultConnection`) con tu usuario y contraseña de SQL Server local:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR_SQL;Database=ShopDB;User Id=tu_usuario;Password=tu_contraseña;TrustServerCertificate=True;"
}
```

### 3. Aplicar las Migraciones (Crear tablas)
Genera la estructura de la base de datos automáticamente en tu SQL Server ejecutando:
```bash
dotnet ef database update
```

### 4. Ejecutar la API
Inicia el servidor de desarrollo local:
```bash
dotnet run
```
La API comenzará a escuchar peticiones en la dirección: `http://localhost:5000`

---

## 📂 Estructura Principal del Proyecto

```text
├── Controllers/                # Endpoints de la API REST
├── Models/                     # Entidades de C# que mapean a las tablas de SQL
├── Data/                       # DbContext y configuraciones de Entity Framework
├── Migrations/                 # Historial de cambios de la base de datos (SÍ SE SUBE)
├── Program.cs                  # Configuración de servicios, middlewares y CORS
├── appsettings.json            # Configuración base global
├── appsettings.Example.json    # Plantilla pública de configuración (SÍ SE SUBE)
└── .gitignore                  # Excluye bin/, obj/ y appsettings.Development.json
```

---
