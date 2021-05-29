## Csharp Learn

We can install dotnet under debian and compile c sharp.

## File Explanation

This repository try to solve online problem [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/).

- `README.rd` this file. Explain this repository
- `UnitTest1.cs` The unit test code. For test-driven programming, it is start point. For this problem, this code file includes examples from [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/)
- `Class1.cs` includes real solution.
- `Program.cs` Console Application, which can call Library (functions methods in `Class1.cs`)

## Library
- Create solution
    ```dotnet new sln```

- Create library
    ```dotnet new classlib -o medianArray```
    Code file:

- Add to solution
    ```dotnet sln add medianArray/medianArray.csproj```

- Build library
    ```dotnet build```

## Unit Test
- create test
    ```dotnet new mstest -o MyTest```
    or
    ```dotnet new xunit -o MyTest```
    What are difference of `mstest` and `xunit`?
  - MSTest has been around since Visual Studio 2015, at least. When it first came out, didn’t have a way to pass parameters into your unit tests. For this reason, a lot of people opted to use NUnit instead. Since V2 MSTest also supports parameters, so the difference between the frameworks on a day-to-day basis has lessened a lot. 
  - xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework. Written by the original inventor of NUnit v2, xUnit.net is the latest technology for unit testing C#, F#, VB.NET and other .NET languages. xUnit.net works with ReSharper, CodeRush, TestDriven.NET and Xamarin.

- Add to solution
    ```dotnet sln add MyTest/MyTest.csproj```

- Link test to library
    ```dotnet add MyTest/MyTest.csproj reference medianArray/medianArray.csproj```

- Run test
    ```dotnet test MyTest/MyTest.csproj```

## Console Application
- Create console application
    ```dotnet new console -o ConsoleApp```

- Add to solution
    ```dotnet sln add ConsoleApp/ConsoleApp.csproj```

- Add dependency to console application
    ```dotnet add ConsoleApp/ConsoleApp.csproj reference medianArray/medianArray.csproj```

- run console application
    ```dotnet run -p ConsoleApp/ConsoleApp.csproj```