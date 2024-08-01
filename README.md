# PruebaMassiveH
# Mi Aplicación

Este proyecto incluye un backend desarrollado con .NET y un frontend basado en React. A continuación se detallan los pasos para clonar, configurar y ejecutar la aplicación.

## Requisitos Previos

Asegúrate de tener instalados los siguientes requisitos:

- [.NET SDK](https://dotnet.microsoft.com/download) (versión compatible con el proyecto)
- [Node.js](https://nodejs.org/) (versión compatible con el proyecto)
- [Git](https://git-scm.com/)

## Clonar el Repositorio

Para clonar el repositorio junto con sus submódulos, utiliza el siguiente comando:

```bash
git clone https://github.com/BrayanPacheco05/PruebaMassiveH.git --recurse-submodules
```
### Después hacer un dotnet restore
### Después configurar el archivo de appsettings.json para añadir la cadenas de conexión de la base de datos
```bash
dotnet ef database update
dotnet run
```
# Front-end
```bash
npm install 
npm run dev /run start
```


