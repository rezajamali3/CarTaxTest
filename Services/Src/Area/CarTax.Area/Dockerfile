#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Src/Area/CarTax.Area/CarTax.Area.csproj", "Services/Src/Area/CarTax.Area/"]
COPY ["Services/Src/Area/CarTax.Area.Application/CarTax.Area.Application.csproj", "Services/Src/Area/CarTax.Area.Application/"]
COPY ["CarTax.Area.Domain/CarTax.Area.Domain.csproj", "CarTax.Area.Domain/"]
COPY ["Libraries/Libraries_Helper/Libraries_Helper.csproj", "Libraries/Libraries_Helper/"]
COPY ["Libraries/Library_API/Library_API.csproj", "Libraries/Library_API/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
COPY ["Services/Src/Area/CarTax.Area.Message/CarTax.Area.Message.csproj", "Services/Src/Area/CarTax.Area.Message/"]
COPY ["Libraries/Library_EF/Library_EF.csproj", "Libraries/Library_EF/"]
COPY ["Services/Src/Area/CarTax.Area.Infrastruchar/CarTax.Area.Infrastruchar.csproj", "Services/Src/Area/CarTax.Area.Infrastruchar/"]
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