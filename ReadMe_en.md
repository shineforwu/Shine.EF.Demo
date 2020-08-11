# ReadMe
This solution is a demo about net core's EF framework.
## EF.DB.Mysql project
### Need to reference the library
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools
MySql.Data.EntityFrameworkCore
## DemoConsole
### Need to reference the library
Microsoft.EntityFrameworkCore.Tools

## Creat DataBase
### Creat __efmigrationshistory
```mysql
CREATE TABLE `__EFMigrationsHistory` 
( 
	`MigrationId` nvarchar(150) NOT NULL, 
	`ProductVersion` nvarchar(32) NOT NULL, 
	 PRIMARY KEY (`MigrationId`) 
);
```
### powershell
```powershell
Add-Migration
Update-DataBase
```
