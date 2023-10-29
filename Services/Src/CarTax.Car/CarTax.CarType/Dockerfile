#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Src/CarTax.Car/CarTax.CarType/CarTax.CarType.csproj", "Services/Src/CarTax.Car/CarTax.CarType/"]
COPY ["Libraries/Library_EF/Library_EF.csproj", "Libraries/Library_EF/"]
COPY ["Services/Src/CarTax.Car/CarTax.CarType.Application/CarTax.CarType.Application.csproj", "Services/Src/CarTax.Car/CarTax.CarType.Application/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
COPY ["Services/Src/CarTax.Car/CarTax.CarType.Infrastruchar/CarTax.CarType.Infrastruchar.csproj", "Services/Src/CarTax.Car/CarTax.CarType.Infrastruchar/"]
COPY ["Services/Src/CarTax.Car/CarTax.CarType.Domain/CarTax.CarType.Domain.csproj", "Services/Src/CarTax.Car/CarTax.CarType.Domain/"]
COPY ["Libraries/Libraries_Helper/Libraries_Helper.csproj", "Libraries/Libraries_Helper/"]
COPY ["Services/Src/CarTax.Car/CarTax.CarType.Message/CarTax.CarType.Message.csproj", "Services/Src/CarTax.Car/CarTax.CarType.Message/"]
RUN dotnet restore "Services/Src/CarTax.Car/CarTax.CarType/CarTax.CarType.csproj"
COPY . .
WORKDIR "/src/Services/Src/CarTax.Car/CarTax.CarType"
RUN dotnet build "CarTax.CarType.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarTax.CarType.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarTax.CarType.dll"]