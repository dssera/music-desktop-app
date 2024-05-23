using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserService
    {
        private UserRepository _repository;
        public UserService(string connectionString) 
        { 
            _repository= new UserRepository(connectionString);
        }
        public bool IsLoginExist(string login)
        {
           return _repository.GetByLogin(login) != null ? true : false;
        }
        public bool Create(string login, string password, int rollId)
        {
            return _repository.Add(new UserEntity(-1, login, password, rollId));
        }
        public UserEntity? GetByLogin(string login) 
        {
            return _repository.GetByLogin(login);
        }
        public bool isUserExist(string login, string password)
        {
            var user = _repository.GetByLogin(login);
            if (user != null)
            {
                return user.Password== password;
            }
            return false;
        }


    }
}
