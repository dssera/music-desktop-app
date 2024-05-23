using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Services;

namespace UI.MainForms
{
    public partial class LoginForm : Form
    {
        private Service _service;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _service = new Service(@"Host = localhost;
                    Port = 5432;
                    Database = music-service-coursework;
                    User Id = postgres;
                    Password = 12345;");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBoxLoginField.Text;
            string enteredPassword = textBoxPasswordField.Text;

            var _user = _service.Login(enteredLogin, enteredPassword);
            if (_user == null) labelDebug.Text = "Неправильный логин или пароль";
            else
            {
                var user = _service.GetFullUserByLogin(_user.Login);
                var form = new ListenerScreenForm();
                Visible = false;
                form.ShowDialog();
                Dispose();

            }
        }
    }
}
