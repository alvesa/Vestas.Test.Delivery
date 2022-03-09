# Vestas Test

## Startup
## Database setup
```
docker compose up
```
### Api setup
- In the Vestas.Test.Delivery folder execute the commands below
```
dotnet publish -c Release -o dist
cd dist
dotnet Vestas.Test.Delivery.dll
```

### Tools/Frameworks and runtimes
- .NET v 5.0.14
- Entity Framework.Core v 5.0.14 (Code First) with migrations
- Mysql v8+
- Jwt
- Docker