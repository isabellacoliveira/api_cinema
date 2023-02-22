using System.ComponentModel.DataAnnotations;
using FilmesApi.Models;

namespace FilmesAPI.Models;

public class Filme 
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O título do filme é obrigatório!")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório!"), 
    MaxLength(50, ErrorMessage = "O tamanho não pode exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatório!"),
    Range(70, 600, ErrorMessage = "A duração deve estar entre 70 e 600 minutos")]
    public int Duracao { get; set; }
    // criamos uma icollection para indicar que pode ter uma sessão ou muitas 
    // ou seja, pode haver uma coleção de dados 
    public virtual ICollection<Sessao> Sessoes { get; set; }
}