FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MercadoLibre.WebApi/MercadoLibre.WebApi.csproj", "MercadoLibre.WebApi/"]
RUN dotnet restore "MercadoLibre.WebApi/MercadoLibre.WebApi.csproj"
COPY . .
WORKDIR "/src/MercadoLibre.WebApi"
RUN dotnet build "MercadoLibre.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MercadoLibre.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MercadoLibre.WebApi.dll"]