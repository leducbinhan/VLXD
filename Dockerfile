FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

RUN find . -name "*.csproj"

RUN dotnet restore ./VLXDManager/VLXDManager.csproj
RUN dotnet publish ./VLXDManager/VLXDManager.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "VLXDManager.dll"]