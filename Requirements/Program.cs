using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;
using Requirements.Data;
using Requirements.Data.Migrations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<RequirementContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Requirements")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentMigratorCore()
    .ConfigureRunner(rb => rb
    .AddSqlServer()
    .WithGlobalConnectionString(builder.Configuration.GetConnectionString("Requirements"))
    .ScanIn(typeof(Migrations).Assembly).For.Migrations());

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{
}
