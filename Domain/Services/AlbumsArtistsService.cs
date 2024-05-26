using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AlbumsArtistsService
    {
        ArtistsAlbumsRepository _repository;

        public AlbumsArtistsService(string connectionString)
        {
            _repository = new ArtistsAlbumsRepository(connectionString);
        }
        public List<AlbumEntity>? GetAlbumsByArtist(long userId)
        {
            return _repository.GetAlbumsByArtist(userId);
        }
        public List<UserEntity>? GetArtistsByAlbum(long albumId)
        {
            return _repository.GetArtistsByAlbum(albumId);
        }
    }
}
