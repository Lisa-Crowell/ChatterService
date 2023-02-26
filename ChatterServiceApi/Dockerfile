FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ChatterServiceApi/ChatterServiceApi.csproj", "ChatterServiceApi/"]
RUN dotnet restore "ChatterServiceApi/ChatterServiceApi.csproj"
COPY . .
WORKDIR "/src/ChatterServiceApi"
RUN dotnet build "ChatterServiceApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChatterServiceApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChatterServiceApi.dll"]
