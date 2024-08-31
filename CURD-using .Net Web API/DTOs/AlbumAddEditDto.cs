using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CURD_using_.Net_Web_API.DTOs
{
    public class AlbumAddEditDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public List<int> ArtistIds { get; set; }
    }
}
