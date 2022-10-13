FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestGeometryLibraryApp/TestGeometryLibraryApp.csproj", "TestGeometryLibraryApp/"]
RUN dotnet restore "TestGeometryLibraryApp/TestGeometryLibraryApp.csproj"
COPY . .
WORKDIR "/src/TestGeometryLibraryApp"
RUN dotnet build "TestGeometryLibraryApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestGeometryLibraryApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestGeometryLibraryApp.dll"]
