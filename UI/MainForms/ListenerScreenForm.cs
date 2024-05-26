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
using UI.Forms;

namespace UI
{
    public partial class ListenerScreenForm : Form
    {
        private Service _service;
        private User _user;

        public ListenerScreenForm(User user)
        {
            InitializeComponent();
            _service = new Service(@"Host = localhost;
                    Port = 5432;
                    Database = music-service-coursework;
                    User Id = postgres;
                    Password = 12345;");
            _user = user;
        }

        private void ListenerScreenForm_Load(object sender, EventArgs e)
        {

            // your songs tab
            var userSongs = _service.GetSongsByPlaylist(_user.Id, "default_playlist");
            if (userSongs != null)
            {
                foreach (SongEntity song in userSongs)
                {
                    string artists = GetArtistsString(song);
                    dataGridViewUserSongs.Rows.Add(song.Title, artists, song.Duration);
                }
            }
            // all songs tab
            var allSongs = _service.GetSongs(100);
            if (allSongs != null)
            {
                foreach (var song in allSongs)
                {
                    string artists = GetArtistsString(song);
                    dataGridViewAllSongs.Rows.Add(song.Title, artists, song.Duration);
                }
            }
            // playlists tab
            var playlists = _service.GetPlaylistsByUser(_user.Id);
            if (playlists != null)
            {
                foreach (var playlist in playlists)
                {
                    dataGridViewPlaylists.Rows.Add(playlist.Title, playlist.SongsCount);
                }
            }
            // album tab
            var albums = _service.GetAllAlbums();
            if (albums != null)
            {
                foreach (var album in albums)
                {
                    var artists = GetArtistsString(album);
                    dataGridViewAllAlbums.Rows.Add(album.Title, artists, album.Plays);
                }
            }
            // account
            labelUsername.Text = _user.Login;
            labelFullNameValue.Text = _user.FullName;
            labelEmailValue.Text = _user.Email;
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
        private string GetArtistsString(AlbumEntity album)
        {
            // ...
            var artists = new List<string>();
            var artistEntitites = _service.GetArtistsByAlbum(album.Id);
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
            MessageBox.Show("sdsd");
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
            // button add song in all songs
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                var title = dataGridViewAllSongs.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (title == null)
                    return;
                var song = _service.GetSongByTitle(title);
                var playlist = _service.GetPlaylistByTitle(_user.Id, "default_playlist");
                if (song == null || playlist == null)
                    return;
                _service.AddSongToPlaylist(song.Id, playlist.Id);
            }
        }

        private void tabControl1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {
            // add playlist
            // will run dkialog form where user choose songs for playlist
            // develop form
            var formPlaylistCreate = new FormPlaylistCreate(_service, _user);
            formPlaylistCreate.ShowDialog();
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

        private void dataGridViewPlaylists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    // play playlist btn
                    MessageBox.Show("2");
                    var playlistTitle = dataGridViewPlaylists.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (playlistTitle == null)
                        return;
                    var songs = _service.GetSongsByPlaylist(_user.Id, playlistTitle);

                
                    if (songs != null)
                    {
                        dataGridViewPlaylistSongs.Rows.Clear();
                        foreach (var song in songs)
                        {
                            string artists = GetArtistsString(song);
                            dataGridViewPlaylistSongs.Rows.Add(song.Title, artists, song.Duration);
                        }
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    // cahnge palylist
                    // new screen
                    var playlistTitle = dataGridViewPlaylists.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (playlistTitle == null) 
                        return;
                    var playlist = _service.GetPlaylistByTitle(_user.Id, playlistTitle);
                    if (playlist == null)
                        return;
                    var changePLaylistForm = new ChangePlaylistForm(_service, _user, playlist);
                    changePLaylistForm.ShowDialog();
                    
                }
                else if (e.ColumnIndex == 4)
                {
                    // delete playlist from table
                    // delete palylist from db
                    var playlistTitle = dataGridViewPlaylists.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (playlistTitle == null)
                        return;
                    var playlist = _service.GetPlaylistByTitle(_user.Id, playlistTitle);
                    if (playlist == null)
                        return;
                    foreach (DataGridViewRow row in dataGridViewPlaylists.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == playlistTitle)
                        {
                            dataGridViewPlaylists.Rows.Remove(row);
                            break;
                        }
                    }
                    _service.DeletePlaylist(_user.Id, playlistTitle);


                }
            }
        }

        private void buttonAddSong_Click(object sender, EventArgs e)
        {
            // create playlist
            
        }

        private void tabPagePlaylists_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAllAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {
                    // play album btn
                    var albumTitle = dataGridViewAllAlbums.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (albumTitle == null)
                        return;
                    var songs = _service.GetSongsByAlbum(albumTitle);

                    if (songs != null)
                    {
                        dataGridViewAlbum.Rows.Clear();
                        foreach (var song in songs)
                        {
                            string artists = GetArtistsString(song);
                            dataGridViewAlbum.Rows.Add(song.Title, artists, song.Duration);
                        }
                    }
                }
                
            }
        }

        private void tabPageAlbums_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
