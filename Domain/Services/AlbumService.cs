using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AlbumService
    {
        AlbumRepository _repository;

        public AlbumService(string connectionString)
        {
            _repository= new AlbumRepository(connectionString);
        }
        public List<AlbumEntity>? GetAlbums(int limit=15, int offset=0)
        {
            return _repository.GetCollection();
        }
        public AlbumEntity? GetAlbumByTitle(string title)
        {
            return _repository.Get(title);
        }
        
        
        
    }
}
