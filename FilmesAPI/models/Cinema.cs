using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models; 

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
    public int EnderecoId { get; set; }
    // aqui estamos dizendo ao entity que o cinema possui um e apenas um endereço 
    // do tipo endereço
    public virtual Endereco Endereco { get; set; }
}