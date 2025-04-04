# appPPCPS

Creacion del proyecto
    Instalar el SDK --> https://dotnet.microsoft.com/download
    Crear una carpeta para alojar el proyecto
    En la terminal de PowerShell ejecutar --> dotnet new webapi -o Backend
    Dentro de la carpeta Backend ejecutar --> dotnet add package MySql.Data
    Dentro de la carpeta Backend deben encontrarse las carpetas Controller, Data y Models, en caso de faltar alguna, crearla.
    En el en la carpeta de proyecto agregar una carpeta que se llame Frontend donde se alojaran las vistas del proyecto.
    Dentro de Frontend deberan crear las carpetas css, js, y las carpetas de areas (Grado, Personal, Inventario, etc)


Ejecutar el proyecto
Terminal PowerShell (ejecuta la API)
    cd ./Backend
    dotnet run

Ejecutar el index.html con live server (ejecuta el Frontend)