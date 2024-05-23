using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SongsArtistsService
    {
        private SongsArtistsRepository _repository;

        public SongsArtistsService(string connectionString)
        {
            _repository = new SongsArtistsRepository(connectionString);
        }

        public List<UserEntity>? GetArtistsBySong(long id)
        {
            return _repository.GetArtistsBySong(id);
        }
    }
}
