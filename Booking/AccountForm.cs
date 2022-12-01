using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();

            List<string> user_date = SQLClass.Select("SELECT Name, Surname, City, Age, Login, Password, Email FROM users WHERE Login = '" + MainForm.Login + "'");
            List<string> cities = SQLClass.Select("SELECT Name FROM cities");

            NameTextBox.Text = user_date[0];
            SurnameTextBox.Text = user_date[1];
            for(int i=0; i<cities.Count; i++)
            {
                CityComboBox.Items.Add(cities[i]);
                if (user_date[2] == cities[i])
                    CityComboBox.Text = cities[i];
            }
            AgeTextBox.Text = user_date[3];
            LoginTextBox.Text = user_date[4];
            PasTextBox.Text = user_date[5];
            EmailTextBox.Text = user_date[6];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Update("UPDATE users SET Name='" + NameTextBox.Text + "' , Surname='" + SurnameTextBox.Text + "' , City='" + CityComboBox.Text + "' , Age='" + AgeTextBox.Text + "' , Login='" + LoginTextBox.Text + "' , Password='" + PasTextBox.Text + "' , Email='" + EmailTextBox.Text + "' WHERE Login ='" + MainForm.Login + "'");

            MainForm.Login = LoginTextBox.Text;
            MessageBox.Show("Сохранено");
            Close();
        }
    }
}
