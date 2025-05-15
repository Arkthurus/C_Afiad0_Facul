using BIBLIOTECA.App;

namespace BIBLIOTECA.ROUTES;
public static class POST_ROUTE
{
    public static void MapPostRoutes(this WebApplication app)
    {
        app.MapPost("/livros", async (LIVRO livro, LivrosContext context) =>
        {
            context.Livros.Add(livro);
            await context.SaveChangesAsync();
            return Results.Created($"/livros/{livro.id}", livro);
        });
    }
}