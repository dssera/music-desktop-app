using DAO.Entities;
using Data.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO.Repositories
{
    public class SongsArtistsRepository
    {
        private string _connectionString;

        public SongsArtistsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<SongEntity>? GetSongsByArtist(long artistId, int limit = 15, int offset = 0)
        {

            List<SongEntity>? songsList = null;
            try
            {
                
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT s.id, s.album_id, s.created, s.plays, s.is_published, s.duration, s.title FROM songs_artists AS sa " +
                    "JOIN songs AS s ON sa.song_id = s.id WHERE sa.artist_id = @ArtistId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("ArtistId", artistId);
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
        public List<UserEntity>? GetArtistsBySong(long songId, int limit = 15, int offset = 0)
        {
            
            List<UserEntity>? usersList = null;
            try
            {

                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT u.id, u.login, u.password, u.roll_id FROM songs_artists AS sa " +
                    "JOIN users AS u ON sa.artist_id = u.id WHERE sa.song_id = @SongId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("SongId", songId);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    usersList = new List<UserEntity>();
                    while (reader.Read())
                    {
                        usersList.Add(new UserEntity(reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return usersList;
        }
        public bool AddSongToArtist(long songId, long artistId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.artists_songs (song_id, artist_id) " +
                    "VALUES (@SongId, ArtistId)");
                command.Parameters.AddWithValue("SongId", songId);
                command.Parameters.AddWithValue("ArtistId", artistId);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }
            return success;
        }
        public bool DeleteSongFromArtist(long songId, long artistId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.artists_songs WHERE song_id=@SongId AND artist_id=@ArtistId");
                command.Parameters.AddWithValue("SongId", songId);
                command.Parameters.AddWithValue("ArtistId", artistId);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }
            return success;
        }

    }
}
