using DAO.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public class ArtistsAlbumsRepository
    {
        private string _connectionString;

        public ArtistsAlbumsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AddArtistToAlbum(long artistId, long albumId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.artists_albums (artist_id, album_id) " +
                    "VALUES (@ArtistId, AlbumId)");
                command.Parameters.AddWithValue("ArtistId", artistId);
                command.Parameters.AddWithValue("AlbumId", albumId);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }
            return success;
        }
        public bool RemoveArtistFromAlbum(long artistId, long albumId)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.artists_albums WHERE artist_id=@ArtistId AND album_id=@AlbumId");
                command.Parameters.AddWithValue("ArtistId", artistId);
                command.Parameters.AddWithValue("AlbumId", albumId);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }
            return success;
        }

    }
}
