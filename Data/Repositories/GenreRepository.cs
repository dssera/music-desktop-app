using Data.Entities;
using Data.Repositories.Abstract;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public class GenreRepository : IRepositoryCRUD<GenreEntity>
    {
        // https://habr.com/ru/articles/263033/
        private string _connectionString;

        public GenreRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool Delete(long id)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.genres WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }
            return success;
        }

        public bool Add(GenreEntity genre)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.genres (name) " +
                    "VALUES (@Name)");
                command.Parameters.AddWithValue("Name", genre.Name);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }
            return success;
        }
        public GenreEntity? Get(long id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, name FROM public.genres WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new GenreEntity(reader.GetInt64(0),
                        reader.GetString(1)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }
            return null;
        }

        public List<GenreEntity>? GetCollection(int limit = 15, int offset = 0)
        {
            List<GenreEntity>? genresList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.genres LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    genresList = new List<GenreEntity>();
                    while (reader.Read())
                    {
                        genresList.Add(new GenreEntity(reader.GetInt64(0),
                            reader.GetString(1))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }
            return genresList;
        }
        public bool Update(GenreEntity genre)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.genres SET name = @Name WHERE id = @id");
                command.Parameters.AddWithValue("Name", genre.Name);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }
            return success;
        }
    }
}
