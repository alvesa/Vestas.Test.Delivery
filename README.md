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
### Testing the aaplication
- Once both containers running there is in the **Misc** folder a json file with the **insominia** collections to perform the tests
### Tools/Frameworks and runtimes
- .NET Core v 5.0.14
- Entity Framework.Core v 5.0.14 (Code First) with migrations
- Mysql v8+
- Jwt
- Docker

## TODO
- Remove the workaround to run the application (issue caused by docker compose)
- Register an issue to fix the connection between the db and application in the compose
- Encrypt password
- Include Tests
