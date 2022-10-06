using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Booking
{
    
    static class Program
    {
        public const string CONNECTION_STRING =
           "SslMode=none;Server=localhost;Database=booking;port=3306;Uid=root;";

        public static MySqlConnection CONN;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CONN = new MySqlConnection(CONNECTION_STRING);
            CONN.Open();

            Application.Run(new MainForm());

            CONN.Close();
        }
    }
}
