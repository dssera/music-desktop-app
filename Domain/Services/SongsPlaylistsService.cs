using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SongsPlaylistsService
    {
        private SongsPlaylistsRepository _repository;

        public SongsPlaylistsService(string connectionString)
        {
            _repository = new SongsPlaylistsRepository(connectionString);
        }

        public List<SongEntity>? GetSongsByPlaylist(long userId, string playlistTitle)
        {
            return _repository.GetSongsByPlaylist(userId, playlistTitle);
        }
    }
}
