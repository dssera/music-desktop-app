using DAO.Entities;
using Data.Entities;
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
        public List<SongEntity>? GetSongsByPlaylist(long playlistId, int limit = 15, int offset = 0)
        {

            List<SongEntity>? songsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT s.id, s.album_id, s.created, s.plays, s.is_published, s.duration, s.title FROM songs_playlists AS sp " +
                    "JOIN songs AS s ON sp.song_id = s.id WHERE sp.playlist_id = @PlaylistId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("PlaylistId", playlistId);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    songsList = new List<SongEntity>();
                    while (reader.Read())
                    {
                        songsList.Add(new SongEntity(reader.GetInt32(0),
                                reader.IsDBNull(1) ? null : reader.GetInt32(1),
                                reader.GetDateTime(2),
                                reader.GetInt64(3),
                                reader.GetBoolean(4),
                                reader.GetTimeSpan(5),
                                reader.GetString(6))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return songsList;
        }
        public List<SongEntity>? GetSongsByPlaylist(long userId, string playlistTitle, int limit = 15, int offset = 0)
        {

            List<SongEntity>? songsList = null;
            try
            {
                // SELECT s.id, s.album_id, s.created, s.plays, s.is_published, s.duration, s.title FROM public.songs s JOIN public.songs_playlists sp ON sp.song_id = s.id JOIN public.playlists p ON p.id = sp.playlist_id WHERE p.title = 'default_playlist' AND p.user_id = 9 LIMIT @limit OFFSET @offset;
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT s.id, s.album_id, s.created, s.plays, s.is_published, s.duration, s.title FROM public.songs s " +
                    "JOIN public.songs_playlists sp ON sp.song_id = s.id " +
                    "JOIN public.playlists p ON p.id = sp.playlist_id " +
                    "WHERE p.title = @PlaylistTitle AND p.user_id = @UserId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("UserId", userId);
                command.Parameters.AddWithValue("PlaylistTitle", playlistTitle);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    songsList = new List<SongEntity>();
                    while (reader.Read())
                    {
                        songsList.Add(new SongEntity(reader.GetInt32(0),
                                reader.IsDBNull(1) ? null : reader.GetInt32(1),
                                reader.GetDateTime(2),
                                reader.GetInt64(3),
                                reader.GetBoolean(4),
                                reader.GetTimeSpan(5),
                                reader.GetString(6))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return songsList;
        }
        public List<PlaylistEntity>? GetPlaylistsBySong(long songId, int limit = 15, int offset = 0)
        {

            List<PlaylistEntity>? playlistsList = null;
            try
            {
                
                using var dataSource = NpgsqlDataSource.Create(_connectionString);

                using var command = dataSource.CreateCommand("SELECT p.id, p.title, p.user_id, p.created, p.plays, p.songs_count FROM songs_playlists AS sp " +
                    "JOIN playlists AS p ON sp.playlist_id = p.id WHERE sp.song_id = @SongId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("SongId", songId);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    playlistsList = new List<PlaylistEntity>();
                    while (reader.Read())
                    {
                        playlistsList.Add(new PlaylistEntity(reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetInt64(2),
                            reader.GetDateTime(3),
                            reader.GetInt64(4),
                            reader.GetInt32(5))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return playlistsList;
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
