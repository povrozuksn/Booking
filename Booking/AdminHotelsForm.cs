using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Booking
{
    public partial class AdminHotelsForm : Form
    {
        public AdminHotelsForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string adress = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO hotels (Name, City, Rating, Image, Adress)"+
                                                "VALUES('"+ textBox1.Text +"', '"+ textBox2.Text + "', '"+ textBox3.Text + "', '"+ adress + "', '"+ textBox4.Text + "')", Program.CONN);
            cmd.ExecuteReader();
            cmd.Dispose();
            MessageBox.Show("Сохранено");
        }

        private void AdminHotelsForm_Load(object sender, EventArgs e)
        {
            List<string> list = MainForm.MySelect("SELECT Name, City, Rating, Image, Adress FROM hotels");

            panel1.Controls.Clear();
            int y = 30;
            for (int i=0; i<list.Count;i+=5)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(250, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                panel1.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(350, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeletHotelClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeletHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in panel1.Controls)
            {
                if(control.Location == new Point(50, y))
                {
                    MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM hotels WHERE Name = '" + control.Text + "'", Program.CONN);
                    cmd.ExecuteReader();
                    cmd.Dispose();
                    MessageBox.Show("Удалено");
                }
            }
        }
    }
}
