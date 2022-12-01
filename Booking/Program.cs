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
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLClass.CONN = new MySqlConnection(SQLClass.CONNECTION_STRING);
            SQLClass.CONN.Open();

            Application.Run(new MainForm());

            SQLClass.CONN.Close();
        }
    }
}
