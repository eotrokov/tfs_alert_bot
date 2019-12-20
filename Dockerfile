FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY TfsAlertBot.sln .
COPY . .
RUN dotnet restore -s "https://api.nuget.org/v3/index.json"


RUN dotnet publish TfsAlertBot.sln -c Release -o /app/

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "WebApi.dll"]