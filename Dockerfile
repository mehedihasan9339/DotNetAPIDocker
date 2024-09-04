# Use the official .NET 8.0 SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["DotNetAPIDocker.csproj", "./"]
RUN dotnet restore "DotNetAPIDocker.csproj"

# Copy the remaining files and build the project
COPY . .
RUN dotnet build "DotNetAPIDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNetAPIDocker.csproj" -c Release -o /app/publish

# Use the official .NET 8.0 ASP.NET image for the runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Expose HTTP port
EXPOSE 80

ENTRYPOINT ["dotnet", "DotNetAPIDocker.dll"]
