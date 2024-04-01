using FIAP_PrimeiraApi.Api.Implementations;
using FIAP_PrimeiraApi.Api.Interfaces;
using FIAP_PrimeiraApi.Api.Logging;
using FIAP_PrimeiraApi.Api.Repository;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//Fazendo as injeções de dependêcia
builder.Services.AddScoped<IBancoDados, BancoDados>();
//builder.Services.AddKeyedScoped<IBancoDados, BancoDados>("Forma2");
//builder.Services.AddKeyedScoped<IAlunoCadastro, AlunoCadastro>("AlunoKeyed");
builder.Services.AddScoped<IAlunoCadastro, AlunoCadastro>(); 


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Logging.ClearProviders();
builder.Logging.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration
{
    LogLevel = LogLevel.Information
}));    

builder.Services.AddSingleton<IAlunoCadastro, AlunoRepository>();

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
