using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme 
{
    // queremos dizer que o id será uma chave para uma tabela no banco de dados 
    // precisamos dizer para o dotnet fazer um mapeamento para jogar isso no banco de dados
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
}