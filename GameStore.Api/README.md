# Game Store API

## Starting SQL Server
```powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -v sqlvolumn:/var/opt/mysql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
```