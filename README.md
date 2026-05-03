# PySharp
![NuGet Version](https://img.shields.io/nuget/v/Py-Sharp) ![NuGet Downloads](https://img.shields.io/nuget/dt/Py-Sharp)
### **🐍 This library allows you to use [Python](https://python.org) methods such as print, input and more in [C#!](https://dotnet.microsoft.com/en-us/languages/csharp)**

## Installation
- type this command:
```
dotnet add package Py-Sharp
```
## Alternative
- Go to [Releases](https://github.com/nicky-suss/Py-sharp/releases) or [NuGet](https://www.nuget.org/packages/Py-Sharp) and install the latest .nupkg file.
- put the .nupkg in any folder in your project (e.g. /libs, it doesn't matter)
- type this command:
```
dotnet add package Py-Sharp -s ./
```

## How to use
- **type this to use PySharp methods:**
- ```csharp
  using PySharp;
  ```

## Example:

```csharp
color.fore.yellow();
int numtofind = Int(input("type first number: "));
print();
int num2tofind = Int(input("type second number: "));
color.reset();
print("Calculating...");
time.sleep(2);
int result = numtofind + num2tofind;
print("Result:", result);
```


## XML hints
- When pointing to a method from this library, you can see an XML hint.
- It explains what this method is for



![XML Hints](https://raw.githubusercontent.com/nicky-suss/Py-sharp/refs/heads/main/images/0418.gif)