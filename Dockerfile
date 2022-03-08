FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS BUILD
RUN dotnet public -c Release ./Vestas.Test.Delivery -o ./dist
WORKDIR /app
COPY ./dist ./app
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS RUNTIME
ENTRYPOINT ["dotnet", "Vestas.Test.Delivery"]