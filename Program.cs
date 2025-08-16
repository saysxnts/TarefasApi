// Program.cs

var builder = WebApplication.CreateBuilder(args);

// --- Adiciona serviços ao container de injeção de dependência ---

builder.Services.AddControllers();

// As duas linhas abaixo são essenciais para o Swagger funcionar
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- Configura o pipeline de requisições HTTP ---

// Este bloco garante que o Swagger UI só será usado em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comentamos a linha de redirecionamento HTTPS para simplificar nosso ambiente local
// e evitar o aviso que vimos antes.
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();