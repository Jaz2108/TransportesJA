# Usa la imagen base oficial de .NET para aplicaciones ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
COPY . .
ENTRYPOINT ["dotnet", "TransportesJA.dll"]
