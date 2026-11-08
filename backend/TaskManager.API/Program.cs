var builder = WebApplication.CreateBuilder(args);
// Registrando controllers
builder.Services.AddControllers();

// Configurando OpenAPI
builder.Services.AddOpenApi();
var app = builder.Build();

// Disponibiliza OpenAPI no desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Habilita as rotas dos Controllers

app.MapControllers();

app.Run();