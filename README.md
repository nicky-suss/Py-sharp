# PySharp


## Installation
- type this command:
```
dotnet add package Py-Sharp
```
## Alternative
- Go to [Releases](https://github.com/nicky-suss/Py-sharp/releases) and install the latest .nupkg file.
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



![XML Hints](https://github.com/user-attachments/assets/ddc741b9-8f38-4a10-b6e4-f2753670eedd)