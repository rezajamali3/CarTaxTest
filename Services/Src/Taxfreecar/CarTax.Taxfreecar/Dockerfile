#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Src/Taxfreecar/CarTax.Taxfreecar/CarTax.Taxfreecar.csproj", "Services/Src/Taxfreecar/CarTax.Taxfreecar/"]
COPY ["Libraries/Library_API/Library_API.csproj", "Libraries/Library_API/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
COPY ["Services/Src/Taxfreecar/CarTax.Taxfreecar.Aplication/CarTax.Taxfreecar.Aplication.csproj", "Services/Src/Taxfreecar/CarTax.Taxfreecar.Aplication/"]
COPY ["Services/Src/Taxfreecar/CarTax.Taxfreecar.Domain/CarTax.Taxfreecar.Domain.csproj", "Services/Src/Taxfreecar/CarTax.Taxfreecar.Domain/"]
COPY ["Services/Src/Taxfreecar/CarTax.Taxfreecar.Infrastruchar/CarTax.Taxfreecar.Infrastruchar.csproj", "Services/Src/Taxfreecar/CarTax.Taxfreecar.Infrastruchar/"]
COPY ["Libraries/Library_EF/Library_EF.csproj", "Libraries/Library_EF/"]
COPY ["Services/Src/Taxfreecar/CarTax.Taxfreecar.Message/CarTax.Taxfreecar.Message.csproj", "Services/Src/Taxfreecar/CarTax.Taxfreecar.Message/"]
RUN dotnet restore "Services/Src/Taxfreecar/CarTax.Taxfreecar/CarTax.Taxfreecar.csproj"
COPY . .
WORKDIR "/src/Services/Src/Taxfreecar/CarTax.Taxfreecar"
RUN dotnet build "CarTax.Taxfreecar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarTax.Taxfreecar.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarTax.Taxfreecar.dll"]