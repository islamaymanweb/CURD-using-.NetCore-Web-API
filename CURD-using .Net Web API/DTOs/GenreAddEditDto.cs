using System.ComponentModel.DataAnnotations;

namespace CURD_using_.Net_Web_API.DTOs
{
    public class GenreAddEditDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
