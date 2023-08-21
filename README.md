# Proyecto de Verificación de Tipo de Cambio

Este proyecto es una aplicación que obtiene los tipos de cambio mensuales de una fuente externa y los muestra en un DataGridView. Los tipos de cambio también se almacenan en una base de datos para su registro y se evita el registro duplicado.

## Requisitos

- Visual Studio (o cualquier otro entorno de desarrollo compatible con C#)
- Conexión a internet para obtener los datos de los tipos de cambio
- Base de datos para almacenar los registros (se utiliza Entity Framework)

## Instalación y Configuración

1. Clona o descarga este repositorio en tu máquina local.

2. Abre el proyecto en Visual Studio.

3. Configura la conexión a la base de datos:
   - Abre el archivo `App.config` en el proyecto.
   - Encuentra la sección `<connectionStrings>` y modifica la cadena de conexión para que coincida con tu base de datos.

4. Compila y ejecuta el proyecto.

## Uso

1. Ejecuta la aplicación.

2. Haz clic en el botón "Obtener Cambio Mensual".

3. Los tipos de cambio del mes actual se mostrarán en el DataGridView.

4. Si los tipos de cambio aún no están registrados en la base de datos, se registrarán automáticamente.

5. Si ya existen registros en la base de datos para el mes actual, se mostrará un mensaje indicando que los registros ya existen.

