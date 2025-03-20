using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//FUNCIONALIDADES 

//REQUEST - URL e Metodo HTTP

//METODOS HTTP
//GET - Pegar alguma informação
//POST - Enviar alguma informação


app.MapGet("/", () => "Eae Vagabundo");

app.MapGet("/Douglas", () => "Eae Vagabundo 2");

app.MapGet("/parametros/{param1}", ([FromRoute]string param1) => 
{
    string result = param1 + " " + DateTime.Now;
    return result;

});

app.Run();


