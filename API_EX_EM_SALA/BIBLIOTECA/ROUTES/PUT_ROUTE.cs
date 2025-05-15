using BIBLIOTECA.App;

namespace BIBLIOTECA.ROUTES;
public static class Rota_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        app.MapPut("/livros/{id}", async (int id, LIVRO input, LivrosContext context) =>
        {
            var livro = await context.Livros.FindAsync(id);
            if (livro is null) return Results.NotFound();

            livro.titulo = input.titulo;
            livro.autor = input.autor;
            livro.ano = input.ano;

            await context.SaveChangesAsync();
            return Results.Ok(livro);
        });
    }
}