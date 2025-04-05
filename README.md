
# 📦 Proyecto appPPCPS

Este proyecto utiliza **.NET 6/7 Web API** para el backend y archivos HTML, CSS y JS para el frontend.

---

## 🚀 Creación del Proyecto

### 1. Requisitos previos
- Tener instalado el SDK de .NET: [Descargar SDK .NET](https://dotnet.microsoft.com/download)

### 2. Pasos para iniciar el proyecto

1. Crear una carpeta para alojar el proyecto.
2. Abrir una terminal PowerShell y ejecutar el siguiente comando para crear el backend:

   ```bash
   dotnet new webapi -o Backend
   ```

3. Entrar en la carpeta `Backend` y agregar el paquete de conexión a MySQL:

   ```bash
   cd Backend
   dotnet add package MySql.Data
   ```

4. Verificar que dentro de la carpeta `Backend` existan las siguientes subcarpetas:
   - `Controllers`
   - `Data`
   - `Models`

   > Si alguna carpeta no está presente, créala manualmente.

5. En la raíz del proyecto, crear una carpeta llamada `Frontend` para alojar las vistas del sistema.

6. Dentro de `Frontend`, crear las siguientes carpetas:
   - `css` → Para hojas de estilo
   - `js` → Para archivos JavaScript
   - Carpetas específicas por áreas del sistema:
     - `Grado`
     - `Personal`
     - `Inventario`
     - etc.

---

## ▶️ Ejecución del Proyecto

### Backend

1. Abrir una terminal PowerShell.
2. Navegar a la carpeta del backend:

   ```bash
   cd ./Backend
   ```

3. Ejecutar la API:

   ```bash
   dotnet run
   ```

### Frontend

1. Abrir el archivo `index.html` dentro de la carpeta `Frontend`.
2. Ejecutarlo utilizando **Live Server** (por ejemplo, con la extensión de VS Code).

---

## 📁 Estructura del Proyecto

```
appPPCPS/
│
├── Backend/
│   ├── Controllers/
│   ├── Data/
│   ├── Models/
│   ├── Program.cs
│   └── ...
│
├── Frontend/
│   ├── css/
│   ├── js/
│   ├── Grado/
│   ├── Personal/
│   ├── Inventario/
│   └── index.html
```
