using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace Booking
{
    public partial class MainForm : Form
    {
        public static string Login = "";
        public static string NameSurname = "";
        public static bool isAdmin = false;

        public MainForm()
        {
            InitializeComponent();
            Search_Click(null, null);
            List<string> cities = SQLClass.Select("SELECT Name1 FROM cities ORDER BY Name");
            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cities)
                CityComboBox.Items.Add(city);
        }


        private void FilrtButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Size.Height < 50)
            {
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 145);
            }
            else
            {
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, FilrtButton.Size.Height);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;            
            HotelForm hf = new HotelForm(pb.Tag.ToString());
            hf.ShowDialog();                      
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;            
            HotelForm hf = new HotelForm(lb.Tag.ToString());
            hf.ShowDialog();                
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            HotelsPanel.Controls.Clear();
            HotelsPanel.Controls.Add(label7);
            HotelsPanel.Controls.Add(button2);

            string command = "SELECT Name, City, Rating, Image, ID FROM hotels WHERE 1";
            if (CityComboBox.Text != "")
                command += " AND City = '" + CityComboBox.Text + "'";
            if (RatingComboBox.Text != "")
                command += " AND Rating >= '" + RatingComboBox.Text + "'";
            List<string> otels = SQLClass.Select(command);

            int x = 40;
            for (int i = 0; i < otels.Count; i += 5)
            {
                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + otels[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(250, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = otels[i + 4];
                pb.Click += new EventHandler(pictureBox1_Click);
                HotelsPanel.Controls.Add(pb);

                Label lbl = new Label();
                lbl.Location = new Point(x, 210);
                lbl.Size = new Size(250, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = otels[i];
                lbl.Tag = otels[i + 4];
                lbl.Click += new EventHandler(label4_Click);
                HotelsPanel.Controls.Add(lbl);

                x += 260;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user_data = SQLClass.Select(
            "SELECT Login, Name, Surname, admin_id FROM users WHERE Login = '"+ LoginTextBox.Text +"' and Password = '"+ PaswTextBox.Text + "'");

            if (AuthButton.Text == "Выйти")
            {
                Login = "";
                AuthPanel.Controls.Clear();
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                AdminPanelButton.Visible = false;
                AccountButton.Visible = false;
                AuthPanel.Controls.Add(label4);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(LoginTextBox);
                PaswTextBox.Text = "";
                AuthPanel.Controls.Add(PaswTextBox);

            }
            else
            {
                if (user_data.Count > 0)
                {
                    isAdmin = (user_data[3] == "1");
                    Login = user_data[0];
                    NameSurname = user_data[1] + " " + user_data[2];
                    AuthPanel.Controls.Clear();
                    AuthButton.Text = "Выйти";
                    AuthPanel.Controls.Add(AuthButton);
                    AdminPanelButton.Visible = isAdmin;
                    AuthPanel.Controls.Add(AccountButton);
                    AccountButton.Visible = true;
                    AuthPanel.Controls.Add(AdminPanelButton);
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Text = "Приветствуем, " + NameSurname;
                }
                else
                {
                    var result = MessageBox.Show("Вы указали неверный логин/пароль", "Зарегистрироваться", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        RegForm reg = new RegForm();
                        reg.ShowDialog();
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }
    }
}
