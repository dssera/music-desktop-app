using DAO.Entities;
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
    public class UserDataRepository : IRepositoryCRUD<UserDataEntity>
    {
        // https://habr.com/ru/articles/263033/
        private string _connectionString;

        public UserDataRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool Delete(long id)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.users_data WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }

            return success;
        }

        public bool Add(UserDataEntity userData)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.users_data (user_id, email, full_name) " +
                    "VALUES (@UserId, @Email, @FullName)");
                command.Parameters.AddWithValue("UserId", userData.UserId);
                command.Parameters.AddWithValue("Email", userData.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("FullName", userData.FullName ?? (object)DBNull.Value);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }   
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }

            return success;
        }
        public UserDataEntity? GetById(long id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, user_id, email, full_name FROM public.users_data WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new UserDataEntity(reader.GetInt64(0),
                        reader.GetInt64(1),
                        reader.IsDBNull(2) ? null : reader.GetString(2),
                        reader.IsDBNull(3) ? null : reader.GetString(3)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }
            return null;
        }

        public List<UserDataEntity>? GetCollection(int limit = 15, int offset = 0)
        {
            List<UserDataEntity>? usersDataList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.users LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    usersDataList = new List<UserDataEntity>();
                    while (reader.Read())
                    {
                        usersDataList.Add(new UserDataEntity(reader.GetInt64(0),
                            reader.GetInt64(1),
                            reader.IsDBNull(2) ? null : reader.GetString(2),
                            reader.IsDBNull(3) ? null : reader.GetString(3))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return usersDataList;
        }
        public bool Update(UserDataEntity userData)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.users SET user_id = @UserId, email = @Email, full_name = @FullName WHERE id = @id");
                command.Parameters.AddWithValue("UserId", userData.UserId);
                command.Parameters.AddWithValue("Email", userData.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("FullName", userData.FullName ?? (object)DBNull.Value);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }

            return success;
        }
    }
}
