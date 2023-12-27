using Microsoft.EntityFrameworkCore;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);


string connection = builder.Configuration.GetConnectionString("WebApiDatabase");
builder.Services.AddDbContext<ItsmWorkContext>(options => options.UseNpgsql(connection));

builder.Services.AddScoped<KnowledgeRepo>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDeveloperExceptionPage();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
