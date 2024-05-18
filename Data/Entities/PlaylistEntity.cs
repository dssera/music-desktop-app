using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PlaylistEntity : BaseEntity
    {
        public PlaylistEntity(long id, string title, long userId,
            DateTime created, long plays, int songsCount) 
        { 
            Id = id;
            Title = title;
            UserId = userId;
            Created = created;
            Plays = plays;
            SongsCount = songsCount;
        }
        public string Title { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public long Plays { get; set; } = 0;
        public int SongsCount { get; set; }

    }
}
