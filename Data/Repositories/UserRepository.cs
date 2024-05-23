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
    public class UserRepository : IRepositoryCRUD<UserEntity>
    {
        // https://habr.com/ru/articles/263033/
        private string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool Delete(long id)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.users WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }

            return success;
        }

        public bool Add(UserEntity user)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.users (login, password, roll_id) " +
                    "VALUES (@Login, @Password, @RollId)");
                command.Parameters.AddWithValue("Login", user.Login);
                command.Parameters.AddWithValue("Password", user.Password);
                command.Parameters.AddWithValue("RollId", user.RollId);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }

            return success;
        }
        public UserEntity? GetById(long id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, login, password, roll_id FROM public.users WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new UserEntity(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }
            return null;
        }

        public List<UserEntity>? GetCollection(int limit = 15, int offset = 0)
        {
            List<UserEntity>? usersList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.users LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
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
        public bool Update(UserEntity user)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.users SET login = @login, password = @password, rollId = @rollId WHERE id = @id");
                command.Parameters.AddWithValue("login", user.Login);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("rollId", user.RollId);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }

            return success;
        }
        public UserEntity? GetByLogin(string login)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, login, password, roll_id FROM public.users WHERE login = @Login");
                command.Parameters.AddWithValue("Login", login);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new UserEntity(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetByLogin:" + ex.Message); }
            return null;
        }
    }
}
