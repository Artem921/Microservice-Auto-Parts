#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/Microservice.Products/Products.API/Products.API.csproj", "Services/Microservice.Products/Products.API/"]
COPY ["Infrastructure/MassTransit.Contract/MassTransit.Contract.csproj", "Infrastructure/MassTransit.Contract/"]
COPY ["Services/Microservice.Products/Products.Application/Products.Application.csproj", "Services/Microservice.Products/Products.Application/"]
COPY ["Services/Microservice.Products/Products.Domain/Products.Domain.csproj", "Services/Microservice.Products/Products.Domain/"]
COPY ["Services/Microservice.Products/Products.Infrastructure/Products.Infrastructure.csproj", "Services/Microservice.Products/Products.Infrastructure/"]
RUN dotnet restore "./Services/Microservice.Products/Products.API/./Products.API.csproj"
COPY . .
WORKDIR "/src/Services/Microservice.Products/Products.API"
RUN dotnet build "./Products.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Products.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Products.API.dll"]