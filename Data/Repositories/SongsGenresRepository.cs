using DAO.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public class SongsGenresRepository
    {
        private string _connectionString;

        public SongsGenresRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AddGenreToSong(int genreId, long songId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.songs_genres (song_id, genre_id) " +
                    "VALUES (@SongId, GenreId)");
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
