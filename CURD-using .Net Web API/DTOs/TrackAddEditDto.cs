using System.ComponentModel.DataAnnotations;

namespace CURD_using_.Net_Web_API.DTOs
{
    public class TrackAddEditDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int AlbumId { get; set; }
    }
}
