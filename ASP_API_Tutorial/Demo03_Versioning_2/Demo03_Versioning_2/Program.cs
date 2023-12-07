using Demo03_Versioning_2;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// ***** Config swagger to use versioning
builder.Services.AddApiVersioning(option =>
    {
        option.AssumeDefaultVersionWhenUnspecified = true;
        option.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
        option.ReportApiVersions = true;
    });

builder.Services.AddVersionedApiExplorer(option =>
    {
        option.GroupNameFormat = "'v'VVV";
        option.SubstituteApiVersionInUrl = true;
    }); 
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
// End config 1

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// ***** Config swagger to use versioning 2
var apiVersionDescription = 
    app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach(var description in apiVersionDescription.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"{description.GroupName}/swagger.json",
                description.GroupName);
        }
    });// End config 2
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
