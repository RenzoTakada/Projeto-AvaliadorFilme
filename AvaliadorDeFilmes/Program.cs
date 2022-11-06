using AvaliadorDeFilmes.Adapter.SQLAdapter.Extension;
using AvaliadorDeFilmes.Application.Routes;
using AvaliadorDeFilmes.Extensions;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDomainExtensions();
builder.Services.AddSQLAdapter();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.AddEndpoints();

app.Run();
