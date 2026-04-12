📂 Estructura de Carpetas del Proyecto
En este proyecto solo nos enfocamos en las carpetas que realmente afectan al funcionamiento y al resultado final:

1. Properties (Configuración)
   Es la "cédula de identidad" de tu programa. Aquí se guarda el nombre del proyecto, la versión (ej. 1.0.0) y los recursos como el ícono que ves en el escritorio. No se toca mucho, pero es vital para que Windows sepa qué está ejecutando.

2. Dependencies / Referencias (Herramientas)
   Es tu caja de herramientas externa. Aquí es donde vive el conector de SQL Server (Microsoft.Data.SqlClient). Sin esta carpeta, el código no sabría cómo hablar con la base de datos. Cada vez que instalas algo por NuGet, aparece aquí.

3. bin (El resultado final)
   Esta es la carpeta más importante cuando terminas de programar. Viene de "Binary" y es donde se "cocina" tu código:

bin/Debug: Aquí es donde el programa corre mientras estás haciendo pruebas. Tiene archivos extra que ayudan a Visual Studio a decirte dónde falló algo.

bin/Release: Es el horno donde sale el pan caliente. Aquí se genera el archivo .exe final, optimizado y rápido, listo para ser entregue al usuario o cliente.

.

🔌 5. Conexión con SQL Server
Esta es la parte más importante del proyecto, ya que permite que los datos no se borren al cerrar el programa. Se divide en estos archivos:

ConexionBD.cs (El Enlace)
Es el archivo que contiene la Cadena de Conexión. Esta cadena funciona como una dirección de GPS que le dice a C# dónde está el servidor de SQL Server y a qué base de datos debe entrar. También contiene los métodos para abrir y cerrar la comunicación de forma segura.

Program.cs (El Verificador)
Aquí es donde ocurre el "doble chequeo". Antes de que se muestre la ventana del programa, este archivo le pregunta a SQL Server: "¿Ya tienes la tabla Usuarios creada?". Si la respuesta es no, el código la crea automáticamente. Esto asegura que el programa nunca falle por falta de tablas.

Form1.cs (El Mensajero)
Cuando presionas un botón, este archivo toma la información de los cuadros de texto y usa la clase ConexionBD para enviar los datos. Utiliza comandos como INSERT (para guardar) y DELETE (para borrar), asegurándose de que la información viaje rápido y sin errores.

Form1.Designer.cs (La Estructura)
Aunque es un archivo de diseño, aquí es donde definimos el DataGridView (la tabla visual). Es importante porque está configurado para mostrar las columnas exactamente como se llaman en SQL Server, permitiendo que los datos se vean ordenados apenas el programa arranca.

🛠️ Dependencias Necesarias
Para que todo este sistema de conexión funcione, se instaló la librería oficial de Microsoft. Si vas a ejecutar este proyecto en otra PC, asegúrate de correr este comando en la Consola del Administrador de Paquetes NuGet:

PowerShell
Install-Package Microsoft.Data.SqlClient
