# PySharp


## Installation
- Go to [Releases](https://github.com/nicky-suss/Py-sharp/releases) and install the latest .nupkg file.
### VS Code
- put the .nupkg in any folder in your project (e.g. /libs, it doesn't matter)
- type this command:
```
dotnet add package Py-Sharp -s ./
```

## How to use
- **type this to use PySharp methods:**
- ```csharp
  using static PySharp.Base;
  using math = PySharp.math;
  ```

## Example:

```csharp
print("Hello! Let's calculate:");
int x = Int(input("Enter x: "));
print("Square root is: " + math.sqrt(x));
```


## XML hints
- When pointing to a method from this library, you can see an XML hint.
- It explains what this method is for
<img width="426" height="240" alt="0418" src="https://github.com/user-attachments/assets/ddc741b9-8f38-4a10-b6e4-f2753670eedd" />
