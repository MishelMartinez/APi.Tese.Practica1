#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api.Tese.Api/Api.Tese.Api.csproj", "Api.Tese.Api/"]
RUN dotnet restore "Api.Tese.Api/Api.Tese.Api.csproj"
COPY . .
WORKDIR "/src/Api.Tese.Api"
RUN dotnet build "Api.Tese.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Tese.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Tese.Api.dll"]