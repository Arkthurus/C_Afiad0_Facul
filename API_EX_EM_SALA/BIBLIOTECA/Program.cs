using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.App;
using BIBLIOTECA.ROUTES;

var builder = WebApplication.CreateBuilder(args);

// Configura o banco SQLite
builder.Services.AddDbContext<LivrosContext>(options =>
    options.UseSqlite("Data Source=livros.db"));

// Configura o CORS para permitir qualquer origem
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();
app.UseCors("AllowAll");

// Mapeia as rotas REST
app.MapGetRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.MapDeleteRoutes();

// Popular o banco com dados iniciais, se estiver vazio
PopularBancoDeDados(app);

// Inicia a aplicação
app.Run();

void PopularBancoDeDados(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<LivrosContext>();

    context.Database.Migrate();

    if (!context.Livros.Any())
    {
        var livros = new List<LIVRO>();

        livros.Add(new LIVRO(1, "nome 1", "Autor 1", 2020));
        // Continue com até 20 referências reais se desejar 

        context.Livros.AddRange(livros);
        context.SaveChanges();
    }
}
