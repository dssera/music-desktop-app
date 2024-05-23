using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public User(long id, string login, string password, long rollId,
            string? fullName, string? email)
        {
            Id= id;
            Login= login;
            Password= password;
            RollId= rollId;
            FullName= fullName;
            Email= email;
        }
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long RollId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
    }
}
