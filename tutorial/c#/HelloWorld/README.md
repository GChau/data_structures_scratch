Playing around with C# and Hello World in a Docker container.
I did Japanese text for fun.

# Steps

## Create and compile project

1. Execute the following commands in a terminal.
2. Generate a new console.\
    `dotnet new console`
2. `dotnet run`.
3. `dotnet publish -c Release`.

## Build as Docker Image

1. `docker build --rm . -t helloworld:latest`.

## Run as Docker Container

1. `docker run -it --rm helloworld:latest`.

Source:

* https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
* https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows