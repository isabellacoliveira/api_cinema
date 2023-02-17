using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data; 

public class FilmeContext : DbContext
{
    // ele vai receber como parâmetro uma configuração de acesso ao banco 
    // vamos fazer a passagem dessa opçoes para o método construtor que estamos 
    // vamos fazer isso através do base 
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
    {
        
    }

    // precisamos criar a propriedades de acesso 
    // db set : conjuntos de dados do nosso banco 
    // vai conter os filmes 
    public DbSet<Filme> Filmes { get; set; }

    // precisamos autenticar a aplicação ao banco 
}