FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Usamos el nombre exacto de tu explorador de archivos
COPY ["ArroyoSecoGastronomia.csproj", "./"]
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
# IMPORTANTE: El .dll debe coincidir con el nombre del proyecto
ENTRYPOINT ["dotnet", "ArroyoSecoGastronomia.dll"]