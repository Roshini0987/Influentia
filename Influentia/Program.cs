using Influentia.BLL;
using Influentia.DAL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDefectsService, DefectsService>();

var constr = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<DefaultContext>(opt =>
{
    opt.UseSqlServer(constr);
    opt.EnableSensitiveDataLogging();
    opt.EnableServiceProviderCaching();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
