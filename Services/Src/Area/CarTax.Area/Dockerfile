#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Src/Area/CarTax.Area/CarTax.Area.csproj", "Services/Src/Area/CarTax.Area/"]
RUN dotnet restore "Services/Src/Area/CarTax.Area/CarTax.Area.csproj"
COPY . .
WORKDIR "/src/Services/Src/Area/CarTax.Area"
RUN dotnet build "CarTax.Area.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarTax.Area.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarTax.Area.dll"]