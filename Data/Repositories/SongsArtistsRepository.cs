using DAO.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public class SongsArtistsRepository
    {
        private string _connectionString;

        public SongsArtistsRepository(string connectionString)
        {
            _connectionString = connectionString;
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
