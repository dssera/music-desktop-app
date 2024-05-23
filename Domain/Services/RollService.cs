using DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class RollService
    {
        private RollRepository _repository;
        public RollService(string connectionString)
        {
            _repository= new RollRepository(connectionString);
        }
    }
}
