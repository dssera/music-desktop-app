using DAO.Repositories;
using Data.Entities;
using Data.Repositories.Abstract;

namespace Domain.Services
{
    public class SongService
    {
        private IRepositoryCRUD<SongEntity> _songRepository;

        public SongService(IRepositoryCRUD<SongEntity> _songRepository) 
        {
            this._songRepository = _songRepository;
        }

        public SongEntity GetSongById(int id)
        {
            return _songRepository.Get(id);
        }


        //void CreateSong(SongEntity song)
        //{
        //    _songRepository.Create(song);
        //}


    }
}