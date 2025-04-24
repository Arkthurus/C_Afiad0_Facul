var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/", () => "MAIN");

app.MapGet("/sobre", () => "O Backend é a parte de um sistema de software que trabalha 'nos bastidores' para fazer tudo funcionar.");

app.MapGet("/localizacao", () => "Voce ta em Curitiba PR");

app.MapGet("/ctt", () => "40028922");

app.MapGet("/nossosProdutos&Servicos", () => "ABACATE, TECLADO GAYMER, TOALHA MOLHADA, HAMSTER");

app.MapGet("/agr", () => $"Data e Hora Atual: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

app.MapGet("/hoje", () => $"Dia da Semana: {DateTime.Now.ToString("dddd")}");

app.MapGet("/ano", () => $"ANO Atual: {DateTime.Now.ToString("yyyy")}");

app.Run();