using DAO.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public class SongsPlaylistsRepository
    {
        private string _connectionString;

        public SongsPlaylistsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AddSongToPlaylist(long songId, long playlistId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.songs_playlists (song_id, playlist_id) " +
                    "VALUES (@SongId, PlaylistId)");
                command.Parameters.AddWithValue("SongId", songId);
                command.Parameters.AddWithValue("PlaylistId", playlistId);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }
            return success;
        }
        public bool DeleteSongFromPlaylist(long songId, long playlistId) 
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.songs_playlists WHERE song_id=@SongId AND playlist_id=@PlaylistId");
                command.Parameters.AddWithValue("SongId", songId);
                command.Parameters.AddWithValue("PlaylistId", playlistId);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }
            return success;
        }
        
    }
}
