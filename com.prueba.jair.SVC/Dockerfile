#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["com.prueba.jair.SVC/com.prueba.jair.SVC.csproj", "com.prueba.jair.SVC/"]
RUN dotnet restore "com.prueba.jair.SVC/com.prueba.jair.SVC.csproj"
COPY . .
WORKDIR "/src/com.prueba.jair.SVC"
RUN dotnet build "com.prueba.jair.SVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "com.prueba.jair.SVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "com.prueba.jair.SVC.dll"]