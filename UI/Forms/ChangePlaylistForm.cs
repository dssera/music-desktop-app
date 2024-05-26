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
    public partial class ChangePlaylistForm : Form
    {
        Service _service;
        User _user;
        PlaylistEntity _playlist;
        List<SongEntity>? _playlistSongs = null;

        public ChangePlaylistForm(Service service, User user, PlaylistEntity playlist)
        {
            InitializeComponent();

            _service = service;
            _user = user;
            _playlist = playlist;
            _playlistSongs = _service.GetSongsByPlaylist(_user.Id, _playlist.Title);
            
        }
        private void ChangePlaylistForm_Load(object sender, EventArgs e)
        {
            var songs = _service.GetSongsByPlaylist(_user.Id, _playlist.Title);
            if (songs != null)
            {
                foreach (var song in songs)
                {
                    dataGridViewPlaylistSongs.Rows.Add(song.Title, GetArtistsString(song), song.Duration);
                }
            }
            var allSongs = _service.GetSongs(100);
            if (allSongs != null)
            {
                foreach (var song in allSongs)
                {
                    dataGridViewAllSongs.Rows.Add(song.Title, GetArtistsString(song), song.Duration);
                }
            }
            textBoxTitle.Text = _playlist.Title;
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

        private void dataGridViewAllSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var songTitle = dataGridViewAllSongs.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (songTitle == null)
                    return;
                var song = _service.GetSongByTitle(songTitle);
                if (song == null)
                    return;
                if (e.ColumnIndex == 4)
                {
                    // добавление в плейлист
                    MessageBox.Show("add to palylist");
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
                    MessageBox.Show("delete from palylist");
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // update playlist data
            _playlist.Title = textBoxTitle.Text;
            _playlist.SongsCount = dataGridViewPlaylistSongs.Rows.Count;
            // _service.UpdatePlaylist(_playlist);
            // update playlists songs
            var newSongs = new List<SongEntity>();
            foreach (DataGridViewRow row in dataGridViewPlaylistSongs.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                string? title = row.Cells[0].Value.ToString();
                if (title == null)
                    continue;
                var song = _service.GetSongByTitle(title);
                if (song == null) 
                    continue;
                newSongs.Add(song);
            }

            if (_playlistSongs != null)
            {
                foreach (var song in _playlistSongs)
                {
                    _service.DeleteSongFromPlaylist(song.Id, _playlist.Id);
                }
            }
            if (newSongs != null)
            {
                foreach (var song in newSongs)
                {
                   _service.AddSongToPlaylist(song.Id, _playlist.Id);
                }
            }
            Close();
        }
    }
}
