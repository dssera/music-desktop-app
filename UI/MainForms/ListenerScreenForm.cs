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

        public ListenerScreenForm()
        {
            InitializeComponent();
        }

        private void ListenerScreenForm_Load(object sender, EventArgs e)
        {
            _service = new Service(@"Host = localhost;
                    Port = 5432;
                    Database = music-service-coursework;
                    User Id = postgres;
                    Password = 12345;");

        }
    }
}
