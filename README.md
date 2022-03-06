# Vestas Test

## Database
### Migrations
```
dotnet ef migrations add initialMigration --startup-project ../Vestas.Test.Delivery
dotnet ef database update
```
```
docker pull mysql:8
```