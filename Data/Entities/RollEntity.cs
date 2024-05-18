using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class RollEntity : BaseEntity
    {
        public RollEntity(long id, string name) 
        {
            Id= id;
            Name = name;
        }
        public string Name { get; set; }
    }
}
