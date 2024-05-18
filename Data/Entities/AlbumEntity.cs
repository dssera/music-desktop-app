using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class AlbumEntity : BaseEntity
    {
        public AlbumEntity(long id, string title, DateTime created, 
            long plays, int songsCount) 
        {
            Id= id;
            Title= title;
            Created= created;
            Plays= plays;
            SongsCount= songsCount;
        }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public long Plays { get; set; }
        public int SongsCount { get; set; }
    }
}
