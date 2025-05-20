> [Ver en ingles/See in english](https://github.com/LuisMiSanVe/MouseDummy/blob/main/README.md)
# <img src="https://github.com/LuisMiSanVe/MouseDummy/blob/main/MouseDummy/Resources/icon.ico" width=35 height=35 alt="🖱️"> Simulador del Ratón
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

Programa de WinForms que te deja configurar el movimiento del ratón y reproducirlo en cualquier momento.

Aunque tenga un concepto parecido, este programa no está pensando para usarse como *autoclicker* (aunque es posible hacerlo), principalmente su proposito es controlar el cursor de forma automática usando secuencias de todas las acciones posibles que tiene un ratón estándar.

## 📝 Explicación de Tecnología
Uso la librería DLL `user32.dll` como una API de Windows para usar los métodos ya definidos del movimiento del ratón.

## ⚙️ Explicación de uso del proyecto
Presional el botón de `Reastrear` y sin perder el foco del programa, mueve el ratón a las coordenadas que quieras, presiona `N` para guardarlo en la lista de Puntos, entonces asignale una acción al punto desde la lista de Acciones.

Puedes guardar la secuencia y reproducirla cuando quieras seleccionandolo en el *combo box*.

## 📂 Archivos
Al presionar el botón de `Guardar` dentro del *combo box*, un archivo con la secuencia de puntos se guardará en tu equipo internamente.

El nombre del archivo se cerará automaticamente por un método que resume las acciones de la secuencia.

## 🚀 Lanzamientos
Una versión será lanzada solo cuando se cumplan los siguientes puntos:\
Nuevas funciones importantes y arreglos de fallos criticos causarán la salida inmediata de una nueva versión, mientras que otros cambios/arreglos menores deberán esperar una semana desde que se incluyeron en el repositorio antes de ser incluidos en la nueva versión, para que otros posibles cambios puedan ser añadidos tambien.
>[!NOTE]
>Estos posibles nuevos cambios no alargarán la espera de la salida de la nueva versión a más de una semana.

El número de la versión seguirá este formato: \
\[Añadido Importante\].\[Añadido Menor\].\[Arreglos de Errores\]

## 💻 Tecnologías usadas
- Lenguaje de programación: [C#](https://dotnet.microsoft.com/en-us/languages/csharp) 
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
- Librerías: user32.dll
- Otros:
  - [ChatGPT](https://chatgpt.com/) (icono)
- IDE Recomendado: [Visual Studio](https://visualstudio.microsoft.com/)
