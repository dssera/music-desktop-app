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
        private SongService songService;
        private SongsArtistsService songsArtistsService;
        private PlaylistService playlistService;
        private SongsPlaylistsService songsPlaylistsService;


        public Service(string connectionString)
        {
            userService = new UserService(connectionString);
            userDataService = new UserDataService(connectionString);
            rollService = new RollService(connectionString);
            songService = new SongService(connectionString);
            songsArtistsService = new SongsArtistsService(connectionString);
            playlistService = new PlaylistService(connectionString);
            songsPlaylistsService = new SongsPlaylistsService(connectionString);

        }

        public UserEntity? Register(string login, string password, string? fullName, string? email, int rollId)
        { 
            if (userService.IsLoginExist(login)) return null;
            userService.Create(login, password, rollId);

            var user = userService.GetByLogin(login);
            if (user != null)
            {
                userDataService.Add(user.Id, fullName, email);
                playlistService.Add(new PlaylistEntity(-1, "default_playlist", user.Id, DateTime.Now, 0, 0)); 
            }
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
        public List<SongEntity>? GetSongs(int limit=5, int offset=0)
        {
            return songService.GetSongs(limit, offset);
        }
        public List<SongEntity>? GetSongs(string qTitle, int limit = 5, int offset = 0)
        {
            return songService.GetSongs(qTitle, limit, offset);
        }
        public SongEntity? GetSongByTitle(string title)
        {
            return songService.GetSongByTitle(title);
        }
        public List<UserEntity>? GetArtistsBySong(long id)
        {
            return songsArtistsService.GetArtistsBySong(id);
        }

        public List<SongEntity>? GetSongsByPlaylist(long userId, string playlistTitle)
        {
            var playlist = playlistService.GetPlaylist(userId, playlistTitle);
            songsPlaylistsService.GetSongsByPlaylist(playlist.Id);
            return songsPlaylistsService.GetSongsByPlaylist(playlist.Id);
        }
        public bool AddSongToPlaylist(long songId, long playlistId)
        {
            return songsPlaylistsService.AddSongToPlaylist(songId, playlistId);
        }
        public bool DeleteSongFromPlaylist(long songId, long palylistId)
        {
            return songsPlaylistsService.DeleteSongFromPlaylist(songId, palylistId);
        }
        public PlaylistEntity? GetPlaylistByTitle(long userId, string title)
        {
            return playlistService.GetPlaylist(userId, title);
        }
        public List<PlaylistEntity>? GetPlaylistsByUser(long userId)
        {
            return playlistService.GetPlaylistsByUser(userId);
        }
        public bool AddPlaylist(PlaylistEntity playlist)
        {
            return playlistService.Add(playlist);
        }
    }
}
