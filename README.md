## csharplearn

We can install dotnet under debian and compile c sharp.


## unit test
- Create solution
    ```dotnet new sln```

- Create library
    ```dotnet new classlib -o medianArray```
    Code file:

- Add to solution
    ```dotnet sln add medianArray/medianArray.csproj```

- Build library
    ```dotnet build```

- create test
    ```dotnet new mstest -o MyTest```

- Add to solution
    ```dotnet sln add MyTest/MyTest.csproj```

- Link test to library
    ```dotnet add MyTest/MyTest.csproj reference medianArray/medianArray.csproj```

- Run test
    ```dotnet test MyTest/MyTest.csproj```