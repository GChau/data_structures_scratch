FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

COPY HelloWorld.csproj ./HelloWorldApp/
COPY Program.cs ./HelloWorldApp/
WORKDIR /app/HelloWorldApp
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/HelloWorldApp/out ./
ENTRYPOINT ["dotnet", "HelloWorld.dll"]