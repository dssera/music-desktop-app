using DAO.Repositories;

string connectionString = @"Host = localhost;
            Port = 5432;
            Database = music-service-coursework;
            User Id = postgres;
            Password = 12345;";
var songRepository = new SongRepository(connectionString);

var data = songRepository.GetCollection();
//foreach (var item in data)
//{
//    Console.WriteLine(item.Title);
//}
var item = songRepository.GetById(1);
Console.WriteLine(item?.Title);
if (data is not null)
{
    foreach (var song in data)
    {
        Console.WriteLine(song.Title);
    }
}

