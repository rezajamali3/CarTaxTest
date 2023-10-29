#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Api.Aggregator/Api.Aggregator.csproj", "Api.Aggregator/"]
COPY ["Libraries/Library_API/Library_API.csproj", "Libraries/Library_API/"]
COPY ["Libraries/Library_Domain/Library_Domain.csproj", "Libraries/Library_Domain/"]
RUN dotnet restore "Api.Aggregator/Api.Aggregator.csproj"
COPY . .
WORKDIR "/src/Api.Aggregator"
RUN dotnet build "Api.Aggregator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Aggregator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Aggregator.dll"]