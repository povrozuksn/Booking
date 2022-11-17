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
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
            FindButton_Click(null, null);
            List<string> cities = MainForm.MySelect("SELECT Name FROM cities ORDER BY Name");
            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cities)
                CityComboBox.Items.Add(city);
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string command = "SELECT Name, Surname, City, Age FROM users WHERE 1";
            if (CityComboBox.Text != "")
                command += " AND City = '" + CityComboBox.Text + "'";
            if (AgeTextBox.Text != "")
                command += " AND Age >= '" + AgeTextBox.Text + "'";
            
            List<string> user_data = MainForm.MySelect(command);

            UsersPanel.Controls.Clear();
            int y = 10;
            for (int i = 0; i < user_data.Count; i += 4)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(100, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = user_data[i];
                UsersPanel.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(155, y);
                lbl1.Size = new Size(150, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = user_data[i + 1];
                UsersPanel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(310, y);
                lbl2.Size = new Size(150, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = user_data[i + 2];
                UsersPanel.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(470, y);
                lbl3.Size = new Size(50, 30);
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Text = user_data[i + 3];
                UsersPanel.Controls.Add(lbl3);

                y += 35;
            }
        }
    }
}
