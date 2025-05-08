
namespace BIBLIOTECA.App;

public static class GET_ROUTE{
    public static void MapGetRoutes(this WebApplication app){

        List<LIVRO> livros = new List<LIVRO>(){
            new LIVRO( 1, "Coco", "Lincoln", 2012),
            new LIVRO(2, "TCHUKABANGA", "Arthur", 2013)
        };

        //ROTA GET RAIZ/INDEX
        app.MapGet("/", () => "API de Livros em Funcionamento!");
        //ROTA GET LISTAR LIVROS
        app.MapGet("/api/listalivros", () => livros);
        //ROTA GET BUSCA LIVRP P/ID
        app.MapGet("/api/listalivros/{id}", (int id) => {
            var livro = livros.FirstOrDefault( l => l.id == id);
            return livro != null ? Results.Ok(livro) : Results.NotFound("Livro não encontrado");
        });


    }
}