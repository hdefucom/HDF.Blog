#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["HDF.Blog.WebApi/HDF.Blog.WebApi.csproj", "HDF.Blog.WebApi/"]
COPY ["HDF.Blog.Model/HDF.Blog.Model.csproj", "HDF.Blog.Model/"]
RUN dotnet restore "HDF.Blog.WebApi/HDF.Blog.WebApi.csproj"
COPY . .
WORKDIR "/src/HDF.Blog.WebApi"
RUN dotnet build "HDF.Blog.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HDF.Blog.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HDF.Blog.WebApi.dll"]