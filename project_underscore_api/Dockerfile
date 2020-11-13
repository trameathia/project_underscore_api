#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["project_underscore_api/project_underscore_api.csproj", "project_underscore_api/"]
RUN dotnet restore "project_underscore_api/project_underscore_api.csproj"
COPY . .
WORKDIR "/src/project_underscore_api"
RUN dotnet build "project_underscore_api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "project_underscore_api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "project_underscore_api.dll"]