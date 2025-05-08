namespace BIBLIOTECA.App;

public class LIVRO{
    public    int     id { get; set; }
    public string titulo { get; set; }
    public string  autor { get; set; }
    public    int    ano { get; set; }

    public LIVRO(int id, string titulo, string autor, int ano){
        
        this.id     =     id;
        this.titulo = titulo;
        this.autor  =  autor;
        this.ano    =    ano;
    }

}