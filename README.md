# Introduction to JSON / nuget packages

[JSON](https://www.w3schools.com/js/js_json_intro.asp) is a way of storing structured data, e.g. as lists, dictionaries or even potentially as objects, in text files. This is called "[serialisation](https://en.wikipedia.org/wiki/Serialization)". 

The *de facto* way of working with JSON in C# is using the JSON.net library, which is not written by Microsoft, but which is available using the nuget package manager. 

These examples can come from any text - a string, a local text file or, more exotically, a network connection to a remote API or (potentially RESTful) [webserver](https://github.com/jdorfman/Awesome-JSON-Datasets) (linked to, somewhat riskily, without fully checking the contents). 

## VS.Code

The C# project shown in the subdirectory `introduction-to-json` is VS.Code (loadable in Visual Studio but uses .NET core).   

### Using nuget 

As outlined on [Stack Overflow](https://stackoverflow.com/a/42218729/2902), open the terminal and type `dotnet add package Newtonsoft.Json`. 

Notice the new XML `ItemGroup` in the `csproj` file. 

## Visual Studio 

The C# solution shown in `IntroductionToJsonFull` is a Visual Studio .NET Framework solution.  

### Using nuget

As outlined on [MSDN](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio), right-click on the project > manage nuget > install `Newtonsoft.Json`. 

Notice the new file `packages.config`.