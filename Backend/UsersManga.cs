using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Backend
{
    public class UsersManga
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int MangaId { get; set; }

        public int Volume { get; set; }
        
        public int Chapter { get; set; }
    }
}
