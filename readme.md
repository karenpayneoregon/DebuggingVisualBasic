# Loading assembles
This repository provides insight into loading a projects assemblies which resides in paths below the executing assemble, in paths outside the executing assemble path. 

Reasons for placing assemblies in a different path then the executing assembly.
- Provides a common path for other projects to use the same assemblies without placing them in the GAC.
- Cleaning up the folder for the executing assembly.
- For plugin ([example](https://code.msdn.microsoft.com/windowsdesktop/Creating-a-simple-plugin-b6174b62)) libraries.

## Exception handling
Also provides basic exception handling dealing when an assembly can not be located.

## Logging
Basic logging for debug purposes using a singleton.

> The repository name is not a mistake, there will be other articles using this repo.

Microsoft TechNet article [VB.NET Dynamically load assemblies](https://social.technet.microsoft.com/wiki/contents/articles/53408.vb-net-dynamically-load-assemblies.aspx)

https://karenpayneoregon.github.io/DebuggingVisualBasic/

