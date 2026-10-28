FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY src/SmartHome.Api/SmartHome.Api.csproj src/SmartHome.Api/
RUN dotnet restore src/SmartHome.Api/SmartHome.Api.csproj
COPY src/SmartHome.Api/ src/SmartHome.Api/
WORKDIR /src/src/SmartHome.Api
RUN dotnet publish -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "SmartHome.Api.dll"]
