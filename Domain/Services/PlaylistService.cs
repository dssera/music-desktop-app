using DAO.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PlaylistService
    {
        private PlaylistRepository _repository;
        
        public PlaylistService(string connectionString)
        {
            _repository= new PlaylistRepository(connectionString);
        }

        public bool Add(PlaylistEntity playlist)
        {
            return _repository.Add(playlist);
        }
        public PlaylistEntity? GetPlaylist(long userId, string playlistTitle)
        {
            return _repository.Get(userId, playlistTitle);
        }
        public List<PlaylistEntity>? GetPlaylistsByUser(long userId)
        {
            return _repository.GetPlaylistsByUser(userId);
        }
    }
}
