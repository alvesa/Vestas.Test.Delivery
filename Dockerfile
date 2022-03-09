FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app 
#
COPY Vestas.Test.Delivery/*.csproj ./Vestas.Test.Delivery/
COPY Vestas.Test.Delivery.Application/*.csproj ./Vestas.Test.Delivery.Application/
COPY Vestas.Test.Delivery.Infra/*.csproj ./Vestas.Test.Delivery.Infra/
#
RUN dotnet restore ./Vestas.Test.Delivery/Vestas.Test.Delivery.csproj
#
COPY Vestas.Test.Delivery/. ./Vestas.Test.Delivery/
COPY Vestas.Test.Delivery.Application/. ./Vestas.Test.Delivery.Application/
COPY Vestas.Test.Delivery.Infra/. ./Vestas.Test.Delivery.Infra/ 
#
WORKDIR /app/Vestas.Test.Delivery
RUN dotnet publish -c Release -o dist 
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app 
#
COPY --from=build /app/Vestas.Test.Delivery/dist .
EXPOSE 5000
ENTRYPOINT ["dotnet", "Vestas.Test.Delivery.dll"]