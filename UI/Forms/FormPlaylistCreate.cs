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

namespace UI.Forms
{
    public partial class FormPlaylistCreate : Form
    {

        private Service _service;
        private User _user;
        public FormPlaylistCreate(Service service, User user)
        {
            InitializeComponent();
            _service = service;
            _user = user;
        }
        public FormPlaylistCreate(Service service, User user, string title)
        {
            InitializeComponent();

            _service = service;
            _user = user;

            labelCreatePlaylist.Text = "Измените плейлист:"; 
            var songs = _service.GetSongsByPlaylist(_user.Id, title);
            if (songs != null)
            {
                foreach (var song in songs)
                {
                    dataGridViewPlaylistSongs.Rows.Add(song.Title, GetArtistsString(song), song.Duration);
                }
            }
            textBoxTitle.Text = title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void dataGridViewAllSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPlaylistCreate_Load(object sender, EventArgs e)
        {
            var allSongs = _service.GetSongs(100);
            if (allSongs != null)
            {
                foreach (var song in allSongs)
                {
                    string artists = GetArtistsString(song);

                    dataGridViewAllSongs.Rows.Add(song.Title, artists, song.Duration);
                }
            }
        }
        bool isTitleUnique(string title)
        {
            var userPlaylists = _service.GetPlaylistsByUser(_user.Id);
            if (userPlaylists == null) 
                return true;
            foreach (var item in userPlaylists)
            {
                if (item.Title == title)
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // если плейлист редактируется - значит нужно работать с уже сущетсв плейлистом
            
            // если плейлист создается то делать то что ниже

            var songs = new List<SongEntity>();
            string title = textBoxTitle.Text;
            if (!isTitleUnique(title))
            {
                MessageBox.Show("Плейлист с таким названием уже сущетсвует!");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewPlaylistSongs.Rows)
            {
                var val = row.Cells[0].Value;
                if (val == null)
                    continue;
                var song = _service.GetSongByTitle(val.ToString());
                if (song == null)
                    continue;
                songs.Add(song);
            }
            if (songs.Count < 0)
                return;
            var newPlaylist = new PlaylistEntity(-1, title, _user.Id, DateTime.Now, 0, songs.Count);

            if (_service.AddPlaylist(newPlaylist))
            {
                var createdPlaylist = _service.GetPlaylistByTitle(_user.Id, title);
                if (createdPlaylist == null)
                    return;
                foreach (var song in songs)
                {
                    _service.AddSongToPlaylist(song.Id, createdPlaylist.Id);
                }
            }
        }

        private void dataGridViewAllSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var title = dataGridViewAllSongs.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (title == null) 
                    return;
                var song = _service.GetSongByTitle(title);
                if (song == null)
                    return;
                if (e.ColumnIndex == 4)
                {
                    // добавление в плейлист

                    var addedTitles = new List<string>();
                    foreach (DataGridViewRow row in dataGridViewPlaylistSongs.Rows)
                    {
                        if (row.Cells[0].Value == null) continue;
                        string? title_ = row.Cells[0].Value.ToString();
                        if (title_ == null)
                            continue;
                        addedTitles.Add(title_);
                    }
                    if (!addedTitles.Contains(song.Title))
                    {
                        dataGridViewPlaylistSongs.Rows.Add(song.Title, GetArtistsString(song), song.Duration);
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    var addedTitles = new List<string>();
                    foreach (DataGridViewRow row in dataGridViewPlaylistSongs.Rows)
                    {
                        if (row.Cells[0].Value == null) continue;
                        string? title_ = row.Cells[0].Value.ToString();
                        if (title_ == null)
                            continue;
                        addedTitles.Add(title_);
                    }
                    if (addedTitles.Contains(song.Title))
                    {
                        // do delete
                        var removedRow = dataGridViewPlaylistSongs.Rows
                            .Cast<DataGridViewRow>()
                            .FirstOrDefault(row => row.Cells[0].Value?.ToString() == song.Title);
                        dataGridViewPlaylistSongs.Rows.Remove(removedRow);
                    }
                }

            }
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

        private void dataGridViewPlaylistSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
