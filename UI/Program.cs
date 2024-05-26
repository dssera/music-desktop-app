using UI.MainForms;
using UI.Forms;
using Domain.Services;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new ListenerScreenForm(new Domain.User(10, "test", "test", 2, "test", "test")));
            Application.Run(new LoginForm());
            //Application.Run(new RegisterForm());
            //Application.Run(new FormPlaylistCreate(new Service(@"Host = localhost;
            //        Port = 5432;
            //        Database = music-service-coursework;
            //        User Id = postgres;
            //        Password = 12345;"),
            //        new Domain.User(10, "test", "test", 2, "test", "test")));
        }
    }
}