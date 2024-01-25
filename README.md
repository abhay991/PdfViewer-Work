# PdfViewer-Work
 For Yann Senecheau

There are two ways to install the wrapper library

1. Nuget Local (Recommended)
 - Click on Tools > Nuget Package Manager > Manage Nuget Package for Solution...
 - At right hand side you will see Package Source with settings button, click that
 - Now you will see package sources so you have to click plus (add) button at top right hand side
 - Name it Local Packages
 - Now in source you will see select button, click that and select a folder containing nuget file (FreeImage-dotnet-core.4.3.6.nupkg)
 - Then click update to update the file path and name and click close
 - Now you are back on Nuget - Solutions window so you have to select Package Source as Local Packages 
 - After selecting Local Packages you will see package FreeImage-dotnet-core which you have to install
- Finally copy Library/FreeImage.dll into Debug or Release folder where your exe is located
 - Once done you are ready to go

2. Importing library (dll)
 - In Solution Explorer you will see your project under which you will see Dependencies
 - Right click on it and select Add Project Reference...
 - Select Browse tab and click Browse... Button below
 - Select DLL File (FreeImage-dotnet-core.dll) from Library Folder and click OK
 - Copy FreeImage.dll into Debug or Release folder where your exe is located

Note: The sample .net core project i have sent works on both .net core 6 and .net core 8 (as well as 7) so you can just upgrade it's version from properties. The wrapper library is built in .net core 6
  