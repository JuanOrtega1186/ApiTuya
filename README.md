# APIPagos

## Comenzando 🚀

Esta API genera validaciones de para pagos utilizando Net Core - C# simulando un servicio de pago tipica como lo es una transacción.


### Pre-requisitos 📋

- C#
- Visual Studio Comunity (Version 2019).
- Microsoft SQL Server Management Studio (version 18).
- Postman (Version 7.21.1).

### Instalación 🔧

- Clonar el repositorio con el siguiente comando: git clone ...
- Abrir el repositorio descargado con Visual Studio Comunity (Version 2019).
- Inicial la ejecucion de la solucion para validar las API's y visualizar la documentacion usando Swagger.
- Abrir Microsoft SQL Server Management Studio para visualizar las bases de datos independientes de cada API.
- Abrir Postman para realizar validaciones de consumo de las API's y sus requerimientos. 

### Estructura de la Solucion 🔧
- apiPagos:
    - Properties/launchSettings.json = Archivo .json que controla el lanzamiento de la API. en este archivo se modifica "applicationUrl": 
        "http://localhost:48226","sslPort": 44339 para individualizar la URL de la API a consumir.
    - Context/AppDbContext.cs = Clase que sirve como intermediario entre Controllers y  Models.
    - Controllers/TransferenciaController.cs = Es una clase de controlador de API que genera un esqueleto.
    - Models/Factura = Modelo que posee los datos que se lanzaran por la API. posee GET , SET.
    - Models/Pedido = Modelo que posee los datos que se lanzaran por la API. posee GET , SET.
    - Models/producto = Modelo que posee los datos que se lanzaran por la API. posee GET , SET.
    - Models/transferencia = Modelo que posee los datos que se lanzaran por la API. posee GET , SET.

## Ejecutando las pruebas ⚙️

- Se realizan pruebas unitarias con la carpeta Test y el archivo apiPagos.Test

## Construido con 🛠️

* [Visual Studio Comunity (Version 2019).](https://visualstudio.microsoft.com/es/downloads/) - El framework web usado
* [Microsoft SQL Server Management Studio (version 18).](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15) -  Gestor de base de datos
* [Postman (Version 7.21.1).](https://www.postman.com/downloads/) Motor de API
* [Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.7](https://www.youtube.com/watch?v=6if4pntcVPA) - Manejador de dependencias

## Autores ✒️

* **Juan Camilo Ortega Alvarez** - [juancamilo.ortega86@gmail.com](https://github.com/JuanOrtega1186)
 
