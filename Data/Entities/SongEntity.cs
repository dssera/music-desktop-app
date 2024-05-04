using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class SongEntity : BaseEntity
    {
        public SongEntity() { Title = "WrongTitle"; }
        public string Title { get; set; }
        int album_id;
        DateTime created;
        int plays;
        bool published;
        TimeOnly duration;
    }
}
