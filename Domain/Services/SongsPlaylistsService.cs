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

        //public List<SongEntity>? GetSongsByPlaylist(long userId, string playlistTitle)
        //{
        //    return _repository.GetSongsByPlaylist(userId, playlistTitle);
        //}
        public List<SongEntity>? GetSongsByPlaylist(long playlistId)
        {
            return _repository.GetSongsByPlaylist(playlistId);
        }

        public bool AddSongToPlaylist(long songId, long playlistId)
        {
            return _repository.AddSongToPlaylist(songId, playlistId);
        }
    }
}
