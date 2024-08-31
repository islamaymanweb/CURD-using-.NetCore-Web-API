using System.ComponentModel.DataAnnotations;

namespace CURD_using_.Net_Web_API.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
          public string Name { get; set; }
    }
}
