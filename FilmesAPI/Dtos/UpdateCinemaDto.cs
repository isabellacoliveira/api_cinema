using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
    }
}