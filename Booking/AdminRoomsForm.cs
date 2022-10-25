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
    public partial class AdminRoomsForm : Form
    {
        public AdminRoomsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.MyUpdate("INSERT INTO rooms (Name, Price, Name_hotel, City)" +
                              "VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')");

            MessageBox.Show("Сохранено");
            AdminRoomsForm_Load(sender, e);
            return;
        }

        private void AdminRoomsForm_Load(object sender, EventArgs e)
        {
            List<string> list = MainForm.MySelect("SELECT Name, Price, Name_hotel, City, ID, Hotel_id FROM rooms");

            panel1.Controls.Clear();
            int y = 10;
            for (int i = 0; i < list.Count; i += 6)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(170, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i];
                lbl0.Tag = list[i+4];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(225, y);
                lbl1.Size = new Size(50, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i + 1];
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(280, y);
                lbl2.Size = new Size(200, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = list[i + 2];
                panel1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(485, y);
                lbl3.Size = new Size(200, 30);
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Text = list[i + 3];
                panel1.Controls.Add(lbl3);

                Button btn = new Button();
                btn.Location = new Point(690, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    MainForm.MyUpdate("DELETE FROM rooms WHERE ID = '" + control.Tag + "'");
                    AdminRoomsForm_Load(sender, e);
                    return;
                }
            }
        }

        string adress = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
                System.IO.File.Copy(adress, "../../Pictures/" + System.IO.Path.GetFileName(adress));
                adress = System.IO.Path.GetFileName(adress);
            }
        }
    }
}
