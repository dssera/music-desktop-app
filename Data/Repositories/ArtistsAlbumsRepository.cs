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
    public class ArtistsAlbumsRepository
    {
        private string _connectionString;

        public ArtistsAlbumsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<UserEntity>? GetArtistsByAlbum(long albumId, int limit = 15, int offset = 0)
        {
            List<UserEntity>? usersList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT u.id, u.login, u.password, u.roll_id FROM artists_albums " +
                    "AS aa JOIN users AS u ON aa.artist_id = u.id WHERE aa.album_id = @AlbumId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("AlbumId", albumId);
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
        public List<AlbumEntity>? GetAlbumsByArtist(long artistId, int limit = 15, int offset = 0)
        {
            List<AlbumEntity>? albumsList = null;
            try
            {
                
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT a.id, a.title, a.created, a.plays, a.songs_count FROM artists_albums AS aa " +
                    "JOIN albums AS a ON aa.album_id = a.id WHERE aa.artist_id = @ArtistId LIMIT @limit OFFSET @offset;");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                command.Parameters.AddWithValue("ArtistId", artistId);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    albumsList = new List<AlbumEntity>();
                    while (reader.Read())
                    {
                        albumsList.Add(new AlbumEntity(reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetDateTime(3),
                            reader.GetInt64(4),
                            reader.GetInt32(5))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return albumsList;
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
