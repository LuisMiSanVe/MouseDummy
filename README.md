> [See in spanish/Ver en español](https://github.com/LuisMiSanVe/MouseDummy/blob/main/README.es.md)
#  <img src="https://github.com/LuisMiSanVe/MouseDummy/blob/main/MouseDummy/Resources/icon.ico" width=35 height=35 alt="🖱️"> Mouse Dummy
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

WinForms program that lets you configure the mouse's movement and reproduce it anytime.

Despite having similar concept, this program is not meant to be an *autoclicker* (even if you can use it as one), mainly its purpose is to control the cursor automatically using sequences with all the actions possible with a standart mouse.

## 📝 Technology Explanation
I use the DLL librabry `user32.dll` as a Windows API to use the prebuilt mouse movement methods.

## ⚙️ Project Usage Explanation
Press the `Track` button and without losing the focus on the program, move the mouse to the desired coordinates, press `N` to save them into the Points list, then link the point to the action desired on the Action list.

You can save a secuence and reproduce it anytime selecting it on the *combo box*.

## 📂 Files
By pressing the `Save` button in the *combo box*, a file with the point secuence will be saved internally in your drive.

The name of the file will be automatically created by a method that summarizes the actions of the sequence.

## 🚀 Releases
The version will be released using these versioning policies:\
New major features and critical bug fixes will cause the immediate release of a new version, while other minor changes/fixes will wait one week from the time the change is introduced in the repository before being included in the new version, so that other potential changes can be added.
>[!NOTE]
>These potencial new changes will not increase the wait time for the new version beyond one week.

The version number will follow this format: \
\[Major Feature\].\[Minor Feature\].\[Bug Fixes\]

## 💻 Technologies Used
- Programming Language: [C#](https://dotnet.microsoft.com/en-us/languages/csharp) 
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
- Libraries: **user32.dll**
- Other:
  - [ChatGPT](https://chatgpt.com/) (icon)
  - [Freeicons](https://freeicons.io/) (images)
- Recommended IDE: [Visual Studio](https://visualstudio.microsoft.com/)
