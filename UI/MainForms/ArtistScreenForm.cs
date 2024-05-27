using Data.Entities;
using Domain;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ArtistScreenForm : Form
    {
        Service _service;
        User _user;
        public ArtistScreenForm(User user)
        {
            InitializeComponent();

            _service = new Service(@"Host = localhost;
                    Port = 5432;
                    Database = music-service-coursework;
                    User Id = postgres;
                    Password = 12345;");
            _user = user;
        }

        private void ArtistForm_Load(object sender, EventArgs e)
        {

            // my songs tab
            //var userSongs = _service.GetSongsByArtist(_user.Id);
            //if (userSongs != null)
            //{
            //    foreach (SongEntity song in userSongs)
            //    {
            //        string artists = GetArtistsString(song);
            //        dataGridViewMySongs.Rows.Add(song.Title, artists, song.Duration, song.Plays);
            //    }
            //}
            // all songs tab
            //var allSongs = _service.GetSongs(100);
            //if (allSongs != null)
            //{
            //    foreach (var song in allSongs)
            //    {
            //        string artists = GetArtistsString(song);
            //        dataGridViewAllSongs.Rows.Add(song.Title, artists, song.Duration);
            //    }
            //}
            //// my albums tab
            //var userAlbums  = _service.GetAlbumsByArtist(_user.Id);
            //if (userAlbums != null)
            //{
            //    foreach (var album in userAlbums)
            //    {
            //        string artists = GetArtistsString(album);
            //        dataGridViewMyAlbums.Rows.Add(album.Title, artists, album.Plays, album.SongsCount);
            //    }
            //}
            //// all albums tab
            //var allAlbums = _service.GetAllAlbums();
            //if (userAlbums != null)
            //{
            //    foreach (var album in userAlbums)
            //    {
            //        string artists = GetArtistsString(album);
            //        dataGridViewAllAlbums.Rows.Add(album.Title, artists, album.Plays, album.SongsCount);
            //    }
            //}
            // account tab
        }
        private string GetArtistsString(SongEntity song)
        {
            var artists = new List<string>();
            var artistEntitites = _service.GetArtistsBySong(song.Id);
            if (artistEntitites == null)
                return "";
            foreach (var artistEntity in artistEntitites)
            {
                artists.Add(artistEntity.Login);
            }
            return string.Join(", ", artists);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAllSongs_Click(object sender, EventArgs e)
        {

        }
    }
}
