using Data.Entities;
using Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace DAO.Repositories
{
    public class AlbumRepository : IRepositoryCRUD<AlbumEntity>
    {
        private string _connectionString;

        public AlbumRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool Delete(long id)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.albums WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }

            return success;
        }

        public bool Add(AlbumEntity album)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.albums (title, created, plays, songs_count) " +
                    "VALUES (@Title, @Created, @Plays, @SongsCount)");
                command.Parameters.AddWithValue("Title", album.Title);
                command.Parameters.AddWithValue("Created", album.Created);
                command.Parameters.AddWithValue("Plays", album.Plays);
                command.Parameters.AddWithValue("SongsCount", album.SongsCount);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }

            return success;
        }
        public AlbumEntity? GetById(long id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, title, created, plays, songs_count FROM public.albums WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new AlbumEntity(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetDateTime(3),
                        reader.GetInt64(4),
                        reader.GetInt32(5)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }

            return null;
        }

        public List<AlbumEntity>? GetCollection(int limit = 15, int offset = 0)
        {
            List<AlbumEntity>? albumsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.albums LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
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
        public bool Update(AlbumEntity album)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.albums SET title = @Title, created = @Created, plays = @Plays, songs_count = @SongsCount WHERE id = @id");
                command.Parameters.AddWithValue("Title", album.Title);
                command.Parameters.AddWithValue("Created", album.Created);
                command.Parameters.AddWithValue("Plays", album.Plays);
                command.Parameters.AddWithValue("SongsCount", album.SongsCount);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }

            return success;
        }
    }
}
