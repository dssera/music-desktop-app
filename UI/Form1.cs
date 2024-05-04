using DAO.Repositories;
using Data.Entities;
using Domain.Services;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Host = localhost;
            Port = 5432;
            Database = music-service-coursework;
            User Id = postgres;
            Password = 12345;";
            SongService songService = new SongService(new SongRepository(connectionString));
            SongEntity songEntity = songService.GetSongById(3);
            label.Text = songEntity.Title;
        }
    }
}