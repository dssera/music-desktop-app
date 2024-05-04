using Data.Entities;
using Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAO.Repositories
{
    public class SongRepository : IRepositoryCRUD<SongEntity>
    {
        private static List<SongEntity>? _songs { get; } = new List<SongEntity>();
        private string _connectionString;

        public SongRepository(string connectionString) 
        {
            _connectionString = connectionString;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(SongEntity item)
        {
            throw new NotImplementedException();
        }

        public SongEntity Get(int id)
        {
            var song = new SongEntity();

            using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            connection.Open(); // Open the connection 

            using NpgsqlCommand cmd = new NpgsqlCommand("SELECT title FROM songs WHERE id = @id", connection);
            cmd.Parameters.AddWithValue("id", id); // Use parameterized query to avoid SQL injection

            using NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0)); // Assuming 'title' is a string column, use GetString method
                                                        // Use the fetched results
                song.Title = reader.GetString(0);
            }
            
            
            return song;
        }

            public List<SongEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(SongEntity old, SongEntity @new)
        {
            throw new NotImplementedException();
        }
    }
}
