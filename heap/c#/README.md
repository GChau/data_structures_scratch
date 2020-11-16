C# implementation of a Heap data structure.
Execute unit tests in a Docker container (during the build phase).

Steps
1. Create new HeapLib solution\
    `dotnet new sln -o HeapLib`
1. Create Heap library.\
    `dotnet new classlib -o Heap`
1. Add Heap library to HeapLib solution.\
    `dotnet sln add Heap/Heap.csproj`.
1. Create HeapTest MSUnit.\
    `dotnet new mstest -o HeapTest`
1. Add HeapTest MSUnit to HeapLib solution.\
    `dotnet sln add HeapTest/HeapTest.csproj`.
1. Build Heap.\
    `cd ./Heap`.
1. Add project reference.\
    `dotnet add HeapTest/HeapTest.csproj reference Heap/Heap.csproj`
1. Build and test.\
    `cd ../`\
    `dotnet build`

Source:

* https://en.wikipedia.org/wiki/Heap_(data_structure)
* https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new
* https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code
* https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code