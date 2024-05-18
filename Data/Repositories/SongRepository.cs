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
    public class SongRepository : IRepositoryCRUD<SongEntity>
    {
        private string _connectionString;
        public SongRepository(string connectionString) 
        {
            _connectionString = connectionString;
        }
        public bool Delete(int id)
        {
            // USED ONLY ON TRANSACTIONS
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.songs WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }

            return success;
        }

        public bool Add(SongEntity song)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.songs (album_id, created, plays, is_published, duration, title) " +
                    "VALUES (@AlbumId, @Created, @Plays, @IsPublished, @Duration, @Title)");
                command.Parameters.AddWithValue("AlbumId", song.AlbumId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("Created", song.Created);
                command.Parameters.AddWithValue("Plays", song.Plays);
                command.Parameters.AddWithValue("IsPublished", song.IsPublished);
                command.Parameters.AddWithValue("Duration", song.Duration);
                command.Parameters.AddWithValue("Title", song.Title);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }

            return success;
        }
        public SongEntity? GetById(int id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, album_id, created, plays, is_published, duration, title FROM public.songs WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();
            
                while (reader.Read())
                {
                    return new SongEntity(reader.GetInt32(0),
                        reader.IsDBNull(1) ? null : reader.GetInt32(1),
                        reader.GetDateTime(2),
                        reader.GetInt64(3),
                        reader.GetBoolean(4),
                        reader.GetTimeSpan(5),
                        reader.GetString(6)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }

            return null;
        }

        public List<SongEntity>? GetCollection(int limit=15, int offset=0)
        {
            List<SongEntity>? songsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.songs LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
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
        public bool Update(SongEntity song)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.songs SET album_id = @albumId, created = @created, plays = @plays, is_published = @isPublished, duration = @duration, title = @title WHERE id = @id");
                command.Parameters.AddWithValue("AlbumId", song.AlbumId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("created", song.Created);
                command.Parameters.AddWithValue("plays", song.Plays);
                command.Parameters.AddWithValue("isPublished", song.IsPublished);
                command.Parameters.AddWithValue("duration", song.Duration);
                command.Parameters.AddWithValue("title", song.Title);
                command.Parameters.AddWithValue("id", song.Id);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }

            return success;
        }
    }
}
