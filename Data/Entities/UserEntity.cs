using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class UserEntity : BaseEntity
    {
        public UserEntity(long id, string login, string password, int rollId) 
        {
            Id= id;
            Login= login;   
            Password= password;
            RollId= rollId;
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public int RollId { get; set; }
    }
}
