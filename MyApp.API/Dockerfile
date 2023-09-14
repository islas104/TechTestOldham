FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MyApp.API.csproj", "./"]
RUN dotnet restore "./MyApp.API.csproj"
COPY . .
RUN dotnet build "MyApp.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyApp.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyApp.API.dll"]
