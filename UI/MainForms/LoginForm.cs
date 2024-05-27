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
        private void RunForm()
        {

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
                if (user.RollId == 1)
                {
                    
                }
                else if (user.RollId == 2)
                {
                    var form = new ListenerScreenForm(user);
                    Visible = false;
                    form.ShowDialog();
                    Visible = true;
                    textBoxLoginField.Clear();
                    textBoxPasswordField.Clear();
                }
                else if (user.RollId == 3)
                {
                    var form = new ArtistScreenForm(user);
                    Visible = false;
                    form.ShowDialog();
                    Visible = true;
                    textBoxLoginField.Clear();
                    textBoxPasswordField.Clear();
                }
                else if (user.RollId == 4)
                {

                }


            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            form.ShowDialog();
        }
    }
}
