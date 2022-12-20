using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Booking
{
    public static class SQLClass
    {
        public const string CONNECTION_STRING =
           "SslMode=none;Server=localhost;Database=booking;port=3306;Uid=root;";

        public static MySqlConnection CONN;
       
        /// <summary>
        /// Функция Select-запроса
        /// </summary>
        public static List<string> Select(string cmdText)
        {
            List<string> list = new List<string>();

            try 
            { 
                MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader.GetValue(i).ToString());
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                if(!File.Exists(Path.GetTempPath() + "/err.txt"))
                {
                    File.Create(Path.GetTempPath() + "/err.txt");
                }                    

                File.AppendAllText(Path.GetTempPath() + "/err.txt", "Ошибка" + Environment.NewLine +
                    DateTime.Now.ToString() + " " + ex.Message + " " + cmdText + Environment.NewLine + Environment.NewLine);

                MessageBox.Show("Ошибка");
            }

            return list;
        }

        /// <summary>
        /// Функция Update/Insert/Delete - запроса
        /// </summary>
        public static void Update(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }

    }
}
