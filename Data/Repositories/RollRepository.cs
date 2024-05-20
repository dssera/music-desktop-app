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
    public class RollRepository : IRepositoryCRUD<RollEntity>
    {
        // https://habr.com/ru/articles/263033/
        private string _connectionString;

        public RollRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool Delete(long id)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.rolls WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }
            return success;
        }

        public bool Add(RollEntity roll)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.rolls (name) " +
                    "VALUES (@Name)");
                command.Parameters.AddWithValue("Name", roll.Name);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }
            return success;
        }
        public RollEntity? GetById(long id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, name FROM public.rolls WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new RollEntity(reader.GetInt64(0),
                        reader.GetString(1)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }
            return null;
        }

        public List<RollEntity>? GetCollection(int limit = 15, int offset = 0)
        {
            List<RollEntity>? rollsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.rolls LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    rollsList = new List<RollEntity>();
                    while (reader.Read())
                    {
                        rollsList.Add(new RollEntity(reader.GetInt64(0),
                            reader.GetString(1))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }
            return rollsList;
        }
        public bool Update(RollEntity roll)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.users SET name = @Name WHERE id = @id");
                command.Parameters.AddWithValue("Name", roll.Name);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }
            return success;
        }
    }
}
