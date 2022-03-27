dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 11.0.0
dotnet add package Microsoft.EntityFrameworkCore --version 3.1.22
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.22
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.22
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.22
dotnet add package Microsoft.Extensions.Configuration --version 3.1.22
dotnet add package Microsoft.Extensions.Configuration.Abstractions --version 3.1.22
dotnet add package Microsoft.Extensions.Configuration.Binder --version 3.1.22
dotnet add package Microsoft.Extensions.Configuration.FileExtensions --version 3.1.22
dotnet add package Microsoft.Extensions.Configuration.Json --version 3.1.22
dotnet add package Newtonsoft.Json --version 13.0.1
dotnet add package System.Configuration.ConfigurationManager --version 5.0.0
dotnet ef dbcontext scaffold "Data Source=172.31.2.43,1434;User ID=WCTerceros;Password=Agora2021**;Initial Catalog=SGCAC;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False" Microsoft.EntityFrameworkCore.SqlServer -o DAL/SGCAC -c "DBSGCACContext"  --force
rem optionsBuilder.UseSqlServer(UtilitarioTransversal.ObtenerValorPropiedad("AppConfigs:connectionString"));