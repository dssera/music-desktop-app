using DAO.Entities;
using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserDataService
    {
        private UserDataRepository _repository;
        public UserDataService(string connectionString)
        { 
            _repository= new UserDataRepository(connectionString);
        }

        public bool Create(string? fullName, string? email)
        {
            return _repository.Add(new UserDataEntity(-1, -1, fullName, email));
        }
        public UserDataEntity? GetById(long id)
        {
            return _repository.GetById(id);
        }
    }
}
