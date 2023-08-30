# API Cotización Dólar

Este proyecto es una API REST en C# que permite obtener todas las cotizaciones del Dólar y devolverla en formato JSON.
El servicio obtiene los datos de la pagina https://www.infobae.com/

## Instrucciones

Sigue estos pasos para descargar, compilar y probar el proyecto:

### Descarga

1. Ve al repositorio del proyecto en GitHub: [apiCotizacionDolar](https://github.com/tuusuario/apiCotizacionDolar).
2. Haz clic en el botón "Code" y luego en "Download ZIP".
3. Descomprime el archivo ZIP descargado en una ubicación de tu elección.

### Compilación

1. Abre el proyecto en Visual Studio (asegúrate de tener instalado .NET Core 6).
2. Compila el proyecto para asegurarte de que no haya errores de compilación.

### Iniciar

1. Abre el terminal o línea de comandos.
2. Navega hasta la carpeta del proyecto donde se encuentra el archivo `apiCotizacionDolar.csproj`.

3. Ejecuta el siguiente comando para iniciar la aplicación:

```bash
dotnet run
```

### Probar
La aplicación debería iniciar y mostrar la dirección local en la que está ejecutándose, por ejemplo: https://localhost:5001.
Abre tu navegador web o herramienta de cliente API (como Postman) y accede a la siguiente URL para obtener la cotización del Dólar Banco Nación:

```
GET https://localhost:5001/api/CotizacionDolar/obtenerDolarBNA
```

### Notas
Asegúrate de tener instalado .NET Core 6 para compilar y ejecutar el proyecto.