using DAO.Repositories;
using Data.Entities;

string connectionString = @"Host = localhost;
            Port = 5432;
            Database = music-service-coursework;
            User Id = postgres;
            Password = 12345;";
var albumRepository = new AlbumRepository(connectionString);
// albumRepository.Add(new AlbumEntity(-1, "yeee album", DateTime.Now, 0, 0));




