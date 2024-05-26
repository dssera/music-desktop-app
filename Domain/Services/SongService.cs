using DAO.Repositories;
using Data.Entities;
using Data.Repositories.Abstract;

namespace Domain.Services
{
    public class SongService
    {
        private SongRepository _repository;

        public SongService(string connectionString) 
        {
            _repository = new SongRepository(connectionString);
        }

        public SongEntity? GetSongById(int id)
        {
            return _repository.Get(id);
        }
        public SongEntity? GetSongByTitle(string title)
        {
            return _repository.GetByTitle(title);
        }
        public List<SongEntity>? GetSongs(int limit=5, int offset=0)
        {
            return _repository.GetCollection(limit, offset);
        }
        public List<SongEntity>? GetSongs(string qTitle, int limit = 5, int offset = 0)
        {
            return _repository.GetCollection(qTitle, limit, offset);
        }


        //void CreateSong(SongEntity song)
        //{
        //    _songRepository.Create(song);
        //}


    }
}