# Vestas Test

## Database
## Config Env
```
docker compose up
```
### Migrations
```
dotnet ef migrations add initialMigration --startup-project ../Vestas.Test.Delivery
dotnet ef database update --startup-project ../Vestas.Test.Delivery
```