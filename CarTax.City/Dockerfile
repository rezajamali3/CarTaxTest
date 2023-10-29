#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CarTax.City/CarTax.City.csproj", "CarTax.City/"]
COPY ["Libraries/Library_API/Library_API.csproj", "Libraries/Library_API/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
COPY ["Libraries/Library_EF/Library_EF.csproj", "Libraries/Library_EF/"]
COPY ["Services/Src/City/CarTax.City.Application/CarTax.City.Application.csproj", "Services/Src/City/CarTax.City.Application/"]
COPY ["Services/Src/City/CarTax.City.Domain/CarTax.City.Domain.csproj", "Services/Src/City/CarTax.City.Domain/"]
COPY ["Libraries/Libraries_Helper/Libraries_Helper.csproj", "Libraries/Libraries_Helper/"]
COPY ["Services/Src/City/CarTax.City.Message/CarTax.City.Message.csproj", "Services/Src/City/CarTax.City.Message/"]
COPY ["Services/Src/City/CarTax.City.Infrastruchar/CarTax.City.Infrastruchar.csproj", "Services/Src/City/CarTax.City.Infrastruchar/"]
RUN dotnet restore "CarTax.City/CarTax.City.csproj"
COPY . .
WORKDIR "/src/CarTax.City"
RUN dotnet build "CarTax.City.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarTax.City.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarTax.City.dll"]