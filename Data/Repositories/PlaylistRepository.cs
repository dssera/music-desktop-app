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
    public class PlaylistRepository : IRepositoryCRUD<PlaylistEntity>
    {
        private string _connectionString;

        public PlaylistRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool Delete(long id)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("DELETE FROM public.playlists WHERE id=@id");
                command.Parameters.AddWithValue("id", id);
                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Delete:" + ex.Message); }

            return success;
        }

        public bool Add(PlaylistEntity playlist)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("INSERT INTO public.playlists (title, user_id, created, plays, songs_count) " +
                    "VALUES (@Title, @UserId, @Created, @Plays, @SongsCount)");
                command.Parameters.AddWithValue("Title", playlist.Title);
                command.Parameters.AddWithValue("UserId", playlist.UserId);
                command.Parameters.AddWithValue("Created", playlist.Created);
                command.Parameters.AddWithValue("Plays", playlist.Plays);
                command.Parameters.AddWithValue("SongsCount", playlist.SongsCount);

                int rowsAffected = command.ExecuteNonQuery();

                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Add:" + ex.Message); }

            return success;
        }
        public PlaylistEntity? GetById(long id)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, title, user_id, created, plays, songs_count FROM public.playlists WHERE id = @id");
                command.Parameters.AddWithValue("id", id);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new PlaylistEntity(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetInt64(2),
                        reader.GetDateTime(3),
                        reader.GetInt64(4),
                        reader.GetInt32(5)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetById:" + ex.Message); }

            return null;
        }
        public PlaylistEntity? Get(long id, string title)
        {
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, title, user_id, created, plays, songs_count FROM public.playlists WHERE user_id = @Id AND title = @Title");
                command.Parameters.AddWithValue("Id", id);
                command.Parameters.AddWithValue("Title", title);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return new PlaylistEntity(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetInt64(2),
                        reader.GetDateTime(3),
                        reader.GetInt64(4),
                        reader.GetInt32(5)
                        );
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Get:" + ex.Message); }

            return null;
        }
        public List<PlaylistEntity>? GetPlaylistsByUser(long userId)
        {
            List<PlaylistEntity>? playlistsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT id, title, user_id, created, plays, songs_count FROM public.playlists WHERE user_id = @UserId");
                command.Parameters.AddWithValue("UserId", userId);
                using var reader = command.ExecuteReader();

                playlistsList = new List<PlaylistEntity>();
                while (reader.Read())
                {
                    playlistsList.Add(new PlaylistEntity(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetInt64(2),
                        reader.GetDateTime(3),
                        reader.GetInt64(4),
                        reader.GetInt32(5)
                        ));
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Get:" + ex.Message); }

            return playlistsList;
        }

        public List<PlaylistEntity>? GetCollection(int limit = 15, int offset = 0)
        {
            List<PlaylistEntity>? playlistsList = null;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("SELECT * FROM public.songs LIMIT @limit OFFSET @offset");
                command.Parameters.AddWithValue("limit", limit);
                command.Parameters.AddWithValue("offset", offset);
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    playlistsList = new List<PlaylistEntity>();
                    while (reader.Read())
                    {
                        playlistsList.Add(new PlaylistEntity(reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetInt64(2),
                            reader.GetDateTime(3),
                            reader.GetInt64(4),
                            reader.GetInt32(5))
                            );
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.GetCollection:" + ex.Message); }

            return playlistsList;
        }
        public bool Update(PlaylistEntity playlist)
        {
            bool success = false;
            try
            {
                using var dataSource = NpgsqlDataSource.Create(_connectionString);
                using var command = dataSource.CreateCommand("UPDATE public.playlists SET title = @Title, user_id = @UserId, created = @Created, plays = @Plays, songs_count = @SongsCount WHERE id = @id");
                command.Parameters.AddWithValue("Title", playlist.Title);
                command.Parameters.AddWithValue("UserId", playlist.UserId);
                command.Parameters.AddWithValue("Created", playlist.Created);
                command.Parameters.AddWithValue("Plays", playlist.Plays);
                command.Parameters.AddWithValue("SongsCount", playlist.SongsCount);

                int rowsAffected = command.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            catch (Exception ex) { Console.WriteLine($"Exception in {GetType()}.Update:" + ex.Message); }

            return success;
        }
    }
}
