OmniStream - Proyecto Arquitectura en 3 Capas

📌 Descripción
OmniStream es una aplicación desarrollada bajo el patrón de arquitectura en 3 capas, cuyo objetivo es gestionar usuarios y aplicar una regla de negocio que determina si un usuario puede ser considerado como Premium.
La aplicación separa claramente las responsabilidades en:

Capa de Presentación (CLI)
Capa de Dominio
Capa de Infraestructura

🧠 Regla de Negocio
Un usuario será considerado Premium si cumple con las siguientes condiciones:
Tiene un saldo mayor a 50
No tiene deudas
Esta lógica se aplica tanto en el código como en la base de datos.

🏗️ Estructura del Proyecto

OmniStream/
│
├── Dominio/              → Entidades y reglas de negocio
├── Infraestructura/      → Acceso a datos (JSON)
├── PresentacionCLI/      → Interfaz de usuario por consola
├── Tests/                → Pruebas del sistema
├── script.sql            → Script de base de datos
└── README.md

⚙️ Tecnologías utilizadas
C#
.NET
JSON (persistencia de datos)
SQL (script de base de datos)
Git y GitHub

🧪 Pruebas del Sistema
Se implementaron pruebas para validar:
Creación de usuarios
Aplicación de la regla de negocio
Validación de usuarios premium
Estas pruebas permiten asegurar el correcto funcionamiento del sistema.

🗄️ Base de Datos
Se incluye un archivo script.sql que contiene:
Creación de la tabla Usuarios
Inserción de datos de prueba
Consultas para validar la regla de negocio

▶️ Ejecución del Proyecto
Clonar el repositorio:
git clone https://github.com/zairavaldes-cell/OmniStream.git

Ejecutar el proyecto:
dotnet run --project PresentacionCLI

📊 Ejemplo de funcionamiento
Se ingresa un ID de usuario
El sistema consulta los datos
Aplica la regla de negocio
Indica si el usuario es Premium o no

👩‍💻 Autores
Zaira Daniela Valdés Martínez, Jhony Alexander Jimenez
