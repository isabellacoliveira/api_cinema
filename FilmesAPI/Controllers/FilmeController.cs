using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc; // rotas 

namespace FilmesAPI.Controllers;
// precisamos fazer 
[ApiController]
// pois quero que a requisição seja enviada para esse controlador 
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    [HttpPost] // toda vez que fazermos isso, vamos enviar um filme 
    // ele deve estar pronto para cadastrar um novo filme no sistema 
    // ele entra através do corpo de uma requisição
    public void AdicionaFilme([FromBody] Filme filme)
    {
        // queremos adicionar filme, precisamos de informações 
        // precisamos criar o objeto de filme e nossa classe que vai representa-la 
        filmes.Add(filme); 
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
        Console.WriteLine(filme.Genero);
    }
}
