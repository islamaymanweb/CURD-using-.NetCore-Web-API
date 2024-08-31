using System.Collections.Generic;

namespace CURD_using_.Net_Web_API.DTOs
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public List<ArtistDto> Artists { get; set; }
        public List<string> TrackNames { get; set; }
    }
}
