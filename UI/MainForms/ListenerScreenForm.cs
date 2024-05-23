using Data.Entities;
using Domain;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ListenerScreenForm : Form
    {
        private Service _service;
        private User _user;

        public ListenerScreenForm(User user)
        {
            _service = new Service(@"Host = localhost;
                    Port = 5432;
                    Database = music-service-coursework;
                    User Id = postgres;
                    Password = 12345;");
            _user = user;
            InitializeComponent();
        }

        private void ListenerScreenForm_Load(object sender, EventArgs e)
        {

            // separate methods
            List<SongEntity>? songs = _service.GetSongsByPlaylist(_user.Id, "default_playlist");
            if (songs == null)
                return;
            foreach (SongEntity song in songs)
            {
                string artists = GetArtistsString(song);
                dataGridViewUserSongs.Rows.Add(song.Title, artists, song.Duration);
            }

            // separate
            var songs_ = _service.GetSongs(100);
            if (songs_ == null)
                return;
            foreach (var song in songs_)
            {
                string artists = GetArtistsString(song);
                dataGridViewAllSongs.Rows.Add(song.Title, artists, song.Duration);
            }
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



        private void buttonPlay1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUserSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // event for click

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewUserSongs.Rows.Clear();
            string q = textBoxSearchYourSongs.Text;
            List<SongEntity>? songs = null;
            if (q == null || q == "")
                songs = _service.GetSongsByPlaylist(_user.Id, "default_playlist");
            else
                songs = _service.GetSongs(q);
            if (songs == null) 
                return;
            foreach (var song in songs)
            {
                string artists = GetArtistsString(song);
                dataGridViewUserSongs.Rows.Add(song.Title, artists, song.Duration);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //var songs = _service.GetSongs(100);
            //if (songs == null)
            //    return;
            //foreach (var song in songs)
            //{
            //    string artists = GetArtistsString(song);
            //    dataGridViewAllSongs.Rows.Add(song.Title, artists, song.Duration);
            //}
        }

        private void dataGridViewAllSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchAllSongs_Click(object sender, EventArgs e)
        {
            dataGridViewAllSongs.Rows.Clear();
            string q = textBoxSearchAllSongs.Text;
            List<SongEntity>? songs = null;
            if (q == null || q == "")
                songs = _service.GetSongs(100);
            else
                songs = _service.GetSongs(q);
            if (songs == null)
                return;
            foreach (var song in songs)
            {
                string artists = GetArtistsString(song);
                dataGridViewAllSongs.Rows.Add(song.Title, artists, song.Duration);
            }
        }
    }
}
