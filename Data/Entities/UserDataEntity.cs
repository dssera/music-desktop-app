using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Entities
{
    public class UserDataEntity : BaseEntity
    {
        public UserDataEntity(long id, long userId, string? email, string? full_name)
        {
            Id = id;
            UserId = userId;
            Email = email;
            FullName = full_name;
        }

        public long UserId { get; set; }
        public string? Email { get; set; }
        public string? FullName { get; set; }
    }
}
