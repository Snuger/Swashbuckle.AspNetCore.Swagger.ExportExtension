# Swashbuckle.AspNetCore.Swagger.ExportExtension

An exported API document to the MakeDown document

# Getting started

Swashbuckle.AspNetCore.Swagger.ExportExtension is installed from NuGet

```shell
Install-Package  Swashbuckle.AspNetCore
Install-Package Swashbuckle.AspNetCore.Swagger.ExportExtension
```

Enable export function,

```csharp
using Swashbuckle.AspNetCore.Swagger.ExportExtension.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerApiDocumentExportSupport();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMiddleware<SwaggerApiDocmentExportMiddleware>();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

```

# Effect

## ui

![ui](https://raw.githubusercontent.com/Snuger/Swashbuckle.AspNetCore.Swagger.ExportExtension/main/ui.png)

## MarkDown file

![MarkDown](https://raw.githubusercontent.com/Snuger/Swashbuckle.AspNetCore.Swagger.ExportExtension/main/file.png)
