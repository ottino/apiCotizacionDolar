# API Cotizaci�n D�lar

Este proyecto es una API REST en C# que permite obtener todas las cotizaciones del D�lar y devolverla en formato JSON.
El servicio obtiene los datos de la pagina https://www.infobae.com/

## Instrucciones

Sigue estos pasos para descargar, compilar y probar el proyecto:

### Descarga

1. Ve al repositorio del proyecto en GitHub: [apiCotizacionDolar](https://github.com/tuusuario/apiCotizacionDolar).
2. Haz clic en el bot�n "Code" y luego en "Download ZIP".
3. Descomprime el archivo ZIP descargado en una ubicaci�n de tu elecci�n.

### Compilaci�n

1. Abre el proyecto en Visual Studio (aseg�rate de tener instalado .NET Core 6).
2. Compila el proyecto para asegurarte de que no haya errores de compilaci�n.

### Iniciar

1. Abre el terminal o l�nea de comandos.
2. Navega hasta la carpeta del proyecto donde se encuentra el archivo `apiCotizacionDolar.csproj`.

3. Ejecuta el siguiente comando para iniciar la aplicaci�n:

```bash
dotnet run
```

### Probar
La aplicaci�n deber�a iniciar y mostrar la direcci�n local en la que est� ejecut�ndose, por ejemplo: https://localhost:5001.
Abre tu navegador web o herramienta de cliente API (como Postman) y accede a la siguiente URL para obtener la cotizaci�n del D�lar Banco Naci�n:

```
GET https://localhost:5001/api/CotizacionDolar/obtenerDolarBNA
```

### Notas
Aseg�rate de tener instalado .NET Core 6 para compilar y ejecutar el proyecto.