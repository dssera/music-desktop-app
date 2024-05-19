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
    public class SongsGenresRepository
    {
        private string _connectionString;

        public SongsGenresRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SongEntity>? GetSongsByGenre(long genreId, int limit = 15, int offset = 0)
        {
            
            List<SongEntity>? songsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT s.id, s.album_id, s.created, s.plays, s.is_published, s.duration, s.title FROM songs_genres " +
                    "AS sg JOIN songs AS s ON sg.song_id = s.id WHERE sg.genre_id = @GenreId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("GenreId", genreId);
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
        public List<GenreEntity>? GetGenresBySong(long songId, int limit = 15, int offset = 0)
        {
            List<GenreEntity>? genresList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT g.id, g.name FROM songs_genres " +
                    "AS sg JOIN genres AS g ON sg.genre_id = g.id WHERE sg.song_id = @SongId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("SongId", songId);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    genresList = new List<GenreEntity>();
                    while (reader.Read())
                    {
                        genresList.Add(new GenreEntity(reader.GetInt32(0),
                                reader.GetString(1))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return genresList;
        }
        public bool AddGenreToSong(int genreId, long songId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.songs_genres (song_id, genre_id) " +
                    "VALUES (@SongId, @GenreId)");
                command.Parameters.AddWithValue("SongId", songId);
                command.Parameters.AddWithValue("GenreId", genreId);
                
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }
            return success;
        }
        public bool RemoveGenreFromSong(int genreId, long songId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.songs_genres WHERE song_id=@SongId AND genre_id=@GenreId");
                command.Parameters.AddWithValue("SongId", songId);
                command.Parameters.AddWithValue("GenreId", genreId);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }
            return success;
        }

    }
}
