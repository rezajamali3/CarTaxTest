#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Src/Tax/TaxCar.Tax/TaxCar.Tax.csproj", "Services/Src/Tax/TaxCar.Tax/"]
COPY ["Libraries/Library_API/Library_API.csproj", "Libraries/Library_API/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
COPY ["Libraries/Library_Dapper/Library_Dapper.csproj", "Libraries/Library_Dapper/"]
COPY ["Services/Src/Tax/TaxCar.Tax.Application/TaxCar.Tax.Application.csproj", "Services/Src/Tax/TaxCar.Tax.Application/"]
COPY ["Services/Src/Tax/CarTax.Tax.Domain/CarTax.Tax.Domain.csproj", "Services/Src/Tax/CarTax.Tax.Domain/"]
COPY ["Services/Src/Tax/TaxCar.Tax.Infrastruchar/TaxCar.Tax.Infrastruchar.csproj", "Services/Src/Tax/TaxCar.Tax.Infrastruchar/"]
COPY ["Libraries/Library_EF/Library_EF.csproj", "Libraries/Library_EF/"]
COPY ["Services/Src/Tax/TaxCar.Tax.Message/TaxCar.Tax.Message.csproj", "Services/Src/Tax/TaxCar.Tax.Message/"]
RUN dotnet restore "Services/Src/Tax/TaxCar.Tax/TaxCar.Tax.csproj"
COPY . .
WORKDIR "/src/Services/Src/Tax/TaxCar.Tax"
RUN dotnet build "TaxCar.Tax.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaxCar.Tax.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaxCar.Tax.dll"]