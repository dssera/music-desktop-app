using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class SongEntity : BaseEntity
    {
        public SongEntity(long id, long? album_id, DateTime created, 
            long plays, bool is_published, TimeSpan duration, string title) 
        {
            Id= id;
            Title= title;
            AlbumId= album_id;
            Created= created;
            Plays= plays;
            IsPublished= is_published;
            Duration= duration;
        }
        public string Title { get; set; }
        public long? AlbumId { get; set; }
        public DateTime Created { get; set; }
        public long Plays { get; set; }
        public bool IsPublished { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
