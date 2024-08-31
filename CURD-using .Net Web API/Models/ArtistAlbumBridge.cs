namespace CURD_using_.Net_Web_API.Models
{
    public class ArtistAlbumBridge
    {
        public int AlbumId { get; set; }
        public Album Album { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
