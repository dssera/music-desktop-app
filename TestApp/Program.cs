using DAO.Repositories;
using Data.Entities;

string connectionString = @"Host = localhost;
            Port = 5432;
            Database = music-service-coursework;
            User Id = postgres;
            Password = 12345;";
var songRepository = new SongRepository(connectionString);
var genreRepository = new GenreRepository(connectionString);
var songGenreRepo = new SongsGenresRepository(connectionString);
var userRepo = new UserRepository(connectionString);
var rollRepo = new RollRepository(connectionString);




