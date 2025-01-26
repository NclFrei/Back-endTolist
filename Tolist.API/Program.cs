using System.Text.Json.Serialization;
using Tolist.API.Endpoints;
using Tolist.Banco;
using Tolist.Modelos;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TolistContext>();
builder.Services.AddTransient<DAL<Tarefa>>();
builder.Services.AddTransient<DAL<Ambiente>>();

builder.Services.AddEndpointsApiExplorer();


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.AddEndPointsTarefas();

app.Run();
