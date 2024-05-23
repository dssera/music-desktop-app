using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class Service
    {
        private UserService userService;
        private UserDataService userDataService;
        private RollService rollService;

        public Service(string connectionString)
        {
            userService = new UserService(connectionString);
            userDataService = new UserDataService(connectionString);
            rollService = new RollService(connectionString);

        }

        public UserEntity? Register(string login, string password, string? fullName, string? email, int rollId)
        { 
            if (userService.IsLoginExist(login)) return null;
            userService.Create(login, password, rollId);
            var user = userService.GetByLogin(login);
            if (user != null) userDataService.Create(fullName, email);
            return user;
        }

        public UserEntity? Login(string login, string password)
        {
            if (userService.isUserExist(login, password))
            {
                return userService.GetByLogin(login);
            }
            return null;
        }

        public User? GetFullUserByLogin(string login) 
        {
            var userEntity = userService.GetByLogin(login);
            var userData = userDataService.GetById(userEntity.Id);

            if (userEntity != null && userData != null)
            {
                var user = new User(userEntity.Id, userEntity.Login, userEntity.Password, 
                    userEntity.RollId, userData.FullName, userData.Email);
                return user;
            }
            return null;
        }
    }
}
