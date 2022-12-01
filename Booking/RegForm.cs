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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            List<string> cities = SQLClass.Select("SELECT Name FROM cities ORDER BY Name");
            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cities)
                CityComboBox.Items.Add(city);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Update("INSERT INTO users (Name, Surname, City, Age, Login, Password, Email)" +
                              "VALUES('" + NameTextBox.Text + "', '" + SurnameTextBox.Text + "', '" + CityComboBox.Text + "', '" + AgeTextBox.Text + "', '" + LoginTextBox.Text + "', '" + PasTextBox.Text + "', '" + EmailTextBox.Text + "')");

            MessageBox.Show("Сохранено");
            Close();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
