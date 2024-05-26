using DAO.Repositories;
using Data.Entities;
using Domain.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI
{
    public partial class RegisterForm : Form
    {
        private Service _service;
        public RegisterForm()
        {
            _service = new Service(@"Host = localhost;
                    Port = 5432;
                    Database = music-service-coursework;
                    User Id = postgres;
                    Password = 12345;");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLoginInput.Text;
            string password = textBoxPasswordInput.Text;
            string fullName = textBoxFullNameInput.Text;
            string email = textBoxEmailInput.Text;
            var roll = 2;
            if (radioButtonAsArtist.Checked) roll = 3;

            // validations
            // ...

            _service.Register(login, password, fullName, email, roll);
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}