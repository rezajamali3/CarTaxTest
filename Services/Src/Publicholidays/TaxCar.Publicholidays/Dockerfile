#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Src/Publicholidays/TaxCar.Publicholidays/TaxCar.Publicholidays.csproj", "Services/Src/Publicholidays/TaxCar.Publicholidays/"]
COPY ["Libraries/Library_API/Library_API.csproj", "Libraries/Library_API/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
COPY ["Services/Src/Publicholidays/TaxCar.Publicholidays.Applaication/TaxCar.Publicholidays.Application.csproj", "Services/Src/Publicholidays/TaxCar.Publicholidays.Applaication/"]
COPY ["Services/Src/Publicholidays/TaxCar.Publicholidays.Infrastruchar/TaxCar.Publicholidays.Infrastruchar.csproj", "Services/Src/Publicholidays/TaxCar.Publicholidays.Infrastruchar/"]
COPY ["Libraries/Library_EF/Library_EF.csproj", "Libraries/Library_EF/"]
COPY ["Services/Src/Publicholidays/TaxCar.Publicholidays.Domain/TaxCar.Publicholidays.Domain.csproj", "Services/Src/Publicholidays/TaxCar.Publicholidays.Domain/"]
COPY ["Services/Src/Publicholidays/TaxCar.Publicholidays.Message/TaxCar.Publicholidays.Message.csproj", "Services/Src/Publicholidays/TaxCar.Publicholidays.Message/"]
RUN dotnet restore "Services/Src/Publicholidays/TaxCar.Publicholidays/TaxCar.Publicholidays.csproj"
COPY . .
WORKDIR "/src/Services/Src/Publicholidays/TaxCar.Publicholidays"
RUN dotnet build "TaxCar.Publicholidays.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaxCar.Publicholidays.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaxCar.Publicholidays.dll"]